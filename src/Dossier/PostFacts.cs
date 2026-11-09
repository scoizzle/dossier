using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace Dossier;

public sealed partial class DossierStore
{
    private static readonly List<RefInput> NoRefs = new();

    /// <summary>
    /// post_facts. Resolution order, per fact: (a) keyed slot exists =&gt; insert, repoint
    /// the slot, supersede the old fact, "replaced"; (b) live fact with the same
    /// subject/kind/key and content_hash =&gt; "deduped"; (c) insert =&gt; "new".
    /// An invalid item is rejected with a named error and the rest of the batch commits.
    /// </summary>
    public PostResult PostFacts(PostFactsRequest request)
    {
        if (request.Subject is null)
        {
            throw new ArgumentException("post_facts request requires a subject", nameof(request));
        }

        var errors = new List<PostError>();
        var results = new List<FactResult>();
        var createdAt = Timestamp();

        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction();

        var subject = UpsertSubject(connection, transaction, request.Subject, createdAt);
        var localIds = new Dictionary<string, string>(StringComparer.Ordinal);

        for (var index = 0; index < request.Facts.Count; index++)
        {
            var fact = request.Facts[index];

            if (fact is null)
            {
                errors.Add(new PostError(index, "missing_fact", $"fact[{index}] is null"));
                continue;
            }

            if (string.IsNullOrWhiteSpace(fact.Kind))
            {
                errors.Add(new PostError(index, "missing_kind", $"fact[{index}] is missing kind"));
                continue;
            }

            if (fact.Text is null)
            {
                errors.Add(new PostError(index, "missing_text", $"fact[{index}] is missing text"));
                continue;
            }

            if (!string.IsNullOrEmpty(fact.LocalId) && localIds.ContainsKey(fact.LocalId))
            {
                errors.Add(new PostError(index, "duplicate_local_id", $"fact[{index}] local_id \"{fact.LocalId}\" is already used in this batch"));
                continue;
            }

            var (resolvedRefs, refError) = ResolveRefs(fact, index, localIds);
            if (refError is not null)
            {
                errors.Add(refError);
                continue;
            }

            // Hash the resolved refs: an "@x" target must hash as the fact id it points at, so a
            // repost (local id) and a direct-GUID post of the same edge agree on content_hash.
            var hash = ContentHash.Compute(fact.Text, fact.Data, resolvedRefs);

            var replacedId = fact.Key is null
                ? null
                : FindSlotFactId(connection, transaction, subject.Id, fact.Kind, fact.Key);

            if (replacedId is not null)
            {
                var id = InsertFact(connection, transaction, subject.Id, fact, resolvedRefs, hash, createdAt);
                PointSlotAt(connection, transaction, subject.Id, fact.Kind, fact.Key!, id);
                SetFactStatus(connection, transaction, replacedId, "superseded");
                results.Add(new FactResult { Id = id, Status = "replaced", Replaced = replacedId });
                RegisterLocalId(localIds, fact.LocalId, id);
                continue;
            }

            var duplicateId = FindLiveFactByHash(connection, transaction, subject.Id, fact.Kind, fact.Key, hash);
            if (duplicateId is not null)
            {
                results.Add(new FactResult { Id = duplicateId, Status = "deduped", DuplicateOf = duplicateId });
                RegisterLocalId(localIds, fact.LocalId, duplicateId);
                continue;
            }

            var newId = InsertFact(connection, transaction, subject.Id, fact, resolvedRefs, hash, createdAt);
            if (fact.Key is not null)
            {
                PointSlotAt(connection, transaction, subject.Id, fact.Kind, fact.Key, newId);
            }

            results.Add(new FactResult { Id = newId, Status = "new" });
            RegisterLocalId(localIds, fact.LocalId, newId);
        }

        transaction.Commit();

        var response = new PostFactsResponse
        {
            Subject = new SubjectResponse
            {
                Id = subject.Id,
                Name = subject.Name,
                Created = subject.Created,
                Parent = subject.Parent,
            },
            Facts = results,
        };

        return new PostResult(response, errors);
    }

    private static void RegisterLocalId(Dictionary<string, string> localIds, string? localId, string factId)
    {
        if (!string.IsNullOrEmpty(localId))
        {
            localIds[localId] = factId;
        }
    }

