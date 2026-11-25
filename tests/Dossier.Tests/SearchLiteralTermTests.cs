using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// A plain-text q is searched literally: a term FTS5 would misread as syntax (a hyphen, a colon, a
/// dot, a slash) is quoted before the query runs, and real FTS5 syntax keeps working.
/// </summary>
public sealed class SearchLiteralTermTests
{
    private static List<string> Texts(TempDb db, string q) =>
        db.Store.Search(new SearchRequest { Q = q, Limit = 50 }).Hits.Select(hit => hit.Text).OrderBy(text => text, StringComparer.Ordinal).ToList();

    private static TempDb Seeded()
    {
        var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("Self-taught programmer since 2007"),
            Fixtures.Fact("Was taught by a mentor, not self study"),
            Fixtures.Fact("Service runs in region us-east-1"),
            Fixtures.Fact("Service runs in region eu-west-1"),
            Fixtures.Fact("Pinned to version 1.2.3 of the client"),
            Fixtures.Fact("Symbol Unit.cs::Parse reads the input"),
            Fixtures.Fact("Source lives at src/Dossier/Search.cs"),
            Fixtures.Fact("alpha and beta together", tags: new List<string> { "ui-kit" }),
            Fixtures.Fact("gamma alone", tags: new List<string> { "ui" })));
        return db;
    }

    [Test]
    [Arguments("Self-taught", "Self-taught programmer since 2007")]
    [Arguments("self-taught programmer", "Self-taught programmer since 2007")]
    [Arguments("us-east-1", "Service runs in region us-east-1")]
    [Arguments("region us-east-1", "Service runs in region us-east-1")]
    [Arguments("1.2.3", "Pinned to version 1.2.3 of the client")]
    [Arguments("Unit.cs::Parse", "Symbol Unit.cs::Parse reads the input")]
    [Arguments("src/Dossier/Search.cs", "Source lives at src/Dossier/Search.cs")]
    [Arguments("self-tau*", "Self-taught programmer since 2007")]
    [Arguments("tags:ui-kit", "alpha and beta together")]
    public async Task ATermFts5WouldMisread_IsSearchedAsWritten(string q, string expected)
    {
        using var db = Seeded();

        var texts = Texts(db, q);

        await Assert.That(texts.Count).IsEqualTo(1);
        await Assert.That(texts[0]).IsEqualTo(expected);
    }

    [Test]
    [Arguments("C++", "Uses C++ for the parser")]
    [Arguments("a*b", "glob a*b matches every file")]
    [Arguments("*foo", "*foo is not a glob here")]
    [Arguments("x^2", "x^2 means squared")]
    public async Task OperatorCharacters_AreSearchedAsWritten(string q, string expected)
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("Uses C++ for the parser"),
            Fixtures.Fact("glob a*b matches every file"),
            Fixtures.Fact("*foo is not a glob here"),
            Fixtures.Fact("x^2 means squared")));

        var texts = Texts(db, q);

        await Assert.That(texts.Count).IsEqualTo(1);
        await Assert.That(texts[0]).IsEqualTo(expected);
    }

    [Test]
    public async Task Fts5Syntax_StillWorks()
    {
        using var db = Seeded();

        await Assert.That(Texts(db, "alpha OR gamma").Count).IsEqualTo(2);
        await Assert.That(Texts(db, "alpha AND beta").Single()).IsEqualTo("alpha and beta together");
        await Assert.That(Texts(db, "alpha NOT beta").Count).IsEqualTo(0);
        await Assert.That(Texts(db, "\"taught by a mentor\"").Single()).IsEqualTo("Was taught by a mentor, not self study");
        await Assert.That(Texts(db, "ment*").Single()).IsEqualTo("Was taught by a mentor, not self study");
        await Assert.That(Texts(db, "^gamma").Single()).IsEqualTo("gamma alone");
        await Assert.That(Texts(db, "tags:ui").Count).IsEqualTo(2);
        await Assert.That(Texts(db, "text:gamma").Single()).IsEqualTo("gamma alone");
        await Assert.That(Texts(db, "(alpha OR gamma) NOT beta").Single()).IsEqualTo("gamma alone");
        await Assert.That(Texts(db, "\"Self-taught\"").Single()).IsEqualTo("Self-taught programmer since 2007");
        await Assert.That(Texts(db, "us-east-1 OR eu-west-1").Count).IsEqualTo(2);
    }

    [Test]
    public async Task AQueryThatIsStillInvalid_IsReportedAsInvalidQuery()
    {
        using var db = Seeded();

        string? code = null;
        try
        {
            db.Store.Search(new SearchRequest { Q = "\"unbalanced quote" });
        }
        catch (DossierRequestException exception)
        {
            code = exception.Code;
        }

        await Assert.That(code).IsEqualTo("invalid_query");
    }
}
