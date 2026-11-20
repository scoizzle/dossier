using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>verify request: the fact ids a plan, summary or answer cites.</summary>
public sealed class VerifyRequest
{
    public List<string> Ids { get; set; } = new();
}

/// <summary>
/// verify response. <c>Revision</c> is the store revision the answer was read at, and <c>Current</c> is
/// true only when every requested fact is live.
/// </summary>
public sealed class VerifyResponse
{
    public long Revision { get; set; }
    public bool Current { get; set; }
    public List<VerifiedFact> Facts { get; set; } = new();
}

/// <summary>
/// One fact's derived status. <c>Status</c> is the stored lifecycle (superseded, retracted) when that
/// applies, else stale, else contested, else live; an id the store does not hold is unknown.
/// </summary>
public sealed class VerifiedFact
{
    public string Id { get; set; } = string.Empty;
    public string? SubjectId { get; set; }
    public string Status { get; set; } = string.Empty;
    public bool Current { get; set; }

    /// <summary>
    /// Superseded only: the live fact at the end of its chain of successors (keyed reposts and
    /// corrections by ref), which may be several steps later. Absent when the chain ends in a retraction.
    /// </summary>
    public string? ReplacedBy { get; set; }

    /// <summary>Stale and contested only: the refs that make it so.</summary>
    public List<StatusReason>? Why { get; set; }
}

/// <summary>
/// Why a fact is stale or contested. <c>derived_from</c>: <c>Fact</c> is an input that changed, with its
/// <c>State</c> (superseded, retracted or stale) and, for a superseded input, the fact that replaced it.
/// <c>refutes</c> or <c>contradicts</c>: <c>Fact</c> is the other party of the dispute.
/// </summary>
public sealed class StatusReason
{
    public string Rel { get; set; } = string.Empty;
    public string Fact { get; set; } = string.Empty;
    public string? State { get; set; }
    public string? ReplacedBy { get; set; }
}

public sealed partial class DossierStore
{
    /// <summary>Most ids one verify call accepts.</summary>
    public const int MaxVerifyIds = 200;

    public const string StatusLive = "live";
    public const string StatusSuperseded = "superseded";
    public const string StatusRetracted = "retracted";
    public const string StatusStale = "stale";
    public const string StatusContested = "contested";
    public const string StatusUnknown = "unknown";

    /// <summary>
    /// verify. Reports the derived status of each requested fact, read in one snapshot. Stored status is
    /// only ever the lifecycle (live, superseded, retracted); stale and contested are derived here from
    /// refs and never written:
    /// <list type="bullet">
    /// <item>stale: a live fact with a <c>derived_from</c> ref to a fact that was retracted, was superseded
    /// by a different claim (a keyed repost or a correction by <c>supersedes</c> ref), or is itself stale.
    /// An input superseded by a repost of the same claim (same content hash) has not changed.</item>
    /// <item>contested: a live fact that is not stale and that a live, non-stale fact refutes or
    /// contradicts, or that itself contradicts one.</item>
    /// </list>
    /// Only refs of kind <c>fact</c> count: a slot ref follows whatever the slot holds, so it names no
    /// exact input. Writes nothing.
    /// </summary>
    public VerifyResponse Verify(VerifyRequest request)
    {
        var ids = (request.Ids ?? new List<string>())
            .Where(id => !string.IsNullOrWhiteSpace(id))
            .Select(id => id.Trim())
            .Distinct(StringComparer.Ordinal)
            .ToList();
        if (ids.Count == 0)
        {
            throw new DossierRequestException("invalid_request", "verify requires at least one fact id");
        }

        if (ids.Count > MaxVerifyIds)
        {
            throw new DossierRequestException("invalid_request", $"verify accepts at most {MaxVerifyIds} fact ids, got {ids.Count}");
        }

        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction(deferred: true);
        var reader = new CurrencyReader(connection, transaction);
        var facts = ids.Select(reader.Describe).ToList();
        return new VerifyResponse
        {
            Revision = HeadRevision(connection, transaction),
            Current = facts.All(fact => fact.Current),
            Facts = facts,
        };
    }

    /// <summary>
    /// Derives stale and contested for the facts it is asked about, inside one read transaction. Rows and
    /// staleness verdicts are cached for the lifetime of the reader, so shared ancestry is walked once.
    /// </summary>
    private sealed class CurrencyReader
    {
        private readonly SqliteConnection connection;
        private readonly SqliteTransaction transaction;
        private readonly Dictionary<string, Row?> rows = new(StringComparer.Ordinal);
        private readonly Dictionary<string, List<string>> inputs = new(StringComparer.Ordinal);
        private readonly Dictionary<string, bool> stale = new(StringComparer.Ordinal);

