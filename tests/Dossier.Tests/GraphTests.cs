using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class GraphTests
{
    private const string FixtureEnv = "DOSSIER_UPDATE_FIXTURES";

    private static GraphRequest Request(string? subject = GraphSeed.Root, int? depth = null, bool? facts = null, int? maxNodes = null) =>
        new() { Subject = subject, Depth = depth, Facts = facts, MaxNodes = maxNodes };

    private static JsonElement Graph(DossierStore store, GraphRequest request) =>
        JsonDocument.Parse(Ops.Graph(store, request)).RootElement.Clone();

    private static List<string> Ids(JsonElement graph, string list) =>
        graph.GetProperty(list).EnumerateArray().Select(n => n.GetProperty("id").GetString()!).ToList();

    private static List<JsonElement> Edges(JsonElement graph, string kind) =>
        graph.GetProperty("edges").EnumerateArray().Where(e => e.GetProperty("kind").GetString() == kind).ToList();

    private static int Nodes(JsonElement graph) => graph.GetProperty("subjects").GetArrayLength() + graph.GetProperty("facts").GetArrayLength();

    private static (TempDb Db, DossierStore Store) Seeded(bool reverse = false)
    {
        var db = new TempDb();
        GraphSeed.Populate(db.Store, reverse);
        return (db, db.Store);
    }

    private static string RepoFile(params string[] parts)
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "Dossier.sln")))
        {
            directory = directory.Parent;
        }

        return Path.Combine([directory?.FullName ?? throw new InvalidOperationException("Dossier.sln not found above the test binaries"), .. parts]);
    }

    [Test]
    public async Task Graph_ShapeAndDefaults()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request());

        await Assert.That(g.GetProperty("format").GetInt32()).IsEqualTo(1);
        await Assert.That(g.GetProperty("root").GetString()).IsEqualTo("s-root");
        await Assert.That(g.GetProperty("seed").GetString()!.Length).IsEqualTo(8);
        await Assert.That(g.GetProperty("limits").GetProperty("max_nodes").GetInt32()).IsEqualTo(500);
        await Assert.That(g.GetProperty("limits").GetProperty("depth").GetInt32()).IsEqualTo(1);

        // Root, then hop 1 in ordinal id order (children and ref-reached together), then the boundary subject.
        await Assert.That(string.Join(",", Ids(g, "subjects"))).IsEqualTo("s-root,s-core,s-other,s-sh1,s-sh2,s-web,s-far");
        await Assert.That(string.Join(",", Ids(g, "facts"))).IsEqualTo("f-root-1,f-root-2,f-core-1,f-core-2,f-other-1,f-web-1");

        var contains = Edges(g, "contains").Select(e => e.GetProperty("from").GetString() + ">" + e.GetProperty("to").GetString()).ToList();
        await Assert.That(string.Join(",", contains)).IsEqualTo("s-root>s-core,s-root>s-web");

        var factEdge = Edges(g, "fact").Single();
        await Assert.That(factEdge.GetProperty("from").GetString()).IsEqualTo("f-root-1");
        await Assert.That(factEdge.GetProperty("to").GetString()).IsEqualTo("f-core-1");
        await Assert.That(factEdge.GetProperty("rel").GetString()).IsEqualTo("supports");
        await Assert.That(factEdge.GetProperty("basis").GetString()).IsEqualTo("derived");
        await Assert.That(factEdge.GetProperty("to_kind").GetString()).IsEqualTo("fact");
    }

    [Test]
    public async Task Graph_DepthControlsTheNeighbourhood()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;

        var zero = Graph(store, Request(depth: 0));
        await Assert.That(string.Join(",", Ids(zero, "subjects"))).IsEqualTo("s-root");
        await Assert.That(zero.GetProperty("truncated").GetProperty("edges").GetInt32()).IsGreaterThan(0);

        var one = Graph(store, Request(depth: 1));
        await Assert.That(Ids(one, "subjects").Contains("s-lib")).IsFalse();

        var two = Graph(store, Request(depth: 2));
        await Assert.That(Ids(two, "subjects").Contains("s-lib")).IsTrue();
        await Assert.That(Ids(two, "facts").Contains("f-lib-1")).IsTrue();
        // The hidden ref of depth 1 (f-web-1 to f-lib-1) is an edge at depth 2.
        await Assert.That(Edges(two, "fact").Any(e => e.GetProperty("from").GetString() == "f-web-1" && e.GetProperty("to").GetString() == "f-lib-1")).IsTrue();
        await Assert.That(Edges(one, "fact").Any(e => e.GetProperty("from").GetString() == "f-web-1")).IsFalse();
        await Assert.That(one.GetProperty("unresolved").EnumerateArray().Any(u => u.GetProperty("target").GetString() == "f-lib-1" && u.GetProperty("reason").GetString() == "not_admitted")).IsTrue();
        await Assert.That(one.GetProperty("truncated").GetProperty("edges").GetInt32()).IsEqualTo(1);
    }

    [Test]
    public async Task Graph_FactsToggle()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request(facts: false));

        await Assert.That(g.GetProperty("facts").GetArrayLength()).IsEqualTo(0);
        await Assert.That(g.GetProperty("edges").EnumerateArray().All(e => e.GetProperty("kind").GetString() == "contains")).IsTrue();
        await Assert.That(string.Join(",", Ids(g, "subjects"))).IsEqualTo("s-root,s-core,s-web");
    }

    [Test]
    public async Task Graph_MaxNodesIsExactAndDeterministic()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var full = Graph(store, Request(maxNodes: 500));
        var total = Nodes(full);
        await Assert.That(total).IsEqualTo(13);

        for (var max = 1; max <= total + 2; max++)
        {
            var g = Graph(store, Request(maxNodes: max));
            await Assert.That(Nodes(g)).IsEqualTo(Math.Min(max, total));
            await Assert.That(Ops.Graph(store, Request(maxNodes: max))).IsEqualTo(Ops.Graph(store, Request(maxNodes: max)));
            // Every edge endpoint is a node.
            var present = Ids(g, "subjects").Select(i => "subject:" + i).Concat(Ids(g, "facts").Select(i => "fact:" + i)).ToHashSet();
            foreach (var e in g.GetProperty("edges").EnumerateArray())
            {
                await Assert.That(present.Contains(e.GetProperty("from_kind").GetString() + ":" + e.GetProperty("from").GetString())).IsTrue();
                await Assert.That(present.Contains(e.GetProperty("to_kind").GetString() + ":" + e.GetProperty("to").GetString())).IsTrue();
            }
        }

        var tight = Graph(store, Request(maxNodes: 4));
        await Assert.That(string.Join(",", Ids(tight, "subjects"))).IsEqualTo("s-root,s-core,s-other,s-sh1");
        await Assert.That(tight.GetProperty("facts").GetArrayLength()).IsEqualTo(0);
        await Assert.That(tight.GetProperty("truncated").GetProperty("subjects").GetInt32()).IsGreaterThan(0);

        // Same content inserted in the opposite order gives the same bytes.
        var (db2, store2) = Seeded(reverse: true);
        using var keepAlive2 = db2;
        foreach (var max in new[] { 3, 5, 9, 500 })
        {
            await Assert.That(Ops.Graph(store2, Request(maxNodes: max))).IsEqualTo(Ops.Graph(store, Request(maxNodes: max)));
        }
    }

    [Test]
    public async Task Graph_ParentChainIsClampedByTheCap()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;

        var wide = Graph(store, Request("s-lib", depth: 0, facts: false));
        await Assert.That(string.Join(",", Ids(wide, "subjects"))).IsEqualTo("s-lib,s-core,s-root");

        var clamped = Graph(store, Request("s-lib", depth: 0, facts: false, maxNodes: 2));
        await Assert.That(string.Join(",", Ids(clamped, "subjects"))).IsEqualTo("s-lib,s-core");
        await Assert.That(clamped.GetProperty("truncated").GetProperty("subjects").GetInt32()).IsEqualTo(1);
    }

    [Test]
    public async Task Graph_BoundarySubjectsAreAdmittedLastAndMarked()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request());

        var far = g.GetProperty("subjects").EnumerateArray().Single(s => s.GetProperty("id").GetString() == "s-far");
        await Assert.That(far.GetProperty("boundary").GetBoolean()).IsTrue();
        await Assert.That(g.GetProperty("subjects").EnumerateArray().Count(s => s.TryGetProperty("boundary", out _))).IsEqualTo(1);
        await Assert.That(Ids(g, "subjects").Last()).IsEqualTo("s-far");

        var inbound = Edges(g, "inbound").Select(e => e.GetProperty("from").GetString() + ">" + e.GetProperty("to").GetString() + ":" + e.GetProperty("rel").GetString()).ToList();
        await Assert.That(string.Join(",", inbound)).IsEqualTo("f-core-1>s-far:confirms,f-core-2>s-far:mentions");

        // The cap counts boundary subjects: one node short and it is hidden instead.
        var capped = Graph(store, Request(maxNodes: 12));
        await Assert.That(Ids(capped, "subjects").Contains("s-far")).IsFalse();
        await Assert.That(Nodes(capped)).IsEqualTo(12);
        await Assert.That(capped.GetProperty("truncated").GetProperty("subjects").GetInt32()).IsEqualTo(1);
    }

    [Test]
    public async Task Graph_SlotRefsPointAtTheCurrentOccupantOrFallBackToTheOwner()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request());

        var slots = Edges(g, "slot");
        var occupied = slots.Single(e => e.GetProperty("slot").GetString() == "owner");
        await Assert.That(occupied.GetProperty("from").GetString()).IsEqualTo("f-root-1");
        await Assert.That(occupied.GetProperty("to_kind").GetString()).IsEqualTo("fact");
        await Assert.That(occupied.GetProperty("to").GetString()).IsEqualTo("f-core-2");

        var empty = slots.Single(e => e.GetProperty("slot").GetString() == "empty");
        await Assert.That(empty.GetProperty("to_kind").GetString()).IsEqualTo("subject");
        await Assert.That(empty.GetProperty("to").GetString()).IsEqualTo("s-web");
    }

    [Test]
    public async Task Graph_AmbiguousNameLinksEveryMatch()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request());

        var shared = Edges(g, "subject").Where(e => e.GetProperty("rel").GetString() == "mentions").ToList();
        await Assert.That(string.Join(",", shared.Select(e => e.GetProperty("to").GetString()))).IsEqualTo("s-sh1,s-sh2");
        await Assert.That(shared.All(e => e.GetProperty("ambiguous").GetBoolean())).IsTrue();

        var other = Edges(g, "subject").Single(e => e.GetProperty("rel").GetString() == "about");
        await Assert.That(other.GetProperty("to").GetString()).IsEqualTo("s-other");
        await Assert.That(other.TryGetProperty("ambiguous", out _)).IsFalse();
    }

    [Test]
    public async Task Graph_ExternalRefsStayOnTheFactAndUnknownTargetsAreReported()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var g = Graph(store, Request());

        var fact = g.GetProperty("facts").EnumerateArray().Single(f => f.GetProperty("id").GetString() == "f-root-1");
        var external = fact.GetProperty("unresolved").EnumerateArray().Single();
        await Assert.That(external.GetProperty("kind").GetString()).IsEqualTo("symbol");
        await Assert.That(external.GetProperty("target").GetString()).IsEqualTo(GraphSeed.ExternalSymbol);
        await Assert.That(Ops.Graph(store, Request()).Contains("\"id\":\"" + GraphSeed.ExternalSymbol)).IsFalse();

        var ghost = g.GetProperty("unresolved").EnumerateArray().Single(u => u.GetProperty("target").GetString() == "f-ghost");
        await Assert.That(ghost.GetProperty("reason").GetString()).IsEqualTo("not_found");
    }

    [Test]
    public async Task Graph_ResolvesTheRootByNameAndAlias()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        await Assert.That(Graph(store, Request("Acme")).GetProperty("root").GetString()).IsEqualTo("s-root");
        await Assert.That(Graph(store, Request("  acme   docs ")).GetProperty("root").GetString()).IsEqualTo("s-root");
        await Assert.That(Graph(store, Request("Shared")).GetProperty("root").GetString()).IsEqualTo("s-sh1");
    }

    [Test]
    public async Task Graph_WithoutASubjectIsTheSubjectTree()
    {
        using var db = new TempDb();
        GraphSeed.PopulateTree(db.Store, 300);
        var g = Graph(db.Store, Request(subject: null, facts: true, maxNodes: 100));

        await Assert.That(g.GetProperty("root").ValueKind).IsEqualTo(JsonValueKind.Null);
        await Assert.That(g.GetProperty("subjects").GetArrayLength()).IsEqualTo(100);
        await Assert.That(g.GetProperty("facts").GetArrayLength()).IsEqualTo(0);
        await Assert.That(g.GetProperty("edges").EnumerateArray().All(e => e.GetProperty("kind").GetString() == "contains")).IsTrue();
        await Assert.That(g.GetProperty("truncated").GetProperty("subjects").GetInt32()).IsEqualTo(200);
        // Level order: the 20 roots come first.
        await Assert.That(Ids(g, "subjects").Take(20).All(id => int.Parse(id[2..]) < 20)).IsTrue();
        await Assert.That(Ops.Graph(db.Store, Request(subject: null, maxNodes: 100))).IsEqualTo(Ops.Graph(db.Store, Request(subject: null, maxNodes: 100)));
    }

    [Test]
    public async Task Graph_SeedDependsOnlyOnTheRequestParameters()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var seed = Graph(store, Request()).GetProperty("seed").GetString();
        await Assert.That(Graph(store, Request("Acme")).GetProperty("seed").GetString()).IsEqualTo(seed);

        // Content changes (a new fact) do not reshuffle; a different request does.
        store.PostFacts(Fixtures.Post("Acme", Fixtures.Fact("late fact")));
        await Assert.That(Graph(store, Request()).GetProperty("seed").GetString()).IsEqualTo(seed);
        await Assert.That(Graph(store, Request(depth: 2)).GetProperty("seed").GetString()).IsNotEqualTo(seed);
        await Assert.That(Graph(store, Request(maxNodes: 50)).GetProperty("seed").GetString()).IsNotEqualTo(seed);
        await Assert.That(Graph(store, Request(facts: false)).GetProperty("seed").GetString()).IsNotEqualTo(seed);
        await Assert.That(Graph(store, Request("s-core")).GetProperty("seed").GetString()).IsNotEqualTo(seed);
    }

    [Test]
    public async Task Graph_RejectsBadParametersWithNamedCodes()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;

        async Task Expect(Func<string> call, string code)
        {
            var thrown = Assert.Throws<DossierRequestException>(() => call());
            await Assert.That(thrown.Code).IsEqualTo(code);
        }

        await Expect(() => Ops.Graph(store, Request(depth: 4)), "bad_depth");
        await Expect(() => Ops.Graph(store, Request(depth: -1)), "bad_depth");
        await Expect(() => Ops.Graph(store, Request(maxNodes: 0)), "bad_max_nodes");
        await Expect(() => Ops.Graph(store, Request(maxNodes: 2001)), "bad_max_nodes");
        await Expect(() => Ops.Graph(store, Request("nobody")), "subject_not_found");
        await Expect(() => Ops.Graph(store, GraphRequest.FromQuery(null, "x", null, null)), "bad_depth");
        await Expect(() => Ops.Graph(store, GraphRequest.FromQuery(null, "-1", null, null)), "bad_depth");
        await Expect(() => Ops.Graph(store, GraphRequest.FromQuery(null, "99999999999", null, null)), "bad_depth");
        await Expect(() => Ops.Graph(store, GraphRequest.FromQuery(null, null, "maybe", null)), "bad_facts");
        await Expect(() => Ops.Graph(store, GraphRequest.FromQuery(null, null, null, "lots")), "bad_max_nodes");
        await Assert.That(Graph(store, GraphRequest.FromQuery("s-root", "2", "0", "7")).GetProperty("limits").GetProperty("max_nodes").GetInt32()).IsEqualTo(7);
    }

    /// <summary>
    /// Keeps tests/Dossier.Tests/fixtures/graph-api.json honest: it must equal the API output for the seeded
    /// store byte for byte. scripts/graph-smoke.mjs renders this exact file. To regenerate after an intended
    /// change: DOSSIER_UPDATE_FIXTURES=1 dotnet test --solution Dossier.sln -c Release --treenode-filter "/*/*/GraphTests/Graph_FixtureMatchesTheApi"
    /// </summary>
    [Test]
    public async Task Graph_FixtureMatchesTheApi()
    {
        var (db, store) = Seeded();
        using var keepAlive = db;
        var actual = Ops.Graph(store, Request(depth: 2));
        var path = RepoFile("tests", "Dossier.Tests", "fixtures", "graph-api.json");
        if (Environment.GetEnvironmentVariable(FixtureEnv) == "1")
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            await File.WriteAllTextAsync(path, actual, new System.Text.UTF8Encoding(false));
        }

        await Assert.That(await File.ReadAllTextAsync(path)).IsEqualTo(actual);
    }
}
