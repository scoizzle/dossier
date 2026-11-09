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
        using var command = connection.CreateCommand();
        command.CommandText = Schema;
        command.ExecuteNonQuery();
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
