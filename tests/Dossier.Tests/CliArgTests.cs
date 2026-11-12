using System.Diagnostics;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Pins the CLI's argument contract: an unknown option, or a value-taking option with no value,
/// fails closed with a message naming the flag before any store work happens.
/// </summary>
public sealed class CliArgTests
{
    private static async Task<(int Exit, string Out, string Err)> Run(string dbPath, string? stdin, params string[] args)
    {
        var info = new ProcessStartInfo("dotnet")
        {
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            WorkingDirectory = Path.GetDirectoryName(dbPath)!,
        };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in args)
        {
            info.ArgumentList.Add(arg);
        }

        info.Environment["DOSSIER_DB"] = dbPath;
        using var process = Process.Start(info)!;
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.StandardInput.WriteAsync(stdin ?? string.Empty);
        process.StandardInput.Close();
        await process.WaitForExitAsync();
        return (process.ExitCode, await stdout, await stderr);
    }

    private static long FactCount(TempDb db)
    {
        using var connection = db.Store.OpenConnection();
        return Fixtures.Count(connection, "SELECT COUNT(*) FROM facts");
    }

    [Test]
    public async Task UnknownOptionIsRejectedAndSuggestsTheClosestFlag()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var (exit, stdout, stderr) = await Run(
            db.DbPath,
            null,
            "dossier", "compile", "--subject", "Widget", "--budget", "200", "--mode", "strict", "--format", "markdown");

        await Assert.That(exit).IsNotEqualTo(0);
        await Assert.That(stdout).IsEqualTo(string.Empty);
        await Assert.That(stderr).Contains("unknown option \"--mode\"");
        await Assert.That(stderr).Contains("--budget-mode");
    }

    [Test]
    public async Task MissingOptionValueIsRejected()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        string[][] runs =
        [
            ["dossier", "compile", "--subject", "Widget", "--format"],
            ["dossier", "compile", "--subject", "Widget", "--budget", "--format", "markdown"],
        ];

        foreach (var args in runs)
        {
            var (exit, stdout, stderr) = await Run(db.DbPath, null, args);
            await Assert.That(exit).IsNotEqualTo(0);
            await Assert.That(stdout).IsEqualTo(string.Empty);
            await Assert.That(stderr).Contains("requires a value");
        }
    }

    [Test]
    public async Task DryRunTypoDoesNotWrite()
    {
        using var db = new TempDb();
        var request = Path.Combine(db.Directory, "post.json");
        await File.WriteAllTextAsync(
            request,
            """{"subject":{"name":"Widget"},"facts":[{"kind":"note","text":"body"}]}""");

        // A misspelled --dry-run on its own: if the post ran, the fact would be written.
        var (exit, stdout, stderr) = await Run(db.DbPath, null, "post", "--file", request, "--dryrun");
        await Assert.That(exit).IsNotEqualTo(0);
        await Assert.That(stdout).IsEqualTo(string.Empty);
        await Assert.That(stderr).Contains("unknown option \"--dryrun\"");
        await Assert.That(FactCount(db)).IsEqualTo(0L);

        // And next to a valid --dry-run.
        var (dryExit, dryOut, dryErr) = await Run(db.DbPath, null, "post", "--file", request, "--dry-run", "--dryrun");
        await Assert.That(dryExit).IsNotEqualTo(0);
        await Assert.That(dryOut).IsEqualTo(string.Empty);
        await Assert.That(dryErr).Contains("unknown option \"--dryrun\"");
        await Assert.That(FactCount(db)).IsEqualTo(0L);
    }

    [Test]
    public async Task EveryUsageFlagIsAccepted()
    {
        var program = File.ReadAllText(RepoFilePath("src/Dossier/Program.cs"));
        var documented = new List<string>
        {
            Regex.Match(program, @"const string usage = ""(.*?)"";").Groups[1].Value,
        };
        documented.AddRange(Regex.Matches(program, @"""usage: (.*?)""").Select(m => m.Groups[1].Value));
        await Assert.That(documented.Count).IsGreaterThan(1);

        // The const usage literal is also matched by the usage-line regex, so dedupe the pairs
        // before counting: a duplicated pair is not a covered pair.
        var pairs = documented.SelectMany(VerbFlags).Distinct().ToList();

        // Exactly the flags written in brackets or piped together ("[--dry-run]",
        // "[--brief|--q]", "[--drafts <file|->]"): the old token regex dropped every one, so
        // these assertions are what makes the extraction fail loudly on a regression.
        (string Verb, string Flag)[] required =
        [
            ("post", "--dry-run"),
            ("dump", "--source"),
            ("correlate", "--subject"),
            ("correlate", "--matcher"),
            ("check", "--subject"),
            ("check", "--drafts"),
            ("check", "--limit"),
            ("search", "--q"),
            ("search", "--brief"),
            ("search", "--limit"),
            ("dossier compile", "--budget"),
            ("dossier compile", "--budget-mode"),
            ("dossier compile", "--format"),
            ("dossier compile", "--descendants"),
            ("publish", "--out"),
            ("publish", "--format"),
            ("publish", "--subject"),
            ("publish", "--facts"),
            ("publish", "--assets"),
            ("publish", "--respect-limits"),
            ("import", "--from"),
            ("import", "--db"),
        ];
        var missing = required
            .Where(pair => !pairs.Contains(pair))
            .Select(pair => $"{pair.Verb} {pair.Flag}")
            .ToList();
        await Assert.That(string.Join(", ", missing)).IsEqualTo(string.Empty);

        // 43 distinct (verb, flag) pairs are documented today; falling to the floor means the
        // extraction regressed, not that the docs shrank.
        await Assert.That(pairs.Count).IsGreaterThan(40);

        foreach (var (verb, flag) in pairs)
        {
            using var db = new TempDb();
            var args = verb.Split(' ').Concat([flag, "x"]).ToArray();
            var (_, _, stderr) = await Run(db.DbPath, string.Empty, args);
            if (stderr.Contains("unknown option", StringComparison.Ordinal) ||
                stderr.Contains("requires a value", StringComparison.Ordinal))
            {
                throw new Exception($"{string.Join(' ', args)} was rejected: {stderr.Trim()}");
            }
        }
    }

    [Test]
    public async Task EveryInRepoCallerFlagSetIsAccepted()
    {
        using var db = new TempDb();
        const string requestJson = """{"subject":{"name":"Widget"},"facts":[{"kind":"note","text":"body"}]}""";
        var request = Path.Combine(db.Directory, "post.json");
        await File.WriteAllTextAsync(request, requestJson);
        var source = Path.Combine(db.Directory, "doc.md");
        await File.WriteAllTextAsync(source, "# Title\n\nbody\n");
        var outDir = Path.Combine(db.Directory, "bundle");
        var drafts = Path.Combine(db.Directory, "drafts.json");
        await File.WriteAllTextAsync(drafts, "[]");

        var runs = new (string[] Args, string Stdin)[]
        {
            (["post", "--file", "-"], requestJson),
            (["post", "--file", request], ""),
            (["search", "--subject", "Widget", "--q", "body", "--limit", "5"], ""),
            (["search", "--brief", "--q", "body", "--kind", "note", "--tag", "t", "--status", "active", "--ref-target", "Widget", "--direction", "in", "--key", "k", "--actor", "a", "--since", "2020-01-01", "--cursor", "bm90LWEtY3Vyc29y"], ""),
            (["dossier", "compile", "--subject", "Widget", "--budget", "200", "--budget-mode", "strict", "--depth", "full", "--format", "markdown", "--need", "x", "--descendants", "--order", "rank", "--recency", "0.5"], ""),
            (["publish", "--profile", RepoFilePath("profiles/copilot-studio.json"), "--respect-limits", "--out", outDir], ""),
            (["check", "--subject", "Widget"], ""),
            // --drafts and --limit are the bracketed check flags; --drafts must accept a path.
            (["check", "--subject", "Widget", "--drafts", drafts, "--limit", "5"], ""),
            (["dump", "--source", source, "--subject", "Widget", "--split", "heading", "--tag", "t", "--kind", "note", "--entity-subjects"], ""),
            (["correlate", "--subject", "Widget", "--matcher", "same_ref"], ""),
            (["import", "--from", outDir, "--db", Path.Combine(db.Directory, "import", "dossier.db")], ""),
            (["show", "deadbeef"], ""),
            (["retract", "deadbeef"], ""),
        };

        foreach (var (args, stdin) in runs)
        {
            var (_, _, stderr) = await Run(db.DbPath, stdin, args);
            if (stderr.Contains("unknown option", StringComparison.Ordinal) ||
                stderr.Contains("requires a value", StringComparison.Ordinal))
            {
                throw new Exception($"{string.Join(' ', args)} was rejected: {stderr.Trim()}");
            }
        }

        // serve blocks once it binds, so prove --port is accepted by the value check it runs first.
        var (serveExit, _, serveErr) = await Run(db.DbPath, "", "serve", "--port", "not-a-port");
        await Assert.That(serveExit).IsNotEqualTo(0);
        await Assert.That(serveErr).Contains("--port must be an integer");
    }

    private static IEnumerable<(string Verb, string Flag)> VerbFlags(string usage)
    {
        // Parenthetical prose (e.g. import's "must have been published with --facts detail") is not
        // part of the verb's flag list.
        var text = Regex.Replace(usage, @"\([^()]*\)", " ").Trim();
        const string prefix = "usage: ";
        if (text.StartsWith(prefix, StringComparison.Ordinal))
        {
            text = text[prefix.Length..];
        }

        if (text.StartsWith("dossier <", StringComparison.Ordinal) && text.EndsWith('>'))
        {
            text = text["dossier <".Length..^1];
        }
        else if (text.StartsWith("dossier ", StringComparison.Ordinal))
        {
            text = text["dossier ".Length..];
        }

        foreach (var segment in SplitTopLevel(text))
        {
            // Bracket, paren, comma and pipe characters delimit alternatives inside a group
            // ("[--dry-run]", "[--brief|--q]", "[--format md|jsonl]"), so they separate tokens
            // too: "[--limit" and "--respect-limits]" are the flags --limit and --respect-limits.
            var tokens = Regex.Split(segment, @"[\s\[\]()|,]+").Where(t => t.Length > 0).ToArray();
            if (tokens.Length == 0)
            {
                continue;
            }

            var verb = tokens[0];
            var skip = 1;
            if (verb == "dossier" && tokens.Length > 1 && tokens[1] == "compile")
            {
                verb = "dossier compile";
                skip = 2;
            }

            foreach (var token in tokens.Skip(skip))
            {
                if (Regex.IsMatch(token, @"^--[a-z][a-z-]*$"))
                {
                    yield return (verb, token);
                }
            }
        }
    }

    /// <summary>Splits a usage string on top-level '|' so verb groups stay whole (`&lt;file|-&gt;`, `md|jsonl`).</summary>
    private static IEnumerable<string> SplitTopLevel(string text)
    {
        var depth = 0;
        var start = 0;
        for (var i = 0; i < text.Length; i++)
        {
            switch (text[i])
            {
                case '<' or '[':
                    depth++;
                    break;
                case '>' or ']':
                    depth = Math.Max(0, depth - 1);
                    break;
                case '|' when depth == 0:
                    yield return text[start..i];
                    start = i + 1;
                    break;
            }
        }

        yield return text[start..];
    }

    private static string RepoFilePath(string relative)
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
        {
            var candidate = Path.Combine(dir.FullName, relative);
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        throw new FileNotFoundException($"could not find {relative} above {AppContext.BaseDirectory}");
    }
}
