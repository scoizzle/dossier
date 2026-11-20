using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// contract/ops.schema.json is the normative shape of verify_facts and changes. These tests hold what
/// the store really emits against those shapes, one response per status and page kind.
/// </summary>
public sealed class OpsContractTests
{
    private static JsonElement Emitted<T>(T value) =>
        JsonDocument.Parse(JsonSerializer.Serialize(value, JsonCodec.Options)).RootElement.Clone();

    private static string Errors(string definition, JsonElement instance) =>
        JsonlSchemaTests.ErrorsAgainstDefinition("ops.schema.json", definition, instance);

    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    [Test]
    public async Task VerifyResponse_MatchesTheContract_ForEveryStatus()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("input one", key: "input"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("derived", refs: new List<RefInput> { Fixtures.Ref(input, basis: "derived", rel: "derived_from") }));
        PostOne(db, "Widget", Fixtures.Fact("input two", key: "input"));
        var claim = PostOne(db, "Widget", Fixtures.Fact("a claim"));
        var refuter = PostOne(db, "Widget", Fixtures.Fact("an objection", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));
        var gone = PostOne(db, "Widget", Fixtures.Fact("withdrawn"));
        db.Store.Retract(gone);

        var response = db.Store.Verify(new VerifyRequest { Ids = { input, derived, claim, refuter, gone, "no-such-id" } });

        // The case really does cover every status the contract names.
        await Assert.That(response.Facts.Select(f => f.Status).ToList())
            .IsEquivalentTo(new[] { "superseded", "stale", "contested", "live", "retracted", "unknown" });
        await Assert.That(Errors("VerifyResponse", Emitted(response))).IsEqualTo(string.Empty);
        await Assert.That(Errors("VerifyRequest", Emitted(new VerifyRequest { Ids = { input, derived } }))).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task ChangesPage_MatchesTheContract_ForEveryPageKind()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Alpha", Fixtures.Fact("alpha one", key: "state"));
        PostOne(db, "Alpha", Fixtures.Fact("alpha two", key: "state", refs: new List<RefInput> { Fixtures.Ref(first) }));
        var gone = PostOne(db, "Beta", Fixtures.Fact("beta one"));
        db.Store.Retract(gone);

        var pages = new[]
        {
            db.Store.ReadChanges(0, 500),
            db.Store.ReadChanges(0, 2),
            db.Store.ReadChanges(0, 500, "Alpha"),
            db.Store.ReadChanges(0, 1, "Beta"),
            db.Store.ReadChangesLast(3),
            db.Store.ReadChangesLast(1, "Alpha"),
            db.Store.ReadChanges(db.Store.Revision() + 10, 100),
        };

        // Inserts, updates and deletes of every journalled table that this workload touches, and a reset.
        var kinds = pages[0].Changes.Select(row => row.Tbl + "/" + row.Op).ToHashSet();
        foreach (var expected in new[] { "subjects/insert", "facts/insert", "facts/update", "refs/insert", "slots/insert", "slots/update" })
        {
            await Assert.That(kinds.Contains(expected)).IsTrue();
        }

        await Assert.That(pages[^1].Reset).IsTrue();
        foreach (var page in pages)
        {
            await Assert.That(Errors("ChangesPage", Emitted(page))).IsEqualTo(string.Empty);
        }

        await Assert.That(Errors("ChangesRequest", Emitted(new ChangesRequest { Since = 4, Limit = 10, Subject = "Alpha" }))).IsEqualTo(string.Empty);
        await Assert.That(Errors("ChangesRequest", Emitted(new ChangesRequest { Last = 5 }))).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task TheValidationIsNotVacuous_AWrongShapeIsRejected()
    {
        JsonElement Parse(string json) => JsonDocument.Parse(json).RootElement.Clone();

        await Assert.That(Errors("VerifyResponse", Parse("""{"revision":1,"current":true,"facts":[{"id":"a","status":"fresh","current":true}]}""")))
            .Contains("not in enum");
        await Assert.That(Errors("VerifyResponse", Parse("""{"revision":1,"facts":[]}"""))).Contains("current");
        await Assert.That(Errors("VerifyResponse", Parse("""{"revision":1,"current":false,"facts":[{"id":"a","status":"stale","current":false,"why":[]}]}""")))
            .IsNotEqualTo(string.Empty);
        await Assert.That(Errors("VerifyRequest", Parse("""{"ids":[]}"""))).IsNotEqualTo(string.Empty);
        await Assert.That(Errors("ChangesPage", Parse("""{"from":0,"to":1,"next":1,"truncated":false,"reset":false,"changes":[{"seq":1,"tbl":"blobs","op":"insert","subject_id":null,"subject_name":null,"fact_id":null,"fact_kind":null,"fact_status":null,"text":null,"actor":null,"at":"t"}]}""")))
            .Contains("not in enum");
        await Assert.That(Errors("ChangesRequest", Parse("""{"since":-1}"""))).IsNotEqualTo(string.Empty);
        await Assert.That(Errors("ChangesRequest", Parse("""{"cursor":3}"""))).IsNotEqualTo(string.Empty);
    }
}
