using System.Globalization;
using System.Text.Json.Serialization;
using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>One journal row, joined to its fact and subject at read time.</summary>
public sealed record ChangeRow(
    long Seq,
    string Tbl,
    string Op,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? SubjectId,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? SubjectName,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? FactId,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? FactKind,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? FactStatus,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? Text,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.Never)] string? Actor,
    string At);

/// <summary>
/// A page of the journal. <c>Next</c> is the cursor to pass back as <c>since</c>; <c>Reset</c> means the
/// caller's cursor is outside the retained window (or ahead of the head) and it must refetch everything.
/// </summary>
public sealed record ChangesPage(long From, long To, long Next, bool Truncated, bool Reset, List<ChangeRow> Changes);

/// <summary>
/// changes request, shared by the MCP tool and the CLI verb: rows after <c>Since</c> (default 0), or the
/// newest <c>Last</c> rows when that is given (it wins), optionally for one subject.
/// </summary>
public sealed class ChangesRequest
{
    public long? Since { get; set; }
    public int? Last { get; set; }
    public int? Limit { get; set; }
    public string? Subject { get; set; }
}

public sealed partial class DossierStore
{
    /// <summary>Rows per page when a changes request names no limit; the same default <c>/api/changes</c> uses.</summary>
    public const int DefaultChangesLimit = 100;

    /// <summary>Journal rows kept after pruning.</summary>
    internal const int ChangeRetention = 100_000;

    /// <summary>Rows beyond the retention that accumulate before a prune runs, so deletes are amortized.</summary>
    internal const int PruneSlack = 1_000;

    private const string ChangeColumns = """
        c.seq, c.tbl, c.op, c.subject_id, s.name, c.fact_id, f.kind, f.status, substr(f.text, 1, 160),
        CASE WHEN c.tbl = 'facts' AND c.op = 'insert' AND json_valid(f.provenance) THEN json_extract(f.provenance, '$.actor') END,
        c.created_at
        """;

    private const string ChangeFrom = "FROM changes c LEFT JOIN facts f ON f.id = c.fact_id LEFT JOIN subjects s ON s.id = c.subject_id";

