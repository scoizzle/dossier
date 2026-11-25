using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// A superseded fact's replacement is the live fact at the end of its chain of successors; a chain
/// that runs through a retraction ends there, and a later fact posted to the emptied slot is a new
/// claim rather than the old one's replacement.
/// </summary>
public sealed class ReplacementChainTests
{
    private static string PostOne(TempDb db, string subject, FactInput fact) =>
        db.Store.PostFacts(Fixtures.Post(subject, fact)).Response.Facts[0].Id;

    private static List<RefInput> DerivedFrom(params string[] ids) =>
        ids.Select(id => Fixtures.Ref(id, basis: "derived", rel: "derived_from")).ToList();

    private static VerifiedFact VerifyOne(TempDb db, string id) =>
        db.Store.Verify(new VerifyRequest { Ids = { id } }).Facts.Single();

    [Test]
    public async Task SupersededFact_WhoseChainEndsInARetraction_DoesNotNameALaterFactInTheSlot()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("version one", key: "state"));
        var second = PostOne(db, "Widget", Fixtures.Fact("version two", key: "state"));
        db.Store.Retract(second);
        var third = PostOne(db, "Widget", Fixtures.Fact("version three", key: "state"));

        var old = VerifyOne(db, first);
        await Assert.That(old.Status).IsEqualTo("superseded");
        await Assert.That(old.ReplacedBy).IsNull();

        // The new fact in the emptied slot is its own claim, not a replacement for the retracted chain.
        var current = VerifyOne(db, third);
        await Assert.That(current.Status).IsEqualTo("live");
        await Assert.That(current.ReplacedBy).IsNull();
    }

    [Test]
    public async Task DerivedFact_GoesStale_WhenASameTextRepostFollowsARetraction()
    {
        using var db = new TempDb();
        var first = PostOne(db, "Widget", Fixtures.Fact("the header is 64 pixels tall", key: "headerHeight"));
        var derived = PostOne(db, "Widget", Fixtures.Fact("the sidebar starts at 64 pixels", refs: DerivedFrom(first)));
        var second = PostOne(db, "Widget", Fixtures.Fact("the header is 72 pixels tall", key: "headerHeight"));
        db.Store.Retract(second);

        // Same text and key as the original, but posted after the chain was retracted, so it is a new
        // fact: the original's claim was withdrawn and the dependent fact still relied on it.
        PostOne(db, "Widget", Fixtures.Fact("the header is 64 pixels tall", key: "headerHeight"));

        var fact = VerifyOne(db, derived);
        await Assert.That(fact.Status).IsEqualTo("stale");
        await Assert.That(fact.Why!.Single().Rel).IsEqualTo("derived_from");
        await Assert.That(fact.Why!.Single().Fact).IsEqualTo(first);
        await Assert.That(fact.Why!.Single().State).IsEqualTo("superseded");
        await Assert.That(fact.Why!.Single().ReplacedBy).IsNull();
    }
}
