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
    public async Task Schema_EnablesWal()
    {
        using var db = new TempDb();
        using var connection = db.Store.OpenConnection();

        await Assert.That((string?)Fixtures.Scalar(connection, "PRAGMA journal_mode")).IsEqualTo("wal");
    }
}
