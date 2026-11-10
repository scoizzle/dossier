using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Dossier;

/// <summary>
/// A consumer's upload quotas, read from a JSON file (see profiles/). Every limit is optional; 0 (or an
/// absent key) means unbounded for the max_* limits and "no floor" for min_file_bytes, and an absent
/// allowed_extensions accepts any extension. Unknown keys and wrongly typed fields are rejected by name.
/// </summary>
public sealed class PublishProfile
{
    public string Name { get; set; } = string.Empty;
    public string SourceUrl { get; set; } = string.Empty;
    public string Retrieved { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public long MaxFiles { get; set; }
    public long MinFileBytes { get; set; }
    public long MaxFileBytes { get; set; }
    public long MaxTotalBytes { get; set; }
    public long MaxPathDepth { get; set; }

    /// <summary>Lowercase extensions without the dot; null accepts any.</summary>
    public List<string>? AllowedExtensions { get; set; }

    public static PublishProfile Load(string path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            throw new DossierRequestException("invalid_profile", $"profile file not found: {path}");
        }

        JsonDocument document;
        try
        {
            document = JsonDocument.Parse(File.ReadAllText(path));
        }
        catch (JsonException exception)
        {
            throw new DossierRequestException("invalid_profile", $"profile {path} is not valid JSON: {exception.Message}");
        }

        using (document)
        {
            if (document.RootElement.ValueKind != JsonValueKind.Object)
            {
                throw new DossierRequestException("invalid_profile", $"profile {path} must be a JSON object");
            }

            var profile = new PublishProfile { Name = Path.GetFileNameWithoutExtension(path) };
            foreach (var property in document.RootElement.EnumerateObject())
            {
                switch (property.Name)
                {
                    case "name":
                        profile.Name = String(path, property);
                        break;
                    case "source_url":
                        profile.SourceUrl = String(path, property);
                        break;
                    case "retrieved":
                        profile.Retrieved = String(path, property);
                        break;
                    case "note":
                        profile.Note = String(path, property);
                        break;
                    case "max_files":
                        profile.MaxFiles = Count(path, property);
                        break;
                    case "min_file_bytes":
                        profile.MinFileBytes = Count(path, property);
                        break;
                    case "max_file_bytes":
                        profile.MaxFileBytes = Count(path, property);
                        break;
                    case "max_total_bytes":
                        profile.MaxTotalBytes = Count(path, property);
                        break;
                    case "max_path_depth":
                        profile.MaxPathDepth = Count(path, property);
                        break;
                    case "allowed_extensions":
                        profile.AllowedExtensions = Extensions(path, property);
                        break;
                    default:
                        throw new DossierRequestException("invalid_profile", $"profile {path}: unknown field \"{property.Name}\"");
                }
            }

            if (profile.MaxFileBytes > 0 && profile.MinFileBytes > profile.MaxFileBytes)
            {
                throw new DossierRequestException("invalid_profile", $"profile {path}: field \"min_file_bytes\" ({profile.MinFileBytes}) exceeds \"max_file_bytes\" ({profile.MaxFileBytes})");
            }

            return profile;
        }
    }

    private static string String(string path, JsonProperty property) =>
        property.Value.ValueKind == JsonValueKind.String
            ? property.Value.GetString()!
            : throw new DossierRequestException("invalid_profile", $"profile {path}: field \"{property.Name}\" must be a string");

    private static long Count(string path, JsonProperty property) =>
        property.Value.ValueKind == JsonValueKind.Number && property.Value.TryGetInt64(out var value) && value >= 0
            ? value
            : throw new DossierRequestException("invalid_profile", $"profile {path}: field \"{property.Name}\" must be a non-negative integer");

    private static List<string> Extensions(string path, JsonProperty property)
    {
        if (property.Value.ValueKind != JsonValueKind.Array)
        {
            throw new DossierRequestException("invalid_profile", $"profile {path}: field \"{property.Name}\" must be an array of extensions");
        }

        var result = new List<string>();
        foreach (var item in property.Value.EnumerateArray())
        {
            var extension = item.ValueKind == JsonValueKind.String ? item.GetString()!.TrimStart('.').ToLowerInvariant() : string.Empty;
            if (extension.Length == 0)
            {
                throw new DossierRequestException("invalid_profile", $"profile {path}: field \"{property.Name}\" must hold non-empty strings");
            }

            result.Add(extension);
        }

        return result;
    }
}

public sealed record ComplianceRow(string Limit, string Allowed, string Actual, bool Pass);

/// <summary>One row per profile limit, computed over the files a consumer would upload.</summary>
public sealed class ComplianceReport
{
    public PublishProfile Profile { get; init; } = new();

    /// <summary>What was measured, e.g. "shards/ (12 files)".</summary>
    public string Scope { get; init; } = string.Empty;

    /// <summary>"markdown" (default) or "jsonl": names the bundle format in the extension-gap note.</summary>
    public string Format { get; init; } = "markdown";

    public List<ComplianceRow> Rows { get; init; } = new();

