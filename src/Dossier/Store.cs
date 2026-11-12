using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>
/// Raw ADO.NET SQLite store. Schema is created on construction (first use); every
/// connection enables WAL. No ORM and no DI: callers construct it.
/// </summary>
public sealed partial class DossierStore
{
    private const string Schema = """
        CREATE TABLE IF NOT EXISTS subjects (
            id TEXT NOT NULL PRIMARY KEY,
            name TEXT NOT NULL,
            kind TEXT NOT NULL,
            parent_id TEXT,
            aliases TEXT NOT NULL DEFAULT '[]',
            pin TEXT,
            created_at TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS slots (
            subject_id TEXT NOT NULL,
            kind TEXT NOT NULL,
            key TEXT NOT NULL,
            fact_id TEXT NOT NULL,
            PRIMARY KEY (subject_id, kind, key)
        );

        CREATE TABLE IF NOT EXISTS facts (
            id TEXT NOT NULL PRIMARY KEY,
            subject_id TEXT NOT NULL,
            kind TEXT NOT NULL,
            key TEXT,
            text TEXT,
            data TEXT,
            items TEXT,
            tags TEXT NOT NULL DEFAULT '[]',
            confidence REAL NOT NULL DEFAULT 1.0,
            status TEXT NOT NULL,
            provenance TEXT NOT NULL,
            content_hash TEXT NOT NULL,
            created_at TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS refs (
            fact_id TEXT NOT NULL,
            seq INTEGER NOT NULL,
            rel TEXT NOT NULL,
            kind TEXT NOT NULL,
            target TEXT NOT NULL,
            locator TEXT,
            basis TEXT NOT NULL,
            confidence REAL,
            rev TEXT,
            snapshot TEXT,
            snapshot_hash TEXT,
            etag TEXT,
            verified_at TEXT,
            valid INTEGER,
            PRIMARY KEY (fact_id, seq)
        );

        CREATE TABLE IF NOT EXISTS attachments (
            fact_id TEXT NOT NULL,
            sha256 TEXT NOT NULL,
            filename TEXT NOT NULL,
            mime TEXT NOT NULL,
            bytes INTEGER NOT NULL,
            perceptual TEXT,
            PRIMARY KEY (fact_id, sha256)
        );

        CREATE VIRTUAL TABLE IF NOT EXISTS facts_fts USING fts5(text, tags);

        CREATE TABLE IF NOT EXISTS meta (
            key TEXT NOT NULL PRIMARY KEY,
            value TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS changes (
            seq INTEGER NOT NULL PRIMARY KEY,
            tbl TEXT NOT NULL,
            op TEXT NOT NULL,
            subject_id TEXT,
            fact_id TEXT,
            created_at TEXT NOT NULL DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ', 'now'))
        );

        CREATE INDEX IF NOT EXISTS idx_refs_target ON refs(target);
        CREATE INDEX IF NOT EXISTS idx_refs_fact_id ON refs(fact_id);
        CREATE INDEX IF NOT EXISTS idx_facts_subject_id ON facts(subject_id);
        CREATE INDEX IF NOT EXISTS idx_facts_content_hash ON facts(content_hash);
        """;

    public DossierStore(string? dbPath = null)
    {
        DbPath = dbPath ?? Environment.GetEnvironmentVariable("DOSSIER_DB") ?? "./dossier.db";
        var fullPath = Path.GetFullPath(DbPath);
        var directory = Path.GetDirectoryName(fullPath);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        BlobRoot = Path.Combine(directory ?? ".", "blobs");
        Initialize();
    }

    public string DbPath { get; }

    /// <summary>Attachment files live at blobs/&lt;sha256&gt; next to the database.</summary>
    public string BlobRoot { get; }

    public void Initialize()
    {
        using var connection = OpenConnection();
        using (var schema = connection.CreateCommand())
        {
            // CREATE ... IF NOT EXISTS on an existing object takes no write lock.
            schema.CommandText = Schema;
            schema.ExecuteNonQuery();
        }

        // A current database is detected by a read; construction then writes nothing.
        if (RevisionSchemaIsCurrent(connection))
        {
            return;
        }

        // Otherwise take the write lock first (a raw BEGIN IMMEDIATE, not a deferred transaction) and
        // re-check inside it, so concurrent constructions upgrade exactly once and none can interleave
        // with a half-replaced trigger set.
        Run(connection, "BEGIN IMMEDIATE");
        try
        {
            if (!RevisionSchemaIsCurrent(connection))
            {
                Run(connection, DropRevisionTriggers() + RevisionTriggers());

                // Seed only when missing, from the journal head, so an existing store is never reset and a
                // deleted counter can never reissue a seq the journal already holds.
                Run(connection, "INSERT OR IGNORE INTO meta(key, value) SELECT 'revision', CAST(COALESCE((SELECT MAX(seq) FROM changes), 0) AS TEXT)");
            }

            Run(connection, "COMMIT");
        }
        catch
        {
            try
            {
                Run(connection, "ROLLBACK");
            }
            catch (SqliteException)
            {
                // The transaction may already be gone; the original failure is the one to report.
            }

            throw;
        }
    }

