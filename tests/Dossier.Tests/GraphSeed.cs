using Microsoft.Data.Sqlite;

namespace Dossier.Tests;

/// <summary>
/// A deterministic store for the graph tests: fixed ids and timestamps, written with raw SQL so
/// nothing random (the post path mints GUIDs) reaches the output. The committed fixture
/// tests/Dossier.Tests/fixtures/graph-api.json is the graph API output for this store.
/// </summary>
internal static class GraphSeed
{
    public const string ExternalSymbol = "django.db.models.QuerySet.filter@e4f3fb2d2d11";

    private sealed record Subject(string Id, string Name, string Kind, string? Parent, string Aliases = "[]");

    internal sealed record Ref(string Rel, string Kind, string Target, string Basis);

    private sealed record Fact(string Id, string Subject, string Text, string Created, params Ref[] Refs)
    {
        public string Kind { get; init; } = "note";

        public string? Key { get; init; }

        public string Tags { get; init; } = "[]";
    }

    // Hostile strings: the committed fixture carries them through the real API output so the page
    // harness proves they only ever reach the DOM as text.
    public const string EvilImg = "<img src=x onerror=alert(1)>";
    public const string EvilJs = "javascript:alert(1)";
    public const string EvilScript = "\"><script>alert(1)</script>";

    private static readonly Subject[] Subjects =
    [
        new("s-root", "Acme", "project", null, "[\"Acme Docs\"]"),
        new("s-core", "Core", "module", "s-root"),
        new("s-web", "Web", "module", "s-root"),
        new("s-lib", "Lib", EvilJs, "s-core"),
        new("s-other", "Other", "project", null),
        new("s-sh1", "Shared", "topic", null),
        new("s-sh2", "Shared", "topic", null),
        new("s-far", EvilScript, "project", null),
    ];

    private static readonly Fact[] Facts =
    [
        new("f-root-1", "s-root", "root fact with every kind of ref", "2026-01-01T00:00:01Z",
            new Ref("supports", "fact", "f-core-1", "derived"),
            new Ref("mentions", "subject", "Shared", "observed"),
            new Ref("mentions", "slot", "Core#owner", "observed"),
            new Ref("mentions", "slot", "Web#empty", "observed"),
            new Ref("cites", "symbol", ExternalSymbol, "derived"),
            new Ref("about", "subject", "Other", "observed"),
            new Ref("mentions", "fact", "f-ghost", "observed")),
        new("f-root-2", "s-root", "second root fact", "2026-01-01T00:00:02Z"),
        new("f-core-1", "s-core", "core fact", "2026-01-01T00:00:03Z"),
        new("f-core-2", "s-core", "core slot occupant", "2026-01-01T00:00:04Z"),
        new("f-web-1", "s-web", "web fact", "2026-01-01T00:00:05Z",
            new Ref("leads_to", "fact", "f-lib-1", "inferred")) { Key = EvilImg },
        new("f-lib-1", "s-lib", EvilImg + "\n" + EvilJs + "\n" + EvilScript, "2026-01-01T00:00:06Z") { Kind = EvilScript },
        new("f-other-1", "s-other", "other fact", "2026-01-01T00:00:07Z",
            new Ref(EvilImg, "symbol", EvilJs, EvilScript)) { Tags = "[\"" + EvilImg + "\",\"" + EvilJs + "\",\"\\\"><script>alert(1)</script>\"]" },
        new("f-far-1", "s-far", "far fact referring into the graph", "2026-01-01T00:00:08Z",
            new Ref("confirms", "fact", "f-core-1", "observed"),
            new Ref("mentions", "slot", "Core#owner", "observed")),
    ];

    /// <summary>Subject id that owns the most facts, for tests that need a busy subject.</summary>
    public const string Root = "s-root";

    public static void Populate(DossierStore store, bool reverse = false)
    {
        using var connection = store.OpenConnection();
        using var transaction = connection.BeginTransaction();
        foreach (var subject in reverse ? Subjects.Reverse() : Subjects)
        {
            Exec(
                connection,
                transaction,
                "INSERT INTO subjects(id, name, kind, parent_id, aliases, pin, created_at) VALUES($id, $name, $kind, $parent, $aliases, NULL, '2026-01-01T00:00:00Z')",
                ("$id", subject.Id),
                ("$name", subject.Name),
                ("$kind", subject.Kind),
                ("$parent", subject.Parent),
                ("$aliases", subject.Aliases));
        }

        foreach (var fact in reverse ? Facts.Reverse() : Facts)
        {
            InsertFact(connection, transaction, fact);
        }

        Exec(
            connection,
            transaction,
            "INSERT INTO slots(subject_id, kind, key, fact_id) VALUES('s-core', 'note', 'owner', 'f-core-2')");
        transaction.Commit();
    }

