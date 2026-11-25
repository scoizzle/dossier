using System.Text.Json;
using System.Text.Json.Nodes;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// contract/fact.schema.json describes the fact record a read returns: a superseded fact carries
/// <c>replaced_by</c>, and a stale or contested one carries <c>why</c> in the same StatusReason
/// shape verify_facts uses. A published bundle record carries the stored status only, so
/// contract/jsonl-record.schema.json leaves both out.
/// </summary>
public sealed class FactContractTests
{
    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    private static async Task<string> PostStaleAsync(TempDb db)
    {
        var input = PostOne(db, "Widget", Fixtures.Fact("timeout is 10 seconds", key: "timeout"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("retries fit in 30 seconds", refs: new List<RefInput> { Fixtures.Ref(input, basis: "derived", rel: "derived_from") }));
        PostOne(db, "Widget", Fixtures.Fact("timeout is 20 seconds", key: "timeout"));
        await Assert.That(db.Store.Show(derived)!.Fact.Status).IsEqualTo("stale");
        return derived;
    }

    /// <summary>
    /// The fact object a read returns, exactly as show serializes it, held to contract/fact.schema.json.
    /// Every property it carries, the store's insertion clock <c>created_at</c> included, must be one the
    /// contract declares, so no field of a real read can drift out of the contract unnoticed.
    /// </summary>
    private static async Task<JsonElement> ContractFact(TempDb db, string id)
    {
        var show = JsonNode.Parse(JsonSerializer.Serialize(db.Store.Show(id), JsonCodec.Options))!.AsObject();
        var fact = show["fact"]!.AsObject();

        var declared = JsonlSchemaTests.ContractDocument("fact.schema.json")
            .GetProperty("properties")
            .EnumerateObject()
            .Select(property => property.Name)
            .ToHashSet(StringComparer.Ordinal);
        var extra = fact.Select(pair => pair.Key)
            .Where(name => !declared.Contains(name))
            .OrderBy(name => name, StringComparer.Ordinal);
        await Assert.That(string.Join(",", extra)).IsEqualTo(string.Empty);

        return JsonDocument.Parse(fact.ToJsonString()).RootElement.Clone();
    }

    private static string Errors(JsonElement fact) => JsonlSchemaTests.ErrorsAgainstDocument("fact.schema.json", fact);

    [Test]
    public async Task ASupersededFact_CarriesReplacedBy_AndMatchesTheContract()
    {
        using var db = new TempDb();
        var old = PostOne(db, "Widget", Fixtures.Fact("version one"));
        var correction = PostOne(db, "Widget", Fixtures.Fact("version two", refs: new List<RefInput> { Fixtures.Ref(old, rel: "supersedes") }));

        var fact = await ContractFact(db, old);
        await Assert.That(fact.GetProperty("status").GetString()).IsEqualTo("superseded");
        await Assert.That(fact.GetProperty("replaced_by").GetString()).IsEqualTo(correction);
        await Assert.That(Errors(fact)).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task AStaleFact_CarriesWhy_AndMatchesTheContract()
    {
        using var db = new TempDb();
        var input = PostOne(db, "Widget", Fixtures.Fact("timeout is 10 seconds", key: "timeout"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("retries fit in 30 seconds", refs: new List<RefInput> { Fixtures.Ref(input, basis: "derived", rel: "derived_from") }));
        var revised = PostOne(db, "Widget", Fixtures.Fact("timeout is 20 seconds", key: "timeout"));

        var fact = await ContractFact(db, derived);
        await Assert.That(fact.GetProperty("status").GetString()).IsEqualTo("stale");
        var reason = fact.GetProperty("why")[0];
        await Assert.That(reason.GetProperty("rel").GetString()).IsEqualTo("derived_from");
        await Assert.That(reason.GetProperty("fact").GetString()).IsEqualTo(input);
        await Assert.That(reason.GetProperty("state").GetString()).IsEqualTo("superseded");
        await Assert.That(reason.GetProperty("replaced_by").GetString()).IsEqualTo(revised);
        await Assert.That(Errors(fact)).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task AContestedFact_CarriesTheOtherParty_AndMatchesTheContract()
    {
        using var db = new TempDb();
        var claim = PostOne(db, "Widget", Fixtures.Fact("a claim"));
        var refuter = PostOne(db, "Widget", Fixtures.Fact("an objection", refs: new List<RefInput> { Fixtures.Ref(claim, rel: "refutes") }));

        var fact = await ContractFact(db, claim);
        await Assert.That(fact.GetProperty("status").GetString()).IsEqualTo("contested");
        var reason = fact.GetProperty("why")[0];
        await Assert.That(reason.GetProperty("rel").GetString()).IsEqualTo("refutes");
        await Assert.That(reason.GetProperty("fact").GetString()).IsEqualTo(refuter);
        await Assert.That(reason.TryGetProperty("state", out _)).IsFalse();
        await Assert.That(Errors(fact)).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task TheContractIsNotVacuous_AWrongReasonIsRejected()
    {
        using var db = new TempDb();
        var stale = await PostStaleAsync(db);

        var fact = JsonNode.Parse(JsonSerializer.Serialize(db.Store.Show(stale), JsonCodec.Options))!["fact"]!.AsObject();
        fact["why"]![0]!["rel"] = "because";

        var errors = Errors(JsonDocument.Parse(fact.ToJsonString()).RootElement.Clone());
        await Assert.That(errors).Contains("not in enum");
    }
}
