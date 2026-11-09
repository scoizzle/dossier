using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dossier;

/// <summary>
/// content_hash = sha256 over normalized text, data canonical JSON, and sorted ref lines.
/// Ref line = rel|kind|target|locator-min. rev, snapshot, snapshot_hash, etag, verified_at
/// (and seq/basis/confidence/valid) are deliberately absent, so freshness metadata never
/// changes identity.
/// </summary>
public static class ContentHash
{
    private static readonly Regex Whitespace = new(@"\s+", RegexOptions.Compiled);

    /// <summary>Trim and collapse internal whitespace runs to one space.</summary>
    public static string NormalizeText(string text) => Whitespace.Replace(text, " ").Trim();

    public static string Compute(string text, JsonElement? data, IReadOnlyList<RefInput> refs)
    {
        var sb = new StringBuilder();
        sb.Append(NormalizeText(text));
        sb.Append('\n');
        if (data.HasValue)
        {
            sb.Append(CanonicalJson.Write(data.Value));
        }

        sb.Append('\n');

        var lines = refs
            .Select(r => $"{r.Rel ?? string.Empty}|{r.Kind ?? string.Empty}|{r.Target ?? string.Empty}|{LocatorMin(r.Locator)}")
            .OrderBy(line => line, StringComparer.Ordinal)
            .ToList();

        for (var i = 0; i < lines.Count; i++)
        {
            if (i > 0)
            {
                sb.Append('\n');
            }

            sb.Append(lines[i]);
        }

        var bytes = Encoding.UTF8.GetBytes(sb.ToString());
        return Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
    }

    /// <summary>Minimal deterministic locator text; empty when the ref carries no locator.</summary>
    public static string LocatorMin(JsonElement? locator) =>
        locator.HasValue ? CanonicalJson.Write(locator.Value) : string.Empty;
}