    /// <summary>A flat tree of <paramref name="count"/> subjects under 20 roots, three levels deep, for bound checks.</summary>
    public static void PopulateTree(DossierStore store, int count)
    {
        using var connection = store.OpenConnection();
        using var transaction = connection.BeginTransaction();
        for (var i = 0; i < count; i++)
        {
            var parent = i < 20 ? null : $"t-{(i - 20) / 3:D5}";
            Exec(
                connection,
                transaction,
                "INSERT INTO subjects(id, name, kind, parent_id, aliases, pin, created_at) VALUES($id, $name, 'module', $parent, '[]', NULL, '2026-01-01T00:00:00Z')",
                ("$id", $"t-{i:D5}"),
                ("$name", $"Tree {i:D5}"),
                ("$parent", parent));
        }

        transaction.Commit();
    }

    /// <summary>A throwaway writer for shaped stores (many referrers, cycles, big ref lists).</summary>
    internal sealed class Bulk : IDisposable
    {
        private readonly SqliteConnection connection;
        private readonly SqliteTransaction transaction;

        public Bulk(DossierStore store)
        {
            connection = store.OpenConnection();
            transaction = connection.BeginTransaction();
        }

        public Bulk Subject(string id, string name, string? parent = null, string kind = "module")
        {
            Exec(
                connection,
                transaction,
                "INSERT INTO subjects(id, name, kind, parent_id, aliases, pin, created_at) VALUES($id, $name, $kind, $parent, '[]', NULL, '2026-01-01T00:00:00Z')",
                ("$id", id),
                ("$name", name),
                ("$kind", kind),
                ("$parent", parent));
            return this;
        }

        public Bulk AddFact(string id, string subject, string text, string created, params Ref[] refs)
        {
            InsertFact(connection, transaction, new Fact(id, subject, text, created, refs));
            return this;
        }

        public Bulk Slot(string subject, string key, string fact)
        {
            Exec(connection, transaction, "INSERT INTO slots(subject_id, kind, key, fact_id) VALUES($s, 'note', $k, $f)", ("$s", subject), ("$k", key), ("$f", fact));
            return this;
        }

        public void Dispose()
        {
            transaction.Commit();
            transaction.Dispose();
            connection.Dispose();
        }
    }

    private static void InsertFact(SqliteConnection connection, SqliteTransaction transaction, Fact fact)
    {
        Exec(
            connection,
            transaction,
            """
            INSERT INTO facts(id, subject_id, kind, key, text, data, items, tags, confidence, status, provenance, content_hash, created_at)
            VALUES($id, $subject, $kind, $key, $text, NULL, NULL, $tags, 0.9, 'live', '{}', $hash, $created)
            """,
            ("$id", fact.Id),
            ("$subject", fact.Subject),
            ("$kind", fact.Kind),
            ("$key", fact.Key),
            ("$tags", fact.Tags),
            ("$text", fact.Text),
            ("$hash", "hash-" + fact.Id),
            ("$created", fact.Created));
        for (var seq = 0; seq < fact.Refs.Length; seq++)
        {
            var r = fact.Refs[seq];
            Exec(
                connection,
                transaction,
                "INSERT INTO refs(fact_id, seq, rel, kind, target, locator, basis) VALUES($fact, $seq, $rel, $kind, $target, NULL, $basis)",
                ("$fact", fact.Id),
                ("$seq", seq),
                ("$rel", r.Rel),
                ("$kind", r.Kind),
                ("$target", r.Target),
                ("$basis", r.Basis));
        }
    }

    private static void Exec(SqliteConnection connection, SqliteTransaction transaction, string sql, params (string Name, object? Value)[] parameters)
    {
        using var command = connection.CreateCommand();
        command.Transaction = transaction;
        command.CommandText = sql;
        foreach (var (name, value) in parameters)
        {
            command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }

        command.ExecuteNonQuery();
    }
}