    public bool Passed => Rows.All(r => r.Pass);

    /// <summary>Evaluates <paramref name="files"/> (bundle-relative path, byte size) against the profile.</summary>
    public static ComplianceReport Evaluate(PublishProfile profile, IReadOnlyDictionary<string, long> files, string scope, string format = "markdown")
    {
        var rows = new List<ComplianceRow>();
        var count = files.Count;
        var smallest = files.Count == 0 ? 0 : files.Values.Min();
        var largest = files.Count == 0 ? 0 : files.Values.Max();
        var total = files.Values.Sum();
        var depth = files.Count == 0 ? 0 : files.Keys.Max(p => p.Split('/').Length);

        static string Num(long value) => value.ToString(CultureInfo.InvariantCulture);
        static string Limit(long value) => value == 0 ? "unbounded" : Num(value);

        rows.Add(new ComplianceRow("max_files", Limit(profile.MaxFiles), Num(count), profile.MaxFiles == 0 || count <= profile.MaxFiles));
        rows.Add(new ComplianceRow(
            "min_file_bytes",
            profile.MinFileBytes == 0 ? "none" : ">= " + Num(profile.MinFileBytes),
            Num(smallest) + " (smallest)",
            smallest >= profile.MinFileBytes));
        rows.Add(new ComplianceRow(
            "max_file_bytes",
            Limit(profile.MaxFileBytes),
            Num(largest) + " (largest)",
            profile.MaxFileBytes == 0 || largest <= profile.MaxFileBytes));
        rows.Add(new ComplianceRow("max_total_bytes", Limit(profile.MaxTotalBytes), Num(total), profile.MaxTotalBytes == 0 || total <= profile.MaxTotalBytes));

        var extensions = files.Keys
            .Select(p => Path.GetExtension(p).TrimStart('.').ToLowerInvariant())
            .Distinct(StringComparer.Ordinal)
            .OrderBy(e => e, StringComparer.Ordinal)
            .ToList();
        var unsupported = profile.AllowedExtensions is null
            ? new List<string>()
            : extensions.Where(e => !profile.AllowedExtensions.Contains(e)).ToList();
        rows.Add(new ComplianceRow(
            "allowed_extensions",
            profile.AllowedExtensions is null ? "any" : string.Join(", ", profile.AllowedExtensions),
            unsupported.Count == 0 ? string.Join(", ", extensions) : "unsupported: " + string.Join(", ", unsupported.Select(Label)),
            unsupported.Count == 0));

        rows.Add(new ComplianceRow("max_path_depth", Limit(profile.MaxPathDepth), Num(depth), profile.MaxPathDepth == 0 || depth <= profile.MaxPathDepth));

        return new ComplianceReport { Profile = profile, Scope = scope, Format = format, Rows = rows };
    }

    private static string Label(string extension) => extension switch
    {
        "md" => "md (markdown)",
        "" => "(none)",
        _ => extension,
    };

    public string Render()
    {
        var b = new StringBuilder();
        b.Append("profile: ").Append(Profile.Name);
        if (Profile.SourceUrl.Length > 0)
        {
            b.Append(" (source ").Append(Profile.SourceUrl);
            if (Profile.Retrieved.Length > 0)
            {
                b.Append(", retrieved ").Append(Profile.Retrieved);
            }

            b.Append(')');
        }

        b.Append('\n');
        b.Append("scope: ").Append(Scope).Append('\n');

        var w0 = Math.Max("limit".Length, Rows.Max(r => r.Limit.Length));
        var w1 = Math.Max("allowed".Length, Rows.Max(r => r.Allowed.Length));
        var w2 = Math.Max("actual".Length, Rows.Max(r => r.Actual.Length));
        b.Append("| ").Append("limit".PadRight(w0)).Append(" | ").Append("allowed".PadRight(w1)).Append(" | ").Append("actual".PadRight(w2)).Append(" | result |\n");
        b.Append("| ").Append(new string('-', w0)).Append(" | ").Append(new string('-', w1)).Append(" | ").Append(new string('-', w2)).Append(" | ------ |\n");
        foreach (var row in Rows)
        {
            b.Append("| ").Append(row.Limit.PadRight(w0)).Append(" | ").Append(row.Allowed.PadRight(w1)).Append(" | ").Append(row.Actual.PadRight(w2))
                .Append(" | ").Append((row.Pass ? "PASS" : "FAIL").PadRight(6)).Append(" |\n");
        }

        b.Append("overall: ").Append(Passed ? "PASS" : "FAIL").Append('\n');
        if (Rows.Any(r => r.Limit == "allowed_extensions" && !r.Pass))
        {
            b.Append("format gap: this bundle is ").Append(Format).Append(" and no converter is bundled, so the extension check is reported, not fixed; convert the files before uploading to this consumer.\n");
        }

        if (Profile.Note.Length > 0)
        {
            b.Append("note: ").Append(Profile.Note).Append('\n');
        }

        return b.ToString();
    }
}
