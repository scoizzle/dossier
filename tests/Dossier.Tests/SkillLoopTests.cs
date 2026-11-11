using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>Pins the store behaviour the SKILL.md "Document a source" loop relies on.</summary>
public sealed class SkillLoopTests
{
    private static FactInput Symbol(string key, string text) => Fixtures.Fact(
        text,
        key: key,
        refs: new List<RefInput> { Fixtures.Ref("src/Unit.cs", kind: "file", rel: "derived_from", rev: "abc123") });

    [Test]
    public async Task SymbolLoop_CorrelateScopeDescendantsAndCheck()
    {
        using var db = new TempDb();
        var unit = db.Store.PostFacts(Fixtures.Post("Unit.cs")).Response.Subject.Id;
        var a = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Unit.cs::A", Kind = "symbol", Parent = unit },
            Facts = { Symbol("a.role", "A parses the input") },
        }).Response.Facts[0].Id;
        var b = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Unit.cs::B", Kind = "symbol", Parent = unit },
            Facts = { Symbol("b.role", "B renders the output") },
        }).Response.Facts[0].Id;

        // (a) --subject <unit> sees only the unit's own (zero) facts.
        var scoped = db.Store.Correlate(new CorrelateRequest { Subject = "Unit.cs" });
        await Assert.That(scoped.Proposed.Count).IsEqualTo(0);

        // (b) store-wide correlate links the two child facts via the shared file ref.
        var wide = db.Store.Correlate(new CorrelateRequest());
        await Assert.That(wide.Proposed.Count).IsGreaterThanOrEqualTo(1);
        var pairs = wide.Proposed.Select(p => (p.FactId, p.Ref.Target)).ToList();
        await Assert.That(pairs.Contains((a, b)) || pairs.Contains((b, a))).IsTrue();

        // (c) compile with descendants includes both child facts.
        var compiled = db.Store.Compile(new CompileRequest { Subject = "Unit.cs", Depth = "full", Descendants = true });
        var emitted = compiled.Facts.Select(f => f.Id).ToHashSet();
        await Assert.That(emitted.Contains(a)).IsTrue();
        await Assert.That(emitted.Contains(b)).IsTrue();

        // (d) check on a symbol subject is an exact_name match.
        var check = db.Store.Check(new CheckRequest { Subject = "Unit.cs::A" });
        await Assert.That(check.Subject!.Match).IsEqualTo("exact_name");
    }

    private static string PostSymbol(TempDb db, string unit, string name, params FactInput[] facts) =>
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = name, Kind = "symbol", Parent = unit },
            Facts = facts.ToList(),
        }).Response.Subject.Id;

    [Test]
    public async Task SubjectScopedCorrelate_ProposesOnlyWithinThatSubject()
    {
        // Characterization: green on arrival.
        using var db = new TempDb();
        var unit = db.Store.PostFacts(Fixtures.Post("Unit.cs")).Response.Subject.Id;
        var a = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Unit.cs::A", Kind = "symbol", Parent = unit },
            Facts = { Symbol("a.one", "A parses"), Symbol("a.two", "A validates") },
        }).Response.Facts.Select(f => f.Id).ToHashSet();
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Unit.cs::B", Kind = "symbol", Parent = unit },
            Facts = { Symbol("b.one", "B renders") },
        });

        var response = db.Store.Correlate(new CorrelateRequest { Subject = "Unit.cs::A" });

        await Assert.That(response.Proposed.Count).IsGreaterThan(0);
        await Assert.That(response.Proposed.All(p => a.Contains(p.FactId) && a.Contains(p.Ref.Target!))).IsTrue();
    }

    [Test]
    public async Task SharedTagMatcher_NeedsSharedTags_SameRefIgnoresThem()
    {
        // Characterization: green on arrival.
        using var db = new TempDb();
        var unit = db.Store.PostFacts(Fixtures.Post("Unit.cs")).Response.Subject.Id;
        PostSymbol(db, unit, "Unit.cs::Tagged",
            Fixtures.Fact("one", key: "t1", tags: new List<string> { "shared" }),
            Fixtures.Fact("two", key: "t2", tags: new List<string> { "shared" }));
        // Distinct locators: same_ref must still pair them (it ignores the locator).
        PostSymbol(db, unit, "Unit.cs::Plain",
            Fixtures.Fact("plain one", key: "p1", refs: new List<RefInput>
            {
                new() { Rel = "derived_from", Kind = "file", Target = "src/Unit.cs", Basis = "observed", Rev = "abc123", Locator = Fixtures.Json("{\"line\":1}") },
            }),
            Fixtures.Fact("plain two", key: "p2", refs: new List<RefInput>
            {
                new() { Rel = "derived_from", Kind = "file", Target = "src/Unit.cs", Basis = "observed", Rev = "abc123", Locator = Fixtures.Json("{\"line\":99}") },
            }));

        var tagged = db.Store.Correlate(new CorrelateRequest { Subject = "Unit.cs::Tagged", Matchers = new List<string> { "shared_tag" } });
        var plainTag = db.Store.Correlate(new CorrelateRequest { Subject = "Unit.cs::Plain", Matchers = new List<string> { "shared_tag" } });
        var plainRef = db.Store.Correlate(new CorrelateRequest { Subject = "Unit.cs::Plain", Matchers = new List<string> { "same_ref" } });

        await Assert.That(tagged.Proposed.Count).IsGreaterThan(0);
        await Assert.That(plainTag.Proposed.Count).IsEqualTo(0);
        await Assert.That(plainRef.Proposed.Count).IsGreaterThan(0);
    }

    [Test]
    public async Task ShowTakesFactId_SubjectNameComesFromCheckById()
    {
        // Characterization: green on arrival.
        using var db = new TempDb();
        var unit = db.Store.PostFacts(Fixtures.Post("Unit.cs")).Response.Subject.Id;
        var post = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Unit.cs::A", Kind = "symbol", Parent = unit },
            Facts = { Symbol("a.role", "A parses the input") },
        }).Response;
        var subjectId = post.Subject.Id;
        var factId = post.Facts[0].Id;

        var shown = db.Store.Show(factId)!;
        var json = System.Text.Json.JsonSerializer.Serialize(shown, JsonCodec.Options);
        await Assert.That(json.Contains("Unit.cs::A", StringComparison.Ordinal)).IsFalse();

        var check = db.Store.Check(new CheckRequest { Subject = subjectId });
        await Assert.That(check.Subject!.Name).IsEqualTo("Unit.cs::A");
        await Assert.That(check.Subject!.Match).IsEqualTo("exact_id");
    }
}
