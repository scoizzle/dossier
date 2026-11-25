using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Derived status where facts are read: search hits, compiled dossiers and show report stale and
/// contested the way verify does, and a status filter means the derived status.
/// </summary>
public sealed class DerivedStatusTests
{
    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    private static List<RefInput> DerivedFrom(params string[] ids) =>
        ids.Select(id => Fixtures.Ref(id, basis: "derived", rel: "derived_from")).ToList();

    private sealed record World(string Input, string Revised, string Stale, string Claim, string Refuter, string Plain);

    /// <summary>One subject holding a stale fact, a contested fact, its refuter and a plain live fact.</summary>
    private static World Seed(TempDb db)
    {
        var input = PostOne(db, "Widget", Fixtures.Fact("orders ship within five days", key: "shipWindow"));
        var stale = PostOne(db, "Widget", Fixtures.Fact("promise delivery within a week", refs: DerivedFrom(input)));
        var revised = PostOne(db, "Widget", Fixtures.Fact("orders ship within two days", key: "shipWindow"));
        var claim = PostOne(db, "Widget", Fixtures.Fact("the save shortcut is cmd enter"));
        var refuter = PostOne(db, "Widget", Fixtures.Fact("cmd enter did nothing on linux", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));
        var plain = PostOne(db, "Widget", Fixtures.Fact("the header shows the workspace name"));
        return new World(input, revised, stale, claim, refuter, plain);
    }

    private static Dictionary<string, string> Statuses(SearchResponse response) => response.Hits.ToDictionary(hit => hit.Id, hit => hit.Status);

    [Test]
    public async Task SearchHits_CarryTheDerivedStatus_AndTheDefaultStillReturnsThem()
    {
        using var db = new TempDb();
        var world = Seed(db);

        var statuses = Statuses(db.Store.Search(new SearchRequest { Subject = "Widget" }));

        await Assert.That(statuses.Count).IsEqualTo(5);
        await Assert.That(statuses[world.Stale]).IsEqualTo("stale");
        await Assert.That(statuses[world.Claim]).IsEqualTo("contested");
        await Assert.That(statuses[world.Refuter]).IsEqualTo("live");
        await Assert.That(statuses[world.Revised]).IsEqualTo("live");
        await Assert.That(statuses[world.Plain]).IsEqualTo("live");
        await Assert.That(statuses.ContainsKey(world.Input)).IsFalse();

        var brief = db.Store.SearchBrief(new SearchRequest { Subject = "Widget", Brief = true });
        await Assert.That(brief.Hits.Single(hit => hit.Id == world.Stale).Status).IsEqualTo("stale");
        await Assert.That(brief.Hits.Single(hit => hit.Id == world.Claim).Status).IsEqualTo("contested");
    }

    [Test]
    public async Task StatusFilter_MeansTheDerivedStatus()
    {
        using var db = new TempDb();
        var world = Seed(db);

        var live = db.Store.Search(new SearchRequest { Subject = "Widget", Status = "live" });
        await Assert.That(live.Total).IsEqualTo(3);
        await Assert.That(live.Hits.Select(hit => hit.Id).ToHashSet().SetEquals(new[] { world.Revised, world.Refuter, world.Plain })).IsTrue();
        await Assert.That(live.Hits.All(hit => hit.Status == "live")).IsTrue();

        var stale = db.Store.Search(new SearchRequest { Status = "stale" });
        await Assert.That(stale.Total).IsEqualTo(1);
        await Assert.That(stale.Hits.Single().Id).IsEqualTo(world.Stale);
        await Assert.That(stale.Hits.Single().Status).IsEqualTo("stale");

        var contested = db.Store.Search(new SearchRequest { Status = "contested" });
        await Assert.That(contested.Total).IsEqualTo(1);
        await Assert.That(contested.Hits.Single().Id).IsEqualTo(world.Claim);

        var superseded = db.Store.Search(new SearchRequest { Status = "superseded" });
        await Assert.That(superseded.Hits.Single().Id).IsEqualTo(world.Input);
        await Assert.That(superseded.Hits.Single().Status).IsEqualTo("superseded");

        // The filter combines with the others, including a text query.
        await Assert.That(db.Store.Search(new SearchRequest { Q = "delivery", Status = "stale" }).Total).IsEqualTo(1);
        await Assert.That(db.Store.Search(new SearchRequest { Q = "delivery", Status = "live" }).Total).IsEqualTo(0);
    }

