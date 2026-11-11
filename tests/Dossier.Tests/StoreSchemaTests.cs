using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class StoreSchemaTests
{
    [Test]
    public async Task Schema_CreatesEveryTableAndIndexOnFirstUse()
    {
        using var db = new TempDb();
        using var connection = db.Store.OpenConnection();

        foreach (var table in new[] { "subjects", "slots", "facts", "refs", "attachments", "facts_fts", "meta" })
        {
            await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM sqlite_master WHERE name = $name", ("$name", table)))
                .IsEqualTo(1);
        }

        foreach (var index in new[] { "idx_refs_target", "idx_refs_fact_id", "idx_facts_subject_id", "idx_facts_content_hash" })
        {
            await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM sqlite_master WHERE name = $name", ("$name", index)))
                .IsEqualTo(1);
        }
    }

    [Test]
    public async Task Schema_CreatesRevisionTriggersAndSeedRow()
    {
        using var db = new TempDb();
        using var connection = db.Store.OpenConnection();

        var expected = new List<string>();
        foreach (var table in new[] { "facts", "subjects", "refs", "slots" })
        {
            foreach (var op in new[] { "insert", "update", "delete" })
            {
                expected.Add($"trg_{table}_{op}");
            }
        }

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT name FROM sqlite_master WHERE type = 'trigger' AND name LIKE 'trg_%' ORDER BY name";
        var actual = new List<string>();
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                actual.Add(reader.GetString(0));
            }
        }

        expected.Sort(StringComparer.Ordinal);
        await Assert.That(actual.Count).IsEqualTo(12);
        await Assert.That(string.Join(",", actual)).IsEqualTo(string.Join(",", expected));
        await Assert.That((string?)Fixtures.Scalar(connection, "SELECT value FROM meta WHERE key = 'revision'")).IsEqualTo("0");
    }

    [Test]
    public async Task Schema_EnablesWal()
    {
        using var db = new TempDb();
        using var connection = db.Store.OpenConnection();

        await Assert.That((string?)Fixtures.Scalar(connection, "PRAGMA journal_mode")).IsEqualTo("wal");
    }
}
