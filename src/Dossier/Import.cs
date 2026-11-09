using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dossier;

/// <summary>import request: rebuild a store from a published bundle.</summary>
public sealed class ImportOptions
{
    /// <summary>Bundle directory (the --out of a publish run).</summary>
    public string From { get; set; } = string.Empty;
}

/// <summary>What import restored, and every record it could not restore, with the reason.</summary>
public sealed class ImportResult
{
    public int Subjects { get; set; }
    public int Facts { get; set; }
    public int Refs { get; set; }
    public int Attachments { get; set; }

    /// <summary>Attachment blobs actually written (or already present) under blobs/&lt;sha256&gt;.</summary>
    public int Blobs { get; set; }

    public List<ImportSkip> Skipped { get; set; } = new();
}

public sealed record ImportSkip(string Path, string Reason);

public sealed partial class DossierStore
{
    private sealed class ImportRecord
    {
        public string Path = string.Empty;
        public string SubjectDir = string.Empty;
        public string Id = string.Empty;
        public string SubjectId = string.Empty;
        public string SubjectName = string.Empty;
        public string? Key;
        public string Kind = string.Empty;
        public string Text = string.Empty;
        public JsonElement? Data;
        public JsonElement? Items;
        public List<string> Tags = new();
        public double Confidence;
        public string Status = string.Empty;
        public JsonElement Provenance;
        public List<RefRecord> Refs = new();
        public List<AttachmentRecord> Attachments = new();
    }

    private sealed record ImportSubject(string Id, string Name, string Kind, string? ParentId, List<string> Aliases, string? Pin);

