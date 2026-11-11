using Microsoft.Data.Sqlite;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class RevisionTests
{
    private static readonly string[] Tables = { "facts", "subjects", "refs", "slots" };

    private static void Exec(DossierStore store, string sql)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = sql;
        command.ExecuteNonQuery();
    }

    private static long Count(DossierStore store, string sql)
    {
        using var connection = store.OpenConnection();
        return Fixtures.Count(connection, sql);
    }

    [Test]
    public async Task Revision_BumpsOnRawSqlInsertUpdateDelete()
    {
        using var db = new TempDb();
        var r0 = db.Store.Revision();

        Exec(db.Store, "INSERT INTO facts(id, subject_id, kind, status, provenance, content_hash, created_at) VALUES('f1','s1','note','active','{}','h','t')");
        var r1 = db.Store.Revision();
        await Assert.That(r1).IsGreaterThan(r0);

        Exec(db.Store, "UPDATE facts SET text = 'x' WHERE id = 'f1'");
        var r2 = db.Store.Revision();
        await Assert.That(r2).IsGreaterThan(r1);

        Exec(db.Store, "DELETE FROM facts WHERE id = 'f1'");
        var r3 = db.Store.Revision();
        await Assert.That(r3).IsGreaterThan(r2);

        var posted = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var r4 = db.Store.Revision();
        await Assert.That(r4).IsGreaterThan(r3);

        db.Store.Retract(posted.Response.Facts[0].Id);
        await Assert.That(db.Store.Revision()).IsGreaterThan(r4);
    }

    [Test]
    public async Task Revision_UpgradesAnExistingDatabase()
    {
        using var db = new TempDb();
        foreach (var table in Tables)
        {
            foreach (var op in new[] { "insert", "update", "delete" })
            {
                Exec(db.Store, $"DROP TRIGGER trg_{table}_{op}");
            }
        }

        Exec(db.Store, "DELETE FROM meta WHERE key = 'revision'");
        await Assert.That(Count(db.Store, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%'")).IsEqualTo(0);

        var upgraded = new DossierStore(db.DbPath);
        await Assert.That(Count(upgraded, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%'")).IsEqualTo(12);
        await Assert.That(upgraded.Revision()).IsEqualTo(0L);

        Exec(upgraded, "INSERT INTO subjects(id, name, kind, created_at) VALUES('s1','n','k','t')");
        await Assert.That(upgraded.Revision()).IsEqualTo(1L);

        Exec(upgraded, "UPDATE subjects SET name = 'a' WHERE id = 's1'");
        Exec(upgraded, "UPDATE subjects SET name = 'b' WHERE id = 's1'");
        var n = upgraded.Revision();
        await Assert.That(n).IsEqualTo(3L);

        var again = new DossierStore(db.DbPath);
        await Assert.That(again.Revision()).IsEqualTo(n);
        await Assert.That(Count(again, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%'")).IsEqualTo(12);
        TempDb.ClearPool(upgraded);
        TempDb.ClearPool(again);
    }

    [Test]
    public async Task Revision_DoesNotBumpOnIdenticalRepost()
    {
        using var db = new TempDb();
        var request = Fixtures.Post("Widget", Fixtures.Fact("same body"));
        db.Store.PostFacts(request);
        var before = db.Store.Revision();

        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("same body")));

        await Assert.That(db.Store.Revision()).IsEqualTo(before);
    }

    [Test]
    public async Task Revision_DoesNotBumpOnRepeatedRetract()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var id = posted.Response.Facts[0].Id;

        var first = db.Store.Retract(id);
        var r1 = db.Store.Revision();

        // A second retract writes nothing: the row is already a tombstone, so no trigger fires.
        var second = db.Store.Retract(id);

        await Assert.That(db.Store.Revision()).IsEqualTo(r1);
        await Assert.That(second).IsEqualTo(first);
        await Assert.That(second.Found).IsTrue();
        await Assert.That(second.Id).IsEqualTo(id);
    }

    [Test]
    public async Task Revision_ConcurrentUpgradeIsSafe()
    {
        using var db = new TempDb();
        foreach (var table in Tables)
        {
            foreach (var op in new[] { "insert", "update", "delete" })
            {
                Exec(db.Store, $"DROP TRIGGER trg_{table}_{op}");
            }
        }

        Exec(db.Store, "DELETE FROM meta WHERE key = 'revision'");

        var opened = new DossierStore?[4];
        Exception? failure = null;
        try
        {
            Parallel.For(0, opened.Length, i => opened[i] = new DossierStore(db.DbPath));
        }
        catch (Exception exception)
        {
            failure = exception;
        }
        finally
        {
            foreach (var store in opened)
            {
                if (store is not null)
                {
                    TempDb.ClearPool(store);
                }
            }
        }

        await Assert.That(failure).IsNull();
        await Assert.That(Count(db.Store, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%'")).IsEqualTo(12);
        await Assert.That(db.Store.Revision()).IsEqualTo(0L);
    }

    [Test]
    public async Task Revision_UnchangedByReads()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("alpha", tags: new List<string> { "t" }), Fixtures.Fact("beta", tags: new List<string> { "t" })));
        var before = db.Store.Revision();

        db.Store.Search(new SearchRequest { Subject = "Widget" });
        db.Store.Correlate(new CorrelateRequest { Subject = "Widget", Matchers = new List<string> { "shared_tag" } });
        Ops.Graph(db.Store, new GraphRequest { Subject = "Widget" });
        _ = db.Store.Revision();

        await Assert.That(db.Store.Revision()).IsEqualTo(before);
    }
}
