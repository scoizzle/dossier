using System.Text;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace Dossier;

public sealed partial class DossierStore
{
    private const int DefaultLimit = 20;
    private const int MaxLimit = 100;

    /// <summary>
    /// search. Every filter combines with AND. A subject filter matches a subject id exactly or a
    /// subject name/alias after casefold and whitespace collapse. q runs an FTS5 MATCH with bm25
    /// column weights text=10, tags=3. ref_target direction=in is the reverse-impact query (facts
    /// carrying a ref to that target); direction=out follows the refs of a named fact or slot.
    /// Ordering is deterministic: q ranks by bm25, then created_at and id; otherwise created_at
    /// and id. total is the full count the limit was applied to; complete says nothing was cut.
    /// </summary>
    public SearchResponse Search(SearchRequest request)
    {
        var direction = request.Direction;
        if (direction is not null && direction is not ("in" or "out"))
        {
            throw new DossierRequestException(
                "invalid_direction",
                $"direction must be \"in\" or \"out\", got \"{direction}\"");
        }

        var limit = Math.Clamp(request.Limit ?? DefaultLimit, 1, MaxLimit);
        var conditions = new List<string>();
        var parameters = new Dictionary<string, object?>(StringComparer.Ordinal);

        using var connection = OpenConnection();

        if (request.Subject is not null)
        {
            var subjectIds = ResolveSubjectIds(connection, request.Subject);
            if (subjectIds.Count == 0)
            {
                return EmptyResponse();
            }

            conditions.Add($"f.subject_id IN ({BindList(parameters, "subject", subjectIds)})");
        }

        if (request.Kind is not null)
        {
            conditions.Add("f.kind = $kind");
            parameters["$kind"] = request.Kind;
        }

        if (request.Key is not null)
        {
            conditions.Add("f.key = $key");
            parameters["$key"] = request.Key;
        }

        if (request.Tag is not null)
        {
            conditions.Add("EXISTS (SELECT 1 FROM json_each(f.tags) je WHERE je.value = $tag)");
            parameters["$tag"] = request.Tag;
        }

        if (request.Actor is not null)
        {
            conditions.Add("json_extract(f.provenance, '$.actor') = $actor");
            parameters["$actor"] = request.Actor;
        }

        if (request.Status is not null)
        {
            conditions.Add("f.status = $status");
            parameters["$status"] = request.Status;
        }
        else
        {
            conditions.Add("f.status NOT IN ('superseded', 'retracted')");
        }

        if (request.Since is not null)
        {
            conditions.Add("julianday(f.created_at) >= julianday($since)");
            parameters["$since"] = request.Since;
        }

        if (request.RefTarget is not null)
        {
            if (direction == "out")
            {
                var referenced = ResolveOutgoingFacts(connection, request.RefTarget);
                if (referenced.Count == 0)
                {
                    return EmptyResponse();
                }

                conditions.Add($"f.id IN ({BindList(parameters, "out", referenced)})");
            }
            else
            {
                conditions.Add("EXISTS (SELECT 1 FROM refs r WHERE r.fact_id = f.id AND r.target = $refTarget)");
                parameters["$refTarget"] = request.RefTarget;
            }
        }

        string? scoreExpression = null;
        var join = string.Empty;
        if (!string.IsNullOrWhiteSpace(request.Q))
        {
            join = "JOIN facts_fts ON facts_fts.rowid = f.rowid";
            conditions.Add("facts_fts MATCH $q");
            parameters["$q"] = request.Q;
            scoreExpression = "bm25(facts_fts, 10.0, 3.0)";
        }

        var inner = new StringBuilder();
        inner.Append("SELECT f.id, f.subject_id, f.kind, f.text, f.tags, f.confidence, f.status, f.created_at, ");
        inner.Append(scoreExpression ?? "NULL").Append(" AS score FROM facts f ").Append(join);
        if (conditions.Count > 0)
        {
            inner.Append(" WHERE ").Append(string.Join(" AND ", conditions));
        }

        var outer = new List<string>();
        CursorState? cursor = null;
        if (request.Cursor is not null)
        {
            cursor = DecodeCursor(request.Cursor);
            if (scoreExpression is not null)
            {
                if (cursor.S is null)
                {
                    throw new DossierRequestException("invalid_cursor", "cursor is not a search cursor for a q search");
                }

                parameters["$cursorScore"] = cursor.S;
                outer.Add(
                    "(t.score > $cursorScore OR (t.score = $cursorScore AND " +
                    "(t.created_at > $cursorCreated OR (t.created_at = $cursorCreated AND t.id > $cursorId))))");
            }
            else
            {
                outer.Add("(t.created_at > $cursorCreated OR (t.created_at = $cursorCreated AND t.id > $cursorId))");
            }

            parameters["$cursorCreated"] = cursor.C;
            parameters["$cursorId"] = cursor.I;
        }

        var outerWhere = outer.Count > 0 ? " WHERE " + string.Join(" AND ", outer) : string.Empty;

        int total;
        var page = new List<HitRow>();
        try
        {
            using (var countCommand = Command(connection, null, $"SELECT COUNT(*) FROM ({inner}) t{outerWhere}"))
            {
                BindAll(countCommand, parameters);
                total = Convert.ToInt32(countCommand.ExecuteScalar());
            }

            var order = scoreExpression is not null
                ? "t.score ASC, t.created_at ASC, t.id ASC"
                : "t.created_at ASC, t.id ASC";

            using var pageCommand = Command(
                connection,
                null,
                $"SELECT t.id, t.subject_id, t.kind, t.text, t.tags, t.confidence, t.status, t.score, t.created_at " +
                $"FROM ({inner}) t{outerWhere} ORDER BY {order} LIMIT $limit");
            BindAll(pageCommand, parameters);
            Bind(pageCommand, "$limit", limit);

            using var reader = pageCommand.ExecuteReader();
            while (reader.Read())
            {
                page.Add(new HitRow(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    reader.GetString(4),
                    reader.GetDouble(5),
                    reader.GetString(6),
                    reader.IsDBNull(7) ? null : reader.GetDouble(7),
                    reader.GetString(8)));
            }
        }
        catch (SqliteException exception) when (scoreExpression is not null)
        {
            throw new DossierRequestException("invalid_query", $"q is not a valid FTS5 query: {exception.Message}");
        }

        var hits = page.Select(row => row.ToView()).ToList();
        var complete = total <= hits.Count;

        return new SearchResponse
        {
            Hits = hits,
            Total = total,
            Complete = complete,
            Refine = complete ? null : RefineHint(request),
            Next = complete || page.Count == 0
                ? null
                : EncodeCursor(page[^1].CreatedAt, page[^1].Id, page[^1].Score),
        };
    }

