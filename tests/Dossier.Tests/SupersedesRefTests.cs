using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Correction by ref: a fact that carries <c>rel: supersedes</c> to a fact id replaces that fact,
/// keyed or not. The old fact keeps its row and is no longer returned by search or compile.
/// </summary>
public sealed class SupersedesRefTests
{
    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    private static List<RefInput> Supersedes(params string[] ids) =>
        ids.Select(id => Fixtures.Ref(id, rel: "supersedes")).ToList();

    private static VerifiedFact Verify(TempDb db, string id) => db.Store.Verify(new VerifyRequest { Ids = { id } }).Facts.Single();

    private static string? StoredStatus(TempDb db, string id)
    {
        using var connection = db.Store.OpenConnection();
        return (string?)Fixtures.Scalar(connection, "SELECT status FROM facts WHERE id = $id", ("$id", id));
    }

    [Test]
    public async Task AnUnkeyedFact_IsCorrectedByASupersedesRef()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Scot/Career", Fixtures.Fact("Started learning the language in 2009"));
        var revision = db.Store.Revision();

        var posted = db.Store.PostFacts(Fixtures.Post("Scot/Career", Fixtures.Fact("Started learning the language in 2007", refs: Supersedes(old))));
        var correction = posted.Response.Facts[0];

        await Assert.That(posted.Errors.Count).IsEqualTo(0);
        await Assert.That(correction.Status).IsEqualTo("new");
        await Assert.That(StoredStatus(db, old)).IsEqualTo("superseded");
        await Assert.That(db.Store.Revision()).IsGreaterThan(revision);

        // The old row is history: kept, with its text, and out of every default read.
        var shown = db.Store.Show(old)!;
        await Assert.That(shown.Fact.Text).IsEqualTo("Started learning the language in 2009");
        var hits = db.Store.Search(new SearchRequest { Subject = "Scot/Career" }).Hits.Select(hit => hit.Id).ToList();
        await Assert.That(hits.SequenceEqual(new[] { correction.Id })).IsTrue();
        await Assert.That(db.Store.Search(new SearchRequest { Q = "2009" }).Total).IsEqualTo(0);
        var compiled = db.Store.Compile(new CompileRequest { Subject = "Scot/Career", Depth = "full" }).Facts.Select(fact => fact.Id).ToList();
        await Assert.That(compiled.SequenceEqual(new[] { correction.Id })).IsTrue();