    private static (List<RefInput> Refs, PostError? Error) ResolveRefs(
        FactInput fact,
        int index,
        IReadOnlyDictionary<string, string> localIds)
    {
        var resolved = new List<RefInput>();
        var refs = fact.Refs ?? NoRefs;

        for (var refIndex = 0; refIndex < refs.Count; refIndex++)
        {
            var reference = refs[refIndex];

            if (string.IsNullOrWhiteSpace(reference.Rel))
            {
                return (resolved, new PostError(index, "missing_rel", $"fact[{index}] ref[{refIndex}] is missing rel"));
            }

            if (string.IsNullOrWhiteSpace(reference.Kind))
            {
                return (resolved, new PostError(index, "missing_ref_kind", $"fact[{index}] ref[{refIndex}] is missing kind"));
            }

            if (string.IsNullOrWhiteSpace(reference.Target))
            {
                return (resolved, new PostError(index, "missing_target", $"fact[{index}] ref[{refIndex}] is missing target"));
            }

            if (string.IsNullOrWhiteSpace(reference.Basis))
            {
                return (resolved, new PostError(index, "missing_basis", $"fact[{index}] ref[{refIndex}] is missing basis"));
            }

            // kind=slot targets are opaque and stored verbatim; local_id resolution applies
            // only to internal fact references.
            if (!string.Equals(reference.Kind, "slot", StringComparison.Ordinal) && reference.Target!.StartsWith('@'))
            {
                var localId = reference.Target[1..];
                if (!localIds.TryGetValue(localId, out var factId))
                {
                    return (resolved, new PostError(
                        index,
                        "unresolved_local_id",
                        $"fact[{index}] ref[{refIndex}] target \"{reference.Target}\" has no earlier fact with local_id \"{localId}\""));
                }

                var copy = reference.Clone();
                copy.Target = factId;
                resolved.Add(copy);
                continue;
            }

            resolved.Add(reference);
        }

        return (resolved, null);
    }

    private static SubjectResolution UpsertSubject(
        SqliteConnection connection,
        SqliteTransaction transaction,
        SubjectInput input,
        string createdAt)
    {
        var requestedAliases = input.Aliases ?? new List<string>();

        if (!string.IsNullOrWhiteSpace(input.Id) && string.IsNullOrWhiteSpace(input.Name))
        {
            var existing = ReadSubject(connection, transaction, input.Id!);
            if (existing is not null)
            {
                return new SubjectResolution(existing.Id, existing.Name, false, existing.ParentId);
            }

            // Fail closed: an unknown id must not materialize a subject named after the id.
            throw new DossierRequestException(
                "subject_not_found",
                $"subject \"{input.Id}\" does not exist");
        }

        var wanted = Names.Normalize(input.Name);
        if (wanted.Length == 0)
        {
            throw new ArgumentException("subject requires a non-empty name or an id");
        }

        foreach (var row in ReadSubjects(connection, transaction))
        {
            if (Names.Normalize(row.Name) != wanted && !row.Aliases.Any(alias => Names.Normalize(alias) == wanted))
            {
                continue;
            }

            var merged = MergeAliases(row.Aliases, requestedAliases, input.Name);
            var mergedJson = JsonSerializer.Serialize(merged);
            var parent = input.Parent ?? row.ParentId;

            if (mergedJson != JsonSerializer.Serialize(row.Aliases) || parent != row.ParentId)
            {
                using var update = Command(connection, transaction, "UPDATE subjects SET aliases = $aliases, parent_id = $parent WHERE id = $id");
                Bind(update, "$aliases", mergedJson);
                Bind(update, "$parent", parent);
                Bind(update, "$id", row.Id);
                update.ExecuteNonQuery();
            }

            return new SubjectResolution(row.Id, row.Name, false, parent);
        }

        var id = Guid.NewGuid().ToString("D");
        var name = input.Name!.Trim();
        InsertSubject(connection, transaction, id, name, input.Kind ?? "subject", input.Parent, requestedAliases, createdAt);
        return new SubjectResolution(id, name, true, input.Parent);
    }

    private static List<string> MergeAliases(IReadOnlyList<string> existing, IReadOnlyList<string> added, string? name)
    {
        var result = new List<string>();
        var seen = new HashSet<string>(StringComparer.Ordinal);

        void Include(string? value)
        {
            var normalized = Names.Normalize(value);
            if (normalized.Length == 0)
            {
                return;
            }

            if (seen.Add(normalized))
            {
                result.Add(value!.Trim());
            }
        }

        foreach (var alias in existing)
        {
            Include(alias);
        }

        foreach (var alias in added)
        {
            Include(alias);
        }

        Include(name);
        return result;
    }

