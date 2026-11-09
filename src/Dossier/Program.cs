using System.Text.Json;
using Dossier;

const string usage = "usage: dossier <init|post --file <path>|search [--q|--subject|--tag|--kind|--status|--ref-target|--direction|--limit ...]|show <factId>|retract <id>>";

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
