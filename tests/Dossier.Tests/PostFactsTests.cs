using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class PostFactsTests
{
    [Test]
    public async Task Insert_PersistsFactWithLiveStatusAndHash()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("hello world")));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(1);
        var fact = result.Response.Facts[0];
        await Assert.That(fact.Status).IsEqualTo("new");

        using var connection = db.Store.OpenConnection();
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT text FROM facts WHERE id = $id", ("$id", fact.Id)))
            .IsEqualTo("hello world");
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT status FROM facts WHERE id = $id", ("$id", fact.Id)))
            .IsEqualTo("live");
        var hash = (string?)Fixtures.Scalar(connection, "SELECT content_hash FROM facts WHERE id = $id", ("$id", fact.Id));
        await Assert.That(hash).IsNotNull();
        await Assert.That(hash!.Length).IsEqualTo(64);
    }

    [Test]
    public async Task ContentDedupe_ReturnsTheSameId()
    {
        using var db = new TempDb();

        var first = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("the same words")));
        var second = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("the same words")));

        var firstId = first.Response.Facts[0].Id;
        await Assert.That(first.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(second.Response.Facts[0].Status).IsEqualTo("deduped");
        await Assert.That(second.Response.Facts[0].Id).IsEqualTo(firstId);
        await Assert.That(second.Response.Facts[0].DuplicateOf).IsEqualTo(firstId);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(1);
    }

    [Test]
    public async Task KeySupersede_ReturnsReplacedAndFlipsTheOldStatus()
    {
        using var db = new TempDb();

        var first = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version one", key: "state")));
        var second = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("version two", key: "state")));

        var oldId = first.Response.Facts[0].Id;
        var newId = second.Response.Facts[0].Id;
        await Assert.That(second.Response.Facts[0].Status).IsEqualTo("replaced");
        await Assert.That(second.Response.Facts[0].Replaced).IsEqualTo(oldId);
        await Assert.That(newId).IsNotEqualTo(oldId);

        using var connection = db.Store.OpenConnection();
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT status FROM facts WHERE id = $id", ("$id", oldId)))
            .IsEqualTo("superseded");
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT fact_id FROM slots WHERE subject_id = $s AND kind = 'note' AND key = 'state'", ("$s", second.Response.Subject.Id)))
            .IsEqualTo(newId);
    }

    [Test]
    public async Task ContentHash_ExcludesRevAndOtherFreshnessFields()
    {
        using var db = new TempDb();

        var first = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("same body", refs: new List<RefInput> { Fixtures.Ref("https://example.test/x", rev: "rev-1") })));
        var second = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("same body", refs: new List<RefInput> { Fixtures.Ref("https://example.test/x", rev: "rev-2") })));

        await Assert.That(first.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(second.Response.Facts[0].Status).IsEqualTo("deduped");
        await Assert.That(second.Response.Facts[0].Id).IsEqualTo(first.Response.Facts[0].Id);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(1);
    }

    [Test]
    public async Task LongText_400Chars_SurvivesIntact()
    {
        using var db = new TempDb();
        var text = new string('x', 400);

        var result = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact(text)));

        using var connection = db.Store.OpenConnection();
        var stored = (string?)Fixtures.Scalar(connection, "SELECT text FROM facts WHERE id = $id", ("$id", result.Response.Facts[0].Id));
        await Assert.That(stored).IsEqualTo(text);
        await Assert.That(stored!.Length).IsEqualTo(400);
        await Assert.That(stored.EndsWith("...", StringComparison.Ordinal)).IsFalse();
    }

    [Test]
    public async Task SubjectCreated_IsTrueOnlyOnFirstInsert()
    {
        using var db = new TempDb();

        var first = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("one")));
        var second = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("two")));

        await Assert.That(first.Response.Subject.Created).IsTrue();
        await Assert.That(second.Response.Subject.Created).IsFalse();
        await Assert.That(second.Response.Subject.Id).IsEqualTo(first.Response.Subject.Id);
    }

    [Test]
    public async Task AliasCasefold_UpsertMatchesNameAndAlias()
    {
        using var db = new TempDb();
        var created = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Memos UI", Kind = "app", Aliases = new List<string> { "Memos" } },
            Facts = new List<FactInput> { Fixtures.Fact("one") },
        });

        var byName = db.Store.PostFacts(Fixtures.Post("  memos   ui ", Fixtures.Fact("two")));
        var byAlias = db.Store.PostFacts(Fixtures.Post("MEMOS", Fixtures.Fact("three")));

        await Assert.That(byName.Response.Subject.Created).IsFalse();
        await Assert.That(byName.Response.Subject.Id).IsEqualTo(created.Response.Subject.Id);
        await Assert.That(byAlias.Response.Subject.Created).IsFalse();
        await Assert.That(byAlias.Response.Subject.Id).IsEqualTo(created.Response.Subject.Id);
    }

    [Test]
    public async Task Subject_MayBeSuppliedById()
    {
        using var db = new TempDb();

        var created = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Widget" },
            Facts = new List<FactInput> { Fixtures.Fact("one") },
        });
        var subjectId = created.Response.Subject.Id;
        var reused = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Id = subjectId },
            Facts = new List<FactInput> { Fixtures.Fact("two") },
        });

        await Assert.That(created.Response.Subject.Created).IsTrue();
        await Assert.That(reused.Response.Subject.Id).IsEqualTo(subjectId);
        await Assert.That(reused.Response.Subject.Created).IsFalse();
    }

    [Test]
    public async Task Subject_UnknownId_IsRejectedAndNotCreated()
    {
        using var db = new TempDb();

        DossierRequestException? caught = null;
        try
        {
            db.Store.PostFacts(new PostFactsRequest
            {
                Subject = new SubjectInput { Id = "subject-that-does-not-exist" },
                Facts = new List<FactInput> { Fixtures.Fact("should not land") },
            });
        }
        catch (DossierRequestException exception)
        {
            caught = exception;
        }

        await Assert.That(caught).IsNotNull();
        await Assert.That(caught!.Code).IsEqualTo("subject_not_found");

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects")).IsEqualTo(0);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(0);
    }

    [Test]
    public async Task Batch_Repost_Dedupes_WithLocalIds()
    {
        using var db = new TempDb();

        PostFactsRequest Batch() => Fixtures.Post(
            "Widget",
            Fixtures.Fact("the first fact", localId: "x"),
            Fixtures.Fact("the second fact", refs: new List<RefInput> { Fixtures.Ref("@x") }));

        var first = db.Store.PostFacts(Batch());
        var second = db.Store.PostFacts(Batch());

        var firstTargetId = first.Response.Facts[0].Id;
        var firstPointerId = first.Response.Facts[1].Id;

        await Assert.That(first.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(first.Response.Facts[1].Status).IsEqualTo("new");
        await Assert.That(second.Response.Facts[0].Status).IsEqualTo("deduped");
        await Assert.That(second.Response.Facts[1].Status).IsEqualTo("deduped");
        await Assert.That(second.Response.Facts[0].Id).IsEqualTo(firstTargetId);
        await Assert.That(second.Response.Facts[1].Id).IsEqualTo(firstPointerId);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(2);
    }

    [Test]
    public async Task DirectGuidTarget_Dedupes_AgainstLocalIdFact()
    {
        using var db = new TempDb();

        var first = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the target fact", localId: "x"),
            Fixtures.Fact("the pointer fact", refs: new List<RefInput> { Fixtures.Ref("@x") })));
        var targetGuid = first.Response.Facts[0].Id;
        var pointerId = first.Response.Facts[1].Id;

        var direct = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the pointer fact", refs: new List<RefInput> { Fixtures.Ref(targetGuid) })));

        await Assert.That(direct.Response.Facts[0].Status).IsEqualTo("deduped");
        await Assert.That(direct.Response.Facts[0].Id).IsEqualTo(pointerId);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(2);
    }

    [Test]
    public async Task LocalId_ResolvesWithinTheSameBatch()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the first fact", localId: "x"),
            Fixtures.Fact("the second fact", refs: new List<RefInput> { Fixtures.Ref("@x") })));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(2);
        var firstId = result.Response.Facts[0].Id;
        var secondId = result.Response.Facts[1].Id;

        using var connection = db.Store.OpenConnection();
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT target FROM refs WHERE fact_id = $id", ("$id", secondId)))
            .IsEqualTo(firstId);
    }

    [Test]
    public async Task UnresolvableLocalId_RejectsTheItemAndTheBatchStillCommits()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("broken", refs: new List<RefInput> { Fixtures.Ref("@missing") }),
            Fixtures.Fact("fine")));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(1);
        await Assert.That(result.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(result.Errors.Count).IsEqualTo(1);
        await Assert.That(result.Errors[0].Code).IsEqualTo("unresolved_local_id");

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(1);
    }

    [Test]
    public async Task MissingBasis_RejectsTheItemAndTheBatchStillCommits()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("no basis", refs: new List<RefInput> { Fixtures.Ref("https://example.test/x", basis: null) }),
            Fixtures.Fact("kept")));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(1);
        await Assert.That(result.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(result.Errors.Count).IsEqualTo(1);
        await Assert.That(result.Errors[0].Code).IsEqualTo("missing_basis");

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(1);
    }

    [Test]
    public async Task SlotTarget_IsStoredVerbatimAndNotResolved()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("the first fact", localId: "x"),
            Fixtures.Fact("slot holder", refs: new List<RefInput> { Fixtures.Ref("@x", kind: "slot", rel: "about") })));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(2);
        var secondId = result.Response.Facts[1].Id;

        using var connection = db.Store.OpenConnection();
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT target FROM refs WHERE fact_id = $id", ("$id", secondId)))
            .IsEqualTo("@x");
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT kind FROM refs WHERE fact_id = $id", ("$id", secondId)))
            .IsEqualTo("slot");
    }

    [Test]
    public async Task DifferentKeysWithIdenticalText_AreNotDeduped()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("identical words", key: "alpha"),
            Fixtures.Fact("identical words", key: "beta")));

        await Assert.That(result.Response.Facts.Count).IsEqualTo(2);
        await Assert.That(result.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(result.Response.Facts[1].Status).IsEqualTo("new");
        await Assert.That(result.Response.Facts[1].Id).IsNotEqualTo(result.Response.Facts[0].Id);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(2);
    }

    [Test]
    public async Task Ref_IsPersistedOneRowPerRefWithSequence()
    {
        using var db = new TempDb();

        var result = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("has two refs", refs: new List<RefInput>
            {
                Fixtures.Ref("https://example.test/a"),
                Fixtures.Ref("https://example.test/b", rel: "about"),
            })));

        var id = result.Response.Facts[0].Id;
        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM refs WHERE fact_id = $id", ("$id", id))).IsEqualTo(2);
    }
}
