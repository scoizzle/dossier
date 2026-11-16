using System.Globalization;

namespace Dossier.WikipediaDemo;

/// <summary>Parsed command line plus the resolved, validated demo configuration.</summary>
internal sealed class DemoOptions
{
    private static readonly string[] Flags = ["help", "dry-run", "no-serve", "exit-after", "hold", "reuse-server", "fresh"];
    private static readonly string[] DefaultSeeds = ["Apollo 11", "Apollo program", "Saturn V", "NASA"];

    private readonly Dictionary<string, string> _values = new(StringComparer.Ordinal);

    public bool Help { get; private set; }
    public bool DryRun { get; private set; }
    public bool NoServe { get; private set; }
    public bool ExitAfter { get; private set; }
    public bool Hold { get; private set; }
    public bool ReuseServer { get; private set; }
    public bool Fresh { get; private set; }
    public List<string> SeedValues { get; } = [];

    public static string HelpText =>
        """
        usage: Dossier.WikipediaDemo [options]
               dotnet run --project tools/Dossier.WikipediaDemo -- [options]

        Fetches Wikipedia articles and posts them as Dossier subjects, facts and refs,
        paced so the graph grows while you watch.

          --seed <title>            seed article (repeatable or comma separated)
                                    default: "Apollo 11,Apollo program,Saturn V,NASA"
          --max-subjects <n>        articles to post, seeds included (default 10)
          --facts-per-subject <n>   paragraph facts per article (default 4)
          --refs-per-subject <n>    "mentions" refs per article (default 8)
          --interval <seconds>      pause between subjects (default 2.5)
          --api-delay <seconds>     pause between Wikipedia calls (default 0.25)
          --lang <code>             Wikipedia language (default en)
          --root <name>             demo root subject name (default "Wikipedia Demo")
          --db <path>               database (default $DOSSIER_DB or ./dossier-demo.db)
          --fresh                   delete that database first (demo databases only)
          --port <port>             serve port (default 8787; a free one is chosen if busy)
          --reuse-server            use whatever is already on --port instead of starting one
          --no-serve                post without starting the web UI
          --exit-after              stop the server and exit when posting finishes
          --hold                    keep serving until Ctrl-C (default on a TTY)
          --dry-run                 fetch and print the planned posts, write nothing
          --bin <path>              dossier executable (default: detected build, or $DOSSIER_BIN)
          --help                    this text

        Environment: DOSSIER_BIN (executable), DOSSIER_DLL (Dossier.dll), DOSSIER_DB.

        """;

    public static DemoOptions Parse(string[] args)
    {
        var options = new DemoOptions();
        for (var i = 0; i < args.Length; i++)
        {
            var token = args[i];
            if (!token.StartsWith("--", StringComparison.Ordinal))
            {
                throw new DemoFailure($"unexpected argument \"{token}\" (see --help)");
            }

            var key = token[2..];
            if (Flags.Contains(key, StringComparer.Ordinal))
            {
                options.SetFlag(key);
                continue;
            }

            string? value = null;
            if (i + 1 < args.Length)
            {
                value = args[++i];
            }

            if (value is null || value.StartsWith("--", StringComparison.Ordinal))
            {
                throw new DemoFailure($"--{key} needs a value");
            }

            if (key == "seed")
            {
                options.SeedValues.Add(value);
            }
            else
            {
                options._values[key] = value;
            }
        }

        return options;
    }

    private void SetFlag(string key)
    {
        switch (key)
        {
            case "help": Help = true; break;
            case "dry-run": DryRun = true; break;
            case "no-serve": NoServe = true; break;
            case "exit-after": ExitAfter = true; break;
            case "hold": Hold = true; break;
            case "reuse-server": ReuseServer = true; break;
            case "fresh": Fresh = true; break;
        }
    }

    private string? Value(string key) => _values.GetValueOrDefault(key);

    private int Integer(string name, int fallback, int min, int? max = null)
    {
        var raw = Value(name);
        if (raw is null)
        {
            return fallback;
        }

        var valid = double.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed) &&
                    double.IsFinite(parsed) &&
                    Math.Floor(parsed) == parsed &&
                    parsed >= min &&
                    (max is null || parsed <= max);
        if (!valid)
        {
            throw new DemoFailure($"--{name} must be an integer between {min}{(max is null ? "" : $" and {max}")}");
        }

        return (int)parsed;
    }

    private double Seconds(string name, double fallback)
    {
        var raw = Value(name);
        if (raw is null)
        {
            return fallback;
        }

        if (!double.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) ||
            !double.IsFinite(value) ||
            value < 0)
        {
            throw new DemoFailure($"--{name} must be a non-negative number of seconds");
        }

        return value;
    }

    /// <summary>The resolved configuration, with the same defaults and validation order as the script.</summary>
    public DemoConfig BuildConfig()
    {
        var seeds = (SeedValues.Count > 0 ? SeedValues : DefaultSeeds.ToList())
            .SelectMany(value => value.Split(','))
            .Select(value => value.Trim())
            .Where(value => value.Length > 0)
            .ToList();

        var config = new DemoConfig(
            Db: Value("db") ?? Environment.GetEnvironmentVariable("DOSSIER_DB") ?? "./dossier-demo.db",
            Port: Integer("port", 8787, 1, 65535),
            Lang: Value("lang") ?? "en",
            MaxSubjects: Integer("max-subjects", 10, 1),
            FactsPerSubject: Integer("facts-per-subject", 4, 0),
            RefsPerSubject: Integer("refs-per-subject", 8, 0),
            IntervalMs: Seconds("interval", 2.5) * 1000,
            ApiDelayMs: Seconds("api-delay", 0.25) * 1000,
            RootName: Value("root") ?? "Wikipedia Demo",
            Seeds: seeds);

        if (config.Seeds.Count == 0)
        {
            throw new DemoFailure("at least one --seed is required");
        }

        if (string.IsNullOrWhiteSpace(config.RootName))
        {
            throw new DemoFailure("--root must not be empty");
        }

        if (config.Db == ":memory:")
        {
            throw new DemoFailure("each command runs in its own process; use a file database, not :memory:");
        }

        if (Fresh && (config.Db.EndsWith("/dossier.db", StringComparison.Ordinal) ||
                      config.Db.EndsWith("\\dossier.db", StringComparison.Ordinal)))
        {
            throw new DemoFailure("--fresh refuses to delete ./dossier.db; pass a demo database with --db");
        }

        return config;
    }

    public string? Bin => Value("bin");
}

/// <summary>Everything the demo needs after the command line is validated.</summary>
internal sealed record DemoConfig(
    string Db,
    int Port,
    string Lang,
    int MaxSubjects,
    int FactsPerSubject,
    int RefsPerSubject,
    double IntervalMs,
    double ApiDelayMs,
    string RootName,
    IReadOnlyList<string> Seeds);
