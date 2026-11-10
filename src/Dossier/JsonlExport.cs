using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dossier;

public sealed partial class DossierStore
{
    /// <summary>The manifest "format" value of a JSONL bundle. Markdown bundles keep the number 1.</summary>
    public const string JsonlFormatId = "dossier-jsonl/1";

    /// <summary>Largest single attachment publish will inline as base64 (and import will accept inline).</summary>
    internal const long MaxEmbedAssetBytes = 256L * 1024 * 1024;

    private static readonly Regex JsonlDataFileRegex = new("^dossier-[0-9]{4,}\\.jsonl$", RegexOptions.Compiled);
    private static readonly Regex JsonlAssetPathRegex = new("^assets/[0-9a-f]{64}(\\.[a-z0-9]+)?$", RegexOptions.Compiled);

    // U+2028, U+2029 and U+0085 are valid raw inside JSON strings but split lines in several readers, so they are always escaped.
    private static readonly string LineSeparator = ((char)0x2028).ToString();
    private static readonly string ParagraphSeparator = ((char)0x2029).ToString();
    private static readonly string NextLine = ((char)0x0085).ToString();

    private sealed record JsonlRecord(string Label, byte[] Line);

    private sealed record JsonlDataFile(string Name, List<JsonlRecord> Records, long Bytes);

    private sealed record JsonlAssetFile(string Path, string Source, string Sha, long Bytes);

    /// <summary>One JSON text as a JSONL line: line/paragraph separators escaped, '\n' appended, UTF-8 without BOM.</summary>
    private static byte[] JsonlLine(string json)
    {
        var escaped = json
            .Replace(LineSeparator, "\\u2028", StringComparison.Ordinal)
            .Replace(ParagraphSeparator, "\\u2029", StringComparison.Ordinal)
            .Replace(NextLine, "\\u0085", StringComparison.Ordinal);
        var bytes = new byte[Utf8NoBom.GetByteCount(escaped) + 1];
        Utf8NoBom.GetBytes(escaped, 0, escaped.Length, bytes, 0);
        bytes[^1] = (byte)'\n';
        return bytes;
    }

    private static string CompactJson(Action<Utf8JsonWriter> write)
    {
        using var stream = new MemoryStream();
        using (var w = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))
        {
            write(w);
        }