        var verified = Verify(db, old);
        await Assert.That(verified.Status).IsEqualTo("superseded");
        await Assert.That(verified.ReplacedBy).IsEqualTo(correction.Id);
        await Assert.That(Verify(db, correction.Id).Status).IsEqualTo("live");
    }

    [Test]
    public async Task ACorrectionChain_NamesTheFactThatIsLiveNow()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var second = PostOne(db, "Widget", Fixtures.Fact("version two", refs: Supersedes(first)));
        var third = PostOne(db, "Widget", Fixtures.Fact("version three", refs: Supersedes(second)));

        await Assert.That(Verify(db, first).ReplacedBy).IsEqualTo(third);
        await Assert.That(Verify(db, second).ReplacedBy).IsEqualTo(third);
        await Assert.That(Verify(db, third).Status).IsEqualTo("live");
    }

    [Test]
    public async Task AKeyedChainEndedByACorrection_StillResolves_AndWhatWasDerivedFromItGoesStale()
    {
        using var db = new TempDb();
        var k1 = PostOne(db, "Widget", Fixtures.Fact("timeout is 10 seconds", key: "timeout"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("retries fit in 30 seconds", refs: new List<RefInput> { Fixtures.Ref(k1, basis: "derived", rel: "derived_from") }));
        var k2 = PostOne(db, "Widget", Fixtures.Fact("timeout is 20 seconds", key: "timeout"));
        var correction = PostOne(db, "Widget", Fixtures.Fact("there is no timeout at all", refs: Supersedes(k2)));

        // K1 was replaced by a keyed repost, which wrote no ref, and the correction emptied the slot.
        await Assert.That(Verify(db, k1).ReplacedBy).IsEqualTo(correction);
        await Assert.That(Verify(db, k2).ReplacedBy).IsEqualTo(correction);

        var stale = Verify(db, derived);
        await Assert.That(stale.Status).IsEqualTo("stale");
        await Assert.That(stale.Why!.Single().Fact).IsEqualTo(k1);
        await Assert.That(stale.Why!.Single().State).IsEqualTo("superseded");
        await Assert.That(stale.Why!.Single().ReplacedBy).IsEqualTo(correction);
    }

    [Test]
    public async Task CorrectingAKeyedFact_EmptiesItsSlot_SoALaterKeyedPostIsNew()
    {
        using var db = new TempDb();
        var keyed = PostOne(db, "Widget", Fixtures.Fact("owner is the platform team", key: "owner"));
        var correction = PostOne(db, "Widget", Fixtures.Fact("nobody owns it", refs: Supersedes(keyed)));

        using (var connection = db.Store.OpenConnection())
        {
            await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM slots WHERE fact_id = $id", ("$id", keyed))).IsEqualTo(0);
        }

        var later = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("owner is the data team", key: "owner"))).Response.Facts[0];
        await Assert.That(later.Status).IsEqualTo("new");

        // The correction is what replaced it; the later slot value is a new claim, not its successor.
        await Assert.That(Verify(db, keyed).ReplacedBy).IsEqualTo(correction);
    }

    [Test]
    public async Task ASupersedesRefToAMissingFact_IsRejected_AndNothingIsWritten()
    {
        using var db = new TempDb();
        PostOne(db, "Widget", Fixtures.Fact("an existing fact"));
        var revision = db.Store.Revision();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("a correction with a mistyped id", refs: Supersedes("11111111-2222-3333-4444-555555555555")),
            Fixtures.Fact("an unrelated fact in the same batch")));

        await Assert.That(result.Errors.Count).IsEqualTo(1);
        await Assert.That(result.Errors[0].Index).IsEqualTo(0);
        await Assert.That(result.Errors[0].Code).IsEqualTo("supersedes_target_not_found");

        // The rest of the batch still commits, as for every other rejected item.
        await Assert.That(result.Response.Facts.Count).IsEqualTo(1);
        await Assert.That(result.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(db.Store.Search(new SearchRequest { Q = "mistyped" }).Total).IsEqualTo(0);
        await Assert.That(db.Store.Revision()).IsGreaterThan(revision);
    }

    [Test]
    public async Task ACorrectionMayNameAFactPostedEarlierInTheSameBatch()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("first draft", localId: "draft"),
            Fixtures.Fact("final wording", refs: Supersedes("@draft"))));

        await Assert.That(result.Errors.Count).IsEqualTo(0);
        await Assert.That(StoredStatus(db, result.Response.Facts[0].Id)).IsEqualTo("superseded");
        await Assert.That(StoredStatus(db, result.Response.Facts[1].Id)).IsEqualTo("live");
    }

    [Test]
    public async Task ATargetThatIsAlreadySupersededOrRetracted_IsLeftAsItIs()
    {
        using var db = new TempDb();
        var k1 = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var k2 = PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));
        var gone = PostOne(db, "Widget", Fixtures.Fact("withdrawn"));
        db.Store.Retract(gone);

        var result = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("a late correction of both", refs: Supersedes(k1, gone))));

        await Assert.That(result.Errors.Count).IsEqualTo(0);
        await Assert.That(StoredStatus(db, k1)).IsEqualTo("superseded");
        await Assert.That(StoredStatus(db, gone)).IsEqualTo("retracted");
        await Assert.That(Verify(db, gone).Status).IsEqualTo("retracted");

        // The keyed repost replaced k1 first, so it stays the answer; the slot still holds it.
        await Assert.That(StoredStatus(db, k2)).IsEqualTo("live");
        await Assert.That(Verify(db, k1).ReplacedBy).IsEqualTo(k2);
    }

    [Test]
    public async Task ABatchThatReplacesAFactByKeyAndThenByRef_DoesNotFail()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("version two", key: "state"),
            Fixtures.Fact("a note that also supersedes version one", refs: Supersedes(old))));

        await Assert.That(result.Errors.Count).IsEqualTo(0);
        await Assert.That(result.Response.Facts[0].Status).IsEqualTo("replaced");
        await Assert.That(result.Response.Facts[1].Status).IsEqualTo("new");
        await Assert.That(StoredStatus(db, result.Response.Facts[0].Id)).IsEqualTo("live");
    }

    [Test]
    public async Task ACorrectionMayTargetAFactOnAnotherSubject()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Alpha", Fixtures.Fact("alpha depends on beta version 1"));
        PostOne(db, "Beta", Fixtures.Fact("beta is at version 2, so alpha's note is out of date", refs: Supersedes(old)));

        await Assert.That(StoredStatus(db, old)).IsEqualTo("superseded");
        await Assert.That(db.Store.Compile(new CompileRequest { Subject = "Alpha", Depth = "full" }).Facts.Count).IsEqualTo(0);
    }

    [Test]
    [Arguments("slot")]
    [Arguments("symbol")]
    [Arguments("url")]
    public async Task OnlyARefOfKindFact_Supersedes(string kind)
    {
        using var db = new TempDb();
        var keyed = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var target = kind switch
        {
            "slot" => "Widget#state",
            "symbol" => "Widget.State@abc123",
            _ => "https://example.test/state",
        };

        var result = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("a note", refs: new List<RefInput> { Fixtures.Ref(target, kind: kind, rel: "supersedes") })));

        // Stored as written, with no effect and no rejection.
        await Assert.That(result.Errors.Count).IsEqualTo(0);
        await Assert.That(StoredStatus(db, keyed)).IsEqualTo("live");
    }

    [Test]
    public async Task DryRunAndCheckDrafts_GiveTheRealVerdict_AndWriteNothing()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var revision = db.Store.Revision();

        var dry = Fixtures.Post(
            "Widget",
            Fixtures.Fact("version two", refs: Supersedes(old)),
            Fixtures.Fact("bad correction", refs: Supersedes("no-such-fact")));
        dry.DryRun = true;
        var result = db.Store.PostFacts(dry);
        await Assert.That(result.Response.Facts.Single().Status).IsEqualTo("new");
        await Assert.That(result.Errors.Single().Code).IsEqualTo("supersedes_target_not_found");

        var check = db.Store.Check(new CheckRequest { Subject = "Widget", Drafts = dry.Facts });
        await Assert.That(check.Drafts![0].Status).IsEqualTo("new");
        await Assert.That(check.Drafts![1].Status).IsEqualTo("error");
        await Assert.That(check.Drafts![1].Error!.Code).IsEqualTo("supersedes_target_not_found");

        await Assert.That(StoredStatus(db, old)).IsEqualTo("live");
        await Assert.That(db.Store.Revision()).IsEqualTo(revision);
    }

    [Test]
    public async Task RepostingACorrection_AppliesItWhenItsTargetIsStillLive()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var correction = PostOne(db, "Widget", Fixtures.Fact("version two", refs: Supersedes(old)));

        // A store written before corrections took effect holds the ref with its target still live.
        using (var connection = db.Store.OpenConnection())
        {
            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE facts SET status = 'live' WHERE id = $id";
            command.Parameters.AddWithValue("$id", old);
            command.ExecuteNonQuery();
        }

        var again = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version two", refs: Supersedes(old)))).Response.Facts[0];
        await Assert.That(again.Status).IsEqualTo("deduped");
        await Assert.That(again.Id).IsEqualTo(correction);
        await Assert.That(StoredStatus(db, old)).IsEqualTo("superseded");

        // And once it has taken effect, the same repost writes nothing.
        var revision = db.Store.Revision();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version two", refs: Supersedes(old))));
        await Assert.That(db.Store.Revision()).IsEqualTo(revision);
    }

    [Test]
    public async Task AConflict_Disappears_WhenOneSideSupersedesTheOther()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("header is 64 pixels tall", data: Fixtures.Json("{\"headerHeight\":64}")));
        PostOne(db, "Widget", Fixtures.Fact("header is 72 pixels tall", data: Fixtures.Json("{\"headerHeight\":72}")));
        await Assert.That(db.Store.Compile(new CompileRequest { Subject = "Widget" }).Conflicts.Count).IsEqualTo(1);
        await Assert.That(db.Store.Check(new CheckRequest { Subject = "Widget" }).Summary.Conflicts).IsEqualTo(1);

        PostOne(db, "Widget", Fixtures.Fact("header measured again: 72 pixels", data: Fixtures.Json("{\"headerHeight\":72}"), refs: Supersedes(first)));

        await Assert.That(db.Store.Compile(new CompileRequest { Subject = "Widget" }).Conflicts.Count).IsEqualTo(0);
        await Assert.That(db.Store.Check(new CheckRequest { Subject = "Widget" }).Summary.Conflicts).IsEqualTo(0);
    }

    [Test]
    public async Task TheJournal_RecordsTheStatusFlipOfTheCorrectedFact()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var cursor = db.Store.Revision();

        var correction = PostOne(db, "Widget", Fixtures.Fact("version two", refs: Supersedes(old)));

        var rows = db.Store.ReadChanges(cursor, 100).Changes;
        await Assert.That(rows.Any(row => row.Tbl == "facts" && row.Op == "insert" && row.FactId == correction)).IsTrue();
        await Assert.That(rows.Any(row => row.Tbl == "facts" && row.Op == "update" && row.FactId == old && row.FactStatus == "superseded")).IsTrue();
    }

    [Test]
    public async Task PublishAndImport_CarryTheCorrection_AndLeaveTheOldFactBehind()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var correction = PostOne(db, "Widget", Fixtures.Fact("version two", refs: Supersedes(old)));
        var bundle = Path.Combine(db.Directory, "bundle");
        db.Store.Publish(new PublishOptions { Out = bundle, Depth = "full", Facts = "detail" });

        using var target = new TempDb();
        target.Store.Import(new ImportOptions { From = bundle });

        // Publish carries live facts only, so the old fact is not in the bundle. Import does not go
        // through post, so the correction's ref to a fact outside the bundle is accepted as it is.
        var imported = target.Store.Search(new SearchRequest { Subject = "Widget" }).Hits;
        await Assert.That(imported.Count).IsEqualTo(1);
        await Assert.That(imported[0].Text).IsEqualTo("version two");
        await Assert.That(target.Store.Show(imported[0].Id)!.Refs.Any(reference => reference.Rel == "supersedes")).IsTrue();
        await Assert.That(target.Store.Verify(new VerifyRequest { Ids = { old } }).Facts.Single().Status).IsEqualTo("unknown");
        await Assert.That(db.Store.Verify(new VerifyRequest { Ids = { correction } }).Current).IsTrue();
    }

    [Test]
    public async Task KnownGap_Issue25_ReDumpingAnUnchangedSourceBringsACorrectedClaimBack()
    {
        using var db = new TempDb();
        var source = Path.Combine(db.Directory, "note.txt");
        File.WriteAllText(source, "The service was launched in 2019.");
        var dumped = db.Store.Dump(new DumpRequest { Source = source, Subject = "Service" }).Created.Single();
        PostOne(db, "Service", Fixtures.Fact("The service was launched in 2018.", refs: Supersedes(dumped)));
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Service" }).Total).IsEqualTo(1);

        var again = db.Store.Dump(new DumpRequest { Source = source, Subject = "Service" });

        // Pinned on purpose: dedupe only looks at live facts, so the corrected claim is created again
        // and both read live. Issue #25 asks for a re-dump not to revive it; when that lands, this
        // test changes to expect no new fact.
        await Assert.That(again.Created.Count).IsEqualTo(1);
        await Assert.That(db.Store.Search(new SearchRequest { Subject = "Service" }).Total).IsEqualTo(2);
    }

    [Test]
    public async Task AnAgentCorrectsAnotherAgentsFact_OverMcp()
    {
        using var db = new TempDb();
        var first = new McpServer(db.Store, "agent-a");
        var second = new McpServer(db.Store, "agent-b");

        JsonElement Call(McpServer server, string name, object arguments) => JsonDocument.Parse(JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 1,
            method = "tools/call",
            @params = new { name, arguments },
        }))!.ToJsonString()).RootElement.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!).RootElement.Clone();

        var old = Call(first, "post_facts", new { subject = new { name = "Widget" }, facts = new[] { new { kind = "note", text = "the cache is cold" } } })
            .GetProperty("response").GetProperty("facts")[0].GetProperty("id").GetString()!;
        var correction = Call(second, "post_facts", new
        {
            subject = new { name = "Widget" },
            facts = new[] { new { kind = "note", text = "the cache is warm; the index was missing", refs = new[] { new { rel = "supersedes", kind = "fact", target = old, basis = "observed" } } } },
        }).GetProperty("response").GetProperty("facts")[0].GetProperty("id").GetString()!;

        var verified = Call(second, "verify_facts", new { ids = new[] { old } }).GetProperty("facts")[0];
        await Assert.That(verified.GetProperty("status").GetString()).IsEqualTo("superseded");
        await Assert.That(verified.GetProperty("replaced_by").GetString()).IsEqualTo(correction);

        // Both writers stay on record: the old row keeps its author, the correction names its own.
        var oldActor = db.Store.Show(old)!.Fact.Provenance!.Value.GetProperty("actor").GetString();
        var newActor = db.Store.Show(correction)!.Fact.Provenance!.Value.GetProperty("actor").GetString();
        await Assert.That(oldActor).IsEqualTo("agent-a");
        await Assert.That(newActor).IsEqualTo("agent-b");
    }
}
