// Stub: three verbs, no logic yet.
const string usage = "usage: dossier <dump|correlate|retrieve> [args]";

if (args.Length == 0)
{
    Console.Error.WriteLine(usage);
    return 1;
}

switch (args[0])
{
    case "dump":      // placeholder
    case "correlate": // placeholder
    case "retrieve":  // placeholder
    default:
        Console.Error.WriteLine(usage);
        return 1;
}