    private static SearchResponse EmptyResponse() => new()
    {
        Hits = new List<FactView>(),
        Total = 0,
        Complete = true,
    };

    private static string RefineHint(SearchRequest request)
    {
        var unused = new List<string>();
        if (request.Subject is null)
        {
            unused.Add("subject");
        }

        if (request.Kind is null)
        {
            unused.Add("kind");
        }

        if (request.Tag is null)
        {
            unused.Add("tag");
        }

        if (request.Status is null)
        {
            unused.Add("status");
        }

        if (string.IsNullOrWhiteSpace(request.Q))
        {
            unused.Add("q");
        }

        if (request.RefTarget is null)
        {
            unused.Add("ref_target");
        }

        return unused.Count == 0
            ? "add a more specific q"
            : "narrow by " + string.Join(", ", unused);
    }

    private static string BindList(Dictionary<string, object?> parameters, string prefix, IReadOnlyList<string> values)
    {
        var names = new List<string>(values.Count);
        for (var i = 0; i < values.Count; i++)
        {
            var name = $"${prefix}{i}";
            parameters[name] = values[i];
            names.Add(name);
        }

        return string.Join(", ", names);
    }

    private static void BindAll(SqliteCommand command, IReadOnlyDictionary<string, object?> parameters)
    {
        foreach (var pair in parameters)
        {
            Bind(command, pair.Key, pair.Value);
        }
    }

    /// <summary>Subject ids whose id equals the value exactly, or whose name/alias matches casefolded.</summary>
    private static List<string> ResolveSubjectIds(SqliteConnection connection, string value)
    {
        var wanted = Names.Normalize(value);
        var ids = new List<string>();

        using var command = Command(connection, null, "SELECT id, name, aliases FROM subjects");
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var id = reader.GetString(0);
            var name = reader.GetString(1);
            var aliases = ParseAliases(reader.GetString(2));

            if (string.Equals(id, value, StringComparison.Ordinal)
                || Names.Normalize(name) == wanted
                || aliases.Any(alias => Names.Normalize(alias) == wanted))
            {
                ids.Add(id);
            }
        }

