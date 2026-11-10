namespace Dossier.Tests;

/// <summary>Bundle-relative path helpers for tests; independent of the host OS path rules.</summary>
internal static class BundlePaths
{
    /// <summary>Normalizes an OS path (either separator) to the '/' form bundle keys and links use.</summary>
    public static string ToBundle(string path) => path.Replace('\\', '/');

    /// <summary>
    /// Resolves a relative link written in the bundle file <paramref name="from"/> to a bundle-relative
    /// path, purely by '/' segments (no filesystem or drive-letter semantics).
    /// </summary>
    public static string Resolve(string from, string target)
    {
        var segments = new List<string>();
        var fromParts = ToBundle(from).Split('/');
        segments.AddRange(fromParts.Take(fromParts.Length - 1));
        foreach (var part in ToBundle(target).Split('/'))
        {
            if (part is "" or ".")
            {
                continue;
            }

            if (part == "..")
            {
                if (segments.Count > 0)
                {
                    segments.RemoveAt(segments.Count - 1);
                }

                continue;
            }

            segments.Add(part);
        }

        return string.Join('/', segments);
    }
}