    private static readonly (string Table, string Name, string Op)[] TriggerSpecs = BuildTriggerSpecs();

    private static (string, string, string)[] BuildTriggerSpecs()
    {
        var specs = new List<(string, string, string)>();
        foreach (var table in new[] { "facts", "subjects", "refs", "slots" })
        {
            foreach (var (name, op) in new[] { ("insert", "INSERT"), ("update", "UPDATE"), ("delete", "DELETE") })
            {
                specs.Add((table, name, op));
            }
        }

        return specs.ToArray();
    }

    private static void Run(SqliteConnection connection, string sql)
    {
        using var command = connection.CreateCommand();
        command.CommandText = sql;
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// True when all twelve revision triggers exist with journal-writing bodies and the revision
    /// counter row is present.
    /// </summary>
    private static bool RevisionSchemaIsCurrent(SqliteConnection connection)
    {
        using var triggers = connection.CreateCommand();
        triggers.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type = 'trigger' AND name LIKE 'trg\\_%' ESCAPE '\\' AND sql LIKE '%INSERT INTO changes%'";
        if (Convert.ToInt64(triggers.ExecuteScalar(), System.Globalization.CultureInfo.InvariantCulture) != TriggerSpecs.Length)
        {
            return false;
        }

        using var meta = connection.CreateCommand();
        meta.CommandText = "SELECT COUNT(*) FROM meta WHERE key = 'revision'";
        return Convert.ToInt64(meta.ExecuteScalar(), System.Globalization.CultureInfo.InvariantCulture) > 0;
    }

    /// <summary>
    /// Durable cross-process change counter (meta.revision), bumped by triggers on every
    /// write to facts, subjects, refs and slots. 0 when the row is absent.
    /// </summary>
    public long Revision()
    {
        using var connection = OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT value FROM meta WHERE key = 'revision'";
        return command.ExecuteScalar() is string text
            && long.TryParse(text, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out var value)
            ? value
            : 0;
    }

    private static string DropRevisionTriggers()
    {
        var builder = new System.Text.StringBuilder();
        foreach (var (table, name, _) in TriggerSpecs)
        {
            builder.Append($"DROP TRIGGER IF EXISTS trg_{table}_{name};\n");
        }

        return builder.ToString();
    }

    /// <summary>
    /// One trigger per table and operation. Each bumps meta.revision and journals the row write under
    /// that same number (seq == revision), so the counter and the journal commit or roll back together.
    /// A missing counter row is re-seeded from the journal head, never from 0, so a deleted row cannot
    /// reissue a seq the journal already holds.
    /// </summary>
    private static string RevisionTriggers()
    {
        var builder = new System.Text.StringBuilder();
        foreach (var (table, name, op) in TriggerSpecs)
        {
            var row = name == "delete" ? "OLD" : "NEW";
            var (subject, fact) = table switch
            {
                "facts" => ($"{row}.subject_id", $"{row}.id"),
                "subjects" => ($"{row}.id", "NULL"),
                "refs" => ($"(SELECT subject_id FROM facts WHERE id = {row}.fact_id)", $"{row}.fact_id"),
                _ => ($"{row}.subject_id", $"{row}.fact_id"),
            };

            builder.Append($"""

                CREATE TRIGGER trg_{table}_{name} AFTER {op} ON {table} FOR EACH ROW
                BEGIN
                    INSERT INTO meta(key, value) SELECT 'revision', CAST(COALESCE((SELECT MAX(seq) FROM changes), 0) AS TEXT) WHERE NOT EXISTS (SELECT 1 FROM meta WHERE key = 'revision');
                    UPDATE meta SET value = CAST(CAST(value AS INTEGER) + 1 AS TEXT) WHERE key = 'revision';
                    INSERT INTO changes(seq, tbl, op, subject_id, fact_id, created_at) SELECT CAST(value AS INTEGER), '{table}', '{name}', {subject}, {fact}, strftime('%Y-%m-%dT%H:%M:%fZ', 'now') FROM meta WHERE key = 'revision';
                END;

                """);
        }

        return builder.ToString();
    }

    /// <summary>Opens a connection configured for WAL and a busy timeout.</summary>
    public SqliteConnection OpenConnection()
    {
        var connection = new SqliteConnection(new SqliteConnectionStringBuilder { DataSource = DbPath }.ToString());
        connection.Open();
        using var pragma = connection.CreateCommand();
        pragma.CommandText = "PRAGMA journal_mode=WAL; PRAGMA busy_timeout=5000; PRAGMA foreign_keys=ON;";
        pragma.ExecuteNonQuery();
        return connection;
    }

    internal static SqliteCommand Command(SqliteConnection connection, SqliteTransaction? transaction, string sql)
    {
        var command = connection.CreateCommand();
        command.Transaction = transaction;
        command.CommandText = sql;
        return command;
    }

    internal static void Bind(SqliteCommand command, string name, object? value) =>
        command.Parameters.AddWithValue(name, value ?? DBNull.Value);

    internal static string Timestamp() => DateTimeOffset.UtcNow.ToString("O");
}