    [Test]
    public async Task StatusFilter_KeepsTotalsAndPagingHonest()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var staleIds = new List<string>();
        for (var index = 0; index < 5; index++)
        {
            staleIds.Add(PostOne(db, "Widget", Fixtures.Fact($"conclusion number {index}", refs: DerivedFrom(input))));
            PostOne(db, "Widget", Fixtures.Fact($"unrelated live fact {index}"));
        }

        PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));

        var seen = new List<string>();
        string? cursor = null;
        for (var guard = 0; guard < 10; guard++)
        {
            var page = db.Store.Search(new SearchRequest { Status = "stale", Limit = 2, Cursor = cursor });
            await Assert.That(page.Hits.Count).IsLessThanOrEqualTo(2);
            seen.AddRange(page.Hits.Select(hit => hit.Id));
            cursor = page.Next;
            if (cursor is null)
            {
                break;
            }
        }

        await Assert.That(seen.SequenceEqual(staleIds)).IsTrue();
        await Assert.That(db.Store.Search(new SearchRequest { Status = "stale", Limit = 2 }).Total).IsEqualTo(5);
        await Assert.That(db.Store.Search(new SearchRequest { Status = "stale", Limit = 2 }).Complete).IsFalse();
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Widget", Status = "live", Limit = 100 }).Total).IsEqualTo(6);
    }

    [Test]
    public async Task StatusFilter_DerivesOnlyTheCandidatesTheOtherFiltersAdmit()
    {
        using var db = new TempDb();

        // Subject Y carries many facts whose status has to be derived; subject X carries three.
        var yInput = PostOne(db, "Y", Fixtures.Fact("y input", key: "input"));
        db.Store.PostFacts(Fixtures.Post(
            "Y",
            Enumerable.Range(0, 25)
                .Select(index => Fixtures.Fact($"y conclusion {index}", refs: DerivedFrom(yInput)))
                .ToArray()));
        PostOne(db, "Y", Fixtures.Fact("y input revised", key: "input"));

        var xInput = PostOne(db, "X", Fixtures.Fact("x input", key: "input"));
        var xConclusions = Enumerable.Range(0, 3)
            .Select(index => PostOne(db, "X", Fixtures.Fact($"x conclusion {index}", refs: DerivedFrom(xInput))))
            .ToList();
        var xRevised = PostOne(db, "X", Fixtures.Fact("x input revised", key: "input"));

        var derived = new List<string>();
        db.Store.StatusDerivationProbe = ids => derived.AddRange(ids);
        var live = db.Store.Search(new SearchRequest { Subject = "X", Status = "live" });
        db.Store.StatusDerivationProbe = null;

        // The search may only derive the status of rows its subject filter admits, not every fact
        // in the store that carries a currency ref.
        await Assert.That(derived.ToHashSet().SetEquals(xConclusions)).IsTrue();

        // And the filter still answers correctly: the three conclusions are stale, the revised
        // input is the one live fact.
        await Assert.That(live.Total).IsEqualTo(1);
        await Assert.That(live.Hits.Single().Id).IsEqualTo(xRevised);
        await Assert.That(live.Hits.Single().Status).IsEqualTo("live");
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "X", Status = "stale" }).Hits.Select(hit => hit.Id).ToHashSet().SetEquals(xConclusions)).IsTrue();
    }

    [Test]
    public async Task ADataConflict_IsNotAStatus_AndStaysListedWhenAPartyIsContested()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("header is 64 pixels tall", data: Fixtures.Json("{\"headerHeight\":64}")));
        var second = PostOne(db, "Widget", Fixtures.Fact("header is 72 pixels tall", data: Fixtures.Json("{\"headerHeight\":72}")));

        // Disagreeing data alone leaves both facts live; the dossier lists the conflict.
        var statuses = Statuses(db.Store.Search(new SearchRequest { Subject = "Widget" }));
        await Assert.That(statuses[first]).IsEqualTo("live");
        await Assert.That(statuses[second]).IsEqualTo("live");
        await Assert.That(db.Store.Compile(new CompileRequest { Subject = "Widget" }).Conflicts.Count).IsEqualTo(1);

        // A declared dispute makes them contested, and the conflict must not vanish with it.
        var third = PostOne(db, "Widget", Fixtures.Fact("measured it: 72", refs: new List<RefInput> { Fixtures.Ref(first, rel: "refutes") }));
        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget", Depth = "full" });
        await Assert.That(dossier.Facts.Single(fact => fact.Id == first).Status).IsEqualTo("contested");
        await Assert.That(dossier.Facts.Single(fact => fact.Id == third).Status).IsEqualTo("live");
        await Assert.That(dossier.Conflicts.Count).IsEqualTo(1);
        await Assert.That(dossier.Conflicts[0].Values.Select(value => value.Fact).ToHashSet().SetEquals(new[] { first, second })).IsTrue();
        await Assert.That(db.Store.Check(new CheckRequest { Subject = "Widget" }).Summary.Conflicts).IsEqualTo(1);
    }

    [Test]
    public async Task Compile_ReportsStatusAndWhy_AndRanksStaleFactsLast()
    {
        using var db = new TempDb();
        var world = Seed(db);

        // The stale fact matches the need best, so without the tier it would lead the dossier.
        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget", Depth = "full", Needs = new List<string> { "promise delivery week" }, Rank = new RankOptions { Recency = 0 } });

        await Assert.That(dossier.Facts.Count).IsEqualTo(5);
        await Assert.That(dossier.Facts[^1].Id).IsEqualTo(world.Stale);
        var stale = dossier.Facts[^1];
        await Assert.That(stale.Status).IsEqualTo("stale");
        await Assert.That(stale.Why!.Single().Rel).IsEqualTo("derived_from");
        await Assert.That(stale.Why!.Single().Fact).IsEqualTo(world.Input);
        await Assert.That(stale.Why!.Single().State).IsEqualTo("superseded");
        await Assert.That(stale.Why!.Single().ReplacedBy).IsEqualTo(world.Revised);

        var contested = dossier.Facts.Single(fact => fact.Id == world.Claim);
        await Assert.That(contested.Status).IsEqualTo("contested");
        await Assert.That(contested.Why!.Single().Rel).IsEqualTo("refutes");
        await Assert.That(contested.Why!.Single().Fact).IsEqualTo(world.Refuter);

        foreach (var fact in dossier.Facts.Where(fact => fact.Id != world.Stale && fact.Id != world.Claim))
        {
            await Assert.That(fact.Status).IsEqualTo("live");
            await Assert.That(fact.Why).IsNull();
        }
    }

    [Test]
    [Arguments("rank")]
    [Arguments("seq")]
    public async Task StrictBudget_SpendsOnCurrentFactsBeforeStaleOnes(string order)
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var staleIds = new List<string>();
        for (var index = 0; index < 6; index++)
        {
            staleIds.Add(PostOne(db, "Widget", Fixtures.Fact($"budget conclusion number {index} drawn from the old input value", refs: DerivedFrom(input))));
        }

        var liveIds = new List<string>();
        for (var index = 0; index < 6; index++)
        {
            liveIds.Add(PostOne(db, "Widget", Fixtures.Fact($"budget observation number {index} that stands on its own today")));
        }

        PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));

        // The need favours the stale facts; the budget fits only some of the eleven live-or-stale lines.
        var dossier = db.Store.Compile(new CompileRequest
        {
            Subject = "Widget", Depth = "full", BudgetMode = "strict", Budget = 260, Order = order, Format = "markdown",
            Needs = new List<string> { "conclusion drawn old input value" }, Rank = new RankOptions { Recency = 0 },
        });

        var emitted = dossier.Facts.Select(fact => fact.Id).ToList();
        await Assert.That(emitted.Count).IsGreaterThan(0);
        await Assert.That(dossier.Dropped.Count).IsGreaterThan(0);

        // No stale fact is emitted while a current one is dropped.
        var droppedLive = dossier.Dropped.Count(id => liveIds.Contains(id));
        var emittedStale = emitted.Count(id => staleIds.Contains(id));
        await Assert.That(droppedLive == 0 || emittedStale == 0).IsTrue();
        await Assert.That(emitted.Count(id => liveIds.Contains(id))).IsGreaterThan(0);
    }

    [Test]
    public async Task Markdown_MarksStaleAndContestedLines_AndTheTokenEstimateCountsTheMark()
    {
        using var db = new TempDb();
        var world = Seed(db);

        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget", Depth = "full", Format = "markdown" });
        var markdown = DossierStore.RenderMarkdown(dossier);
        var lines = markdown.Split('\n');

        var staleLine = lines.Single(line => line.Contains("[" + world.Stale + "]", StringComparison.Ordinal));
        await Assert.That(staleLine).Contains("stale:");
        await Assert.That(staleLine).Contains(world.Input);
        await Assert.That(staleLine).Contains(world.Revised);
        var contestedLine = lines.Single(line => line.Contains("[" + world.Claim + "]", StringComparison.Ordinal));
        await Assert.That(contestedLine).Contains("contested:");
        await Assert.That(contestedLine).Contains(world.Refuter);
        var plainLine = lines.Single(line => line.Contains("[" + world.Plain + "]", StringComparison.Ordinal));
        await Assert.That(plainLine).IsEqualTo("- the header shows the workspace name [" + world.Plain + "]");

        // Only an emitted fact's own id is in brackets, so a bracketed id is always a citation.
        var bracketed = System.Text.RegularExpressions.Regex.Matches(markdown, @"\[([0-9a-f-]{36})\]").Select(match => match.Groups[1].Value).ToHashSet();
        await Assert.That(bracketed.SetEquals(dossier.Facts.Select(fact => fact.Id))).IsTrue();

        // used_tokens is the sum of the rendered fact lines, marks included.
        var expected = dossier.Facts.Sum(fact => DossierStore.EstimateFactTokens(fact, "markdown"));
        await Assert.That(dossier.UsedTokens).IsEqualTo(expected);
        var staleView = dossier.Facts.Single(fact => fact.Id == world.Stale);
        await Assert.That(DossierStore.EstimateFactTokens(staleView, "markdown")).IsEqualTo(DossierStore.EstimateTokens(staleLine + "\n"));
    }

    [Test]
    public async Task Show_ReportsTheDerivedStatusWithItsReason()
    {
        using var db = new TempDb();
        var world = Seed(db);

        var stale = db.Store.Show(world.Stale)!;
        await Assert.That(stale.Fact.Status).IsEqualTo("stale");
        await Assert.That(stale.Fact.Why!.Single().Fact).IsEqualTo(world.Input);
        await Assert.That(stale.Fact.ReplacedBy).IsNull();

        var old = db.Store.Show(world.Input)!;
        await Assert.That(old.Fact.Status).IsEqualTo("superseded");
        await Assert.That(old.Fact.ReplacedBy).IsEqualTo(world.Revised);
        await Assert.That(old.Fact.Why).IsNull();

        var contested = db.Store.Show(world.Claim)!;
        await Assert.That(contested.Fact.Status).IsEqualTo("contested");
        await Assert.That(contested.Inbound.Single().Id).IsEqualTo(world.Refuter);

        var plain = db.Store.Show(world.Plain)!;
        await Assert.That(plain.Fact.Status).IsEqualTo("live");
        var json = JsonSerializer.Serialize(plain, JsonCodec.Options);
        await Assert.That(json.Contains("\"why\"", StringComparison.Ordinal)).IsFalse();
        await Assert.That(json.Contains("\"replaced_by\"", StringComparison.Ordinal)).IsFalse();
    }

    [Test]
    public async Task EveryReadSurface_AgreesWithVerify()
    {
        using var db = new TempDb();

        // A small tangle: chains, a diamond, a dispute over a derived fact, a correction and a retraction.
        var a = PostOne(db, "Tangle", Fixtures.Fact("root a", key: "a"));
        var b = PostOne(db, "Tangle", Fixtures.Fact("root b", key: "b"));
        var ab = PostOne(db, "Tangle", Fixtures.Fact("from a and b", refs: DerivedFrom(a, b)));
        var abc = PostOne(db, "Tangle", Fixtures.Fact("from ab", refs: DerivedFrom(ab)));
        var onlyB = PostOne(db, "Tangle", Fixtures.Fact("from b alone", refs: DerivedFrom(b)));
        var objection = PostOne(db, "Tangle", Fixtures.Fact("objects to from b alone", refs: new List<RefInput> { Fixtures.Ref(onlyB, rel: "refutes") }));
        var loose = PostOne(db, "Tangle", Fixtures.Fact("an unkeyed claim"));
        var fromLoose = PostOne(db, "Tangle", Fixtures.Fact("from the unkeyed claim", refs: DerivedFrom(loose)));
        PostOne(db, "Tangle", Fixtures.Fact("the unkeyed claim, corrected", refs: new List<RefInput> { Fixtures.Ref(loose, rel: "supersedes") }));
        var withdrawn = PostOne(db, "Tangle", Fixtures.Fact("to be withdrawn"));
        var fromWithdrawn = PostOne(db, "Tangle", Fixtures.Fact("from the withdrawn claim", refs: DerivedFrom(withdrawn)));
        db.Store.Retract(withdrawn);
        PostOne(db, "Tangle", Fixtures.Fact("root a, revised", key: "a"));

        var all = new List<string> { a, b, ab, abc, onlyB, objection, loose, fromLoose, withdrawn, fromWithdrawn };
        var verified = db.Store.Verify(new VerifyRequest { Ids = all }).Facts.ToDictionary(fact => fact.Id, fact => fact.Status);

        // The tangle really exercises each status.
        await Assert.That(verified.Values.ToHashSet().SetEquals(new[] { "live", "superseded", "retracted", "stale", "contested" })).IsTrue();
        await Assert.That(verified[abc]).IsEqualTo("stale");
        await Assert.That(verified[onlyB]).IsEqualTo("contested");
        await Assert.That(verified[fromLoose]).IsEqualTo("stale");
        await Assert.That(verified[fromWithdrawn]).IsEqualTo("stale");

        var searched = Statuses(db.Store.Search(new SearchRequest { Subject = "Tangle", Limit = 100 }));
        var compiled = db.Store.Compile(new CompileRequest { Subject = "Tangle", Depth = "full" }).Facts.ToDictionary(fact => fact.Id, fact => fact.Status);
        foreach (var id in all)
        {
            await Assert.That(db.Store.Show(id)!.Fact.Status).IsEqualTo(verified[id]);
            if (verified[id] is "superseded" or "retracted")
            {
                await Assert.That(searched.ContainsKey(id)).IsFalse();
                await Assert.That(compiled.ContainsKey(id)).IsFalse();
                continue;
            }

            await Assert.That(searched[id]).IsEqualTo(verified[id]);
            await Assert.That(compiled[id]).IsEqualTo(verified[id]);
            await Assert.That(db.Store.Search(new SearchRequest { Subject = "Tangle", Status = verified[id], Limit = 100 }).Hits.Any(hit => hit.Id == id)).IsTrue();
        }
    }

    [Test]
    public async Task Compile_WithStaleFacts_IsReproducible_AndIndependentOfFactIds()
    {
        static List<string> Build(TempDb db)
        {
            var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
            PostOne(db, "Widget", Fixtures.Fact("conclusion alpha", refs: DerivedFrom(input)));
            PostOne(db, "Widget", Fixtures.Fact("conclusion beta", refs: DerivedFrom(input)));
            PostOne(db, "Widget", Fixtures.Fact("standalone gamma"));
            PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));
            var request = new CompileRequest { Subject = "Widget", Depth = "full", Rank = new RankOptions { Recency = 0 } };
            var first = JsonSerializer.Serialize(db.Store.Compile(request), JsonCodec.Options);
            var second = JsonSerializer.Serialize(db.Store.Compile(request), JsonCodec.Options);
            if (first != second)
            {
                throw new InvalidOperationException("repeated compile differs");
            }

            return db.Store.Compile(request).Facts.Select(fact => fact.Status + ": " + fact.Text).ToList();
        }

        using var one = new TempDb();
        using var two = new TempDb();
        var left = Build(one);
        var right = Build(two);

        await Assert.That(left.SequenceEqual(right)).IsTrue();
        await Assert.That(left.Count).IsEqualTo(4);
        await Assert.That(left.Skip(2).All(line => line.StartsWith("stale: ", StringComparison.Ordinal))).IsTrue();
    }

    [Test]
    public async Task StrictClustering_NeverFoldsAStaleFactIntoACurrentOne()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var stale = PostOne(db, "Widget", Fixtures.Fact("the nightly export job writes one parquet file per region", refs: DerivedFrom(input)));
        var live = PostOne(db, "Widget", Fixtures.Fact("the nightly export job writes one parquet file per region today"));
        PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));

        var dossier = db.Store.Compile(new CompileRequest { Subject = "Widget", Depth = "full", BudgetMode = "strict", Budget = 4000 });

        // Near-duplicates cluster in strict mode, but a current line must not cite a stale fact as its own.
        var liveView = dossier.Facts.Single(fact => fact.Id == live);
        await Assert.That(liveView.Cites!.Contains(stale)).IsFalse();
        await Assert.That(dossier.Facts.Any(fact => fact.Id == stale && fact.Status == "stale")).IsTrue();
    }

    [Test]
    public async Task AStoredStatusOutsideTheLifecycle_ReadsAsLiveEverywhere()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("imported with a derived status"));
        using (var connection = db.Store.OpenConnection())
        {
            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE facts SET status = 'stale' WHERE id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Widget" }).Hits.Single().Status).IsEqualTo("live");
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Widget", Status = "live" }).Total).IsEqualTo(1);
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Widget", Status = "stale" }).Total).IsEqualTo(0);
        await Assert.That(db.Store.Compile(new CompileRequest { Subject = "Widget" }).Facts.Single().Status).IsEqualTo("live");
        await Assert.That(db.Store.Show(id)!.Fact.Status).IsEqualTo("live");
    }

    [Test]
    public async Task PublishAndImport_CarryStoredStatusOnly_SoStalenessDoesNotSurviveABundle()
    {
        using var db = new TempDb();
        var world = Seed(db);
        var bundle = Path.Combine(db.Directory, "bundle");
        db.Store.Publish(new PublishOptions { Out = bundle, Depth = "full", Facts = "detail" });

        using var target = new TempDb();
        target.Store.Import(new ImportOptions { From = bundle });

        // A bundle holds live facts only, so the superseded input is not in it: the fact that was
        // stale arrives with a ref to nothing and reads live. Its stored status was never anything else.
        var imported = target.Store.Search(new SearchRequest { Subject = "Widget", Limit = 100 }).Hits;
        var arrived = imported.Single(hit => hit.Text == "promise delivery within a week");
        await Assert.That(arrived.Status).IsEqualTo("live");
        using var connection = target.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts WHERE status NOT IN ('live')")).IsEqualTo(0);
        await Assert.That(db.Store.Show(world.Stale)!.Fact.Status).IsEqualTo("stale");
    }

    [Test]
    [Arguments("live")]
    [Arguments("stale")]
    public async Task AWriteDuringASearch_CannotMakeTheFilterAndTheLabelsDisagree(string status)
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("built on the input", refs: DerivedFrom(input)));
        var old = PostOne(db, "Widget", Fixtures.Fact("older input one", key: "older"));
        var alreadyStale = PostOne(db, "Widget", Fixtures.Fact("built on the older input", refs: DerivedFrom(old)));
        PostOne(db, "Widget", Fixtures.Fact("older input two", key: "older"));

        // Another agent writes after the search has worked out which facts are stale and before it
        // reads its page: it changes an input, and it posts a fact that is stale from the start
        // because it was built on an input that had already changed. The search must answer from one
        // snapshot, so neither write may show.
        var writes = 0;
        string? late = null;
        db.Store.SearchProbe = () =>
        {
            writes++;
            var other = new DossierStore(db.DbPath);
            other.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("input two", key: "input")));
            late = other.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("a late conclusion from the older input", refs: DerivedFrom(old)))).Response.Facts[0].Id;
        };

        var during = db.Store.Search(new SearchRequest { Subject = "Widget", Status = status, Limit = 50 });
        db.Store.SearchProbe = null;

        await Assert.That(writes).IsEqualTo(1);
        await Assert.That(during.Hits.Count).IsGreaterThan(0);
        await Assert.That(during.Hits.All(hit => hit.Status == status)).IsTrue();
        await Assert.That(during.Total).IsEqualTo(during.Hits.Count);

        // The snapshot was taken before the write, so it shows the store as it was then.
        await Assert.That(during.Hits.Any(hit => hit.Id == derived)).IsEqualTo(status == "live");
        await Assert.That(during.Hits.Any(hit => hit.Id == alreadyStale)).IsEqualTo(status == "stale");
        await Assert.That(during.Hits.Any(hit => hit.Id == late)).IsFalse();

        // And the next search sees the write.
        var after = db.Store.Search(new SearchRequest { Subject = "Widget", Status = "stale", Limit = 50 });
        await Assert.That(after.Hits.Any(hit => hit.Id == derived)).IsTrue();
        await Assert.That(after.Hits.Any(hit => hit.Id == late)).IsTrue();
    }

    [Test]
    public async Task StrictBudget_NeverEmitsAStaleFact_OnceACurrentFactWasLeftOutForSize()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var big = PostOne(db, "Widget", Fixtures.Fact("a current fact too long to fit the budget " + new string('a', 400)));
        var tinyStale = PostOne(db, "Widget", Fixtures.Fact("tiny stale", refs: DerivedFrom(input)));
        var revised = PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));

        var dossier = db.Store.Compile(new CompileRequest
        {
            Subject = "Widget", Depth = "full", BudgetMode = "strict", Budget = 80, Format = "markdown", Rank = new RankOptions { Recency = 0 },
        });

        // The long current fact does not fit, so the small stale one must not take its place.
        var emitted = dossier.Facts.Select(fact => fact.Id).ToList();
        await Assert.That(dossier.Dropped.Contains(big)).IsTrue();
        await Assert.That(emitted.Contains(tinyStale)).IsFalse();
        await Assert.That(dossier.Dropped.Contains(tinyStale)).IsTrue();
        await Assert.That(emitted.Contains(revised)).IsTrue();
    }

    [Test]
    public async Task Publish_ChargesTheLineItPrints_NotTheMarkdownStatusNote()
    {
        using var db = new TempDb();
        var world = Seed(db);
        var bundle = Path.Combine(db.Directory, "bundle");
        db.Store.Publish(new PublishOptions { Out = bundle, Depth = "full", Facts = "detail" });

        // A published page prints the stored status and no status note, so its token count must be
        // the count of the plain lines, the same number a store with no stale fact would print.
        var page = Directory.GetFiles(bundle, "index.md", SearchOption.AllDirectories)
            .Select(File.ReadAllText)
            .Single(text => text.Contains("promise delivery within a week", StringComparison.Ordinal));
        await Assert.That(page.Contains("(stale:", StringComparison.Ordinal)).IsFalse();
        await Assert.That(page.Contains("(contested:", StringComparison.Ordinal)).IsFalse();

        var compiled = db.Store.Compile(new CompileRequest { Subject = "Widget", Depth = "full", Format = "markdown" });
        var plain = compiled.Facts.Sum(fact => DossierStore.EstimateTokens("- " + fact.Text + " [" + fact.Id + "]\n"));
        var withNotes = compiled.Facts.Sum(fact => DossierStore.EstimateFactTokens(fact, "markdown"));
        await Assert.That(withNotes).IsGreaterThan(plain);
        await Assert.That(page).Contains("- Used: " + plain + " tokens");
        await Assert.That(db.Store.Show(world.Stale)!.Fact.Status).IsEqualTo("stale");
    }

    [Test]
    public async Task TheCurrencyIndexExists()
    {
        using var db = new TempDb();
        using var connection = db.Store.OpenConnection();

        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM sqlite_master WHERE type = 'index' AND name = 'idx_refs_currency'")).IsEqualTo(1);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM sqlite_master WHERE type = 'index' AND name = 'idx_facts_slot'")).IsEqualTo(1);
    }

    [Test]
    public async Task ManyFactsBuiltOnOneChangedInput_AreClassifiedWithoutRescanningTheSubject()
    {
        using var db = new TempDb();
        const int Count = 2000;
        var facts = new List<FactInput> { Fixtures.Fact("input one", key: "input", localId: "in") };
        for (var index = 0; index < Count; index++)
        {
            facts.Add(Fixtures.Fact($"conclusion number {index} drawn from the input", refs: DerivedFrom("@in")));
            facts.Add(Fixtures.Fact($"standalone observation number {index}"));
        }

        db.Store.PostFacts(Fixtures.Post("Bench", facts.ToArray()));
        PostOne(db, "Bench", Fixtures.Fact("input two", key: "input"));

        // A guard against the quadratic path this once had (one subject scan per stale fact, 28 s at
        // 5,000 facts): the bound is generous, the old cost was two orders of magnitude over it.
        var watch = System.Diagnostics.Stopwatch.StartNew();
        var stale = db.Store.Search(new SearchRequest { Subject = "Bench", Status = "stale", Limit = 5 });
        var live = db.Store.Search(new SearchRequest { Subject = "Bench", Status = "live", Limit = 5 });
        var dossier = db.Store.Compile(new CompileRequest { Subject = "Bench", Depth = "index" });
        watch.Stop();

        await Assert.That(stale.Total).IsEqualTo(Count);
        await Assert.That(live.Total).IsEqualTo(Count + 1);
        // Complete mode emits every fact: the current ones first, then every stale one.
        await Assert.That(dossier.Facts.Count).IsEqualTo((2 * Count) + 1);
        await Assert.That(dossier.Facts.Take(Count + 1).All(fact => fact.Status == "live")).IsTrue();
        await Assert.That(dossier.Facts.Skip(Count + 1).All(fact => fact.Status == "stale")).IsTrue();
        await Assert.That(watch.Elapsed).IsLessThan(TimeSpan.FromSeconds(10));
    }
}
