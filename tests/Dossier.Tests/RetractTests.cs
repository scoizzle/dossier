using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class RetractTests
{
    [Test]
    public async Task Retract_TombstonesFactAndClearsTheFtsRow()
    {
        using var db = new TempDb();
        var sha = new string('a', 64);
        Directory.CreateDirectory(db.Store.BlobRoot);
        var blob = Path.Combine(db.Store.BlobRoot, sha);
        File.WriteAllText(blob, "attachment bytes");

        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact(
                "to be retracted",
                data: Fixtures.Json("{\"a\":1}"),
                attachments: new List<AttachmentInput>
                {
                    new() { Sha256 = sha, Filename = "a.txt", Mime = "text/plain", Bytes = 16 },
                })));
        var id = posted.Response.Facts[0].Id;

        using var connection = db.Store.OpenConnection();
        var hashBefore = (string?)Fixtures.Scalar(connection, "SELECT content_hash FROM facts WHERE id = $id", ("$id", id));
        var provenanceBefore = (string?)Fixtures.Scalar(connection, "SELECT provenance FROM facts WHERE id = $id", ("$id", id));
        var createdBefore = (string?)Fixtures.Scalar(connection, "SELECT created_at FROM facts WHERE id = $id", ("$id", id));
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts_fts")).IsEqualTo(1);

        var result = db.Store.Retract(id);

        await Assert.That(result.Found).IsTrue();
        await Assert.That(Fixtures.Count(
            connection,
            "SELECT COUNT(*) FROM facts WHERE id = $id AND status = 'retracted' AND text IS NULL AND data IS NULL",
            ("$id", id))).IsEqualTo(1);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts_fts")).IsEqualTo(0);
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT content_hash FROM facts WHERE id = $id", ("$id", id)))
            .IsEqualTo(hashBefore);
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT provenance FROM facts WHERE id = $id", ("$id", id)))
            .IsEqualTo(provenanceBefore);
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT created_at FROM facts WHERE id = $id", ("$id", id)))
            .IsEqualTo(createdBefore);
        await Assert.That(File.Exists(blob)).IsFalse();
    }

    [Test]
    public async Task Retract_KeepsBlobReferencedByAnotherLiveFact()
    {
        using var db = new TempDb();
        var sha = new string('b', 64);
        Directory.CreateDirectory(db.Store.BlobRoot);
        var blob = Path.Combine(db.Store.BlobRoot, sha);
        File.WriteAllText(blob, "shared bytes");

        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("first holder", attachments: new List<AttachmentInput>
            {
                new() { Sha256 = sha, Filename = "b.txt", Mime = "text/plain", Bytes = 12 },
            }),
            Fixtures.Fact("second holder", attachments: new List<AttachmentInput>
            {
                new() { Sha256 = sha, Filename = "b.txt", Mime = "text/plain", Bytes = 12 },
            })));

        db.Store.Retract(posted.Response.Facts[0].Id);

        await Assert.That(File.Exists(blob)).IsTrue();

        db.Store.Retract(posted.Response.Facts[1].Id);

        await Assert.That(File.Exists(blob)).IsFalse();
    }

    [Test]
    public async Task Retract_UnknownIdReportsNotFound()
    {
        using var db = new TempDb();

        var result = db.Store.Retract("does-not-exist");

        await Assert.That(result.Found).IsFalse();
    }
}