    /// <summary>
    /// import: reads the machine record at the end of every fact file in a bundle and rebuilds the
    /// store from them, with the original ids. Subjects come from the manifest's subject map, refs keep
    /// their original targets and attachment bytes are copied from the subject's assets directory into
    /// blobs/&lt;sha256&gt;. All rows commit in one transaction, so a failure leaves the store untouched.
    /// </summary>
    public ImportResult Import(ImportOptions options)
    {
        if (string.IsNullOrWhiteSpace(options.From))
        {
            throw new DossierRequestException("invalid_from", "import requires --from <bundle directory>");
        }

        var root = Path.GetFullPath(options.From);
        if (!Directory.Exists(root))
        {
            throw new DossierRequestException("bundle_not_found", $"bundle directory \"{options.From}\" does not exist");
        }

        var result = new ImportResult();
        var factFiles = Directory.EnumerateFiles(root, "*.md", SearchOption.AllDirectories)
            .Select(p => Path.GetRelativePath(root, p).Replace('\\', '/'))
            .Where(p => FactPathRegex.IsMatch(p))
            .OrderBy(p => p, StringComparer.Ordinal)
            .ToList();
        if (factFiles.Count == 0)
        {
            throw new DossierRequestException(
                "bundle_has_no_facts",
                "the bundle has no fact files (subjects/<slug>/facts/*.md); round tripping requires a bundle published with --facts detail");
        }

        var records = new List<ImportRecord>();
        var byId = new Dictionary<string, ImportRecord>(StringComparer.Ordinal);
        foreach (var path in factFiles)
        {
            var (record, error) = ParseImportRecord(path, File.ReadAllText(Path.Combine(root, path), Utf8NoBom));
            if (record is null)
            {
                result.Skipped.Add(new ImportSkip(path, error!));
                continue;
            }

            if (byId.TryGetValue(record.Id, out var first))
            {
                throw new DossierRequestException(
                    "import_duplicate_id",
                    $"fact id {record.Id} is claimed by two fact files: {first.Path} and {path}");
            }

            byId[record.Id] = record;
            records.Add(record);
        }

        if (records.Count == 0)
        {
            throw new DossierRequestException(
                "bundle_has_no_records",
                "no fact file carries a readable machine record; re-publish the bundle with this version using --facts detail");
        }

        // The live slot of a (subject, kind, key) holds at most one fact.
        var slots = new Dictionary<(string Subject, string Kind, string Key), ImportRecord>();
        foreach (var record in records.Where(r => r.Key is not null && r.Status is not ("superseded" or "retracted")))
        {
            var slot = (record.SubjectId, record.Kind, record.Key!);
            if (slots.TryGetValue(slot, out var other))
            {
                throw new DossierRequestException(
                    "import_slot_conflict",
                    $"live facts {other.Id} and {record.Id} both claim slot (subject {record.SubjectId}, kind {record.Kind}, key \"{record.Key}\"); a bundle can hold only one");
            }

            slots[slot] = record;
        }

        var subjects = ReadImportSubjects(root, records);
        var createdAt = Timestamp();

        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction();

        foreach (var subject in subjects.Values.OrderBy(s => s.Id, StringComparer.Ordinal))
        {
            using var exists = Command(connection, transaction, "SELECT COUNT(*) FROM subjects WHERE id = $id");
            Bind(exists, "$id", subject.Id);
            if ((long)exists.ExecuteScalar()! > 0)
            {
                throw new DossierRequestException("import_subject_exists", $"subject {subject.Id} (\"{subject.Name}\") already exists in the store; import into an empty database");
            }

            using var command = Command(
                connection,
                transaction,
                "INSERT INTO subjects(id, name, kind, parent_id, aliases, pin, created_at) VALUES($id, $name, $kind, $parent, $aliases, $pin, $created)");
            Bind(command, "$id", subject.Id);
            Bind(command, "$name", subject.Name);
            Bind(command, "$kind", subject.Kind);
            Bind(command, "$parent", subject.ParentId);
            Bind(command, "$aliases", JsonSerializer.Serialize(subject.Aliases));
            Bind(command, "$pin", subject.Pin);
            Bind(command, "$created", createdAt);
            command.ExecuteNonQuery();
            result.Subjects++;
        }

        var blobs = new HashSet<string>(StringComparer.Ordinal);
        foreach (var record in records.OrderBy(r => PostedAt(r) ?? createdAt, StringComparer.Ordinal).ThenBy(r => r.Path, StringComparer.Ordinal))
        {
            using (var exists = Command(connection, transaction, "SELECT COUNT(*) FROM facts WHERE id = $id"))
            {
                Bind(exists, "$id", record.Id);
                if ((long)exists.ExecuteScalar()! > 0)
                {
                    throw new DossierRequestException("import_fact_exists", $"fact {record.Id} already exists in the store; import into an empty database");
                }
            }

            var refInputs = record.Refs.Select(r => new RefInput { Rel = r.Rel, Kind = r.Kind, Target = r.Target, Locator = r.Locator }).ToList();
            var hash = ContentHash.Compute(record.Text, record.Data, refInputs);
            long rowId;
            using (var command = Command(
                connection,
                transaction,
                """
                INSERT INTO facts(id, subject_id, kind, key, text, data, items, tags, confidence, status, provenance, content_hash, created_at)
                VALUES($id, $subject, $kind, $key, $text, $data, $items, $tags, $confidence, $status, $provenance, $hash, $created)
                """))
            {
                Bind(command, "$id", record.Id);
                Bind(command, "$subject", record.SubjectId);
                Bind(command, "$kind", record.Kind);
                Bind(command, "$key", record.Key);
                Bind(command, "$text", record.Text);
                Bind(command, "$data", record.Data is { } data ? CanonicalJson.Write(data) : null);
                Bind(command, "$items", record.Items is { } items ? ItemsColumn(items) : null);
                Bind(command, "$tags", JsonSerializer.Serialize(record.Tags));
                Bind(command, "$confidence", record.Confidence);
                Bind(command, "$status", record.Status);
                Bind(command, "$provenance", CanonicalJson.Write(record.Provenance));
                Bind(command, "$hash", hash);
                Bind(command, "$created", PostedAt(record) ?? createdAt);
                command.ExecuteNonQuery();
            }

            using (var rowIdCommand = Command(connection, transaction, "SELECT last_insert_rowid()"))
            {
                rowId = (long)rowIdCommand.ExecuteScalar()!;
            }

            using (var fts = Command(connection, transaction, "INSERT INTO facts_fts(rowid, text, tags) VALUES($rowid, $text, $tags)"))
            {
                Bind(fts, "$rowid", rowId);
                Bind(fts, "$text", record.Text);
                Bind(fts, "$tags", string.Join(' ', record.Tags));
                fts.ExecuteNonQuery();
            }

            if (record.Key is not null && record.Status is not ("superseded" or "retracted"))
            {
                PointSlotAt(connection, transaction, record.SubjectId, record.Kind, record.Key, record.Id);
            }

            for (var seq = 0; seq < record.Refs.Count; seq++)
            {
                var reference = record.Refs[seq];
                using var command = Command(
                    connection,
                    transaction,
                    """
                    INSERT INTO refs(fact_id, seq, rel, kind, target, locator, basis, confidence, rev, snapshot, snapshot_hash, etag, verified_at, valid)
                    VALUES($fact, $seq, $rel, $kind, $target, $locator, $basis, $confidence, $rev, $snapshot, $snapshot_hash, $etag, $verified_at, $valid)
                    """);
                Bind(command, "$fact", record.Id);
                Bind(command, "$seq", seq);
                Bind(command, "$rel", reference.Rel);
                Bind(command, "$kind", reference.Kind);
                Bind(command, "$target", reference.Target);
                Bind(command, "$locator", reference.Locator is { } locator ? CanonicalJson.Write(locator) : null);
                Bind(command, "$basis", reference.Basis);
                Bind(command, "$confidence", reference.Confidence);
                Bind(command, "$rev", reference.Rev);
                Bind(command, "$snapshot", reference.Snapshot);
                Bind(command, "$snapshot_hash", reference.SnapshotHash);
                Bind(command, "$etag", reference.Etag);
                Bind(command, "$verified_at", reference.VerifiedAt);
                Bind(command, "$valid", reference.Valid is { } valid ? (valid ? 1 : 0) : null);
                command.ExecuteNonQuery();
                result.Refs++;
            }

            foreach (var attachment in record.Attachments)
            {
                using var command = Command(
                    connection,
                    transaction,
                    "INSERT OR REPLACE INTO attachments(fact_id, sha256, filename, mime, bytes, perceptual) VALUES($fact, $sha, $filename, $mime, $bytes, $perceptual)");
                Bind(command, "$fact", record.Id);
                Bind(command, "$sha", attachment.Sha256);
                Bind(command, "$filename", attachment.Filename);
                Bind(command, "$mime", attachment.Mime);
                Bind(command, "$bytes", attachment.Bytes);
                Bind(command, "$perceptual", attachment.Perceptual is { } perceptual ? CanonicalJson.Write(perceptual) : null);
                command.ExecuteNonQuery();
                result.Attachments++;

                if (RestoreBlob(root, record, attachment, out var reason))
                {
                    if (blobs.Add(attachment.Sha256))
                    {
                        result.Blobs++;
                    }
                }
                else
                {
                    result.Skipped.Add(new ImportSkip(record.Path, $"attachment {attachment.Sha256}: {reason}"));
                }
            }

            result.Facts++;
        }

        transaction.Commit();
        return result;
    }