        public CurrencyReader(SqliteConnection connection, SqliteTransaction transaction)
        {
            this.connection = connection;
            this.transaction = transaction;
        }

        private sealed record Row(string Id, long RowId, string SubjectId, string Kind, string? Key, string Status, string ContentHash);

        /// <summary>What happened to a fact as an input: null when the claim it made still stands.</summary>
        private sealed record Change(string State, string? ReplacedBy);

        public VerifiedFact Describe(string id)
        {
            var row = Read(id);
            if (row is null)
            {
                return new VerifiedFact { Id = id, Status = StatusUnknown };
            }

            var fact = new VerifiedFact { Id = row.Id, SubjectId = row.SubjectId };
            if (row.Status == StatusRetracted)
            {
                fact.Status = StatusRetracted;
                return fact;
            }

            if (row.Status == StatusSuperseded)
            {
                fact.Status = StatusSuperseded;
                fact.ReplacedBy = Replacement(row);
                return fact;
            }

            var reasons = StaleReasons(row.Id);
            if (reasons.Count > 0)
            {
                fact.Status = StatusStale;
                fact.Why = reasons;
                return fact;
            }

            reasons = ContestedReasons(row.Id);
            if (reasons.Count > 0)
            {
                fact.Status = StatusContested;
                fact.Why = reasons;
                return fact;
            }

            fact.Status = StatusLive;
            fact.Current = true;
            return fact;
        }

        private Row? Read(string id)
        {
            if (rows.TryGetValue(id, out var cached))
            {
                return cached;
            }

            using var command = Command(connection, transaction, "SELECT id, rowid, subject_id, kind, key, status, content_hash FROM facts WHERE id = $id");
            Bind(command, "$id", id);
            using var reader = command.ExecuteReader();
            Row? row = reader.Read()
                ? new Row(
                    reader.GetString(0),
                    reader.GetInt64(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.IsDBNull(4) ? null : reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6))
                : null;
            rows[id] = row;
            return row;
        }

        /// <summary>
        /// The fact that took a fact's place: the earliest written of the next fact posted to the same
        /// slot (a keyed repost writes no ref) and the facts that carry a <c>supersedes</c> ref to it.
        /// Whichever was written first is the one that found it live. Read from the facts themselves,
        /// not from the slot table, which a correction or a retraction empties.
        /// </summary>
        private string? Successor(Row row)
        {
            using var command = Command(
                connection,
                transaction,
                """
                SELECT id FROM (
                    SELECT f.id AS id, f.rowid AS position FROM facts f
                    WHERE $key IS NOT NULL AND f.subject_id = $subject AND f.kind = $kind AND f.key = $key AND f.rowid > $rowid
                    UNION
                    SELECT f.id AS id, f.rowid AS position FROM refs r JOIN facts f ON f.id = r.fact_id
                    WHERE r.target = $id AND r.rel = 'supersedes' AND r.kind = 'fact' AND f.id <> $id
                ) ORDER BY position LIMIT 1
                """);
            Bind(command, "$id", row.Id);
            Bind(command, "$rowid", row.RowId);
            Bind(command, "$subject", row.SubjectId);
            Bind(command, "$kind", row.Kind);
            Bind(command, "$key", row.Key);
            return command.ExecuteScalar() as string;
        }

        /// <summary>
        /// The live fact at the end of a superseded fact's chain of successors, which may be several
        /// reposts or corrections later; null when the chain ends in a retraction or (in a hand-edited
        /// store) loops.
        /// </summary>
        private string? Replacement(Row row)
        {
            var seen = new HashSet<string>(StringComparer.Ordinal) { row.Id };
            var current = row;
            while (Successor(current) is { } next && seen.Add(next) && Read(next) is { } successor)
            {
                if (successor.Status is not (StatusSuperseded or StatusRetracted))
                {
                    return successor.Id;
                }

                current = successor;
            }

            return null;
        }

        /// <summary>
        /// Retracted, or superseded by a different claim. A fact whose replacement makes the same claim
        /// (same content hash, so the same text, data and refs) still says what its dependents relied on;
        /// a correction by ref never does, because its hash covers its <c>supersedes</c> ref.
        /// </summary>
        private Change? Changed(Row row)
        {
            if (row.Status == StatusRetracted)
            {
                return new Change(StatusRetracted, null);
            }

            if (row.Status != StatusSuperseded)
            {
                return null;
            }

            var replacement = Replacement(row);
            if (replacement is not null && Read(replacement) is { } current && current.ContentHash == row.ContentHash)
            {
                return null;
            }

            return new Change(StatusSuperseded, replacement);
        }

