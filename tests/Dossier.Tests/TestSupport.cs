using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace Dossier.Tests;

/// <summary>Per-test database directory, deleted on dispose.</summary>
internal sealed class TempDb : IDisposable
{
    public TempDb()
    {
        Directory = Path.Combine(Path.GetTempPath(), "dossier-tests", Guid.NewGuid().ToString("N"));
        System.IO.Directory.CreateDirectory(Directory);
        DbPath = Path.Combine(Directory, "dossier.db");
        Store = new DossierStore(DbPath);
    }

    public string Directory { get; }

    public string DbPath { get; }

    public DossierStore Store { get; }

    public void Dispose()
    {
        SqliteConnection.ClearAllPools();
        try
        {
            System.IO.Directory.Delete(Directory, recursive: true);
        }
        catch (IOException)
        {
            // A leaked handle on a temp dir is not a test failure.
        }
    }
}

internal static class Fixtures
{
    public static PostFactsRequest Post(string name, params FactInput[] facts) => new()
    {
        Subject = new SubjectInput { Name = name },
        Facts = facts.ToList(),
    };

    public static FactInput Fact(
        string text,
        string? key = null,
        string? localId = null,
        List<RefInput>? refs = null,
        JsonElement? data = null,
        List<string>? tags = null,
        List<AttachmentInput>? attachments = null) => new()
    {
        Kind = "note",
        Text = text,
        Key = key,
        LocalId = localId,
        Refs = refs,
        Data = data,
        Tags = tags,
        Attachments = attachments,
    };

    public static RefInput Ref(
        string target,
        string? basis = "observed",
        string kind = "fact",
        string rel = "mentions",
        string? rev = null) => new()
    {
        Rel = rel,
        Kind = kind,
        Target = target,
        Basis = basis,
        Rev = rev,
    };

    public static JsonElement Json(string json) => JsonDocument.Parse(json).RootElement.Clone();

    public static long Count(SqliteConnection connection, string sql, params (string Name, object? Value)[] parameters)
    {
        using var command = connection.CreateCommand();
        command.CommandText = sql;
        foreach (var (name, value) in parameters)
        {
            command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }

        return Convert.ToInt64(command.ExecuteScalar());
    }

    public static object? Scalar(SqliteConnection connection, string sql, params (string Name, object? Value)[] parameters)
    {
        using var command = connection.CreateCommand();
        command.CommandText = sql;
        foreach (var (name, value) in parameters)
        {
            command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }

        return command.ExecuteScalar();
    }
}