    private static string? PostedAt(ImportRecord record) =>
        record.Provenance.ValueKind == JsonValueKind.Object
        && record.Provenance.TryGetProperty("posted_at", out var posted)
        && posted.ValueKind == JsonValueKind.String
            ? posted.GetString()
            : null;

    /// <summary>
    /// Items are stored the way post writes them (ItemInput order, snake_case), so a republish prints
    /// them identically; the record itself has sorted keys.
    /// </summary>
    private static string ItemsColumn(JsonElement items)
    {
        var parsed = items.Deserialize<List<ItemInput>>(JsonCodec.Options) ?? new List<ItemInput>();
        return JsonSerializer.Serialize(parsed, JsonCodec.Options);
    }

    private bool RestoreBlob(string root, ImportRecord record, AttachmentRecord attachment, out string reason)
    {
        reason = string.Empty;
        if (!Sha256Hex.IsMatch(attachment.Sha256))
        {
            reason = "sha256 is not 64 lowercase hex characters";
            return false;
        }

        var assets = record.SubjectDir + "/assets/" + AssetFileName(attachment);
        var source = Path.Combine(root, assets);
        if (!File.Exists(source))
        {
            reason = $"bytes absent from the bundle ({assets}); the store keeps the attachment row without its blob";
            return false;
        }

        var bytes = File.ReadAllBytes(source);
        if (!Convert.ToHexString(SHA256.HashData(bytes)).Equals(attachment.Sha256, StringComparison.OrdinalIgnoreCase))
        {
            reason = $"{assets} does not hash to the recorded sha256; blob not restored";
            return false;
        }

        var target = Path.Combine(BlobRoot, attachment.Sha256);
        if (!File.Exists(target))
        {
            Directory.CreateDirectory(BlobRoot);
            File.WriteAllBytes(target, bytes);
        }

        return true;
    }

