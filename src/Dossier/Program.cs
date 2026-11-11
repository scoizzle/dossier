using Dossier;

const string usage = "usage: dossier <init|version|dump --source <path> --subject <name>|post --file <path> [--dry-run]|correlate [--subject <name>] [--matcher <name>]...|check --subject <text> [--drafts <file|->] [--limit <n>]|search [--brief|--q|--subject|--tag|--kind|--status|--ref-target|--direction|--limit ...]|show <factId>|retract <id>|dossier compile --subject ...|publish --out <dir> [--format md|jsonl] [--subject --budget --budget-mode --depth --facts --assets --index-max-tokens --max-files --max-file-bytes --max-total-bytes --profile --respect-limits]|import --from <dir> [--db <path>]|mcp|serve>";

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

        case "version":
        case "--version":
            Console.Out.Write(AppVersion.Current + "\n");
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
            var request = JsonCodec.Deserialize<PostFactsRequest>(json);
            if (request is null)
            {
                Console.Error.WriteLine("invalid post_facts request");
                return 1;
            }

            if (args.Contains("--dry-run"))
            {
                request.DryRun = true;
            }

            var store = new DossierStore();
            var result = store.PostFacts(request);
            Console.WriteLine(JsonCodec.Serialize(result.Response));
            foreach (var error in result.Errors)
            {
                Console.Error.WriteLine(JsonCodec.Serialize(error));
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
                Tags = ValuesAfter(args, "--tag"),
            };

            var dumpResponse = new DossierStore().Dump(dumpRequest);
            Console.WriteLine(JsonCodec.Serialize(dumpResponse));
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
            Console.WriteLine(JsonCodec.Serialize(correlateResponse));
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

            Console.WriteLine(JsonCodec.Serialize(new RetractedOutput(result.Id, "retracted")));
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
                Brief = args.Contains("--brief"),
            };

            var store = new DossierStore();
            Console.WriteLine(Ops.Search(store, request));
            return 0;
        }

        case "check":
        {
            var subject = ValueAfter(args, "--subject");
            if (subject is null)
            {
                Console.Error.WriteLine("check requires --subject <text>");
                return 1;
            }

            var draftsPath = ValueAfter(args, "--drafts");
            var checkRequest = new CheckRequest
            {
                Subject = subject,
                Limit = ParseLimit(ValueAfter(args, "--limit")),
                Drafts = draftsPath is null
                    ? null
                    : DossierStore.ParseDrafts(draftsPath == "-" ? Console.In.ReadToEnd() : File.ReadAllText(draftsPath)),
            };
            Console.WriteLine(Ops.Check(new DossierStore(), checkRequest));
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

            Console.WriteLine(JsonCodec.Serialize(show));
            return 0;
        }

        case "dossier":
        {
            if (args.Length < 2 || args[1] != "compile")
            {
                Console.Error.WriteLine("usage: dossier dossier compile --subject <s> [--budget n] [--budget-mode complete|strict] [--depth index|full] [--format json|markdown] [--need text]... [--descendants] [--order rank|seq] [--recency 0..1]");
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
                BudgetMode = ValueAfter(args, "--budget-mode"),
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
                : JsonCodec.Serialize(dossier));
            return 0;
        }

        case "publish":
        {
            var outDir = ValueAfter(args, "--out");
            if (outDir is null)
            {
                Console.Error.WriteLine("usage: dossier publish --out <dir> [--format md|jsonl] [--subject <s>] [--budget n] [--budget-mode complete|strict] [--depth index|full] [--facts detail|none] [--assets detail|none (md) | embed|files|none (jsonl)] [--index-max-tokens n] [--max-files n] [--max-file-bytes n] [--max-total-bytes n] [--profile <path>] [--respect-limits]  (--max-* are jsonl only; --budget, --budget-mode, --depth, --facts and --index-max-tokens are md only)");
                return 1;
            }

            var format = ValueAfter(args, "--format") ?? "md";
            if (format is not ("md" or "jsonl"))
            {
                Console.Error.WriteLine($"--format must be md|jsonl, got \"{format}\"");
                return 1;
            }

            var jsonlFormat = format == "jsonl";
            bool Passed(string flag) => args.Skip(1).Contains(flag);
            foreach (var flag in new[] { "--budget", "--budget-mode", "--depth", "--facts", "--index-max-tokens" })
            {
                if (jsonlFormat && Passed(flag))
                {
                    Console.Error.WriteLine($"{flag} is a markdown-only option and cannot be used with --format jsonl");
                    return 1;
                }
            }

            foreach (var flag in new[] { "--max-files", "--max-file-bytes", "--max-total-bytes" })
            {
                if (!jsonlFormat && Passed(flag))
                {
                    Console.Error.WriteLine($"{flag} requires --format jsonl");
                    return 1;
                }
            }

            var assets = ValueAfter(args, "--assets") ?? (jsonlFormat ? "files" : "detail");
            if (jsonlFormat ? assets is not ("embed" or "files" or "none") : assets is not ("detail" or "none"))
            {
                Console.Error.WriteLine(jsonlFormat
                    ? $"--assets must be embed|files|none with --format jsonl, got \"{assets}\""
                    : $"--assets must be detail|none with --format md, got \"{assets}\"");
                return 1;
            }

            var publishOptions = new PublishOptions
            {
                Out = outDir,
                Format = format,
                Subject = ValueAfter(args, "--subject"),
                Budget = ParseInt(ValueAfter(args, "--budget"), "--budget") ?? DossierStore.DefaultBudgetTokens,
                Depth = ValueAfter(args, "--depth") ?? "full",
                BudgetMode = ValueAfter(args, "--budget-mode") ?? DossierStore.BudgetModeComplete,
                Facts = ValueAfter(args, "--facts") ?? "detail",
                Assets = assets,
                IndexMaxTokens = ParseInt(ValueAfter(args, "--index-max-tokens"), "--index-max-tokens") ?? DossierStore.DefaultIndexMaxTokens,
                MaxFiles = ParseLong(ValueAfter(args, "--max-files"), "--max-files") ?? 0,
                MaxFileBytes = ParseLong(ValueAfter(args, "--max-file-bytes"), "--max-file-bytes") ?? 0,
                MaxTotalBytes = ParseLong(ValueAfter(args, "--max-total-bytes"), "--max-total-bytes") ?? 0,
                ProfilePath = ValueAfter(args, "--profile"),
                RespectLimits = args.Contains("--respect-limits"),
                CommandLine = "dossier " + string.Join(' ', args.Select(a => a.Length > 0 && a.All(c => !char.IsWhiteSpace(c) && c != '\'') ? a : "'" + a.Replace("'", "'\\''") + "'")),
            };

            var published = new DossierStore().Publish(publishOptions);
            foreach (var warning in published.Warnings)
            {
                Console.Error.WriteLine(warning);
            }

            Console.WriteLine(JsonCodec.Serialize(
                new PublishSummary(published.Out, published.Files.Count, published.Written, published.Subjects, published.Facts, published.Removed, jsonlFormat ? "jsonl" : null, jsonlFormat ? published.Assets : null)));
            if (published.Compliance is { } compliance)
            {
                Console.WriteLine(compliance.Render().TrimEnd('\n'));
            }

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
            Console.WriteLine(JsonCodec.Serialize(
                new ImportSummary(imported.Subjects, imported.Facts, imported.Refs, imported.Attachments, imported.Blobs, imported.Skipped)));
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

static long? ParseLong(string? value, string flag)
{
    if (value is null)
    {
        return null;
    }

    if (!long.TryParse(value, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out var number))
    {
        throw new ArgumentException($"{flag} must be a non-negative integer number of bytes or files (plain digits, no K/M suffix; 0 is unlimited), got \"{value}\"");
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
