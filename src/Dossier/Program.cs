using System.Text.Json;
using Dossier;

const string usage = "usage: dossier <init|post --file <path>|retract <id>>";

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
