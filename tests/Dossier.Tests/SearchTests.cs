using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class SearchTests
{
    [Test]
    public async Task FtsMatch_ReturnsTextAndTagHits()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("alpha appears in the body", tags: new List<string> { "other" }),
            Fixtures.Fact("unrelated body words", tags: new List<string> { "alpha" })));
        var textId = posted.Response.Facts[0].Id;
        var tagId = posted.Response.Facts[1].Id;

        var result = db.Store.Search(new SearchRequest { Q = "alpha" });
        var ids = result.Hits.Select(hit => hit.Id).ToList();

        await Assert.That(ids.Contains(textId)).IsTrue();
        await Assert.That(ids.Contains(tagId)).IsTrue();
        await Assert.That(result.Total).IsEqualTo(2);
    }

    [Test]
    public async Task Bm25_WeightsTextAboveTags()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("alpha beta gamma delta", tags: new List<string> { "zeta" }),
            Fixtures.Fact("beta gamma delta omega", tags: new List<string> { "alpha" })));
        var textId = posted.Response.Facts[0].Id;
        var tagId = posted.Response.Facts[1].Id;

        var result = db.Store.Search(new SearchRequest { Q = "alpha" });
        var textHit = result.Hits.Single(hit => hit.Id == textId);
        var tagHit = result.Hits.Single(hit => hit.Id == tagId);

        await Assert.That(textHit.Score).IsNotNull();
        await Assert.That(tagHit.Score).IsNotNull();
        // bm25 is more negative for a better match; text weight 10 must beat tag weight 3.
        await Assert.That(textHit.Score!.Value < tagHit.Score!.Value).IsTrue();
        await Assert.That(result.Hits[0].Id).IsEqualTo(textId);
    }

    [Test]
    public async Task SubjectFilter_MatchesAliasCasefold()
    {
        using var db = new TempDb();
        var created = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Memos UI", Kind = "app", Aliases = new List<string> { "Memos" } },
            Facts = new List<FactInput> { Fixtures.Fact("alias searchable") },
        });
        var factId = created.Response.Facts[0].Id;

        var byName = db.Store.Search(new SearchRequest { Subject = "  MEMOS   ui " });
        var byAlias = db.Store.Search(new SearchRequest { Subject = "memos" });

        await Assert.That(byName.Hits.Count).IsEqualTo(1);
        await Assert.That(byName.Hits[0].Id).IsEqualTo(factId);
        await Assert.That(byAlias.Hits.Count).IsEqualTo(1);
        await Assert.That(byAlias.Hits[0].Id).IsEqualTo(factId);
    }

    [Test]
    public async Task RefTarget_In_FindsReferencingFacts()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the target fact", localId: "t"),
            Fixtures.Fact("the pointer fact", refs: new List<RefInput> { Fixtures.Ref("@t") })));
        var targetId = posted.Response.Facts[0].Id;
        var pointerId = posted.Response.Facts[1].Id;

        var result = db.Store.Search(new SearchRequest { RefTarget = targetId, Direction = "in" });

        await Assert.That(result.Hits.Count).IsEqualTo(1);
        await Assert.That(result.Hits[0].Id).IsEqualTo(pointerId);
    }

    [Test]
    public async Task RefTarget_Out_FindsReferencedFacts()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the target fact", localId: "t"),
            Fixtures.Fact("the pointer fact", refs: new List<RefInput> { Fixtures.Ref("@t") })));
        var targetId = posted.Response.Facts[0].Id;
        var pointerId = posted.Response.Facts[1].Id;

        var result = db.Store.Search(new SearchRequest { RefTarget = pointerId, Direction = "out" });

        await Assert.That(result.Hits.Count).IsEqualTo(1);
        await Assert.That(result.Hits[0].Id).IsEqualTo(targetId);
    }

    [Test]
    public async Task RefTarget_Out_RejectsExternalTarget()
    {
        using var db = new TempDb();

        DossierRequestException? caught = null;
        try
        {
            db.Store.Search(new SearchRequest { RefTarget = "https://example.test/x", Direction = "out" });
        }
        catch (DossierRequestException exception)
        {
            caught = exception;
        }

        await Assert.That(caught).IsNotNull();
        await Assert.That(caught!.Code).IsEqualTo("ref_target_not_internal");
    }

    [Test]
    public async Task Superseded_ExcludedByDefault()
    {
        using var db = new TempDb();
        var first = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version one", key: "state")));
        var second = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version two", key: "state")));
        var oldId = first.Response.Facts[0].Id;
        var newId = second.Response.Facts[0].Id;

        var result = db.Store.Search(new SearchRequest());
        var ids = result.Hits.Select(hit => hit.Id).ToList();

        await Assert.That(ids.Contains(oldId)).IsFalse();
        await Assert.That(ids.Contains(newId)).IsTrue();
    }

    [Test]
    public async Task StatusFilter_ReturnsOnlyThatStatus()
    {
        using var db = new TempDb();
        var first = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version one", key: "state")));
        var second = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version two", key: "state")));
        var oldId = first.Response.Facts[0].Id;
        var newId = second.Response.Facts[0].Id;

        var superseded = db.Store.Search(new SearchRequest { Status = "superseded" });
        var live = db.Store.Search(new SearchRequest { Status = "live" });

        await Assert.That(superseded.Hits.Count).IsEqualTo(1);
        await Assert.That(superseded.Hits[0].Id).IsEqualTo(oldId);
        await Assert.That(live.Hits.Count).IsEqualTo(1);
        await Assert.That(live.Hits[0].Id).IsEqualTo(newId);
    }

    [Test]
    public async Task LimitAndCursor_PageWithoutOverlap()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("page fact one"),
            Fixtures.Fact("page fact two"),
            Fixtures.Fact("page fact three"),
            Fixtures.Fact("page fact four"),
            Fixtures.Fact("page fact five")));

        var seen = new List<string>();
        string? cursor = null;
        var complete = false;

        for (var page = 0; page < 10; page++)
        {
            var result = db.Store.Search(new SearchRequest { Limit = 2, Cursor = cursor });
            seen.AddRange(result.Hits.Select(hit => hit.Id));
            cursor = result.Next;
            complete = result.Complete;
            if (cursor is null)
            {
                break;
            }
        }

        await Assert.That(seen.Count).IsEqualTo(5);
        await Assert.That(seen.Distinct().Count()).IsEqualTo(5);
        await Assert.That(complete).IsTrue();
    }

    [Test]
    public async Task TotalIsPreLimit()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("total fact one"),
            Fixtures.Fact("total fact two"),
            Fixtures.Fact("total fact three"),
            Fixtures.Fact("total fact four"),
            Fixtures.Fact("total fact five")));

        var result = db.Store.Search(new SearchRequest { Limit = 2 });

        await Assert.That(result.Hits.Count).IsEqualTo(2);
        await Assert.That(result.Total).IsEqualTo(5);
        await Assert.That(result.Complete).IsFalse();
    }

    [Test]
    public async Task CompleteFalseWhenTruncated()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("truncated one"),
            Fixtures.Fact("truncated two"),
            Fixtures.Fact("truncated three")));

        var result = db.Store.Search(new SearchRequest { Limit = 1 });

        await Assert.That(result.Complete).IsFalse();
        await Assert.That(result.Refine).IsNotNull();
        await Assert.That(result.Refine!.Contains("subject", StringComparison.Ordinal)).IsTrue();
        await Assert.That(result.Next).IsNotNull();
    }

    [Test]
    public async Task FactView_SearchHasScoreAndNullSection()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("the needle in the haystack")));

        var result = db.Store.Search(new SearchRequest { Q = "needle" });

        await Assert.That(result.Hits.Count).IsEqualTo(1);
        await Assert.That(result.Hits[0].Score).IsNotNull();
        await Assert.That(result.Hits[0].Section).IsNull();
        await Assert.That(result.Hits[0].Cites).IsNull();
    }

    [Test]
    public async Task Search_DefaultExcludesRetracted()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("retracted fact body"),
            Fixtures.Fact("kept fact body")));
        var retractedId = posted.Response.Facts[0].Id;
        var keptId = posted.Response.Facts[1].Id;

        db.Store.Retract(retractedId);
        var result = db.Store.Search(new SearchRequest());
        var ids = result.Hits.Select(hit => hit.Id).ToList();

        await Assert.That(ids.Contains(retractedId)).IsFalse();
        await Assert.That(ids.Contains(keptId)).IsTrue();
    }

    [Test]
    public async Task Show_ReturnsRefsAttachmentsAndInbound()
    {
        using var db = new TempDb();
        var sha = new string('c', 64);
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("shown target fact", localId: "t"),
            Fixtures.Fact(
                "shown pointer fact",
                refs: new List<RefInput> { Fixtures.Ref("@t") },
                attachments: new List<AttachmentInput>
                {
                    new() { Sha256 = sha, Filename = "c.txt", Mime = "text/plain", Bytes = 7 },
                })));
        var targetId = posted.Response.Facts[0].Id;
        var pointerId = posted.Response.Facts[1].Id;

        var target = db.Store.Show(targetId);
        var pointer = db.Store.Show(pointerId);

        await Assert.That(target).IsNotNull();
        await Assert.That(target!.Fact.Id).IsEqualTo(targetId);
        await Assert.That(target.Inbound.Count).IsEqualTo(1);
        await Assert.That(target.Inbound[0].Id).IsEqualTo(pointerId);
        await Assert.That(pointer).IsNotNull();
        await Assert.That(pointer!.Refs.Count).IsEqualTo(1);
        await Assert.That(pointer.Refs[0].Target).IsEqualTo(targetId);
        await Assert.That(pointer.Attachments.Count).IsEqualTo(1);
        await Assert.That(pointer.Attachments[0].Sha256).IsEqualTo(sha);
    }

    [Test]
    public async Task Show_UnknownIdReturnsNull()
    {
        using var db = new TempDb();

        var shown = db.Store.Show("no-such-fact");

        await Assert.That(shown).IsNull();
    }

    [Test]
    public async Task SearchBrief_ReturnsOneLinePerHitWithNoExtraFields()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("alpha " + new string('x', 300), tags: new List<string> { "t" }),
            Fixtures.Fact("alpha short")));

        var json = Ops.Search(db.Store, new SearchRequest { Q = "alpha", Brief = true });
        var root = System.Text.Json.JsonDocument.Parse(json).RootElement;
        var hits = root.GetProperty("hits").EnumerateArray().ToList();

        await Assert.That(hits.Count).IsEqualTo(2);
        foreach (var hit in hits)
        {
            var names = hit.EnumerateObject().Select(p => p.Name).OrderBy(n => n).ToList();
            await Assert.That(names).IsEquivalentTo(new[] { "id", "kind", "status", "text" });
            await Assert.That(hit.GetProperty("text").GetString()!.Length <= 121).IsTrue();
        }

        var longHit = hits.Single(h => h.GetProperty("text").GetString()!.EndsWith('…'));
        await Assert.That(longHit.GetProperty("text").GetString()!.Length).IsEqualTo(121);
    }

    [Test]
    public async Task SearchBrief_KeepsTotalAndCursor()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Enumerable.Range(0, 5).Select(i => Fixtures.Fact($"note number {i}")).ToArray()));

        var full = db.Store.Search(new SearchRequest { Subject = "Widget", Limit = 2 });
        var brief = db.Store.SearchBrief(new SearchRequest { Subject = "Widget", Limit = 2, Brief = true });

        await Assert.That(brief.Total).IsEqualTo(full.Total);
        await Assert.That(brief.Complete).IsEqualTo(full.Complete);
        await Assert.That(brief.Next).IsEqualTo(full.Next);
        await Assert.That(brief.Next).IsNotNull();
        await Assert.That(brief.Hits.Select(h => h.Id).ToList()).IsEquivalentTo(full.Hits.Select(h => h.Id).ToList());

        var page2 = db.Store.SearchBrief(new SearchRequest { Subject = "Widget", Limit = 2, Brief = true, Cursor = brief.Next });
        await Assert.That(page2.Hits.Count).IsEqualTo(2);
    }

    [Test]
    public async Task Resolve_MatchesNameAliasPrefixAndFuzzy()
    {
        using var db = new TempDb();
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Billing", Aliases = new List<string> { "Invoices" } }, Facts = { Fixtures.Fact("a") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Payments", Aliases = new List<string> { "Billing Core" } }, Facts = { Fixtures.Fact("b") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Billing Gateway" }, Facts = { Fixtures.Fact("c") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Biling" }, Facts = { Fixtures.Fact("d") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Unrelated" }, Facts = { Fixtures.Fact("e") } });

        var result = db.Store.ResolveSubjects("  BILLING ");
        var labels = result.Select(m => (m.Name, m.Match)).ToList();

        await Assert.That(labels).IsEquivalentTo(new[]
        {
            ("Billing", "exact_name"),
            ("Billing Gateway", "prefix"),
            ("Payments", "prefix"),
            ("Biling", "fuzzy"),
        });
        await Assert.That(result.Select(m => m.Match).ToList()).IsEquivalentTo(new[] { "exact_name", "prefix", "prefix", "fuzzy" });
        await Assert.That(result[0].Facts).IsEqualTo(1);
        await Assert.That(result[0].Aliases.Contains("Invoices")).IsTrue();

        var alias = db.Store.ResolveSubjects("invoices");
        await Assert.That(alias.Single().Match).IsEqualTo("exact_alias");
    }

    [Test]
    public async Task Resolve_NoMatchReturnsEmptyListWithoutError()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("a")));

        await Assert.That(db.Store.ResolveSubjects("zzzzzzzzzz").Count).IsEqualTo(0);
        await Assert.That(db.Store.ResolveSubjects("").Count).IsEqualTo(0);
        await Assert.That(Ops.ResolveSubject(db.Store, "zzzzzzzzzz")).IsEqualTo("[]");
    }
}
