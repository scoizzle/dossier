using System.Text.Json;
using Dossier;

const string usage = "usage: dossier <init|dump --source <path> --subject <name>|post --file <path>|correlate [--subject]|search [--q|--subject|--tag|--kind|--status|--ref-target|--direction|--limit ...]|show <factId>|retract <id>|dossier compile --subject ...|publish --out <dir> [--subject --budget --depth --facts --assets --index-max-tokens]|import --from <dir> [--db <path>]>";

if (args.Length == 0)
{
    Console.Error.WriteLine(usage);
    return 1;
}

try
{
    switch (args[0])
    {
        case "init":
            _ = new DossierStore();
            return 0;

        case "post":
        {
            var file = ValueAfter(args, "--file");
            if (file is null)
            {
                Console.Error.WriteLine("post requires --file <path>");
                return 1;
            }

            var json = file == "-" ? Console.In.ReadToEnd() : File.ReadAllText(file);
            var request = JsonSerializer.Deserialize<PostFactsRequest>(json, JsonCodec.Options);
            if (request is null)
            {
                Console.Error.WriteLine("invalid post_facts request");
                return 1;
            }

            var store = new DossierStore();
            var result = store.PostFacts(request);
            Console.WriteLine(JsonSerializer.Serialize(result.Response, JsonCodec.Options));
            foreach (var error in result.Errors)
            {
                Console.Error.WriteLine(JsonSerializer.Serialize(error, JsonCodec.Options));
            }

            return 0;
        }

        case "dump":
        {
            var source = ValueAfter(args, "--source");
            var subject = ValueAfter(args, "--subject");
            if (source is null || subject is null)
            {
                Console.Error.WriteLine("dump requires --source <path> and --subject <name>");
                return 1;
            }

            var dumpRequest = new DumpRequest
            {
                Source = source,
                Subject = subject,
                Kind = ValueAfter(args, "--kind"),
                Split = ValueAfter(args, "--split"),
                EntitySubjects = args.Contains("--entity-subjects") ? true : null,
                Tags = ValuesAfter(args, "--tag"),
            };

            var dumpResponse = new DossierStore().Dump(dumpRequest);
            Console.WriteLine(JsonSerializer.Serialize(dumpResponse, JsonCodec.Options));
            return 0;
        }

        case "correlate":
        {
            var correlateRequest = new CorrelateRequest
            {
                Subject = ValueAfter(args, "--subject"),
                Matchers = ValuesAfter(args, "--matcher"),
            };

            var correlateResponse = new DossierStore().Correlate(correlateRequest);
            Console.WriteLine(JsonSerializer.Serialize(correlateResponse, JsonCodec.Options));
            return 0;
        }

        case "retract":
        {
            if (args.Length < 2)
            {
                Console.Error.WriteLine("retract requires <id>");
                return 1;
            }

            var store = new DossierStore();
            var result = store.Retract(args[1]);
            if (!result.Found)
            {
                Console.Error.WriteLine($"fact not found: {args[1]}");
                return 1;
            }

            Console.WriteLine(JsonSerializer.Serialize(new { id = result.Id, status = "retracted" }, JsonCodec.Options));
            return 0;
        }

        case "search":
        {
            var request = new SearchRequest
            {
                Q = ValueAfter(args, "--q"),
                Subject = ValueAfter(args, "--subject"),
                Kind = ValueAfter(args, "--kind"),
                Key = ValueAfter(args, "--key"),
                Tag = ValueAfter(args, "--tag"),
                Actor = ValueAfter(args, "--actor"),
                Status = ValueAfter(args, "--status"),
                Since = ValueAfter(args, "--since"),
                RefTarget = ValueAfter(args, "--ref-target"),
                Direction = ValueAfter(args, "--direction"),
                Cursor = ValueAfter(args, "--cursor"),
                Limit = ParseLimit(ValueAfter(args, "--limit")),
            };

            var store = new DossierStore();
            var response = store.Search(request);
            Console.WriteLine(JsonSerializer.Serialize(response, JsonCodec.Options));
            return 0;
        }

        case "show":
        {
            if (args.Length < 2)
            {
                Console.Error.WriteLine("show requires <factId>");
                return 1;
            }

            var store = new DossierStore();
            var show = store.Show(args[1]);
            if (show is null)
            {
                Console.Error.WriteLine($"fact not found: {args[1]}");
                return 1;
            }

            Console.WriteLine(JsonSerializer.Serialize(show, JsonCodec.Options));
            return 0;
        }

        case "dossier":
        {
            if (args.Length < 2 || args[1] != "compile")
            {
                Console.Error.WriteLine("usage: dossier dossier compile --subject <s> [--budget n] [--depth index|full] [--format json|markdown] [--need text]... [--descendants] [--order rank|seq] [--recency 0..1]");
                return 1;
            }

            var subject = ValueAfter(args, "--subject");
            if (subject is null)
            {
                Console.Error.WriteLine("compile requires --subject <subject>");
                return 1;
            }

            var format = ValueAfter(args, "--format") ?? "json";
            if (format is not ("json" or "markdown"))
            {
                Console.Error.WriteLine($"--format must be json or markdown, got \"{format}\"");
                return 1;
            }

            var compileRequest = new CompileRequest
            {
                Subject = subject,
                Budget = ParseInt(ValueAfter(args, "--budget"), "--budget"),
                Depth = ValueAfter(args, "--depth"),
                Format = format,
                Order = ValueAfter(args, "--order"),
                Needs = ValuesAfter(args, "--need"),
                Descendants = args.Contains("--descendants") ? true : null,
                Rank = ValueAfter(args, "--recency") is { } recency
                    ? new RankOptions { Recency = double.Parse(recency, System.Globalization.CultureInfo.InvariantCulture) }
                    : null,
            };

            var dossier = new DossierStore().Compile(compileRequest);
            Console.Error.WriteLine("token estimator: chars/4");
            Console.Error.WriteLine($"used_tokens: {dossier.UsedTokens}");
            Console.WriteLine(format == "markdown"
                ? DossierStore.RenderMarkdown(dossier).TrimEnd('\n')
                : JsonSerializer.Serialize(dossier, JsonCodec.Options));
            return 0;
        }

        case "publish":
        {
            var outDir = ValueAfter(args, "--out");
            if (outDir is null)
            {
                Console.Error.WriteLine("usage: dossier publish --out <dir> [--subject <s>] [--budget n] [--depth index|full] [--facts detail|none] [--assets detail|none] [--index-max-tokens n]");
                return 1;
            }

            var publishOptions = new PublishOptions
            {
                Out = outDir,
                Subject = ValueAfter(args, "--subject"),
                Budget = ParseInt(ValueAfter(args, "--budget"), "--budget") ?? DossierStore.DefaultBudgetTokens,
                Depth = ValueAfter(args, "--depth") ?? "full",
                Facts = ValueAfter(args, "--facts") ?? "detail",
                Assets = ValueAfter(args, "--assets") ?? "detail",
                IndexMaxTokens = ParseInt(ValueAfter(args, "--index-max-tokens"), "--index-max-tokens") ?? DossierStore.DefaultIndexMaxTokens,
                CommandLine = "dossier " + string.Join(' ', args.Select(a => a.Length > 0 && a.All(c => !char.IsWhiteSpace(c) && c != '\'') ? a : "'" + a.Replace("'", "'\\''") + "'")),
            };

            var published = new DossierStore().Publish(publishOptions);
            foreach (var warning in published.Warnings)
            {
                Console.Error.WriteLine(warning);
            }

            Console.WriteLine(JsonSerializer.Serialize(
                new { published.Out, files = published.Files.Count, published.Written, published.Subjects, published.Facts, published.Removed },
                JsonCodec.Options));
            return 0;
        }

        case "import":
        {
            var from = ValueAfter(args, "--from");
            if (from is null)
            {
                Console.Error.WriteLine("usage: dossier import --from <bundle dir> [--db <path>]  (the bundle must have been published with --facts detail)");
                return 1;
            }

            var imported = new DossierStore(ValueAfter(args, "--db")).Import(new ImportOptions { From = from });
            Console.WriteLine(JsonSerializer.Serialize(
                new
                {
                    imported.Subjects,
                    imported.Facts,
                    imported.Refs,
                    imported.Attachments,
                    imported.Blobs,
                    imported.Skipped,
                },
                JsonCodec.Options));
            return 0;
        }

        case "mcp":
        {
            // stdout carries protocol messages only.
            new McpServer(new DossierStore()).Run(Console.In, Console.Out);
            return 0;
        }

        case "serve":
        {
            var port = ParseInt(ValueAfter(args, "--port"), "--port") ?? 8787;
            using var server = new WebServer(new DossierStore(), port);
            server.Start();
            Console.Error.WriteLine($"listening on http://127.0.0.1:{port}/");
            using var stop = new ManualResetEventSlim();
            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true;
                stop.Set();
            };
            stop.Wait();
            return 0;
        }

        default:
            Console.Error.WriteLine(usage);
            return 1;
    }
}
catch (Exception exception)
{
    Console.Error.WriteLine(exception.Message);
    return 1;
}

static string? ValueAfter(string[] arguments, string flag)
{
    for (var i = 1; i < arguments.Length - 1; i++)
    {
        if (arguments[i] == flag)
        {
            return arguments[i + 1];
        }
    }

    return null;
}

static List<string> ValuesAfter(string[] arguments, string flag)
{
    var values = new List<string>();
    for (var i = 1; i < arguments.Length - 1; i++)
    {
        if (arguments[i] == flag)
        {
            values.Add(arguments[i + 1]);
        }
    }

    return values;
}

static int? ParseInt(string? value, string flag)
{
    if (value is null)
    {
        return null;
    }

    if (!int.TryParse(value, out var number))
    {
        throw new ArgumentException($"{flag} must be an integer, got \"{value}\"");
    }

    return number;
}

static int? ParseLimit(string? value)
{
    if (value is null)
    {
        return null;
    }

    if (!int.TryParse(value, out var limit))
    {
        throw new ArgumentException($"--limit must be an integer, got \"{value}\"");
    }

    return limit;
}
