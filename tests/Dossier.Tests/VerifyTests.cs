using System.Diagnostics;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// verify: the check an agent runs on the fact ids a plan cites, before acting on it. It reports
/// each fact's derived status (live, superseded, retracted, stale, contested, unknown) and why.
/// </summary>
public sealed class VerifyTests
{
    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    private static List<RefInput> DerivedFrom(params string[] ids) =>
        ids.Select(id => Fixtures.Ref(id, basis: "derived", rel: "derived_from")).ToList();

    private static VerifiedFact One(TempDb db, string id) => db.Store.Verify(new VerifyRequest { Ids = { id } }).Facts.Single();

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
    }

    [Test]
    public async Task LiveFact_IsCurrent_AndTheResponseCarriesTheRevision()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("the header is 64 pixels tall", key: "headerHeight"));

        var response = db.Store.Verify(new VerifyRequest { Ids = { id } });

        await Assert.That(response.Current).IsTrue();
        await Assert.That(response.Revision).IsEqualTo(db.Store.Revision());
        var fact = response.Facts.Single();
        await Assert.That(fact.Id).IsEqualTo(id);
        await Assert.That(fact.Status).IsEqualTo("live");
        await Assert.That(fact.Current).IsTrue();
        await Assert.That(fact.SubjectId).IsNotNull();
        await Assert.That(fact.ReplacedBy).IsNull();
        await Assert.That(fact.Why).IsNull();
    }

    [Test]
    public async Task SupersededFact_NamesTheFactItsSlotHoldsNow_NotTheDirectSuccessor()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var second = PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));
        var third = PostOne(db, "Widget", Fixtures.Fact("version three", key: "state"));

        var response = db.Store.Verify(new VerifyRequest { Ids = { first, second, third } });

        await Assert.That(response.Current).IsFalse();
        await Assert.That(response.Facts.Select(f => f.Id).SequenceEqual(new[] { first, second, third })).IsTrue();
        await Assert.That(response.Facts[0].Status).IsEqualTo("superseded");
        await Assert.That(response.Facts[0].Current).IsFalse();
        await Assert.That(response.Facts[0].ReplacedBy).IsEqualTo(third);
        await Assert.That(response.Facts[1].Status).IsEqualTo("superseded");
        await Assert.That(response.Facts[1].ReplacedBy).IsEqualTo(third);
        await Assert.That(response.Facts[2].Status).IsEqualTo("live");
        await Assert.That(response.Facts[2].ReplacedBy).IsNull();
    }

    [Test]
    public async Task SupersededFact_WhoseSuccessorWasRetracted_HasNoReplacement()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var second = PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));
        db.Store.Retract(second);

        var old = One(db, first);
        await Assert.That(old.Status).IsEqualTo("superseded");
        await Assert.That(old.ReplacedBy).IsNull();

        var gone = One(db, second);
        await Assert.That(gone.Status).IsEqualTo("retracted");
        await Assert.That(gone.Current).IsFalse();
    }

    [Test]
    public async Task UnknownId_IsReportedNotThrown_AndMakesTheWholeAnswerNotCurrent()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("a fact"));

        var response = db.Store.Verify(new VerifyRequest { Ids = { id, "no-such-fact" } });

        await Assert.That(response.Current).IsFalse();
        await Assert.That(response.Facts[0].Status).IsEqualTo("live");
        await Assert.That(response.Facts[1].Status).IsEqualTo("unknown");
        await Assert.That(response.Facts[1].Current).IsFalse();
        await Assert.That(response.Facts[1].SubjectId).IsNull();
    }

    [Test]
    public async Task DerivedFact_GoesStale_WhenItsInputIsSupersededByADifferentClaim()
    {
        using var db = new TempDb();
        var requirement = PostOne(db, "Checkout", Fixtures.Fact("orders ship within 5 days", key: "shipWindow"));
        var plan = PostOne(db, "Checkout/Plan", Fixtures.Fact("promise delivery in a week", refs: DerivedFrom(requirement)));
        await Assert.That(One(db, plan).Status).IsEqualTo("live");

        var revised = PostOne(db, "Checkout", Fixtures.Fact("orders ship within 2 days", key: "shipWindow"));

        var fact = One(db, plan);
        await Assert.That(fact.Status).IsEqualTo("stale");
        await Assert.That(fact.Current).IsFalse();
        await Assert.That(fact.Why).IsNotNull();
        await Assert.That(fact.Why!.Count).IsEqualTo(1);
        await Assert.That(fact.Why[0].Rel).IsEqualTo("derived_from");
        await Assert.That(fact.Why[0].Fact).IsEqualTo(requirement);
        await Assert.That(fact.Why[0].State).IsEqualTo("superseded");
        await Assert.That(fact.Why[0].ReplacedBy).IsEqualTo(revised);
    }

    [Test]
    public async Task Staleness_IsTransitive_AndNamesTheDirectInputThatIsStale()
    {
        using var db = new TempDb();
        var observation = PostOne(db, "Incident", Fixtures.Fact("error rate is 4 percent", key: "errorRate"));
        var hypothesis = PostOne(db, "Incident", Fixtures.Fact("the cache is cold", refs: DerivedFrom(observation)));
        var mitigation = PostOne(db, "Incident", Fixtures.Fact("warm the cache", refs: DerivedFrom(hypothesis)));
        var verification = PostOne(db, "Incident", Fixtures.Fact("warming fixed it", refs: DerivedFrom(mitigation)));

        PostOne(db, "Incident", Fixtures.Fact("error rate is 0.1 percent", key: "errorRate"));

        await Assert.That(One(db, hypothesis).Why![0].State).IsEqualTo("superseded");
        var leaf = One(db, verification);
        await Assert.That(leaf.Status).IsEqualTo("stale");
        await Assert.That(leaf.Why!.Single().Fact).IsEqualTo(mitigation);
        await Assert.That(leaf.Why!.Single().State).IsEqualTo("stale");
        await Assert.That(leaf.Why!.Single().ReplacedBy).IsNull();
    }

    [Test]
    public async Task DerivedFact_StaysLive_WhenItsInputWasRepostedWithTheSameClaim()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("the header is 64 pixels tall", key: "headerHeight", tags: new List<string> { "ui" }));
        var derived = PostOne(db, "Widget", Fixtures.Fact("the sidebar starts below 64 pixels", refs: DerivedFrom(input)));

        // A tag-only repost replaces the row but the claim (text, data, refs) is the same.
        var retagged = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the header is 64 pixels tall", key: "headerHeight", tags: new List<string> { "ui", "reviewed" })));
        await Assert.That(retagged.Response.Facts[0].Status).IsEqualTo("replaced");

        await Assert.That(One(db, input).Status).IsEqualTo("superseded");
        var fact = One(db, derived);
        await Assert.That(fact.Status).IsEqualTo("live");
        await Assert.That(fact.Why).IsNull();
    }

    [Test]
    public async Task DerivedFact_GoesStale_WhenItsInputIsRetracted()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("a claim that will be withdrawn"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("a conclusion built on it", refs: DerivedFrom(input)));

        db.Store.Retract(input);

        var fact = One(db, derived);
        await Assert.That(fact.Status).IsEqualTo("stale");
        await Assert.That(fact.Why!.Single().State).IsEqualTo("retracted");
        await Assert.That(fact.Why!.Single().ReplacedBy).IsNull();
    }

    [Test]
    public async Task OnlyDerivedFromRefsCarryStaleness()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var mention = PostOne(db, "Widget", Fixtures.Fact("see also the state", refs: new List<RefInput> { Fixtures.Ref(input, rel: "mentions") }));
        var support = PostOne(db, "Widget", Fixtures.Fact("agrees with the state", refs: new List<RefInput> { Fixtures.Ref(input, rel: "supports") }));

        PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));

        await Assert.That(One(db, mention).Status).IsEqualTo("live");
        await Assert.That(One(db, support).Status).IsEqualTo("live");
    }

    [Test]
    public async Task ADerivationCycle_Terminates_AndBothMembersAreStaleWhicheverIsAskedFirst()
    {
        using var db = new TempDb();
        var upstream = PostOne(db, "Widget", Fixtures.Fact("upstream one", key: "upstream"));
        var a = PostOne(db, "Widget", Fixtures.Fact("claim a"));
        var b = PostOne(db, "Widget", Fixtures.Fact("claim b", refs: DerivedFrom(a, upstream)));

        // Facts are immutable, so a cycle can only come from a hand-edited or imported store.
        Exec(
            db,
            "INSERT INTO refs(fact_id, seq, rel, kind, target, basis) VALUES($fact, 0, 'derived_from', 'fact', $target, 'derived')",
            ("$fact", a),
            ("$target", b));
        await Assert.That(db.Store.Verify(new VerifyRequest { Ids = { a, b } }).Current).IsTrue();

        PostOne(db, "Widget", Fixtures.Fact("upstream two", key: "upstream"));

        var forward = db.Store.Verify(new VerifyRequest { Ids = { a, b } });
        var backward = db.Store.Verify(new VerifyRequest { Ids = { b, a } });
        await Assert.That(forward.Facts.All(f => f.Status == "stale")).IsTrue();
        await Assert.That(backward.Facts.All(f => f.Status == "stale")).IsTrue();
        await Assert.That(One(db, a).Status).IsEqualTo("stale");
    }

    [Test]
    public async Task ADerivedFromRefToAFactThatIsNotInTheStore_DoesNotMakeTheFactStale()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("built on a fact from another store", refs: DerivedFrom("11111111-2222-3333-4444-555555555555")));

        var fact = One(db, id);
        await Assert.That(fact.Status).IsEqualTo("live");
        await Assert.That(fact.Why).IsNull();
    }

    [Test]
    public async Task RefutedFact_IsContested_AndTheRefuterStaysLive()
    {
        using var db = new TempDb();
        var claim = PostOne(db, "Widget", Fixtures.Fact("the save shortcut is Cmd+Enter"));
        var refuter = PostOne(db, "Widget", Fixtures.Fact("pressing Cmd+Enter did nothing on Linux", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));

        var response = db.Store.Verify(new VerifyRequest { Ids = { claim, refuter } });

        await Assert.That(response.Current).IsFalse();
        await Assert.That(response.Facts[0].Status).IsEqualTo("contested");
        await Assert.That(response.Facts[0].Current).IsFalse();
        await Assert.That(response.Facts[0].Why!.Single().Rel).IsEqualTo("refutes");
        await Assert.That(response.Facts[0].Why!.Single().Fact).IsEqualTo(refuter);
        await Assert.That(response.Facts[0].Why!.Single().State).IsNull();
        await Assert.That(response.Facts[1].Status).IsEqualTo("live");
    }

    [Test]
    public async Task Contradicts_IsSymmetric_BothFactsAreContested()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("the header is 64 pixels tall"));
        var second = PostOne(db, "Widget", Fixtures.Fact("the header is 72 pixels tall", refs: new List<RefInput> { Fixtures.Ref(first, rel: "contradicts") }));

        var response = db.Store.Verify(new VerifyRequest { Ids = { first, second } });

        await Assert.That(response.Facts[0].Status).IsEqualTo("contested");
        await Assert.That(response.Facts[0].Why!.Single().Fact).IsEqualTo(second);
        await Assert.That(response.Facts[1].Status).IsEqualTo("contested");
        await Assert.That(response.Facts[1].Why!.Single().Rel).IsEqualTo("contradicts");
        await Assert.That(response.Facts[1].Why!.Single().Fact).IsEqualTo(first);
    }

    [Test]
    public async Task ADisputeEnds_WhenTheRefuterIsRetractedSupersededOrStale()
    {
        using var db = new TempDb();
        var claim = PostOne(db, "Widget", Fixtures.Fact("the claim under dispute"));

        var retracted = PostOne(db, "Widget", Fixtures.Fact("first objection", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));
        await Assert.That(One(db, claim).Status).IsEqualTo("contested");
        db.Store.Retract(retracted);
        await Assert.That(One(db, claim).Status).IsEqualTo("live");

        PostOne(db, "Widget", Fixtures.Fact("second objection", key: "objection", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));
        await Assert.That(One(db, claim).Status).IsEqualTo("contested");
        PostOne(db, "Widget", Fixtures.Fact("objection withdrawn", key: "objection"));
        await Assert.That(One(db, claim).Status).IsEqualTo("live");

        var evidence = PostOne(db, "Widget", Fixtures.Fact("a measurement", key: "measurement"));
        var refs = DerivedFrom(evidence);
        refs.Add(Fixtures.Ref(claim, rel: "refutes"));
        PostOne(db, "Widget", Fixtures.Fact("third objection, built on the measurement", refs: refs));
        await Assert.That(One(db, claim).Status).IsEqualTo("contested");
        PostOne(db, "Widget", Fixtures.Fact("a different measurement", key: "measurement"));
        await Assert.That(One(db, claim).Status).IsEqualTo("live");
    }

    [Test]
    public async Task StaleWinsOverContested_AndSupersededWinsOverBoth()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("derived claim", key: "derived", refs: DerivedFrom(input)));
        PostOne(db, "Widget", Fixtures.Fact("an objection", refs: new List<RefInput> { Fixtures.Ref(derived, rel: "refutes") }));
        await Assert.That(One(db, derived).Status).IsEqualTo("contested");

        PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));
        var stale = One(db, derived);
        await Assert.That(stale.Status).IsEqualTo("stale");
        await Assert.That(stale.Why!.All(reason => reason.Rel == "derived_from")).IsTrue();

        var replacement = PostOne(db, "Widget", Fixtures.Fact("derived claim, redone", key: "derived"));
        var superseded = One(db, derived);
        await Assert.That(superseded.Status).IsEqualTo("superseded");
        await Assert.That(superseded.ReplacedBy).IsEqualTo(replacement);
        await Assert.That(superseded.Why).IsNull();
    }

    [Test]
    public async Task AStoredStatusOutsideTheLifecycle_IsReadAsLive()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("imported with a derived status"));
        Exec(db, "UPDATE facts SET status = 'stale' WHERE id = $id", ("$id", id));

        // A hand-edited or imported row can hold any string; only superseded and retracted are lifecycle.
        await Assert.That(One(db, id).Status).IsEqualTo("live");
    }

    [Test]
    public async Task Verify_WritesNothing_AndCollapsesRepeatedIds()
    {
        using var db = new TempDb();
        var id = PostOne(db, "Widget", Fixtures.Fact("a fact"));
        var revision = db.Store.Revision();

        var response = db.Store.Verify(new VerifyRequest { Ids = { id, id, id } });

        await Assert.That(response.Facts.Count).IsEqualTo(1);
        await Assert.That(db.Store.Revision()).IsEqualTo(revision);
    }

    [Test]
    public async Task Verify_RejectsAnEmptyRequestAndTooManyIds()
    {
        using var db = new TempDb();

        string? Code(VerifyRequest request)
        {
            try
            {
                db.Store.Verify(request);
                return null;
            }
            catch (DossierRequestException exception)
            {
                return exception.Code;
            }
        }

        await Assert.That(Code(new VerifyRequest())).IsEqualTo("invalid_request");
        await Assert.That(Code(new VerifyRequest { Ids = { " " } })).IsEqualTo("invalid_request");
        var many = new VerifyRequest();
        many.Ids.AddRange(Enumerable.Range(0, DossierStore.MaxVerifyIds + 1).Select(i => $"id-{i}"));
        await Assert.That(Code(many)).IsEqualTo("invalid_request");
    }

    [Test]
    public async Task Mcp_VerifyFactsToolIsListedAndCallable()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("built on version one", refs: DerivedFrom(input)));
        PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));
        var server = new McpServer(db.Store);

        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var tool = list.GetProperty("result").GetProperty("tools").EnumerateArray()
            .Single(t => t.GetProperty("name").GetString() == "verify_facts");
        await Assert.That(tool.GetProperty("description").GetString()!.Contains("untrusted data")).IsTrue();
        await Assert.That(tool.GetProperty("inputSchema").GetProperty("required")[0].GetString()).IsEqualTo("ids");

        JsonElement Call(object arguments) => JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 2,
            method = "tools/call",
            @params = new { name = "verify_facts", arguments },
        }))!.ToJsonString()).RootElement.GetProperty("result").Clone();

        var result = Call(new { ids = new[] { derived } });
        await Assert.That(result.GetProperty("isError").GetBoolean()).IsFalse();
        var text = result.GetProperty("content")[0].GetProperty("text").GetString()!;
        await Assert.That(text).IsEqualTo(JsonSerializer.Serialize(db.Store.Verify(new VerifyRequest { Ids = { derived } }), JsonCodec.Options));
        var body = JsonDocument.Parse(text).RootElement;
        await Assert.That(body.GetProperty("current").GetBoolean()).IsFalse();
        await Assert.That(body.GetProperty("facts")[0].GetProperty("status").GetString()).IsEqualTo("stale");
        await Assert.That(body.GetProperty("facts")[0].GetProperty("why")[0].GetProperty("state").GetString()).IsEqualTo("superseded");

        var empty = Call(new { ids = Array.Empty<string>() });
        await Assert.That(empty.GetProperty("isError").GetBoolean()).IsTrue();
        await Assert.That(empty.GetProperty("content")[0].GetProperty("text").GetString()!).Contains("invalid_request");
    }

    [Test]
    public async Task Cli_Verify_PrintsTheAnswer_AndRequireCurrentTurnsItIntoAGate()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("built on version one", refs: DerivedFrom(input)));

        var (liveExit, liveOut, _) = await Run(db.DbPath, "verify", derived, "--require-current");
        await Assert.That(liveExit).IsEqualTo(0);
        await Assert.That(JsonDocument.Parse(liveOut).RootElement.GetProperty("current").GetBoolean()).IsTrue();

        PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));

        // Without the flag the command reports and exits 0, like search with no hits.
        var (reportExit, reportOut, _) = await Run(db.DbPath, "verify", derived, input);
        await Assert.That(reportExit).IsEqualTo(0);
        var report = JsonDocument.Parse(reportOut).RootElement;
        await Assert.That(report.GetProperty("current").GetBoolean()).IsFalse();
        await Assert.That(report.GetProperty("facts")[0].GetProperty("status").GetString()).IsEqualTo("stale");
        await Assert.That(report.GetProperty("facts")[1].GetProperty("status").GetString()).IsEqualTo("superseded");

        // With it, a fact that is not current fails the command, and the answer is still printed.
        var (gateExit, gateOut, gateErr) = await Run(db.DbPath, "verify", "--require-current", derived);
        await Assert.That(gateExit).IsEqualTo(1);
        await Assert.That(JsonDocument.Parse(gateOut).RootElement.GetProperty("current").GetBoolean()).IsFalse();
        await Assert.That(gateErr).Contains("not current");

        var (noIdsExit, noIdsOut, noIdsErr) = await Run(db.DbPath, "verify");
        await Assert.That(noIdsExit).IsEqualTo(1);
        await Assert.That(noIdsOut).IsEqualTo(string.Empty);
        await Assert.That(noIdsErr).Contains("verify requires");

        var (typoExit, _, typoErr) = await Run(db.DbPath, "verify", derived, "--require-curent");
        await Assert.That(typoExit).IsEqualTo(1);
        await Assert.That(typoErr).Contains("unknown option");
    }

    private static async Task<(int Exit, string Out, string Err)> Run(string dbPath, params string[] args)
    {
        var info = new ProcessStartInfo("dotnet")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            WorkingDirectory = Path.GetDirectoryName(dbPath)!,
        };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in args)
        {
            info.ArgumentList.Add(arg);
        }

        info.Environment["DOSSIER_DB"] = dbPath;
        using var process = Process.Start(info)!;
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        return (process.ExitCode, await stdout, await stderr);
    }
}
