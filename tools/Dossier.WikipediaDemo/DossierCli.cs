using System.Diagnostics;
using System.Text;

namespace Dossier.WikipediaDemo;

/// <summary>How to invoke the dossier CLI: a binary, or <c>dotnet Dossier.dll</c>.</summary>
internal sealed record DossierCommand(string Command, IReadOnlyList<string> PrefixArgs);

/// <summary>Runs <c>dossier</c> child processes against the demo database.</summary>
internal sealed class DossierCli(DossierCommand command, string db)
{
    public static DossierCommand Resolve(string? binOption)
    {
        var bin = binOption ?? Environment.GetEnvironmentVariable("DOSSIER_BIN");
        if (!string.IsNullOrEmpty(bin))
        {
            return new DossierCommand(bin, []);
        }

        var dll = Environment.GetEnvironmentVariable("DOSSIER_DLL");
        if (!string.IsNullOrEmpty(dll))
        {
            return new DossierCommand("dotnet", [dll]);
        }

        var repo = FindRepoRoot();
        if (repo is not null)
        {
            foreach (var configuration in new[] { "Release", "Debug" })
            {
                var candidate = Path.Combine(repo, "src", "Dossier", "bin", configuration, "net10.0", "Dossier.dll");
                if (File.Exists(candidate))
                {
                    return new DossierCommand("dotnet", [candidate]);
                }
            }
        }

        throw new DemoFailure("no Dossier build found; run `dotnet build -c Release` or set DOSSIER_BIN");
    }

    /// <summary>Walk up from the executable and the working directory looking for the solution.</summary>
    private static string? FindRepoRoot()
    {
        foreach (var start in new[] { AppContext.BaseDirectory, Directory.GetCurrentDirectory() })
        {
            for (var dir = new DirectoryInfo(start); dir is not null; dir = dir.Parent)
            {
                if (File.Exists(Path.Combine(dir.FullName, "Dossier.sln")))
                {
                    return dir.FullName;
                }
            }
        }

        return null;
    }

    /// <summary>Run a dossier command, optionally feeding stdin.</summary>
    public (string Stdout, string Stderr, int ExitCode) Run(IReadOnlyList<string> args, string? stdin = null)
    {
        var startInfo = new ProcessStartInfo(command.Command)
        {
            UseShellExecute = false,
            RedirectStandardInput = stdin is not null,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            StandardOutputEncoding = new UTF8Encoding(false),
            StandardErrorEncoding = new UTF8Encoding(false),
        };
        if (stdin is not null)
        {
            startInfo.StandardInputEncoding = new UTF8Encoding(false);
        }

        foreach (var prefix in command.PrefixArgs)
        {
            startInfo.ArgumentList.Add(prefix);
        }

        foreach (var arg in args)
        {
            startInfo.ArgumentList.Add(arg);
        }

        startInfo.Environment["DOSSIER_DB"] = db;

        Process process;
        try
        {
            process = Process.Start(startInfo) ?? throw new InvalidOperationException("process did not start");
        }
        catch (Exception error)
        {
            throw new DemoFailure($"cannot run {command.Command}: {error.Message}");
        }

        using (process)
        {
            var stdout = process.StandardOutput.ReadToEndAsync();
            var stderr = process.StandardError.ReadToEndAsync();
            if (stdin is not null)
            {
                process.StandardInput.Write(stdin);
                process.StandardInput.Close();
            }

            process.WaitForExit();
            return (stdout.GetAwaiter().GetResult(), stderr.GetAwaiter().GetResult(), process.ExitCode);
        }
    }

    /// <summary>Run a dossier command and fail the demo on a non-zero exit.</summary>
    public (string Stdout, string Stderr) RunOrFail(IReadOnlyList<string> args, string? stdin = null)
    {
        var (stdout, stderr, exitCode) = Run(args, stdin);
        if (exitCode != 0)
        {
            var detail = (stderr.Length > 0 ? stderr : stdout).Trim();
            throw new DemoFailure($"{args[0]} failed (exit {exitCode}): {detail}");
        }

        return (stdout, stderr);
    }

    /// <summary>Start <c>dossier serve</c>; its stderr is inherited so the server's own logs stay visible.</summary>
    public Process SpawnServe(int port, Action<int> onExit)
    {
        var startInfo = new ProcessStartInfo(command.Command)
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = false,
            RedirectStandardInput = false,
            StandardOutputEncoding = new UTF8Encoding(false),
        };
        foreach (var prefix in command.PrefixArgs)
        {
            startInfo.ArgumentList.Add(prefix);
        }

        startInfo.ArgumentList.Add("serve");
        startInfo.ArgumentList.Add("--port");
        startInfo.ArgumentList.Add(port.ToString());
        startInfo.Environment["DOSSIER_DB"] = db;

        Process process;
        try
        {
            process = Process.Start(startInfo) ?? throw new InvalidOperationException("process did not start");
        }
        catch (Exception error)
        {
            throw new DemoFailure($"cannot start dossier serve: {error.Message}");
        }

        // Drain stdout so a chatty server can never block on a full pipe; "ignore" in the script.
        process.OutputDataReceived += (_, _) => { };
        process.BeginOutputReadLine();
        process.EnableRaisingEvents = true;
        process.Exited += (_, _) => onExit(process.ExitCode);
        return process;
    }
}
