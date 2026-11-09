using System.Text.RegularExpressions;

namespace Dossier;

internal static partial class Names
{
    [GeneratedRegex(@"\s+")]
    private static partial Regex Whitespace();

    /// <summary>Casefold (invariant lowercase) and collapse internal whitespace for matching.</summary>
    public static string Normalize(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return Whitespace().Replace(value, " ").Trim().ToLowerInvariant();
    }
}
