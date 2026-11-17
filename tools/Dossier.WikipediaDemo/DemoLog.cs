using System.Diagnostics;

namespace Dossier.WikipediaDemo;

/// <summary>A demo failure: printed as <c>error: ...</c> and exit code 2, like the script it replaces.</summary>
internal sealed class DemoFailure(string message) : Exception(message);

/// <summary>Timed stdout logs and <c>warning:</c> lines on stderr.</summary>
internal static class DemoLog
{
    private static readonly Stopwatch Clock = new();

    public static void Start() => Clock.Start();

    public static void Line(string message) =>
        Console.Out.Write($"[+{Clock.Elapsed.TotalSeconds:F1}s] {message}\n");

    public static void Warn(string message) => Console.Error.Write($"warning: {message}\n");

    public static void Error(string message) => Console.Error.Write($"error: {message}\n");
}