        return ids;
    }

    /// <summary>
    /// direction=out: resolve ref_target to the fact ids it references. ref_target is a fact id, a
    /// slot target, or an external-looking value, which is rejected with a named error.
    /// </summary>
    private static List<string> ResolveOutgoingFacts(SqliteConnection connection, string refTarget)
    {
        var seeds = ResolveOutgoingSeeds(connection, refTarget);
        var referenced = new List<string>();

        foreach (var seed in seeds)
        {
            using var command = Command(connection, null, "SELECT kind, target FROM refs WHERE fact_id = $seed ORDER BY seq");
            Bind(command, "$seed", seed);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var kind = reader.GetString(0);
                var target = reader.GetString(1);

                if (string.Equals(kind, "slot", StringComparison.Ordinal))
                {
                    AddDistinct(referenced, ResolveSlotTarget(connection, target));
                }
                else if (FactExists(connection, target))
                {
                    AddDistinct(referenced, new[] { target });
                }
            }
        }

        return referenced;
    }

    private static List<string> ResolveOutgoingSeeds(SqliteConnection connection, string refTarget)
    {
        if (FactExists(connection, refTarget))
        {
            return new List<string> { refTarget };
        }

        var hash = refTarget.IndexOf('#');
        if (hash > 0)
        {
            return ResolveSlotTarget(connection, refTarget);
        }

        if (LooksExternal(refTarget))
        {
            throw new DossierRequestException(
                "ref_target_not_internal",
                $"ref_target \"{refTarget}\" is not a fact id or slot target");
        }

        return new List<string>();
    }

    /// <summary>Resolve a slot target "&lt;subjectIdOrName&gt;#&lt;key&gt;" to every fact currently in that slot.</summary>
    private static List<string> ResolveSlotTarget(SqliteConnection connection, string target)
    {
        var hash = target.IndexOf('#');
        if (hash <= 0 || hash == target.Length - 1)
        {
            return new List<string>();
        }

        var subjectPart = target[..hash];
        var key = target[(hash + 1)..];
        var factIds = new List<string>();

        foreach (var subjectId in ResolveSubjectIds(connection, subjectPart))
        {
            using var command = Command(connection, null, "SELECT fact_id FROM slots WHERE subject_id = $subject AND key = $key ORDER BY fact_id");
            Bind(command, "$subject", subjectId);
            Bind(command, "$key", key);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                AddDistinct(factIds, new[] { reader.GetString(0) });
            }
        }

        return factIds;
    }

    private static bool FactExists(SqliteConnection connection, string id)
    {
        using var command = Command(connection, null, "SELECT 1 FROM facts WHERE id = $id LIMIT 1");
        Bind(command, "$id", id);
        return command.ExecuteScalar() is not null;
    }

    private static void AddDistinct(List<string> target, IEnumerable<string> additions)
    {
        foreach (var addition in additions)
        {
            if (!target.Contains(addition, StringComparer.Ordinal))
            {
                target.Add(addition);
            }
        }
    }

    /// <summary>An external-looking target carries a URI scheme, e.g. "https://..." or "github:owner/repo".</summary>
    private static bool LooksExternal(string target)
    {
        if (target.Contains("://", StringComparison.Ordinal))
        {
            return true;
        }

        var colon = target.IndexOf(':');
        if (colon <= 0)
        {
            return false;
        }

        for (var i = 0; i < colon; i++)
        {
            var character = target[i];
            var valid = char.IsAsciiLetter(character)
                || (i > 0 && (char.IsAsciiDigit(character) || character is '+' or '-' or '.'));
            if (!valid)
            {
                return false;
            }
        }

        return true;
    }

    private static string EncodeCursor(string createdAt, string id, double? score)
    {
        var json = JsonSerializer.Serialize(new CursorState { C = createdAt, I = id, S = score });
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(json))
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');
    }

    private static CursorState DecodeCursor(string cursor)
    {
        try
        {
            var padded = cursor.Replace('-', '+').Replace('_', '/');
            padded = (padded.Length % 4) switch
            {
                2 => padded + "==",
                3 => padded + "=",
                _ => padded,
            };

            var state = JsonSerializer.Deserialize<CursorState>(Encoding.UTF8.GetString(Convert.FromBase64String(padded)));
            if (state is null || string.IsNullOrEmpty(state.C) || string.IsNullOrEmpty(state.I))
            {
                throw new DossierRequestException("invalid_cursor", "cursor is not a value returned by search");
            }

            return state;
        }
        catch (FormatException)
        {
            throw new DossierRequestException("invalid_cursor", "cursor is not valid base64");
        }
        catch (JsonException)
        {
            throw new DossierRequestException("invalid_cursor", "cursor is not a value returned by search");
        }
    }

    private sealed class CursorState
    {
        public string C { get; set; } = string.Empty;
        public string I { get; set; } = string.Empty;
        public double? S { get; set; }
    }

    private sealed record HitRow(
        string Id,
        string SubjectId,
        string Kind,
        string Text,
        string Tags,
        double Confidence,
        string Status,
        double? Score,
        string CreatedAt)
    {
        public FactView ToView() => new()
        {
            Id = Id,
            SubjectId = SubjectId,
            Kind = Kind,
            Text = Text,
            Tags = ParseAliases(Tags),
            Confidence = Confidence,
            Status = Status,
            Score = Score,
        };
    }
}
