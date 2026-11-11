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
}