    /// <summary>The current head (meta.revision) as seen by <paramref name="transaction"/>; 0 when absent.</summary>
    internal static long HeadRevision(SqliteConnection connection, SqliteTransaction? transaction)
    {
        using var command = Command(connection, transaction, "SELECT value FROM meta WHERE key = 'revision'");
        return command.ExecuteScalar() is string text
            && long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value)
            ? value
            : 0;
    }

    /// <summary>
    /// Drops journal rows older than <c>head - retention</c>, but only once the oldest row is more than
    /// <c>retention + slack</c> behind the head, so the delete runs about once per <c>slack</c> writes.
    /// Runs inside the caller's write transaction.
    /// </summary>
    internal static void PruneChanges(SqliteConnection connection, SqliteTransaction? transaction, long head, int retention = ChangeRetention, int slack = PruneSlack)
    {
        using var oldest = Command(connection, transaction, "SELECT MIN(seq) FROM changes");
        if (oldest.ExecuteScalar() is not long min || min >= head - retention - slack)
        {
            return;
        }

        using var delete = Command(connection, transaction, "DELETE FROM changes WHERE seq <= $cut");
        Bind(delete, "$cut", head - retention);
        delete.ExecuteNonQuery();
    }

    /// <summary>Prunes against the head the transaction sees; the call writers make before commit.</summary>
    internal static void PruneChanges(SqliteConnection connection, SqliteTransaction transaction) =>
        PruneChanges(connection, transaction, HeadRevision(connection, transaction));

    /// <summary>
    /// Journal rows with <c>seq &gt; since</c>, oldest first, at most <paramref name="limit"/>. The head, the
    /// oldest retained seq and the rows are read in one deferred transaction, so they describe one snapshot
    /// and the read never takes the write lock. With <paramref name="subject"/> (an id, name or alias) only
    /// that subject's rows are returned, and a page that is not truncated moves <c>Next</c> to the head:
    /// nothing of the subject is left behind it, so the cursor may skip other subjects' rows.
    /// </summary>
    public ChangesPage ReadChanges(long since, int limit, string? subject = null)
    {
        limit = Math.Clamp(limit, 1, 500);
        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction(deferred: true);
        var (head, oldest) = ReadWindow(connection, transaction);
        var filter = SubjectFilter(connection, transaction, subject);

        if (since > head || since < oldest - 1)
        {
            return new ChangesPage(since, head, head, false, true, new List<ChangeRow>());
        }

        if (filter is null)
        {
            var rows = ReadRows(connection, transaction, $"SELECT {ChangeColumns} {ChangeFrom} WHERE c.seq > $since ORDER BY c.seq LIMIT $limit", ("$since", since), ("$limit", limit));
            var next = rows.Count > 0 ? rows[^1].Seq : head;
            return new ChangesPage(since, next, next, rows.Count > 0 && next < head, false, rows);
        }

        // One row past the page says whether the subject has more; without it the page ends at the head.
        var matched = ReadRows(
            connection,
            transaction,
            $"SELECT {ChangeColumns} {ChangeFrom} WHERE c.seq > $since AND {filter.Value.Sql} ORDER BY c.seq LIMIT $limit",
            [("$since", since), ("$limit", limit + 1), .. filter.Value.Parameters]);
        var truncated = matched.Count > limit;
        if (truncated)
        {
            matched.RemoveAt(matched.Count - 1);
        }

        var cursor = truncated ? matched[^1].Seq : head;
        return new ChangesPage(since, cursor, cursor, truncated, false, matched);
    }

    /// <summary>
    /// The newest <paramref name="limit"/> rows, oldest first; <c>Next</c> is the head. Reads in one
    /// deferred transaction, so it is a WAL snapshot read and never takes the write lock. With
    /// <paramref name="subject"/> the rows are that subject's newest.
    /// </summary>
    public ChangesPage ReadChangesLast(int limit, string? subject = null)
    {
        limit = Math.Clamp(limit, 1, 500);
        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction(deferred: true);
        var (head, oldest) = ReadWindow(connection, transaction);
        var filter = SubjectFilter(connection, transaction, subject);

        if (filter is null)
        {
            var rows = ReadRows(
                connection,
                transaction,
                $"SELECT * FROM (SELECT {ChangeColumns} {ChangeFrom} ORDER BY c.seq DESC LIMIT $limit) ORDER BY 1",
                ("$limit", limit));
            var from = rows.Count > 0 ? rows[0].Seq - 1 : head;
            return new ChangesPage(from, head, head, rows.Count > 0 && rows[0].Seq > oldest, false, rows);
        }

        var matched = ReadRows(
            connection,
            transaction,
            $"SELECT * FROM (SELECT {ChangeColumns} {ChangeFrom} WHERE {filter.Value.Sql} ORDER BY c.seq DESC LIMIT $limit) ORDER BY 1",
            [("$limit", limit + 1), .. filter.Value.Parameters]);
        var older = matched.Count > limit;
        if (older)
        {
            matched.RemoveAt(0);
        }

        return new ChangesPage(matched.Count > 0 ? matched[0].Seq - 1 : head, head, head, older, false, matched);
    }

    /// <summary>
    /// The SQL condition and parameters that keep one subject's journal rows, or null for no filter.
    /// A subject that resolves to nothing is rejected: a typo must not read as "nothing changed".
    /// </summary>
    private static (string Sql, (string Name, object Value)[] Parameters)? SubjectFilter(SqliteConnection connection, SqliteTransaction transaction, string? subject)
    {
        if (subject is null)
        {
            return null;
        }

        var ids = ResolveSubjectIds(connection, subject, transaction);
        if (ids.Count == 0)
        {
            throw new DossierRequestException("subject_not_found", $"subject \"{subject}\" was not found");
        }

        var parameters = ids.Select((id, index) => ($"$subject{index}", (object)id)).ToArray();
        return ($"c.subject_id IN ({string.Join(", ", parameters.Select(p => p.Item1))})", parameters);
    }

    private static (long Head, long Oldest) ReadWindow(SqliteConnection connection, SqliteTransaction transaction)
    {
        var head = HeadRevision(connection, transaction);
        using var command = Command(connection, transaction, "SELECT MIN(seq) FROM changes");
        var oldest = command.ExecuteScalar() is long min ? min : head + 1;
        return (head, oldest);
    }

    private static List<ChangeRow> ReadRows(SqliteConnection connection, SqliteTransaction transaction, string sql, params (string Name, object Value)[] parameters)
    {
        using var command = Command(connection, transaction, sql);
        foreach (var (name, value) in parameters)
        {
            Bind(command, name, value);
        }

        var rows = new List<ChangeRow>();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string? Text(int index) => reader.IsDBNull(index) ? null : Convert.ToString(reader.GetValue(index), CultureInfo.InvariantCulture);
            rows.Add(new ChangeRow(
                reader.GetInt64(0),
                reader.GetString(1),
                reader.GetString(2),
                Text(3),
                Text(4),
                Text(5),
                Text(6),
                Text(7),
                Text(8),
                Text(9),
                reader.GetString(10)));
        }

        return rows;
    }
}
