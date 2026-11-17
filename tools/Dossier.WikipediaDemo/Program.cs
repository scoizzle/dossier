using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Dossier.WikipediaDemo;

/// <summary>
/// Live demo: grow a Dossier graph from Wikipedia in real time.
///
///   article   -> subject (kind "article", child of a demo root subject)
///   prose     -> facts   (the article's plain-text extract, one fact per paragraph)
///   wikilinks -> refs    (kind "subject", rel "mentions", basis "derived")
///
/// Articles are fetched first, then posted one at a time on an interval while
/// <c>dossier serve</c> runs, so the tree and graph fill in as the demo plays.
/// </summary>
internal static class Program
{
    private static readonly JsonSerializerOptions IndentedJson = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    private static readonly JsonSerializerOptions LineJson = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    public static async Task<int> Main(string[] args)
    {
        try
        {
            // The script wrote UTF-8 everywhere; the Windows console default is the OEM code page.
            Console.OutputEncoding = new UTF8Encoding(false);
        }
        catch (Exception)
        {
            // Best effort only: never fail the demo over console encoding.
        }

        DemoLog.Start();
        Process? server = null;
        var stopping = false;

        void StopServer()
        {
            stopping = true;
            if (server is null)
            {
                return;
            }

            try
            {
                if (server.HasExited)
                {
                    return;
                }

                try
                {
                    if (OperatingSystem.IsWindows())
                    {
                        server.Kill();
                    }
                    else
                    {
                        Native.SendSignal(server.Id, Native.Sigterm);
                    }
                }
                catch
                {
                    // fall through to a hard kill below
                }

                server.WaitForExit(5000);
                if (!server.HasExited)
                {
                    server.Kill();
                }
            }
            catch (InvalidOperationException)
            {
                // the process object is already gone; nothing left to stop
            }
        }

        Console.CancelKeyPress += (_, eventArgs) =>
        {
            eventArgs.Cancel = true;
            StopServer();
            Environment.Exit(130);
        };
        AppDomain.CurrentDomain.ProcessExit += (_, _) => StopServer();

        // SIGTERM and bare SIGINT (kill, not a terminal Ctrl-C) are POSIX-only; SIGTERM
        // throws when registered on Windows.
        PosixSignalRegistration? sigint = null;
        PosixSignalRegistration? sigterm = null;
        if (!OperatingSystem.IsWindows())
        {
            sigint = PosixSignalRegistration.Create(PosixSignal.SIGINT, context =>
            {
                context.Cancel = true;
                StopServer();
                Environment.Exit(130);
            });
            sigterm = PosixSignalRegistration.Create(PosixSignal.SIGTERM, context =>
            {
                context.Cancel = true;
                StopServer();
                Environment.Exit(143);
            });
        }

        try
        {
            var options = DemoOptions.Parse(args);
            if (options.Help)
            {
                Console.Out.Write(DemoOptions.HelpText);
                return 0;
            }

            var config = options.BuildConfig();
            var dossierCommand = DossierCli.Resolve(options.Bin);
            var dossier = new DossierCli(dossierCommand, config.Db);

            var dbFile = Path.GetFullPath(config.Db);
            if (!options.DryRun)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbFile)!);
                if (options.Fresh)
                {
                    foreach (var suffix in new[] { "", "-wal", "-shm" })
                    {
                        try
                        {
                            File.Delete(dbFile + suffix);
                        }
                        catch (IOException)
                        {
                            // absent or already gone
                        }
                    }

                    DemoLog.Line($"removed {dbFile}");
                }
            }

            var wikipedia = new WikipediaClient(config);
            var articles = await wikipedia.CollectArticlesAsync();
            var selected = articles.Select(article => article.Title).ToHashSet(StringComparer.Ordinal);
            var rootPayload = Payloads.RootPayload(articles, config);

            if (options.DryRun)
            {
                PrintDryRun(config, dbFile, articles, selected, rootPayload);
                return 0;
            }

            DemoLog.Line($"database {config.Db}");
            dossier.RunOrFail(["init"]);

            var serverPort = config.Port;
            var reused = false;

            if (!options.NoServe)
            {
                if (await ServerControl.IsListeningAsync(config.Port))
                {
                    if (options.ReuseServer)
                    {
                        serverPort = config.Port;
                        reused = true;
                        DemoLog.Line($"reusing the server already on port {serverPort} (it may serve a different database)");
                    }
                    else
                    {
                        serverPort = await ServerControl.FreePortAsync(config.Port + 1);
                        DemoLog.Line($"port {config.Port} is busy; serving on {serverPort} instead");
                    }
                }

                if (!reused)
                {
                    server = dossier.SpawnServe(serverPort, exitCode =>
                    {
                        if (!stopping)
                        {
                            DemoLog.Warn($"dossier serve exited ({exitCode}); the UI is no longer available");
                        }
                    });
                }

                await ServerControl.WaitForServerAsync(serverPort);
                if (await ServerControl.GraphStatusAsync(serverPort) == 404)
                {
                    DemoLog.Warn(
                        "this Dossier build does not serve /api/graph; rebuild with `dotnet build -c Release` for the graph view");
                }

                DemoLog.Line($"web UI  http://127.0.0.1:{serverPort}/");
            }

            var tally = new Tally();
            var rootId = Post(dossier, tally, rootPayload, config.RootName);
            if (rootId.Length == 0)
            {
                throw new DemoFailure($"{config.RootName}: post response had no subject id");
            }

            if (!options.NoServe)
            {
                DemoLog.Line($"graph   http://127.0.0.1:{serverPort}/#/graph/{Js.EncodeUriComponent(rootId)}");
                DemoLog.Line("the UI is read-only; refresh the graph page to see new nodes as they land");
            }

            for (var index = 0; index < articles.Count; index++)
            {
                var payload = Payloads.ArticlePayload(articles[index], selected, rootId, config);
                Post(dossier, tally, payload, articles[index].Title);
                if (index < articles.Count - 1)
                {
                    await Task.Delay(Js.Delay(config.IntervalMs));
                }
            }

            DemoLog.Line(
                $"done: {tally.CreatedSubjects} subject(s) created, {tally.NewFacts} fact(s) new " +
                $"({tally.Deduped} deduped, {tally.Replaced} replaced), {tally.Refs} ref(s) posted");
            DemoLog.Line($"next: dossier check --subject \"{config.RootName}\"");
            DemoLog.Line($"      dossier dossier compile --subject \"{config.RootName}\" --depth full --format markdown");

            var shouldHold = !options.NoServe && !options.ExitAfter && (options.Hold || !Console.IsInputRedirected);
            if (shouldHold)
            {
                DemoLog.Line(
                    reused
                        ? $"open http://127.0.0.1:{serverPort}/; Ctrl-C stops this demo (the reused server keeps running)"
                        : $"serving on http://127.0.0.1:{serverPort}/; press Ctrl-C to stop");
                await Task.Delay(Timeout.Infinite);
            }

            StopServer();
            return 0;
        }
        catch (DemoFailure failure)
        {
            DemoLog.Error(failure.Message);
            StopServer();
            return 2;
        }
        catch (Exception failure)
        {
            DemoLog.Error(failure.Message);
            StopServer();
            return 2;
        }
        finally
        {
            sigint?.Dispose();
            sigterm?.Dispose();
        }
    }

    private static void PrintDryRun(
        DemoConfig config,
        string dbFile,
        IReadOnlyList<Article> articles,
        HashSet<string> selected,
        JsonObject rootPayload)
    {
        var articleRows = new JsonArray();
        foreach (var article in articles)
        {
            articleRows.Add(new JsonObject
            {
                ["title"] = article.Title,
                ["links"] = article.Links.Count,
                ["paragraphs"] = Payloads.ParagraphsOf(article.Extract).Count,
            });
        }

        var plan = new JsonObject
        {
            ["config"] = new JsonObject
            {
                ["db"] = dbFile,
                ["port"] = config.Port,
                ["lang"] = config.Lang,
                ["maxSubjects"] = config.MaxSubjects,
                ["factsPerSubject"] = config.FactsPerSubject,
                ["refsPerSubject"] = config.RefsPerSubject,
                ["intervalMs"] = config.IntervalMs,
                ["apiDelayMs"] = config.ApiDelayMs,
                ["rootName"] = config.RootName,
                ["seeds"] = new JsonArray(config.Seeds.Select(seed => (JsonNode)seed).ToArray()),
            },
            ["root"] = new JsonObject
            {
                ["subject"] = rootPayload["subject"]!.DeepClone(),
                ["facts"] = rootPayload["facts"]!.AsArray().Count,
            },
            ["articles"] = articleRows,
            ["sample"] = new JsonObject
            {
                ["root"] = rootPayload.DeepClone(),
                ["article"] = articles.Count > 0
                    ? Payloads.ArticlePayload(articles[0], selected, null, config)
                    : null,
            },
        };

        Console.Out.Write(plan.ToJsonString(IndentedJson) + "\n");
        Console.Out.Write($"planned posts: 1 root + {articles.Count} articles; wrote nothing\n");
    }

    private static string Post(DossierCli dossier, Tally tally, JsonObject payload, string label)
    {
        var (stdout, stderr) = dossier.RunOrFail(["post", "--file", "-"], payload.ToJsonString(LineJson));
        if (stderr.Trim().Length > 0)
        {
            DemoLog.Warn($"{label}: {stderr.Trim()}");
        }

        if (JsonNode.Parse(stdout) is not JsonObject response)
        {
            throw new DemoFailure($"{label}: post returned invalid JSON");
        }

        var subject = response["subject"] as JsonObject;
        var created = subject?["created"]?.GetValue<bool>() == true;
        var subjectId = subject?["id"]?.GetValue<string>() ?? string.Empty;

        tally.CreatedSubjects += created ? 1 : 0;
        foreach (var fact in payload["facts"]!.AsArray())
        {
            tally.Refs += fact?["refs"] is JsonArray refs ? refs.Count : 0;
        }

        var statusCounts = new List<(string Status, int Count)>();
        if (response["facts"] is JsonArray facts)
        {
            foreach (var fact in facts.OfType<JsonObject>())
            {
                var status = fact["status"]?.GetValue<string>() ?? "unknown";
                switch (status)
                {
                    case "new": tally.NewFacts += 1; break;
                    case "deduped": tally.Deduped += 1; break;
                    case "replaced": tally.Replaced += 1; break;
                }

                var slot = statusCounts.FindIndex(entry => entry.Status == status);
                if (slot >= 0)
                {
                    statusCounts[slot] = (status, statusCounts[slot].Count + 1);
                }
                else
                {
                    statusCounts.Add((status, 1));
                }
            }
        }

        DemoLog.Line(
            $"{label}: subject {(created ? "created" : "existing")}, " +
            string.Join(", ", statusCounts.Select(entry => $"{entry.Count} {entry.Status}")));

        return subjectId;
    }

    private sealed class Tally
    {
        public int CreatedSubjects { get; set; }
        public int Refs { get; set; }
        public int NewFacts { get; set; }
        public int Deduped { get; set; }
        public int Replaced { get; set; }
    }

    private static class Native
    {
        public const int Sigterm = 15;

        [DllImport("libc", EntryPoint = "kill", SetLastError = true)]
        public static extern int SendSignal(int pid, int signal);
    }
}