        return Utf8NoBom.GetString(stream.ToArray());
    }

    private static byte[] SubjectLine(PubSubject subject, string path, bool parentInBundle) => JsonlLine(CompactJson(w =>
    {
        w.WriteStartObject();
        w.WriteStartArray("aliases");
        foreach (var alias in subject.Aliases)
        {
            w.WriteStringValue(alias);
        }

        w.WriteEndArray();
        w.WriteString("id", subject.Id);
        w.WriteString("kind", subject.Kind);
        w.WriteString("name", subject.Name);
        if (parentInBundle)
        {
            w.WriteString("parent", subject.ParentId);
        }

        w.WriteString("path", path);
        if (subject.Pin is { ValueKind: JsonValueKind.Object } pin
            && pin.TryGetProperty("repo", out var repo) && repo.ValueKind == JsonValueKind.String
            && pin.TryGetProperty("rev", out var rev) && rev.ValueKind == JsonValueKind.String)
        {
            w.WriteStartObject("pin");
            w.WriteString("repo", repo.GetString());
            w.WriteString("rev", rev.GetString());
            w.WriteEndObject();
        }

        w.WriteString("type", "subject");
        w.WriteEndObject();
    }));

    private static byte[] AssetLine(AttachmentRecord attachment, long bytes, string? embedded, string? path, bool missing) => JsonlLine(CompactJson(w =>
    {
        w.WriteStartObject();
        w.WriteNumber("bytes", bytes);
        if (embedded is not null)
        {
            w.WriteString("data", embedded);
            w.WriteString("encoding", "base64");
        }

        w.WriteString("filename", attachment.Filename);
        w.WriteString("mime", attachment.Mime);
        if (missing)
        {
            w.WriteBoolean("missing", true);
        }

        if (path is not null)
        {
            w.WriteString("path", path);
        }

        w.WriteString("sha256", attachment.Sha256);
        w.WriteString("type", "asset");
        w.WriteEndObject();
    }));

    private static long StricterLimit(long flag, long profile) => flag == 0 ? profile : profile == 0 ? flag : Math.Min(flag, profile);

    private static string Fail(string message) => message + "; nothing was written";

    /// <summary>
    /// publish --format jsonl: subjects and live facts (the facts markdown publish emits: superseded,
    /// retracted and kind "dossier" facts are not exported) as one JSON record per line, packed greedily
    /// into dossier-NNNN.jsonl files without ever splitting a record, plus manifest.json. Everything is
    /// built and measured in memory first; a limit violation throws before anything is written.
    /// </summary>
    private PublishResult PublishJsonl(
        PublishOptions options,
        PublishProfile? profile,
        string outDir,
        List<PubSubject> ordered,
        Dictionary<string, string> paths,
        List<PubFact> facts,
        string? scopeRootId)
    {
        var enforce = options.RespectLimits && profile is not null;
        var maxFiles = StricterLimit(options.MaxFiles, enforce ? profile!.MaxFiles : 0);
        var maxFileBytes = StricterLimit(options.MaxFileBytes, enforce ? profile!.MaxFileBytes : 0);
        var maxTotalBytes = StricterLimit(options.MaxTotalBytes, enforce ? profile!.MaxTotalBytes : 0);
        var mode = options.Assets;

        var inBundle = ordered.Select(s => s.Id).ToHashSet(StringComparer.Ordinal);
        var factsBySubject = facts.ToLookup(f => f.SubjectId, StringComparer.Ordinal);
        var subjectById = ordered.ToDictionary(s => s.Id, StringComparer.Ordinal);

        var records = new List<JsonlRecord>();
        var warnings = new List<string>();
        var seenAssets = new HashSet<string>(StringComparer.Ordinal);
        var assetFiles = new SortedDictionary<string, JsonlAssetFile>(StringComparer.Ordinal);
        var assetEntries = new SortedDictionary<string, (long Bytes, string Mime, bool Missing)>(StringComparer.Ordinal);

        foreach (var subject in ordered)
        {
            records.Add(new JsonlRecord(
                $"subject {subject.Id}",
                SubjectLine(subject, paths[subject.Id], subject.ParentId is not null && inBundle.Contains(subject.ParentId))));

            foreach (var fact in factsBySubject[subject.Id])
            {
                records.Add(new JsonlRecord($"fact {fact.Id}", JsonlLine(MachineRecordJson(fact, subject, indented: false, jsonlRecord: true))));
                if (mode == "none")
                {
                    continue;
                }

                foreach (var attachment in fact.Attachments)
                {
                    if (!seenAssets.Add(attachment.Sha256))
                    {
                        continue;
                    }

                    var source = Sha256Hex.IsMatch(attachment.Sha256) ? Path.Combine(BlobRoot, attachment.Sha256) : null;
                    if (source is null || !File.Exists(source))
                    {
                        warnings.Add($"warning: missing blob {attachment.Sha256} (attachment \"{Inline(attachment.Filename)}\" on subject \"{Inline(subject.Name)}\"); published without its bytes");
                        records.Add(new JsonlRecord($"asset {attachment.Sha256}", AssetLine(attachment, attachment.Bytes, null, null, missing: true)));
                        assetEntries[attachment.Sha256] = (attachment.Bytes, attachment.Mime, true);
                        continue;
                    }

                    var length = new FileInfo(source).Length;
                    assetEntries[attachment.Sha256] = (length, attachment.Mime, false);
                    if (mode == "files")
                    {
                        var assetPath = $"assets/{attachment.Sha256}.{AssetExtension(attachment)}";
                        assetFiles[assetPath] = new JsonlAssetFile(assetPath, source, attachment.Sha256, length);
                        records.Add(new JsonlRecord($"asset {attachment.Sha256}", AssetLine(attachment, length, null, assetPath, missing: false)));
                        continue;
                    }

                    // embed
                    if (length > MaxEmbedAssetBytes)
                    {
                        throw new DossierRequestException(
                            "asset_too_large_to_embed",
                            Fail($"asset {attachment.Sha256} (\"{Inline(attachment.Filename)}\", {length} bytes) is larger than the {MaxEmbedAssetBytes}-byte embed ceiling; use --assets files or --assets none"));
                    }

                    var base64Length = 4 * ((length + 2) / 3);
                    if (maxFileBytes > 0 && base64Length + 1 > maxFileBytes)
                    {
                        throw new DossierRequestException(
                            "record_exceeds_max_file_bytes",
                            Fail($"asset {attachment.Sha256} (\"{Inline(attachment.Filename)}\") needs at least {base64Length + 1} bytes embedded, more than the {maxFileBytes}-byte file limit; use --assets files or --assets none"));
                    }

                    var blob = File.ReadAllBytes(source);
                    records.Add(new JsonlRecord($"asset {attachment.Sha256}", AssetLine(attachment, blob.LongLength, Convert.ToBase64String(blob), null, missing: false)));
                }
            }
        }

        // Profile enforcement that is a hard error (limits above are folded into the stricter values).
        if (enforce && profile!.AllowedExtensions is { } allowed)
        {
            var wanted = new SortedSet<string>(StringComparer.Ordinal) { "jsonl" };
            foreach (var path in assetFiles.Keys)
            {
                wanted.Add(Path.GetExtension(path).TrimStart('.'));
            }

            var rejected = wanted.Where(e => !allowed.Contains(e)).ToList();
            if (rejected.Count > 0)
            {
                throw new DossierRequestException(
                    "profile_extension_not_allowed",
                    Fail($"profile \"{profile.Name}\" allows only {string.Join(", ", allowed)} but this bundle would write {string.Join(", ", rejected)} files; try --assets embed to avoid asset files, or pick another profile"));
            }
        }

        foreach (var file in assetFiles.Values)
        {
            if (maxFileBytes > 0 && file.Bytes > maxFileBytes)
            {
                throw new DossierRequestException(
                    "record_exceeds_max_file_bytes",
                    Fail($"asset file {file.Path} is {file.Bytes} bytes, more than the {maxFileBytes}-byte file limit; use --assets none or raise the limit"));
            }
        }

        // Greedy packing in record order; a line costs its emitted UTF-8 bytes plus its '\n' (already in the line).
        var dataFiles = new List<JsonlDataFile>();
        List<JsonlRecord>? current = null;
        long currentBytes = 0;
        foreach (var record in records)
        {
            if (maxFileBytes > 0 && record.Line.Length > maxFileBytes)
            {
                throw new DossierRequestException(
                    "record_exceeds_max_file_bytes",
                    Fail($"{record.Label} is {record.Line.Length} bytes as one line, more than the {maxFileBytes}-byte file limit; a record is never split, so use --assets files or --assets none (or raise the limit)"));
            }

            if (current is null || (maxFileBytes > 0 && currentBytes + record.Line.Length > maxFileBytes))
            {
                if (current is not null)
                {
                    dataFiles[^1] = dataFiles[^1] with { Bytes = currentBytes };
                }

                current = new List<JsonlRecord>();
                currentBytes = 0;
                dataFiles.Add(new JsonlDataFile($"dossier-{(dataFiles.Count + 1).ToString("D4", CultureInfo.InvariantCulture)}.jsonl", current, 0));
            }

            current.Add(record);
            currentBytes += record.Line.Length;
        }

        if (current is not null)
        {
            dataFiles[^1] = dataFiles[^1] with { Bytes = currentBytes };
        }

        var fileCount = dataFiles.Count + assetFiles.Count;
        if (maxFiles > 0 && fileCount > maxFiles)
        {
            throw new DossierRequestException(
                "max_files_exceeded",
                Fail($"the bundle needs {fileCount} data files ({dataFiles.Count} .jsonl + {assetFiles.Count} asset files; manifest.json is not counted) but the limit is {maxFiles}; raise the limit, raise --max-file-bytes, or use --assets embed|none"));
        }

        var totalBytes = dataFiles.Sum(f => f.Bytes) + assetFiles.Values.Sum(f => f.Bytes);
        if (maxTotalBytes > 0 && totalBytes > maxTotalBytes)
        {
            throw new DossierRequestException(
                "max_total_bytes_exceeded",
                Fail($"the bundle's data files total {totalBytes} bytes, more than the {maxTotalBytes}-byte limit (manifest.json is not counted); raise the limit or use --assets none"));
        }

        var binary = new SortedDictionary<string, byte[]>(StringComparer.Ordinal);
        var stats = new SortedDictionary<string, (long Bytes, int Lines, string Sha)>(StringComparer.Ordinal);
        foreach (var file in dataFiles)
        {
            var content = new byte[file.Bytes];
            var offset = 0;
            foreach (var record in file.Records)
            {
                record.Line.CopyTo(content, offset);
                offset += record.Line.Length;
            }

            binary[file.Name] = content;
            stats[file.Name] = (content.LongLength, file.Records.Count, Convert.ToHexString(SHA256.HashData(content)).ToLowerInvariant());
        }

        var hashInput = new StringBuilder();
        foreach (var (name, stat) in stats)
        {
            hashInput.Append("file\0").Append(name).Append('\0').Append(stat.Sha).Append('\0');
        }

        foreach (var file in assetFiles.Values)
        {
            hashInput.Append("asset\0").Append(file.Path).Append('\0').Append(file.Sha).Append('\0');
        }

        var bundleHash = Convert.ToHexString(SHA256.HashData(Utf8NoBom.GetBytes(hashInput.ToString()))).ToLowerInvariant();
        var subjectCount = ordered.Count;
        var manifest = BuildJsonlManifest(
            options, profile, scopeRootId, bundleHash, subjectCount, facts.Count, stats, assetEntries, assetFiles.Keys, maxFiles: options.MaxFiles, maxFileBytes: options.MaxFileBytes, maxTotalBytes: options.MaxTotalBytes);

        ComplianceReport? compliance = null;
        if (profile is not null)
        {
            var measured = new Dictionary<string, long>(StringComparer.Ordinal);
            foreach (var (name, stat) in stats)
            {
                measured[name] = stat.Bytes;
            }

            foreach (var file in assetFiles.Values)
            {
                measured[file.Path] = file.Bytes;
            }

            var scope = $"jsonl bundle ({measured.Count} data files: .jsonl{(assetFiles.Count > 0 ? " and asset files" : string.Empty)}; manifest.json not counted)";
            compliance = ComplianceReport.Evaluate(profile, measured, scope, "jsonl");
        }

        var previous = ReadPreviousManifest(outDir);
        var result = WriteBundle(
            outDir,
            new SortedDictionary<string, string>(StringComparer.Ordinal) { [BundleManifest] = manifest },
            new SortedDictionary<string, string>(assetFiles.ToDictionary(kv => kv.Key, kv => kv.Value.Source, StringComparer.Ordinal), StringComparer.Ordinal),
            previous?.Files ?? new List<string>(),
            subjectCount,
            facts.Count,
            binary);
        result.Assets = assetEntries.Count;
        result.Warnings = warnings;
        result.Compliance = compliance;
        return result;
    }

    private static string BuildJsonlManifest(
        PublishOptions options,
        PublishProfile? profile,
        string? scopeRootId,
        string bundleHash,
        int subjects,
        int facts,
        SortedDictionary<string, (long Bytes, int Lines, string Sha)> stats,
        SortedDictionary<string, (long Bytes, string Mime, bool Missing)> assets,
        IEnumerable<string> assetFilePaths,
        long maxFiles,
        long maxFileBytes,
        long maxTotalBytes)
    {
        var fileStats = new Dictionary<string, object?>();
        foreach (var (name, stat) in stats)
        {
            fileStats[name] = new Dictionary<string, object?> { ["bytes"] = stat.Bytes, ["lines"] = stat.Lines, ["sha256"] = stat.Sha };
        }

        var assetMap = new Dictionary<string, object?>();
        foreach (var (sha, entry) in assets)
        {
            assetMap[sha] = new Dictionary<string, object?> { ["bytes"] = entry.Bytes, ["mime"] = entry.Mime, ["missing"] = entry.Missing };
        }

        var optionMap = new Dictionary<string, object?>
        {
            ["assets"] = options.Assets,
            ["max_file_bytes"] = maxFileBytes,
            ["max_files"] = maxFiles,
            ["max_total_bytes"] = maxTotalBytes,
            ["subject"] = options.Subject,
            ["subject_id"] = scopeRootId,
        };
        if (profile is not null)
        {
            optionMap["profile"] = profile.Name;
            optionMap["respect_limits"] = options.RespectLimits;
        }

        var files = stats.Keys.Concat(assetFilePaths).Append(BundleManifest).OrderBy(p => p, StringComparer.Ordinal).ToList();
        var root = new Dictionary<string, object?>
        {
            ["assets"] = assetMap,
            ["bundle_hash"] = bundleHash,
            ["counts"] = new Dictionary<string, object?> { ["assets"] = assets.Count, ["facts"] = facts, ["subjects"] = subjects },
            ["file_stats"] = fileStats,
            ["files"] = files,
            ["format"] = JsonlFormatId,
            ["options"] = optionMap,
        };

        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true, NewLine = "\n", Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))
        {
            WriteSorted(writer, root);
        }

        return Utf8NoBom.GetString(stream.ToArray()) + "\n";
    }
}
