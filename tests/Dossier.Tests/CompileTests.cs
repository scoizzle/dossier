using System.Diagnostics;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class CompileTests
{
    private static void Exec(TempDb db, string sql, params (string Name, object? Value)[] parameters)
    {
        using var connection = db.Store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = sql;
        foreach (var (name, value) in parameters)
        {
            command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }

        command.ExecuteNonQuery();
        SqliteConnection.ClearAllPools();
    }

    private static string At(int minutes) => new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero).AddMinutes(minutes).ToString("O");

    private static void SetCreated(TempDb db, string id, int minutes) =>
        Exec(db, "UPDATE facts SET created_at = $c WHERE id = $id", ("$c", At(minutes)), ("$id", id));

    private static CompileRequest Full(string subject = "Widget", int? budget = null) =>
        new() { Subject = subject, Depth = "full", Budget = budget };

    private static List<string> Post(TempDb db, string subject, params FactInput[] facts) =>
        db.Store.PostFacts(Fixtures.Post(subject, facts)).Response.Facts.Select(f => f.Id).ToList();

    [Test]
    public async Task Compile_IsDeterministic()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("alpha beta gamma delta epsilon"),
            Fixtures.Fact("zeta eta theta iota kappa"),
            Fixtures.Fact("lambda mu nu xi omicron"));
        for (var i = 0; i < ids.Count; i++)
        {
            SetCreated(db, ids[i], i);
        }

        var request = Full();
        request.Needs = new List<string> { "alpha", "missing thing" };
        var first = JsonSerializer.Serialize(db.Store.Compile(request), JsonCodec.Options);
        var second = JsonSerializer.Serialize(db.Store.Compile(request), JsonCodec.Options);

        await Assert.That(second).IsEqualTo(first);
    }

    [Test]
    public async Task CandidateSet_ExcludesSupersededAndRetracted()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("live one here"),
            Fixtures.Fact("superseded one here"),
            Fixtures.Fact("retracted one here"),
            Fixtures.Fact("contested one here"),
            Fixtures.Fact("stale one here"));
        Exec(db, "UPDATE facts SET status = 'superseded' WHERE id = $id", ("$id", ids[1]));
        Exec(db, "UPDATE facts SET status = 'retracted' WHERE id = $id", ("$id", ids[2]));
        Exec(db, "UPDATE facts SET status = 'contested' WHERE id = $id", ("$id", ids[3]));
        Exec(db, "UPDATE facts SET status = 'stale' WHERE id = $id", ("$id", ids[4]));

        var emitted = db.Store.Compile(Full()).Facts.Select(f => f.Id).ToHashSet();

        await Assert.That(emitted.SetEquals(new[] { ids[0], ids[3], ids[4] })).IsTrue();
    }

    [Test]
    public async Task CandidateSet_ExcludesDossierKind()
    {
        using var db = new TempDb();
        var ids = Post(db, "Widget", Fixtures.Fact("a normal fact"), Fixtures.Fact("a compiled dossier fact"));
        Exec(db, "UPDATE facts SET kind = 'dossier' WHERE id = $id", ("$id", ids[1]));

        var emitted = db.Store.Compile(Full()).Facts.Select(f => f.Id).ToList();

        await Assert.That(emitted.Count).IsEqualTo(1);
        await Assert.That(emitted[0]).IsEqualTo(ids[0]);
    }

    [Test]
    public async Task Descendants_IncludesChildFactsToDepth3()
    {
        using var db = new TempDb();
        var rootFacts = db.Store.PostFacts(Fixtures.Post("Root", Fixtures.Fact("root fact text")));
        var chain = new List<string> { rootFacts.Response.Subject.Id };
        var factIds = new List<string> { rootFacts.Response.Facts[0].Id };
        for (var level = 1; level <= 4; level++)
        {
            var posted = db.Store.PostFacts(new PostFactsRequest
            {
                Subject = new SubjectInput { Name = $"Level{level}", Parent = chain[^1] },
                Facts = new List<FactInput> { Fixtures.Fact($"level {level} fact text") },
            });
            chain.Add(posted.Response.Subject.Id);
            factIds.Add(posted.Response.Facts[0].Id);
        }

        var without = db.Store.Compile(Full("Root")).Facts.Select(f => f.Id).ToList();
        var request = Full("Root");
        request.Descendants = true;
        var with = db.Store.Compile(request).Facts.Select(f => f.Id).ToHashSet();

        await Assert.That(without.Count).IsEqualTo(1);
        await Assert.That(with.SetEquals(factIds.Take(4))).IsTrue();
        await Assert.That(with.Contains(factIds[4])).IsFalse();
    }

    [Test]
    public async Task Ranking_ConfidenceAndCentralityOrderFacts()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("plain fact number one"),
            Fixtures.Fact("plain fact number two"),
            Fixtures.Fact("plain fact number three"));
        SetCreated(db, ids[0], 0);
        SetCreated(db, ids[1], 0);
        SetCreated(db, ids[2], 0);
        Exec(db, "UPDATE facts SET confidence = 0.2 WHERE id = $id", ("$id", ids[0]));
        Exec(db, "UPDATE facts SET confidence = 1.0 WHERE id = $id", ("$id", ids[1]));
        Exec(db, "UPDATE facts SET confidence = 0.2 WHERE id = $id", ("$id", ids[2]));
        // Two inbound refs make ids[2] central; it should beat ids[0] at equal confidence.
        Post(db, "Other", Fixtures.Fact("points at it", refs: new List<RefInput> { Fixtures.Ref(ids[2]) }));
        Post(db, "Other", Fixtures.Fact("also points", refs: new List<RefInput> { Fixtures.Ref(ids[2]) }));

        var order = db.Store.Compile(Full()).Facts.Select(f => f.Id).ToList();

        // ids[2]: 0.2 + 1.0 centrality beats ids[1]: 1.0 confidence beats ids[0]: 0.2.
        await Assert.That(order.SequenceEqual(new[] { ids[2], ids[1], ids[0] })).IsTrue();
    }

    [Test]
    public async Task RecencyWeight_ZeroRemovesRecencyEffect()
    {
        using var db = new TempDb();
        var ids = Post(db, "Widget", Fixtures.Fact("older fact with text"), Fixtures.Fact("newer fact with text"));
        SetCreated(db, ids[0], 0);
        SetCreated(db, ids[1], 100);
        Exec(db, "UPDATE facts SET confidence = 0.8 WHERE id = $id", ("$id", ids[0]));
        Exec(db, "UPDATE facts SET confidence = 0.75 WHERE id = $id", ("$id", ids[1]));

        var zero = Full();
        zero.Rank = new RankOptions { Recency = 0 };
        var heavy = Full();
        heavy.Rank = new RankOptions { Recency = 1 };

        var zeroOrder = db.Store.Compile(zero).Facts.Select(f => f.Id).ToList();
        var heavyOrder = db.Store.Compile(heavy).Facts.Select(f => f.Id).ToList();

        await Assert.That(zeroOrder[0]).IsEqualTo(ids[0]);
        await Assert.That(heavyOrder[0]).IsEqualTo(ids[1]);
    }

    [Test]
    public async Task Dedupe_ClustersAtJaccardThresholdAndKeepsCites()
    {
        using var db = new TempDb();
        // 20 shared tokens vs 17 of them: Jaccard 17/20 = 0.85 exactly, so it clusters.
        var shared = string.Join(' ', Enumerable.Range(1, 17).Select(i => $"w{i}"));
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact(shared + " x1 x2 x3"),
            Fixtures.Fact(shared),
            Fixtures.Fact(shared + " y1 y2 y3 y4 y5 y6"),
            Fixtures.Fact("one two three"),
            Fixtures.Fact("three two one"));
        Exec(db, "UPDATE facts SET confidence = 0.5 WHERE id = $id", ("$id", ids[0]));
        Exec(db, "UPDATE facts SET confidence = 0.5 WHERE id = $id", ("$id", ids[2]));

        var dossier = db.Store.Compile(Full());
        var head = dossier.Facts.Single(f => f.Id == ids[1]);

        // ids[0] (17/20 = 0.85) collapses into ids[1]; ids[2] (17/23) does not.
        await Assert.That(head.Cites![0]).IsEqualTo(ids[1]);
        await Assert.That(head.Cites!.Skip(1).SequenceEqual(new[] { ids[0] })).IsTrue();
        await Assert.That(dossier.Facts.Any(f => f.Id == ids[0])).IsFalse();
        await Assert.That(dossier.Facts.Any(f => f.Id == ids[2])).IsTrue();
        // Short facts (<4 tokens) are never clustered, even when identical.
        await Assert.That(dossier.Facts.Count(f => f.Text is "one two three" or "three two one")).IsEqualTo(2);
    }

    [Test]
    public async Task Budget_DropsOverflowAndRecordsIds()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("alpha one with some more words " + new string('a', 60)),
            Fixtures.Fact("bravo two with some more words " + new string('b', 60)),
            Fixtures.Fact("charlie three with some more words " + new string('c', 60)));
        for (var i = 0; i < 3; i++)
        {
            Exec(db, "UPDATE facts SET confidence = $c WHERE id = $id", ("$c", 0.9 - (i * 0.1)), ("$id", ids[i]));
            SetCreated(db, ids[i], 0);
        }

        var everything = db.Store.Compile(Full(budget: 10000));
        var perFact = everything.UsedTokens / 3;
        var tight = db.Store.Compile(Full(budget: (int)Math.Ceiling((perFact * 2 + 2) / 0.75)));

        await Assert.That(everything.Dropped.Count).IsEqualTo(0);
        await Assert.That(tight.Facts.Count).IsEqualTo(2);
        await Assert.That(tight.Facts.Select(f => f.Id).SequenceEqual(new[] { ids[0], ids[1] })).IsTrue();
        await Assert.That(tight.Dropped.SequenceEqual(new[] { ids[2] })).IsTrue();
    }

    [Test]
    public async Task Packing_SkipsOversizedCandidateAndEmitsLaterSmallerOnes()
    {
        using var db = new TempDb();
        var oversized = "oversized " + string.Join(' ', Enumerable.Range(0, 120).Select(i => $"blob{i}"));
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact(oversized),
            Fixtures.Fact("small one alpha beta"),
            Fixtures.Fact("small two gamma delta"));
        Exec(db, "UPDATE facts SET confidence = 0.95 WHERE id = $id", ("$id", ids[0]));
        Exec(db, "UPDATE facts SET confidence = 0.90 WHERE id = $id", ("$id", ids[1]));
        Exec(db, "UPDATE facts SET confidence = 0.85 WHERE id = $id", ("$id", ids[2]));
        for (var i = 0; i < 3; i++)
        {
            SetCreated(db, ids[i], 0);
        }

        // Rank order is the oversized fact, then the two small ones.
        var everything = db.Store.Compile(Full(budget: 1_000_000));
        await Assert.That(everything.Facts.Select(f => f.Id).SequenceEqual(ids)).IsTrue();
        var cost = everything.Facts.ToDictionary(
            f => f.Id,
            f => DossierStore.EstimateTokens(JsonSerializer.Serialize(f, JsonCodec.Options)));
        var slice = cost[ids[1]] + cost[ids[2]];
        await Assert.That(cost[ids[0]] > slice).IsTrue();

        var tight = db.Store.Compile(Full(budget: (int)Math.Ceiling(slice / 0.75)));

        // The large fact was skipped, not fatal: both later small facts are emitted in rank order.
        await Assert.That(tight.Facts.Select(f => f.Id).SequenceEqual(new[] { ids[1], ids[2] })).IsTrue();
        await Assert.That(tight.Dropped.SequenceEqual(new[] { ids[0] })).IsTrue();
    }

    [Test]
    public async Task Packing_StopsWhenRemainingBudgetCannotFitSmallestCandidate()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("alpha bravo charlie delta"),
            Fixtures.Fact("echo foxtrot golf hotel"),
            Fixtures.Fact("india juliet kilo lima"),
            Fixtures.Fact("mike november oscar papa"),
            Fixtures.Fact("quebec romeo sierra tango"));
        for (var i = 0; i < ids.Count; i++)
        {
            Exec(db, "UPDATE facts SET confidence = 0.5 WHERE id = $id", ("$id", ids[i]));
            SetCreated(db, ids[i], 0);
        }

        var everything = db.Store.Compile(Full(budget: 1_000_000));
        var rankIds = everything.Facts.Select(f => f.Id).ToList();
        await Assert.That(rankIds.Count).IsEqualTo(5);
        var costs = everything.Facts
            .Select(f => DossierStore.EstimateTokens(JsonSerializer.Serialize(f, JsonCodec.Options)))
            .ToList();
        var slice = costs[0] + costs[1];

        var tight = db.Store.Compile(Full(budget: (int)Math.Ceiling(slice / 0.75)));

        await Assert.That(tight.Facts.Select(f => f.Id).SequenceEqual(rankIds.Take(2))).IsTrue();
        await Assert.That(tight.Facts.Count).IsEqualTo(2);
        await Assert.That(tight.Dropped.Count).IsEqualTo(3);
    }

    [Test]
    public async Task Packing_DroppedHasNoDuplicatesAndIsRankOrdered()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(1, 6)
            .Select(i => Fixtures.Fact($"pack{i} alpha{i} bravo{i} charlie{i}"))
            .ToArray();
        var ids = Post(db, "Widget", facts);
        for (var i = 0; i < ids.Count; i++)
        {
            Exec(db, "UPDATE facts SET confidence = $c WHERE id = $id", ("$c", 0.9 - (i * 0.1)), ("$id", ids[i]));
            SetCreated(db, ids[i], 0);
        }

        var everything = db.Store.Compile(Full(budget: 1_000_000));
        var rankIds = everything.Facts.Select(f => f.Id).ToList();
        await Assert.That(rankIds.Count).IsEqualTo(6);
        var costs = everything.Facts
            .Select(f => DossierStore.EstimateTokens(JsonSerializer.Serialize(f, JsonCodec.Options)))
            .ToList();
        var slice = costs[0] + costs[1];

        var tight = db.Store.Compile(Full(budget: (int)Math.Ceiling(slice / 0.75)));

        await Assert.That(tight.Dropped.Count).IsGreaterThan(0);
        await Assert.That(tight.Dropped.Distinct(StringComparer.Ordinal).Count()).IsEqualTo(tight.Dropped.Count);
        var expected = rankIds.Where(id => tight.Dropped.Contains(id)).ToList();
        await Assert.That(tight.Dropped.SequenceEqual(expected)).IsTrue();
    }

    [Test]
    public async Task Conflicts_ExemptFromBudgetAndExceedSlice()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("first config", data: Fixtures.Json("""{"a":1,"b":1,"c":1,"d":1}""")),
            Fixtures.Fact("second config", data: Fixtures.Json("""{"a":2,"b":2,"c":2,"d":2}""")));

        var dossier = db.Store.Compile(Full(budget: 20));

        await Assert.That(dossier.Conflicts.Count).IsEqualTo(4);
        await Assert.That(dossier.UsedTokens).IsGreaterThan(dossier.BudgetTokens);
        await Assert.That(dossier.SelfCheck.ConflictsSurfaced).IsEqualTo(4);
        await Assert.That(dossier.Facts.Count).IsEqualTo(0);
        await Assert.That(dossier.Dropped.Count).IsEqualTo(ids.Count);
    }

    [Test]
    public async Task Conflict_FromSamePathDifferentValues()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("first", data: Fixtures.Json("""{"cfg":{"port":80,"host":"x"}}""")),
            Fixtures.Fact("second", data: Fixtures.Json("""{"cfg":{"port":81,"host":"x"}}""")));

        var dossier = db.Store.Compile(Full());
        var conflict = dossier.Conflicts.Single();
        var json = JsonSerializer.Serialize(dossier, JsonCodec.Options);

        await Assert.That(conflict.Field).IsEqualTo("cfg.port");
        await Assert.That(conflict.Values.Select(v => v.Fact).SequenceEqual(ids.OrderBy(i => i, StringComparer.Ordinal))).IsTrue();
        await Assert.That(conflict.Resolution).IsNull();
        await Assert.That(json.Contains("\"resolution\":null")).IsTrue();
    }

    [Test]
    public async Task Gap_EmittedForUnmetNeed()
    {
        using var db = new TempDb();
        Post(db, "Widget", Fixtures.Fact("the widget renders charts"));

        var request = Full();
        request.Needs = new List<string> { "deployment pipeline" };
        var dossier = db.Store.Compile(request);

        await Assert.That(dossier.Gaps.Count).IsEqualTo(1);
        await Assert.That(dossier.Gaps[0].Need).IsEqualTo("deployment pipeline");
        await Assert.That(dossier.Gaps[0].Reason).IsEqualTo("no fact");
    }

    [Test]
    public async Task Need_CoveredByTokensInTextOrTags()
    {
        using var db = new TempDb();
        Post(
            db,
            "Widget",
            Fixtures.Fact("the widget renders charts", tags: new List<string> { "frontend" }));

        var request = Full();
        request.Needs = new List<string> { "Renders the CHARTS", "frontend", "backend" };
        var dossier = db.Store.Compile(request);

        await Assert.That(dossier.Gaps.Select(g => g.Need).SequenceEqual(new[] { "backend" })).IsTrue();
    }

    [Test]
    public async Task IndexDepth_Under300Tokens()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(1, 20)
            .Select(i => Fixtures.Fact($"fact {i} " + string.Join(' ', Enumerable.Range(0, 60).Select(w => $"word{i}x{w}"))))
            .ToArray();
        Post(db, "Widget", facts);

        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget" });
        var estimate = DossierStore.EstimateTokens(JsonSerializer.Serialize(dossier, JsonCodec.Options));

        await Assert.That(dossier.Depth).IsEqualTo("index");
        await Assert.That(estimate).IsLessThanOrEqualTo(300);
        await Assert.That(dossier.Facts.Count).IsLessThanOrEqualTo(8);
        await Assert.That(dossier.Facts.Count).IsGreaterThan(0);
        await Assert.That(dossier.Facts.All(f => f.Text.Length <= 120)).IsTrue();
            }

    [Test]
    public async Task Budget_IsMeasuredInRenderedForm()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(1, 20)
            .Select(i => Fixtures.Fact($"rendered cost probe {i} " + string.Join(' ', Enumerable.Range(0, 8).Select(w => $"tok{i}x{w}"))))
            .ToArray();
        Post(db, "Widget", facts);

        var json = Full(budget: 1200);
        json.Format = "json";
        var markdown = Full(budget: 1200);
        markdown.Format = "markdown";

        var jsonDossier = db.Store.Compile(json);
        var markdownDossier = db.Store.Compile(markdown);

        // Same store and budget: markdown lines cost less than serialized FactViews, so more fit.
        await Assert.That(markdownDossier.Facts.Count).IsGreaterThan(jsonDossier.Facts.Count);
        await Assert.That(markdownDossier.UsedTokens).IsLessThan(jsonDossier.UsedTokens);
    }

    [Test]
    public async Task Markdown_StaysWithinBudget()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(1, 12)
            .Select(i => Fixtures.Fact($"budget probe {i} " + string.Join(' ', Enumerable.Range(0, 10).Select(w => $"word{i}x{w}"))))
            .ToArray();
        Post(db, "Widget", facts);

        var budget = 200;
        var request = Full(budget: budget);
        request.Format = "markdown";
        var dossier = db.Store.Compile(request);

        var factTokens = dossier.Facts.Sum(f => DossierStore.EstimateFactTokens(f, "markdown"));
        await Assert.That(factTokens).IsLessThanOrEqualTo((int)Math.Floor(budget * 0.75));
        await Assert.That(dossier.UsedTokens).IsLessThanOrEqualTo(budget);

        // Conflicts are exempt from the fact slice: when they alone exceed the budget the dossier
        // may overrun it, but every conflict is still surfaced and the facts still fit the slice.
        using var conflictedDb = new TempDb();
        Post(
            conflictedDb,
            "Widget",
            Fixtures.Fact("first config", data: Fixtures.Json("""{"a":1,"b":1,"c":1,"d":1}""")),
            Fixtures.Fact("second config", data: Fixtures.Json("""{"a":2,"b":2,"c":2,"d":2}""")));

        var conflictedRequest = Full(budget: 20);
        conflictedRequest.Format = "markdown";
        var conflicted = conflictedDb.Store.Compile(conflictedRequest);

        var conflictedFactTokens = conflicted.Facts.Sum(f => DossierStore.EstimateFactTokens(f, "markdown"));
        await Assert.That(conflicted.Conflicts.Count).IsEqualTo(4);
        await Assert.That(conflicted.SelfCheck.ConflictsSurfaced).IsEqualTo(4);
        await Assert.That(conflictedFactTokens).IsLessThanOrEqualTo((int)Math.Floor(20 * 0.75));
        await Assert.That(conflicted.UsedTokens).IsGreaterThan(conflicted.BudgetTokens);
    }

    [Test]
    public async Task IndexDepth_UsesRenderedCost()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(1, 20)
            .Select(i => Fixtures.Fact($"fact {i} " + string.Join(' ', Enumerable.Range(0, 60).Select(w => $"word{i}x{w}"))))
            .ToArray();
        Post(db, "Widget", facts);

        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget", Format = "markdown" });
        var rendered = DossierStore.RenderMarkdown(dossier);

        await Assert.That(dossier.Depth).IsEqualTo("index");
        await Assert.That(DossierStore.EstimateTokens(rendered)).IsLessThanOrEqualTo(300);
        await Assert.That(DossierStore.EstimateRenderedTokens(dossier, "markdown")).IsLessThanOrEqualTo(300);
        await Assert.That(dossier.Facts.Count).IsGreaterThan(0);
    }

    [Test]
    public async Task SeqOrder_IsChronological()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("first by confidence text"),
            Fixtures.Fact("second by confidence text"),
            Fixtures.Fact("third by confidence text"));
        SetCreated(db, ids[0], 30);
        SetCreated(db, ids[1], 10);
        SetCreated(db, ids[2], 20);
        Exec(db, "UPDATE facts SET confidence = 1.0 WHERE id = $id", ("$id", ids[0]));
        Exec(db, "UPDATE facts SET confidence = 0.1 WHERE id = $id", ("$id", ids[1]));

        var request = Full();
        request.Order = "seq";
        var order = db.Store.Compile(request).Facts.Select(f => f.Id).ToList();

        await Assert.That(order.SequenceEqual(new[] { ids[1], ids[2], ids[0] })).IsTrue();
    }

    [Test]
    public async Task UncitedClaims_IsZero()
    {
        using var db = new TempDb();
        Post(db, "Widget", Fixtures.Fact("some fact here"), Fixtures.Fact("another fact there"));

        var dossier = db.Store.Compile(Full());

        await Assert.That(dossier.Facts.Count).IsEqualTo(2);
        await Assert.That(dossier.Facts.All(f => f.Cites is { Count: > 0 } && f.Cites[0] == f.Id)).IsTrue();
        await Assert.That(dossier.SelfCheck.UncitedClaims).IsEqualTo(0);
    }

    [Test]
    public async Task Markdown_ContainsEveryFactId()
    {
        using var db = new TempDb();
        Post(
            db,
            "Widget",
            Fixtures.Fact("renders charts", data: Fixtures.Json("""{"v":1}""")),
            Fixtures.Fact("draws graphs", data: Fixtures.Json("""{"v":2}""")),
            Fixtures.Fact("third distinct statement"));

        var request = Full();
        request.Needs = new List<string> { "nonexistent topic" };
        var dossier = db.Store.Compile(request);
        var markdown = DossierStore.RenderMarkdown(dossier);

        await Assert.That(markdown.StartsWith("# Widget")).IsTrue();
        foreach (var fact in dossier.Facts)
        {
            await Assert.That(markdown.Contains($"[{fact.Id}]")).IsTrue();
        }

        await Assert.That(markdown.Contains("## Conflicts")).IsTrue();
        await Assert.That(markdown.Contains("## Gaps")).IsTrue();
    }

    [Test]
    public async Task Relevance_Bm25RanksMatchingNeedFirst()
    {
        using var db = new TempDb();
        // Three facts with disjoint token sets (Jaccard 0, no clustering) and no refs, so only the
        // bm25 relevance term can separate the fact that carries the need tokens.
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("deployment pipeline runs nightly builds"),
            Fixtures.Fact("widget renders charts quickly"),
            Fixtures.Fact("database stores user records"));
        // Make the relevant fact the oldest: without relevance it ranks last on recency, so the
        // bm25 term alone can move it to position 1 (deterministic, unlike a GUID tie-break).
        SetCreated(db, ids[0], 0);
        SetCreated(db, ids[1], 50);
        SetCreated(db, ids[2], 100);

        var withoutNeeds = db.Store.Compile(Full()).Facts.Select(f => f.Id).ToList();
        await Assert.That(withoutNeeds.SequenceEqual(new[] { ids[2], ids[1], ids[0] })).IsTrue();

        var request = Full();
        request.Needs = new List<string> { "deployment pipeline" };
        var dossier = db.Store.Compile(request);
        var order = dossier.Facts.Select(f => f.Id).ToList();

        await Assert.That(order.Count).IsEqualTo(3);
        // Position 1 in the score-ordered facts array is the only fact whose tokens match the need.
        await Assert.That(order[0]).IsEqualTo(ids[0]);
        await Assert.That(dossier.Facts[0].Text.Contains("deployment pipeline")).IsTrue();
    }

    [Test]
    public async Task Relevance_AbsentWhenNoRelevance()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            "Widget",
            Fixtures.Fact("alpha beta gamma delta"),
            Fixtures.Fact("zeta eta theta iota"),
            Fixtures.Fact("kappa lambda mu nu"));
        SetCreated(db, ids[0], 0);
        SetCreated(db, ids[1], 50);
        SetCreated(db, ids[2], 100);
        foreach (var id in ids)
        {
            Exec(db, "UPDATE facts SET confidence = 0.5 WHERE id = $id", ("$id", id));
        }

        // Empty needs: bm25 has no terms, so relevance is 0 and the other four terms decide.
        // With equal confidence, equal explicitness, no inbound refs, and the default recency
        // weight, only recency differs, so the newest fact ranks first and the oldest last.
        var none = Full();
        none.Needs = new List<string>();
        var ranked = db.Store.Compile(none).Facts.Select(f => f.Id).ToList();
        await Assert.That(ranked.SequenceEqual(new[] { ids[2], ids[1], ids[0] })).IsTrue();

        // Control: same store, empty needs, recency weight 0 and all confidences equal. Every
        // remaining term is then an identical constant, so any residual bm25 ordering would show
        // up here; instead the result is the pure id tie-break, proving relevance is exactly 0.
        var flat = Full();
        flat.Needs = new List<string>();
        flat.Rank = new RankOptions { Recency = 0 };
        var flattened = db.Store.Compile(flat).Facts.Select(f => f.Id).ToList();
        var idOrder = ids.OrderBy(id => id, StringComparer.Ordinal).ToList();
        await Assert.That(flattened.SequenceEqual(idOrder)).IsTrue();
    }

    [Test]
    public async Task Descendants_CycleInParentsDoesNotHang()
    {
        using var db = new TempDb();
        var a = db.Store.PostFacts(Fixtures.Post("CycleA", Fixtures.Fact("cycle alpha fact")));
        var b = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "CycleB", Parent = a.Response.Subject.Id },
            Facts = new List<FactInput> { Fixtures.Fact("cycle bravo fact") },
        });

        // Close the loop: A's parent becomes B, so A -> B -> A.
        Exec(
            db,
            "UPDATE subjects SET parent_id = $parent WHERE id = $id",
            ("$parent", b.Response.Subject.Id),
            ("$id", a.Response.Subject.Id));

        var request = Full("CycleA");
        request.Descendants = true;
        var stopwatch = Stopwatch.StartNew();
        var dossier = db.Store.Compile(request);
        stopwatch.Stop();

        await Assert.That(stopwatch.Elapsed < TimeSpan.FromSeconds(5)).IsTrue();
        await Assert.That(dossier.Facts.Count).IsEqualTo(2);
        await Assert.That(dossier.Subject.Id).IsEqualTo(a.Response.Subject.Id);
    }
}