    /// <summary>Subjects from the manifest map, plus any subject only a fact record names (from its subject_name).</summary>
    private static Dictionary<string, ImportSubject> ReadImportSubjects(string root, List<ImportRecord> records)
    {
        var subjects = new Dictionary<string, ImportSubject>(StringComparer.Ordinal);
        var manifestPath = Path.Combine(root, BundleManifest);
        if (File.Exists(manifestPath))
        {
            try
            {
                using var document = JsonDocument.Parse(File.ReadAllText(manifestPath, Utf8NoBom));
                if (document.RootElement.TryGetProperty("subjects", out var map) && map.ValueKind == JsonValueKind.Object)
                {
                    foreach (var entry in map.EnumerateObject().Where(e => e.Value.ValueKind == JsonValueKind.Object))
                    {
                        var value = entry.Value;
                        string? Text(string name) => value.TryGetProperty(name, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null;
                        var aliases = value.TryGetProperty("aliases", out var a) && a.ValueKind == JsonValueKind.Array
                            ? a.EnumerateArray().Where(x => x.ValueKind == JsonValueKind.String).Select(x => x.GetString()!).ToList()
                            : new List<string>();
                        string? pin = value.TryGetProperty("pin", out var p) && p.ValueKind == JsonValueKind.Object ? CanonicalJson.Write(p) : null;
                        subjects[entry.Name] = new ImportSubject(entry.Name, Text("name") ?? entry.Name, Text("kind") ?? "subject", Text("parent"), aliases, pin);
                    }
                }
            }
            catch (JsonException)
            {
                // An unreadable manifest only costs the subject metadata; the fact records still name each subject.
            }
        }

        foreach (var record in records)
        {
            if (!subjects.ContainsKey(record.SubjectId))
            {
                subjects[record.SubjectId] = new ImportSubject(record.SubjectId, record.SubjectName, "subject", null, new List<string>(), null);
            }
        }

        return subjects;
    }

    private static (ImportRecord? Record, string? Error) ParseImportRecord(string path, string content)
    {
        var heading = "\n## " + MachineRecordHeading + "\n";
        var at = content.LastIndexOf(heading, StringComparison.Ordinal);
        if (at < 0)
        {
            return (null, "no \"## Machine record\" section; the bundle predates machine records, publish it again");
        }

        var lines = content[(at + heading.Length)..].Split('\n');
        var open = Array.FindIndex(lines, l => l.Length > 0);
        if (open < 0)
        {
            return (null, "machine record section is empty");
        }

        var fence = Regex.Match(lines[open], "^(`{3,})json$");
        if (!fence.Success)
        {
            return (null, "machine record has no json code fence");
        }

        var close = Array.FindIndex(lines, open + 1, l => l == fence.Groups[1].Value);
        if (close < 0)
        {
            return (null, "machine record code fence is not closed");
        }

        try
        {
            using var document = JsonDocument.Parse(string.Join('\n', lines[(open + 1)..close]));
            var e = document.RootElement;
            if (e.ValueKind != JsonValueKind.Object)
            {
                return (null, "machine record is not a json object");
            }

            string? Str(JsonElement from, string name) => from.TryGetProperty(name, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null;
            JsonElement? Raw(JsonElement from, string name) => from.TryGetProperty(name, out var v) && v.ValueKind != JsonValueKind.Null ? v.Clone() : null;

            var id = Str(e, "id");
            var subjectId = Str(e, "subject_id");
            var kind = Str(e, "kind");
            var status = Str(e, "status");
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(subjectId) || string.IsNullOrEmpty(kind) || string.IsNullOrEmpty(status)
                || !e.TryGetProperty("text", out var text) || text.ValueKind != JsonValueKind.String)
            {
                return (null, "machine record lacks id, subject_id, kind, status or text");
            }

            var record = new ImportRecord
            {
                Path = path,
                SubjectDir = path[..path.LastIndexOf("/facts/", StringComparison.Ordinal)],
                Id = id,
                SubjectId = subjectId,
                SubjectName = Str(e, "subject_name") ?? subjectId,
                Key = Str(e, "key"),
                Kind = kind,
                Text = text.GetString()!,
                Data = Raw(e, "data"),
                Items = Raw(e, "items"),
                Confidence = e.TryGetProperty("confidence", out var c) && c.ValueKind == JsonValueKind.Number ? c.GetDouble() : 1.0,
                Status = status,
                Provenance = Raw(e, "provenance") ?? JsonDocument.Parse("{}").RootElement.Clone(),
            };

            if (e.TryGetProperty("tags", out var tags) && tags.ValueKind == JsonValueKind.Array)
            {
                record.Tags = tags.EnumerateArray().Where(t => t.ValueKind == JsonValueKind.String).Select(t => t.GetString()!).ToList();
            }

            if (e.TryGetProperty("refs", out var refs) && refs.ValueKind == JsonValueKind.Array)
            {
                foreach (var r in refs.EnumerateArray())
                {
                    var rel = Str(r, "rel");
                    var rkind = Str(r, "kind");
                    var target = Str(r, "target");
                    var basis = Str(r, "basis");
                    if (rel is null || rkind is null || target is null || basis is null)
                    {
                        return (null, "a ref lacks rel, kind, target or basis");
                    }

                    record.Refs.Add(new RefRecord
                    {
                        Rel = rel,
                        Kind = rkind,
                        Target = target,
                        Basis = basis,
                        Locator = Raw(r, "locator"),
                        Confidence = r.TryGetProperty("confidence", out var rc) && rc.ValueKind == JsonValueKind.Number ? rc.GetDouble() : null,
                        Rev = Str(r, "rev"),
                        Snapshot = Str(r, "snapshot"),
                        SnapshotHash = Str(r, "snapshot_hash"),
                        Etag = Str(r, "etag"),
                        VerifiedAt = Str(r, "verified_at"),
                        Valid = r.TryGetProperty("valid", out var rv) && rv.ValueKind is JsonValueKind.True or JsonValueKind.False ? rv.GetBoolean() : null,
                    });
                }
            }

            if (e.TryGetProperty("attachments", out var attachments) && attachments.ValueKind == JsonValueKind.Array)
            {
                foreach (var a in attachments.EnumerateArray())
                {
                    var sha = Str(a, "sha256");
                    if (sha is null)
                    {
                        return (null, "an attachment lacks sha256");
                    }

                    record.Attachments.Add(new AttachmentRecord
                    {
                        Sha256 = sha,
                        Filename = Str(a, "filename") ?? string.Empty,
                        Mime = Str(a, "mime") ?? string.Empty,
                        Bytes = a.TryGetProperty("bytes", out var b) && b.ValueKind == JsonValueKind.Number ? b.GetInt64() : 0,
                        Perceptual = Raw(a, "perceptual"),
                    });
                }
            }

            return (record, null);
        }
        catch (JsonException exception)
        {
            return (null, "machine record is not valid json: " + exception.Message);
        }
    }
}