    private static void InsertSubject(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string id,
        string name,
        string kind,
        string? parentId,
        IReadOnlyList<string> aliases,
        string createdAt)
    {
        var normalizedAliases = MergeAliases(Array.Empty<string>(), aliases, null);
        using var command = Command(
            connection,
            transaction,
            "INSERT INTO subjects(id, name, kind, parent_id, aliases, pin, created_at) VALUES($id, $name, $kind, $parent, $aliases, NULL, $created)");
        Bind(command, "$id", id);
        Bind(command, "$name", name);
        Bind(command, "$kind", kind);
        Bind(command, "$parent", parentId);
        Bind(command, "$aliases", JsonSerializer.Serialize(normalizedAliases));
        Bind(command, "$created", createdAt);
        command.ExecuteNonQuery();
    }

    private static SubjectRow? ReadSubject(SqliteConnection connection, SqliteTransaction transaction, string id)
    {
        using var command = Command(connection, transaction, "SELECT id, name, parent_id, aliases FROM subjects WHERE id = $id");
        Bind(command, "$id", id);
        using var reader = command.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        return new SubjectRow(
            reader.GetString(0),
            reader.GetString(1),
            reader.IsDBNull(2) ? null : reader.GetString(2),
            ParseAliases(reader.GetString(3)));
    }

    private static List<SubjectRow> ReadSubjects(SqliteConnection connection, SqliteTransaction transaction)
    {
        var rows = new List<SubjectRow>();
        using var command = Command(connection, transaction, "SELECT id, name, parent_id, aliases FROM subjects ORDER BY created_at, id");
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            rows.Add(new SubjectRow(
                reader.GetString(0),
                reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                ParseAliases(reader.GetString(3))));
        }

