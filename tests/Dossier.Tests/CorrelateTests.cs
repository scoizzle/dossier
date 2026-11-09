using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class CorrelateTests
{
    private static List<string> Post(TempDb db, params FactInput[] facts) =>
        db.Store.PostFacts(Fixtures.Post("Widget", facts)).Response.Facts.Select(fact => fact.Id).ToList();

    private static CorrelateRequest Request(params string[] matchers) => new()
    {
        Subject = "Widget",
        Matchers = matchers.ToList(),
    };

    private static RefInput External(string target) => Fixtures.Ref(target, kind: "url");

    [Test]
    public async Task Correlate_SameRef_Proposes()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            Fixtures.Fact("first body", refs: new List<RefInput> { External("https://example.test/x") }),
            Fixtures.Fact("second body", refs: new List<RefInput> { External("https://example.test/x") }));

        var response = db.Store.Correlate(Request("same_ref"));

        await Assert.That(response.Proposed.Count).IsEqualTo(2);
        var pairs = response.Proposed.Select(proposal => (proposal.FactId, proposal.Ref.Target)).ToList();
        await Assert.That(pairs.Contains((ids[0], ids[1]))).IsTrue();
        await Assert.That(pairs.Contains((ids[1], ids[0]))).IsTrue();

        foreach (var proposal in response.Proposed)
        {
            await Assert.That(proposal.Ref.Rel).IsEqualTo("mentions");
            await Assert.That(proposal.Ref.Kind).IsEqualTo("fact");
            await Assert.That(proposal.Ref.Basis).IsEqualTo("derived");
        }
    }

    [Test]
    public async Task Correlate_SharedTag_Proposes()
    {
        using var db = new TempDb();
        var ids = Post(
            db,
            Fixtures.Fact("first tagged", tags: new List<string> { "alpha" }),
            Fixtures.Fact("second tagged", tags: new List<string> { "alpha" }));

        var response = db.Store.Correlate(Request("shared_tag"));

        await Assert.That(response.Proposed.Count).IsEqualTo(2);
        var pairs = response.Proposed.Select(proposal => (proposal.FactId, proposal.Ref.Target)).ToList();
        await Assert.That(pairs.Contains((ids[0], ids[1]))).IsTrue();
        await Assert.That(pairs.Contains((ids[1], ids[0]))).IsTrue();
    }

    [Test]
    public async Task Correlate_NeverEmitsObservedBasis()
    {
        using var db = new TempDb();
        Post(
            db,
            Fixtures.Fact(
                "first body",
                refs: new List<RefInput> { External("https://example.test/x") },
                tags: new List<string> { "shared" }),
            Fixtures.Fact(
                "second body",
                refs: new List<RefInput> { External("https://example.test/x") },
                tags: new List<string> { "shared" }));

        var response = db.Store.Correlate(Request());

        await Assert.That(response.Proposed.Count).IsGreaterThan(0);
        foreach (var proposal in response.Proposed)
        {
            await Assert.That(proposal.Ref.Basis).IsEqualTo("derived");
            await Assert.That(proposal.Ref.Basis == "observed").IsFalse();
        }
    }

    [Test]
    public async Task Correlate_WritesNothing()
    {
        using var db = new TempDb();
        Post(
            db,
            Fixtures.Fact("first body", refs: new List<RefInput> { External("https://example.test/x") }),
            Fixtures.Fact("second body", refs: new List<RefInput> { External("https://example.test/x") }));

        long factsBefore;
        long refsBefore;
        using (var connection = db.Store.OpenConnection())
        {
            factsBefore = Fixtures.Count(connection, "SELECT COUNT(*) FROM facts");
            refsBefore = Fixtures.Count(connection, "SELECT COUNT(*) FROM refs");
        }

        var response = db.Store.Correlate(Request("same_ref"));

        long factsAfter;
        long refsAfter;
        using (var connection = db.Store.OpenConnection())
        {
            factsAfter = Fixtures.Count(connection, "SELECT COUNT(*) FROM facts");
            refsAfter = Fixtures.Count(connection, "SELECT COUNT(*) FROM refs");
        }

        await Assert.That(response.Proposed.Count).IsGreaterThan(0);
        await Assert.That(factsAfter).IsEqualTo(factsBefore);
        await Assert.That(refsAfter).IsEqualTo(refsBefore);
    }

    [Test]
    public async Task Correlate_IsDeterministic()
    {
        using var db = new TempDb();
        Post(
            db,
            Fixtures.Fact(
                "first body",
                refs: new List<RefInput> { External("https://example.test/x") },
                tags: new List<string> { "shared" }),
            Fixtures.Fact(
                "second body",
                refs: new List<RefInput> { External("https://example.test/x") },
                tags: new List<string> { "shared" }),
            Fixtures.Fact("third body", tags: new List<string> { "shared" }));

        var first = JsonSerializer.Serialize(db.Store.Correlate(Request()), JsonCodec.Options);
        var second = JsonSerializer.Serialize(db.Store.Correlate(Request()), JsonCodec.Options);

        await Assert.That(second).IsEqualTo(first);
    }

    [Test]
    public async Task Correlate_CapsAt200()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(0, 21)
            .Select(index => Fixtures.Fact($"bulk fact number {index} with a distinct body", tags: new List<string> { "bulk" }))
            .ToArray();
        Post(db, facts);

        var response = db.Store.Correlate(Request("shared_tag"));

        await Assert.That(response.Proposed.Count).IsEqualTo(200);
        await Assert.That(response.Truncated == true).IsTrue();

        var ordered = response.Proposed
            .Select(proposal => (proposal.FactId, proposal.Ref.Target))
            .ToList();
        var sorted = ordered
            .OrderBy(pair => pair.FactId, StringComparer.Ordinal)
            .ThenBy(pair => pair.Target, StringComparer.Ordinal)
            .ToList();
        await Assert.That(ordered.SequenceEqual(sorted)).IsTrue();
    }
}
