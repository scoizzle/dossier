using System.Reflection;

namespace Dossier;

/// <summary>The build's informational version without any "+sourcerevision" suffix.</summary>
internal static class AppVersion
{
    public static string Current { get; } = Read();

    private static string Read()
    {
        var assembly = typeof(AppVersion).Assembly;
        var value = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion
            ?? assembly.GetName().Version?.ToString(3)
            ?? "0.0.0";
        var plus = value.IndexOf('+');
        return plus < 0 ? value : value[..plus];
    }
}
