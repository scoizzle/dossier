using System.Collections.Concurrent;
using System.Net;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>The change journal: trigger-written rows (seq == meta.revision), upgrade, retention and the read API.</summary>
public sealed class ChangeLogTests
{
    private static readonly string[] Tables = { "facts", "subjects", "refs", "slots" };
    private static readonly string[] Ops = { "insert", "update", "delete" };

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

    private static List<(long Seq, string Tbl, string Op)> Journal(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT seq, tbl, op FROM changes ORDER BY seq";
        var rows = new List<(long, string, string)>();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            rows.Add((reader.GetInt64(0), reader.GetString(1), reader.GetString(2)));
        }

        return rows;
    }

    private static string TriggerSql(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT group_concat(name || ':' || sql, char(10)) FROM (SELECT name, sql FROM sqlite_master WHERE type = 'trigger' AND name LIKE 'trg_%' ORDER BY name)";
        return (string?)command.ExecuteScalar() ?? string.Empty;
    }

    private static void RawSubject(DossierStore store, string id) =>
        Exec(store, $"INSERT INTO subjects(id, name, kind, created_at) VALUES('{id}','n-{id}','k','t')");

    private static void DropTriggers(DossierStore store)
    {
        foreach (var table in Tables)
        {
            foreach (var op in Ops)
            {
                Exec(store, $"DROP TRIGGER IF EXISTS trg_{table}_{op}");
            }
        }
    }

    /// <summary>The pre-journal trigger body, copied here so the upgrade test does not depend on production code.</summary>
    private static void CreateLegacyTriggers(DossierStore store)
    {
        foreach (var table in Tables)
        {
            foreach (var (name, op) in new[] { ("insert", "INSERT"), ("update", "UPDATE"), ("delete", "DELETE") })
            {
                Exec(store, $"""
                    CREATE TRIGGER trg_{table}_{name} AFTER {op} ON {table} FOR EACH ROW
                    BEGIN
                        INSERT INTO meta(key, value) SELECT 'revision', '0' WHERE NOT EXISTS (SELECT 1 FROM meta WHERE key = 'revision');
                        UPDATE meta SET value = CAST(CAST(value AS INTEGER) + 1 AS TEXT) WHERE key = 'revision';
                    END;
                    """);
            }
        }
    }

    [Test]
    public async Task ChangeLog_RecordsEveryRowWrite()
    {
        using var db = new TempDb();
        var start = db.Store.Revision();

        var statements = new (string Table, string Op, string Sql)[]
        {
            ("subjects", "insert", "INSERT INTO subjects(id, name, kind, created_at) VALUES('s1','n','k','t')"),
            ("subjects", "update", "UPDATE subjects SET name = 'b' WHERE id = 's1'"),
            ("facts", "insert", "INSERT INTO facts(id, subject_id, kind, status, provenance, content_hash, created_at) VALUES('f1','s1','note','active','{}','h','t')"),
            ("facts", "update", "UPDATE facts SET text = 'x' WHERE id = 'f1'"),
            ("refs", "insert", "INSERT INTO refs(fact_id, seq, rel, kind, target, basis) VALUES('f1',0,'mentions','fact','t','observed')"),
            ("refs", "update", "UPDATE refs SET rel = 'cites' WHERE fact_id = 'f1'"),
            ("slots", "insert", "INSERT INTO slots(subject_id, kind, key, fact_id) VALUES('s1','note','k','f1')"),
            ("slots", "update", "UPDATE slots SET fact_id = 'f2' WHERE subject_id = 's1'"),
            ("slots", "delete", "DELETE FROM slots WHERE subject_id = 's1'"),
            ("refs", "delete", "DELETE FROM refs WHERE fact_id = 'f1'"),
            ("facts", "delete", "DELETE FROM facts WHERE id = 'f1'"),
            ("subjects", "delete", "DELETE FROM subjects WHERE id = 's1'"),
        };

        foreach (var (_, _, sql) in statements)
        {
            Exec(db.Store, sql);
        }

        var journal = Journal(db.Store);
        await Assert.That(journal.Count).IsEqualTo(statements.Length);
        for (var index = 0; index < statements.Length; index++)
        {
            await Assert.That(journal[index].Seq).IsEqualTo(start + index + 1);
            await Assert.That(journal[index].Tbl).IsEqualTo(statements[index].Table);
            await Assert.That(journal[index].Op).IsEqualTo(statements[index].Op);
        }

        await Assert.That(Count(db.Store, "SELECT MAX(seq) FROM changes")).IsEqualTo(db.Store.Revision());
    }

    [Test]
    public async Task ChangeLog_OneRowPerRowWrite()
    {
        using var db = new TempDb();
        var start = db.Store.Revision();

        var posted = db.Store.PostFacts(Fixtures.Post(
            "Widget",
            Fixtures.Fact("body", key: "slot-a", refs: new List<RefInput> { Fixtures.Ref("https://example.test/x") })));

        var journal = Journal(db.Store);
        var summary = string.Join(",", journal.Select(row => $"{row.Tbl}:{row.Op}").OrderBy(text => text, StringComparer.Ordinal));
        await Assert.That(summary).IsEqualTo("facts:insert,refs:insert,slots:insert,subjects:insert");
        await Assert.That(journal.Count).IsEqualTo((int)(db.Store.Revision() - start));

        using var connection = db.Store.OpenConnection();
        var factId = posted.Response.Facts[0].Id;
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM changes WHERE tbl = 'facts' AND fact_id = $id AND subject_id = $subject", ("$id", factId), ("$subject", posted.Response.Subject.Id))).IsEqualTo(1);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM changes WHERE tbl = 'refs' AND fact_id = $id AND subject_id = $subject", ("$id", factId), ("$subject", posted.Response.Subject.Id))).IsEqualTo(1);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM changes WHERE tbl = 'subjects' AND fact_id IS NULL AND subject_id = $subject", ("$subject", posted.Response.Subject.Id))).IsEqualTo(1);
    }

    [Test]
    public async Task ChangeLog_UpgradesAnExistingTwelveTriggerDatabase()
    {
        using var db = new TempDb();
        DropTriggers(db.Store);
        CreateLegacyTriggers(db.Store);
        Exec(db.Store, "DROP TABLE changes");
        Exec(db.Store, "INSERT INTO subjects(id, name, kind, created_at) VALUES('s1','n','k','t')");
        Exec(db.Store, "UPDATE subjects SET name = 'b' WHERE id = 's1'");
        var revision = db.Store.Revision();
        await Assert.That(revision).IsEqualTo(2L);

        var upgraded = new DossierStore(db.DbPath);
        try
        {
            await Assert.That(Count(upgraded, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%'")).IsEqualTo(12);
            await Assert.That(Count(upgraded, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%' AND sql LIKE '%INSERT INTO changes%'")).IsEqualTo(12);
            await Assert.That(Count(upgraded, "SELECT COUNT(*) FROM changes")).IsEqualTo(0);
            await Assert.That(upgraded.Revision()).IsEqualTo(revision);

            Exec(upgraded, "UPDATE subjects SET name = 'c' WHERE id = 's1'");
            var journal = Journal(upgraded);
            await Assert.That(journal.Count).IsEqualTo(1);
            await Assert.That(journal[0].Seq).IsEqualTo(revision + 1);
            await Assert.That(upgraded.Revision()).IsEqualTo(revision + 1);
        }
        finally
        {
            TempDb.ClearPool(upgraded);
        }
    }

    [Test]
    public async Task ChangeLog_UpgradesAPreRevisionDatabase()
    {
        using var db = new TempDb();
        DropTriggers(db.Store);
        Exec(db.Store, "DELETE FROM meta WHERE key = 'revision'");
        Exec(db.Store, "DROP TABLE changes");

        var upgraded = new DossierStore(db.DbPath);
        try
        {
            await Assert.That(Count(upgraded, "SELECT COUNT(*) FROM sqlite_master WHERE type='trigger' AND name LIKE 'trg_%' AND sql LIKE '%INSERT INTO changes%'")).IsEqualTo(12);
            await Assert.That(upgraded.Revision()).IsEqualTo(0L);

            RawSubject(upgraded, "s1");
            var journal = Journal(upgraded);
            await Assert.That(journal.Count).IsEqualTo(1);
            await Assert.That(journal[0].Seq).IsEqualTo(1L);
            await Assert.That(upgraded.Revision()).IsEqualTo(1L);
        }
        finally
        {
            TempDb.ClearPool(upgraded);
        }
    }

    [Test]
    public async Task ChangeLog_ConstructionLeavesACurrentDatabaseAlone()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var triggers = TriggerSql(db.Store);
        var revision = db.Store.Revision();
        var rows = Count(db.Store, "SELECT COUNT(*) FROM changes");
        var schemaVersion = Count(db.Store, "PRAGMA schema_version");

        // A held write lock proves construction takes none: a store that tried to write would wait out
        // the 5s busy timeout and throw.
        using var holder = db.Store.OpenConnection();
        using (var begin = holder.CreateCommand())
        {
            begin.CommandText = "BEGIN IMMEDIATE";
            begin.ExecuteNonQuery();
        }

        DossierStore again;
        var watch = System.Diagnostics.Stopwatch.StartNew();
        try
        {
            again = new DossierStore(db.DbPath);
        }
        finally
        {
            using var rollback = holder.CreateCommand();
            rollback.CommandText = "ROLLBACK";
            rollback.ExecuteNonQuery();
        }

        watch.Stop();
        try
        {
            await Assert.That(watch.Elapsed).IsLessThan(TimeSpan.FromSeconds(3));
            await Assert.That(TriggerSql(again)).IsEqualTo(triggers);
            await Assert.That(again.Revision()).IsEqualTo(revision);
            await Assert.That(Count(again, "SELECT COUNT(*) FROM changes")).IsEqualTo(rows);
            await Assert.That(Count(again, "PRAGMA schema_version")).IsEqualTo(schemaVersion);
        }
        finally
        {
            TempDb.ClearPool(again);
        }
    }

    [Test]
    public async Task ChangeLog_SeedAfterMetaRowDeletedDoesNotCollide()
    {
        using var db = new TempDb();
        RawSubject(db.Store, "s1");
        RawSubject(db.Store, "s2");
        RawSubject(db.Store, "s3");
        var max = Count(db.Store, "SELECT MAX(seq) FROM changes");
        Exec(db.Store, "DELETE FROM meta WHERE key = 'revision'");

        RawSubject(db.Store, "s4");

        await Assert.That(Count(db.Store, "SELECT MAX(seq) FROM changes")).IsEqualTo(max + 1);
        await Assert.That(Count(db.Store, "SELECT COUNT(*) FROM changes")).IsEqualTo(max + 1);
        await Assert.That(db.Store.Revision()).IsEqualTo(max + 1);
    }

    [Test]
    public async Task ChangeLog_PrunesAmortized()
    {
        using var db = new TempDb();
        for (var index = 1; index <= 30; index++)
        {
            RawSubject(db.Store, $"s{index}");
        }

        using var connection = db.Store.OpenConnection();
        long Min() => Fixtures.Count(connection, "SELECT MIN(seq) FROM changes");
        long Total() => Fixtures.Count(connection, "SELECT COUNT(*) FROM changes");

        // retention 10, slack 5: nothing until the oldest row is more than 15 behind the head.
        DossierStore.PruneChanges(connection, null, 14, retention: 10, slack: 5);
        await Assert.That(Total()).IsEqualTo(30L);

        DossierStore.PruneChanges(connection, null, 30, retention: 10, slack: 5);
        await Assert.That(Min()).IsEqualTo(21L);
        await Assert.That(Total()).IsEqualTo(10L);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM changes WHERE seq = 30")).IsEqualTo(1L);

        for (var index = 31; index <= 40; index++)
        {
            RawSubject(db.Store, $"s{index}");
        }

        // Inside the slack again: oldest row 21 is not more than 15 behind head 35, so nothing goes.
        DossierStore.PruneChanges(connection, null, 35, retention: 10, slack: 5);
        await Assert.That(Total()).IsEqualTo(20L);

        DossierStore.PruneChanges(connection, null, 40, retention: 10, slack: 5);
        await Assert.That(Min()).IsEqualTo(31L);
        await Assert.That(Total()).IsEqualTo(10L);
    }

    [Test]
    public async Task ChangeLog_ConcurrentWritersProduceContiguousUniqueSeqs()
    {
        using var db = new TempDb();
        const int writers = 8;
        const int perWriter = 50;
        var start = db.Store.Revision();
        var errors = new ConcurrentQueue<Exception>();
        var stores = Enumerable.Range(0, writers).Select(_ => new DossierStore(db.DbPath)).ToArray();
        var gate = new Barrier(writers);

        var tasks = Enumerable.Range(0, writers).Select(writer => Task.Factory.StartNew(
            () =>
            {
                try
                {
                    gate.SignalAndWait();
                    for (var index = 0; index < perWriter; index++)
                    {
                        stores[writer].PostFacts(Fixtures.Post($"Agent/{writer}", Fixtures.Fact($"w{writer}-{index}")));
                    }
                }
                catch (Exception exception)
                {
                    errors.Enqueue(exception);
                }
            },
            TaskCreationOptions.LongRunning)).ToArray();
        await Task.WhenAll(tasks);

        try
        {
            await Assert.That(string.Join(" | ", errors.Select(error => error.Message))).IsEqualTo(string.Empty);

            var end = db.Store.Revision();
            var seqs = Journal(db.Store).Select(row => row.Seq).ToList();
            await Assert.That(seqs.Count).IsEqualTo((int)(end - start));
            await Assert.That(seqs.Distinct().Count()).IsEqualTo(seqs.Count);
            await Assert.That(seqs[0]).IsEqualTo(start + 1);
            await Assert.That(seqs[^1]).IsEqualTo(end);
            await Assert.That(seqs.SequenceEqual(Enumerable.Range((int)start + 1, seqs.Count).Select(value => (long)value))).IsTrue();
        }
        finally
        {
            foreach (var store in stores)
            {
                TempDb.ClearPool(store);
            }
        }
    }

    [Test]
    public async Task ChangesQuery_PagesAndResets()
    {
        using var db = new TempDb();

        // An empty store is not a reset at since=0.
        var empty = db.Store.ReadChanges(0, 100);
        await Assert.That(empty.Reset).IsFalse();
        await Assert.That(empty.Changes.Count).IsEqualTo(0);
        await Assert.That(empty.Next).IsEqualTo(0L);

        for (var index = 1; index <= 5; index++)
        {
            RawSubject(db.Store, $"s{index}");
        }

        var first = db.Store.ReadChanges(0, 2);
        await Assert.That(first.Reset).IsFalse();
        await Assert.That(first.Truncated).IsTrue();
        await Assert.That(first.From).IsEqualTo(0L);
        await Assert.That(first.Next).IsEqualTo(2L);
        await Assert.That(first.Changes.Select(row => row.Seq).ToArray()).IsEquivalentTo(new long[] { 1, 2 });
        await Assert.That(first.Changes[0].Tbl).IsEqualTo("subjects");
        await Assert.That(first.Changes[0].Op).IsEqualTo("insert");
        await Assert.That(first.Changes[0].SubjectId).IsEqualTo("s1");
        await Assert.That(first.Changes[0].SubjectName).IsEqualTo("n-s1");
        await Assert.That(first.Changes[0].Actor).IsNull();

        var rest = db.Store.ReadChanges(first.Next, 100);
        await Assert.That(rest.Truncated).IsFalse();
        await Assert.That(rest.Next).IsEqualTo(5L);
        await Assert.That(rest.Changes.Count).IsEqualTo(3);

        var caughtUp = db.Store.ReadChanges(5, 100);
        await Assert.That(caughtUp.Reset).IsFalse();
        await Assert.That(caughtUp.Changes.Count).IsEqualTo(0);
        await Assert.That(caughtUp.Next).IsEqualTo(5L);

        var last = db.Store.ReadChangesLast(2);
        await Assert.That(last.Reset).IsFalse();
        await Assert.That(last.Changes.Select(row => row.Seq).ToArray()).IsEquivalentTo(new long[] { 4, 5 });
        await Assert.That(last.Next).IsEqualTo(5L);

        // Past the head: the client is ahead of this store.
        var ahead = db.Store.ReadChanges(6, 100);
        await Assert.That(ahead.Reset).IsTrue();
        await Assert.That(ahead.Next).IsEqualTo(5L);
        await Assert.That(ahead.Changes.Count).IsEqualTo(0);

        // Below the pruned window.
        Exec(db.Store, "DELETE FROM changes WHERE seq <= 3");
        var pruned = db.Store.ReadChanges(1, 100);
        await Assert.That(pruned.Reset).IsTrue();
        await Assert.That(pruned.Next).IsEqualTo(5L);
        var edge = db.Store.ReadChanges(3, 100);
        await Assert.That(edge.Reset).IsFalse();
        await Assert.That(edge.Changes.Select(row => row.Seq).ToArray()).IsEquivalentTo(new long[] { 4, 5 });
    }

    [Test]
    public async Task ChangesQuery_UpgradedDatabaseWithEmptyJournalResetsOnlyBelowRevision()
    {
        using var db = new TempDb();
        for (var index = 1; index <= 4; index++)
        {
            RawSubject(db.Store, $"s{index}");
        }

        // Legacy-upgrade shape: revision 4, no journal rows.
        Exec(db.Store, "DELETE FROM changes");
        await Assert.That(db.Store.Revision()).IsEqualTo(4L);

        var current = db.Store.ReadChanges(4, 100);
        await Assert.That(current.Reset).IsFalse();
        await Assert.That(current.Next).IsEqualTo(4L);

        var stale = db.Store.ReadChanges(0, 100);
        await Assert.That(stale.Reset).IsTrue();
        await Assert.That(stale.Next).IsEqualTo(4L);
    }

    [Test]
    public async Task ChangesQuery_JoinsFactFieldsAndActorOnlyForFactInserts()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact(new string('x', 400), key: "k")));
        var factId = posted.Response.Facts[0].Id;
        Exec(db.Store, $"UPDATE facts SET provenance = '{{\"actor\":\"agent-7\"}}' WHERE id = '{factId}'");
        Exec(db.Store, $"UPDATE facts SET status = 'superseded' WHERE id = '{factId}'");

        var page = db.Store.ReadChanges(0, 100);
        var factInsert = page.Changes.Single(row => row.Tbl == "facts" && row.Op == "insert");
        var factUpdate = page.Changes.Single(row => row.Tbl == "facts" && row.Op == "update" && row.Seq == page.Changes.Max(r => r.Seq));
        await Assert.That(factInsert.FactId).IsEqualTo(factId);
        await Assert.That(factInsert.FactKind).IsEqualTo("note");
        await Assert.That(factInsert.Text!.Length).IsEqualTo(160);
        await Assert.That(factInsert.SubjectName).IsEqualTo("Widget");
        await Assert.That(factInsert.Actor).IsEqualTo("agent-7");
        await Assert.That(factUpdate.Actor).IsNull();
        await Assert.That(factUpdate.FactStatus).IsEqualTo("superseded");
        await Assert.That(page.Changes.Where(row => row.Actor is not null).Count()).IsEqualTo(1);
    }

    [Test]
    public async Task ChangesEndpoint_ServesPagesAndRejectsBadInput()
    {
        using var db = new TempDb();
        for (var index = 1; index <= 3; index++)
        {
            RawSubject(db.Store, $"s{index}");
        }

        using var server = await TestServers.StartAsync(db.Store);
        using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{server.Port}/") };

        var ok = await http.GetAsync("/api/changes?since=0&limit=2");
        await Assert.That(ok.StatusCode).IsEqualTo(HttpStatusCode.OK);
        using var document = JsonDocument.Parse(await ok.Content.ReadAsStringAsync());
        var root = document.RootElement;
        await Assert.That(root.GetProperty("from").GetInt64()).IsEqualTo(0L);
        await Assert.That(root.GetProperty("to").GetInt64()).IsEqualTo(2L);
        await Assert.That(root.GetProperty("next").GetInt64()).IsEqualTo(2L);
        await Assert.That(root.GetProperty("truncated").GetBoolean()).IsTrue();
        await Assert.That(root.GetProperty("reset").GetBoolean()).IsFalse();
        var rows = root.GetProperty("changes");
        await Assert.That(rows.GetArrayLength()).IsEqualTo(2);
        var row = rows[0];
        await Assert.That(row.GetProperty("seq").GetInt64()).IsEqualTo(1L);
        await Assert.That(row.GetProperty("tbl").GetString()).IsEqualTo("subjects");
        await Assert.That(row.GetProperty("op").GetString()).IsEqualTo("insert");
        await Assert.That(row.GetProperty("subject_id").GetString()).IsEqualTo("s1");
        await Assert.That(row.GetProperty("subject_name").GetString()).IsEqualTo("n-s1");
        await Assert.That(row.GetProperty("fact_id").ValueKind).IsEqualTo(JsonValueKind.Null);
        await Assert.That(row.GetProperty("actor").ValueKind).IsEqualTo(JsonValueKind.Null);
        await Assert.That(row.GetProperty("at").GetString()).IsNotNull();

        var last = await http.GetAsync("/api/changes?last=1");
        await Assert.That(last.StatusCode).IsEqualTo(HttpStatusCode.OK);
        using var lastDocument = JsonDocument.Parse(await last.Content.ReadAsStringAsync());
        await Assert.That(lastDocument.RootElement.GetProperty("next").GetInt64()).IsEqualTo(3L);
        await Assert.That(lastDocument.RootElement.GetProperty("changes").GetArrayLength()).IsEqualTo(1);

        // limit is clamped, not rejected.
        var clamped = await http.GetAsync("/api/changes?since=0&limit=100000");
        await Assert.That(clamped.StatusCode).IsEqualTo(HttpStatusCode.OK);
        var zero = await http.GetAsync("/api/changes?since=0&limit=0");
        await Assert.That(zero.StatusCode).IsEqualTo(HttpStatusCode.OK);

        foreach (var bad in new[] { "since=abc", "since=99999999999999999999", "limit=x", "last=abc", "since=-1" })
        {
            var response = await http.GetAsync($"/api/changes?{bad}");
            await Assert.That(response.StatusCode).IsEqualTo(HttpStatusCode.BadRequest);
            await Assert.That(await response.Content.ReadAsStringAsync()).Contains("invalid_request");
        }

        var post = await http.PostAsync("/api/changes?since=0", new StringContent(string.Empty));
        await Assert.That(post.StatusCode).IsEqualTo(HttpStatusCode.MethodNotAllowed);
    }
}