        return rows;
    }

    private static List<string> ParseAliases(string json)
    {
        try
        {
            return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
        }
        catch (JsonException)
        {
            return new List<string>();
        }
    }

    private static string? FindSlotFactId(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string subjectId,
        string kind,
        string key)
    {
        using var command = Command(
            connection,
            transaction,
            "SELECT fact_id FROM slots WHERE subject_id = $subject AND kind = $kind AND key = $key");
        Bind(command, "$subject", subjectId);
        Bind(command, "$kind", kind);
        Bind(command, "$key", key);
        return command.ExecuteScalar() as string;
    }

    private static void PointSlotAt(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string subjectId,
        string kind,
        string key,
        string factId)
    {
        using var command = Command(
            connection,
            transaction,
            """
            INSERT INTO slots(subject_id, kind, key, fact_id) VALUES($subject, $kind, $key, $fact)
            ON CONFLICT(subject_id, kind, key) DO UPDATE SET fact_id = excluded.fact_id
            """);
        Bind(command, "$subject", subjectId);
        Bind(command, "$kind", kind);
        Bind(command, "$key", key);
        Bind(command, "$fact", factId);
        command.ExecuteNonQuery();
    }

    private static void SetFactStatus(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string factId,
        string status)
    {
        using var command = Command(connection, transaction, "UPDATE facts SET status = $status WHERE id = $id");
        Bind(command, "$status", status);
        Bind(command, "$id", factId);
        command.ExecuteNonQuery();
    }

    private static string? FindLiveFactByHash(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string subjectId,
        string kind,
        string? key,
        string contentHash)
    {
        using var command = Command(
            connection,
            transaction,
            """
            SELECT id FROM facts
            WHERE subject_id = $subject
              AND kind = $kind
              AND key IS $key
              AND content_hash = $hash
              AND status = 'live'
            ORDER BY rowid
            LIMIT 1
            """);
        Bind(command, "$subject", subjectId);
        Bind(command, "$kind", kind);
        Bind(command, "$key", key);
        Bind(command, "$hash", contentHash);
        return command.ExecuteScalar() as string;
    }

    private static string InsertFact(
        SqliteConnection connection,
        SqliteTransaction transaction,
        string subjectId,
        FactInput fact,
        IReadOnlyList<RefInput> refs,
        string contentHash,
        string createdAt)
    {
        var id = Guid.NewGuid().ToString("D");
        var tags = fact.Tags ?? new List<string>();
        var data = fact.Data.HasValue ? CanonicalJson.Write(fact.Data.Value) : null;
        var items = fact.Items is { Count: > 0 } ? JsonSerializer.Serialize(fact.Items, JsonCodec.Options) : null;
        var provenance = JsonSerializer.Serialize(
            new Dictionary<string, object?>
            {
                ["actor"] = "dossier-cli",
                ["actor_type"] = "tool",
                ["channel"] = "cli",
                ["posted_at"] = createdAt,
            },
            JsonCodec.Options);

        using (var command = Command(
            connection,
            transaction,
            """
            INSERT INTO facts(id, subject_id, kind, key, text, data, items, tags, confidence, status, provenance, content_hash, created_at)
            VALUES($id, $subject, $kind, $key, $text, $data, $items, $tags, $confidence, 'live', $provenance, $hash, $created)
            """))
        {
            Bind(command, "$id", id);
            Bind(command, "$subject", subjectId);
            Bind(command, "$kind", fact.Kind);
            Bind(command, "$key", fact.Key);
            Bind(command, "$text", fact.Text);
            Bind(command, "$data", data);
            Bind(command, "$items", items);
            Bind(command, "$tags", JsonSerializer.Serialize(tags));
            Bind(command, "$confidence", fact.Confidence ?? 1.0);
            Bind(command, "$provenance", provenance);
            Bind(command, "$hash", contentHash);
            Bind(command, "$created", createdAt);
            command.ExecuteNonQuery();
        }

        long rowId;
        using (var rowIdCommand = Command(connection, transaction, "SELECT last_insert_rowid()"))
        {
            rowId = (long)rowIdCommand.ExecuteScalar()!;
        }

        using (var fts = Command(connection, transaction, "INSERT INTO facts_fts(rowid, text, tags) VALUES($rowid, $text, $tags)"))
        {
            Bind(fts, "$rowid", rowId);
            Bind(fts, "$text", fact.Text);
            Bind(fts, "$tags", string.Join(' ', tags));
            fts.ExecuteNonQuery();
        }

        for (var sequence = 0; sequence < refs.Count; sequence++)
        {
            var reference = refs[sequence];
            using var refCommand = Command(
                connection,
                transaction,
                """
                INSERT INTO refs(fact_id, seq, rel, kind, target, locator, basis, confidence, rev, snapshot, snapshot_hash, etag, verified_at, valid)
                VALUES($fact, $seq, $rel, $kind, $target, $locator, $basis, $confidence, $rev, $snapshot, $snapshot_hash, $etag, $verified_at, $valid)
                """);
            Bind(refCommand, "$fact", id);
            Bind(refCommand, "$seq", reference.Seq ?? sequence);
            Bind(refCommand, "$rel", reference.Rel);
            Bind(refCommand, "$kind", reference.Kind);
            Bind(refCommand, "$target", reference.Target);
            Bind(refCommand, "$locator", reference.Locator.HasValue ? CanonicalJson.Write(reference.Locator.Value) : null);
            Bind(refCommand, "$basis", reference.Basis);
            Bind(refCommand, "$confidence", reference.Confidence);
            Bind(refCommand, "$rev", reference.Rev);
            Bind(refCommand, "$snapshot", reference.Snapshot);
            Bind(refCommand, "$snapshot_hash", reference.SnapshotHash);
            Bind(refCommand, "$etag", reference.Etag);
            Bind(refCommand, "$verified_at", reference.VerifiedAt);
            Bind(refCommand, "$valid", reference.Valid.HasValue ? (reference.Valid.Value ? 1 : 0) : null);
            refCommand.ExecuteNonQuery();
        }

        foreach (var attachment in fact.Attachments ?? new List<AttachmentInput>())
        {
            if (string.IsNullOrWhiteSpace(attachment.Sha256))
            {
                continue;
            }

            using var attachmentCommand = Command(
                connection,
                transaction,
                "INSERT OR REPLACE INTO attachments(fact_id, sha256, filename, mime, bytes, perceptual) VALUES($fact, $sha, $filename, $mime, $bytes, $perceptual)");
            Bind(attachmentCommand, "$fact", id);
            Bind(attachmentCommand, "$sha", attachment.Sha256);
            Bind(attachmentCommand, "$filename", attachment.Filename ?? string.Empty);
            Bind(attachmentCommand, "$mime", attachment.Mime ?? string.Empty);
            Bind(attachmentCommand, "$bytes", attachment.Bytes);
            Bind(attachmentCommand, "$perceptual", attachment.Perceptual.HasValue ? CanonicalJson.Write(attachment.Perceptual.Value) : null);
            attachmentCommand.ExecuteNonQuery();
        }

        return id;
    }

    private sealed record SubjectResolution(string Id, string Name, bool Created, string? Parent);

    private sealed record SubjectRow(string Id, string Name, string? ParentId, List<string> Aliases);
}