        /// <summary>The facts a fact names as <c>derived_from</c> inputs, in ref order, each once.</summary>
        private List<string> Inputs(string id)
        {
            if (inputs.TryGetValue(id, out var cached))
            {
                return cached;
            }

            var list = new List<string>();
            using (var command = Command(
                connection,
                transaction,
                "SELECT target FROM refs WHERE fact_id = $id AND rel = 'derived_from' AND kind = 'fact' ORDER BY seq"))
            {
                Bind(command, "$id", id);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var target = reader.GetString(0);
                    if (!list.Contains(target, StringComparer.Ordinal))
                    {
                        list.Add(target);
                    }
                }
            }

            inputs[id] = list;
            return list;
        }

        /// <summary>
        /// Staleness of <paramref name="id"/> and of everything it derives from. The ancestry is collected
        /// first and then settled as a fixed point, so a derivation cycle terminates and every member of
        /// it gets the same verdict whichever one was asked about first.
        /// </summary>
        private bool IsStale(string id)
        {
            if (stale.TryGetValue(id, out var known))
            {
                return known;
            }

            var ancestry = new List<string>();
            var seen = new HashSet<string>(StringComparer.Ordinal);
            var frontier = new Stack<string>();
            frontier.Push(id);
            while (frontier.Count > 0)
            {
                var current = frontier.Pop();
                if (!seen.Add(current) || stale.ContainsKey(current))
                {
                    continue;
                }

                // A changed input ends the walk: what it derived from no longer matters to its dependents.
                if (Read(current) is not { } row || Changed(row) is not null)
                {
                    continue;
                }

                ancestry.Add(current);
                foreach (var input in Inputs(current))
                {
                    frontier.Push(input);
                }
            }

            var verdict = new HashSet<string>(StringComparer.Ordinal);
            bool InputMakesStale(string input) =>
                Read(input) is { } row && (Changed(row) is not null || verdict.Contains(input) || (stale.TryGetValue(input, out var settled) && settled));

            for (var progressed = true; progressed;)
            {
                progressed = false;
                foreach (var fact in ancestry)
                {
                    if (!verdict.Contains(fact) && Inputs(fact).Any(InputMakesStale))
                    {
                        verdict.Add(fact);
                        progressed = true;
                    }
                }
            }

            foreach (var fact in ancestry)
            {
                stale[fact] = verdict.Contains(fact);
            }

            return stale.TryGetValue(id, out var result) && result;
        }

        private List<StatusReason> StaleReasons(string id)
        {
            var reasons = new List<StatusReason>();
            if (!IsStale(id))
            {
                return reasons;
            }

            foreach (var input in Inputs(id))
            {
                if (Read(input) is not { } row)
                {
                    // An input this store does not hold cannot be checked; it is not evidence of change.
                    continue;
                }

                if (Changed(row) is { } change)
                {
                    reasons.Add(new StatusReason { Rel = "derived_from", Fact = input, State = change.State, ReplacedBy = change.ReplacedBy });
                }
                else if (IsStale(input))
                {
                    reasons.Add(new StatusReason { Rel = "derived_from", Fact = input, State = StatusStale });
                }
            }

            return reasons;
        }

        /// <summary>A party to a dispute counts while it is stored live and not stale.</summary>
        private bool Stands(string id) =>
            Read(id) is { } row && row.Status is not (StatusSuperseded or StatusRetracted) && !IsStale(id);

        private List<StatusReason> ContestedReasons(string id)
        {
            var parties = new List<(string Rel, string Fact)>();
            using (var inbound = Command(
                connection,
                transaction,
                """
                SELECT r.rel, r.fact_id FROM refs r JOIN facts f ON f.id = r.fact_id
                WHERE r.target = $id AND r.kind = 'fact' AND r.rel IN ('refutes', 'contradicts') AND r.fact_id <> $id
                ORDER BY f.created_at, f.rowid, r.seq
                """))
            {
                Bind(inbound, "$id", id);
                using var reader = inbound.ExecuteReader();
                while (reader.Read())
                {
                    parties.Add((reader.GetString(0), reader.GetString(1)));
                }
            }

            using (var outbound = Command(
                connection,
                transaction,
                "SELECT r.rel, r.target FROM refs r WHERE r.fact_id = $id AND r.kind = 'fact' AND r.rel = 'contradicts' AND r.target <> $id ORDER BY r.seq"))
            {
                Bind(outbound, "$id", id);
                using var reader = outbound.ExecuteReader();
                while (reader.Read())
                {
                    parties.Add((reader.GetString(0), reader.GetString(1)));
                }
            }

            var reasons = new List<StatusReason>();
            foreach (var (rel, other) in parties)
            {
                if (Stands(other) && !reasons.Any(reason => reason.Rel == rel && reason.Fact == other))
                {
                    reasons.Add(new StatusReason { Rel = rel, Fact = other });
                }
            }

            return reasons;
        }
    }
}
