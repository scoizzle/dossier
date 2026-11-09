using System.Text;
using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>correlate request, per contract/ops.schema.json.</summary>
public sealed class CorrelateRequest
{
    public string? Subject { get; set; }
    public List<string>? Matchers { get; set; }
}

/// <summary>
/// correlate response. Proposals carry basis "derived"; nothing here is ever written or
/// asserted. <see cref="Truncated"/> is omitted unless the 200-proposal cap was hit.
/// </summary>
public sealed class CorrelateResponse
{
    public List<CorrelationProposal> Proposed { get; set; } = new();
    public bool? Truncated { get; set; }
}

public sealed class CorrelationProposal
{
    public string FactId { get; set; } = string.Empty;
    public RefInput Ref { get; set; } = new();
}

public sealed partial class DossierStore
{
    private const int MaxProposals = 200;

    /// <summary>
    /// correlate. Deterministic matchers only, live facts only, read-only. same_ref pairs two
    /// facts carrying an external ref (kind not fact|slot|subject) with the same normalized
    /// kind and target; shared_tag pairs two facts sharing a normalized tag. Every ordered pair
    /// proposes rel=mentions kind=fact with basis "derived", deduplicated and ordered by
    /// fact_id then target, capped at 200 with a truncated flag.
    /// </summary>
    public CorrelateResponse Correlate(CorrelateRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var matchers = request.Matchers is { Count: > 0 }
            ? request.Matchers
            : new List<string> { "same_ref", "shared_tag" };

        foreach (var matcher in matchers)
        {
            if (matcher is not ("same_ref" or "shared_tag"))
            {
                throw new DossierRequestException(
                    "invalid_matcher",
                    $"matcher must be same_ref or shared_tag, got \"{matcher}\"");
            }
        }

        using var connection = OpenConnection();

        List<string>? subjectIds = null;
        if (request.Subject is not null)
        {
            subjectIds = ResolveSubjectIds(connection, request.Subject);
            if (subjectIds.Count == 0)
            {
                return new CorrelateResponse();
            }
        }

        var pairs = new HashSet<(string Fact, string Target)>();

        if (matchers.Contains("same_ref", StringComparer.Ordinal))
        {
            AddSameRefPairs(connection, subjectIds, pairs);
        }

        if (matchers.Contains("shared_tag", StringComparer.Ordinal))
        {
            AddSharedTagPairs(ReadLiveFactTags(connection, subjectIds), pairs);
        }

        var ordered = pairs
            .OrderBy(pair => pair.Fact, StringComparer.Ordinal)
            .ThenBy(pair => pair.Target, StringComparer.Ordinal)
            .ToList();

        var response = new CorrelateResponse();
        if (ordered.Count > MaxProposals)
        {
            response.Truncated = true;
            ordered = ordered.Take(MaxProposals).ToList();
        }

        foreach (var pair in ordered)
        {
            response.Proposed.Add(new CorrelationProposal
            {
                FactId = pair.Fact,
                Ref = new RefInput
                {
                    Rel = "mentions",
                    Kind = "fact",
                    Target = pair.Target,
                    Basis = "derived",
                },
            });
        }

        return response;
    }

    /// <summary>External refs grouped by normalized (kind, target); each fact pair proposes both ways.</summary>
    private static void AddSameRefPairs(
        SqliteConnection connection,
        IReadOnlyList<string>? subjectIds,
        HashSet<(string Fact, string Target)> pairs)
    {
        var sql = new StringBuilder(
            "SELECT r.fact_id, r.kind, r.target FROM refs r JOIN facts f ON f.id = r.fact_id WHERE f.status = 'live'");
        var parameters = new Dictionary<string, object?>(StringComparer.Ordinal);
        AppendSubjectFilter(sql, parameters, subjectIds);
        sql.Append(" ORDER BY r.fact_id, r.seq");

        var groups = new Dictionary<(string Kind, string Target), List<string>>();

        using var command = Command(connection, null, sql.ToString());
        BindAll(command, parameters);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var factId = reader.GetString(0);
            var kind = Names.Normalize(reader.GetString(1));
            var target = Names.Normalize(reader.GetString(2));

            if (kind.Length == 0 || target.Length == 0
                || kind is "fact" or "slot" or "subject")
            {
                continue;
            }

            var key = (kind, target);
            if (!groups.TryGetValue(key, out var factIds))
            {
                factIds = new List<string>();
                groups[key] = factIds;
            }

            if (!factIds.Contains(factId, StringComparer.Ordinal))
            {
                factIds.Add(factId);
            }
        }

        AddPairwise(groups.Values, pairs);
    }

    private static void AddSharedTagPairs(
        Dictionary<string, List<string>> tagsByFact,
        HashSet<(string Fact, string Target)> pairs)
    {
        var groups = new Dictionary<string, List<string>>(StringComparer.Ordinal);

        foreach (var (factId, tags) in tagsByFact)
        {
            foreach (var tag in tags)
            {
                var normalized = Names.Normalize(tag);
                if (normalized.Length == 0)
                {
                    continue;
                }

                if (!groups.TryGetValue(normalized, out var factIds))
                {
                    factIds = new List<string>();
                    groups[normalized] = factIds;
                }

                if (!factIds.Contains(factId, StringComparer.Ordinal))
                {
                    factIds.Add(factId);
                }
            }
        }

        AddPairwise(groups.Values, pairs);
    }

    private static void AddPairwise(
        IEnumerable<List<string>> groups,
        HashSet<(string Fact, string Target)> pairs)
    {
        foreach (var factIds in groups)
        {
            foreach (var fact in factIds)
            {
                foreach (var other in factIds)
                {
                    if (!string.Equals(fact, other, StringComparison.Ordinal))
                    {
                        pairs.Add((fact, other));
                    }
                }
            }
        }
    }

    private static Dictionary<string, List<string>> ReadLiveFactTags(
        SqliteConnection connection,
        IReadOnlyList<string>? subjectIds)
    {
        var sql = new StringBuilder("SELECT f.id, f.tags FROM facts f WHERE f.status = 'live'");
        var parameters = new Dictionary<string, object?>(StringComparer.Ordinal);
        AppendSubjectFilter(sql, parameters, subjectIds);
        sql.Append(" ORDER BY f.id");

        var facts = new Dictionary<string, List<string>>(StringComparer.Ordinal);

        using var command = Command(connection, null, sql.ToString());
        BindAll(command, parameters);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            facts[reader.GetString(0)] = ParseAliases(reader.GetString(1));
        }

        return facts;
    }

    private static void AppendSubjectFilter(
        StringBuilder sql,
        Dictionary<string, object?> parameters,
        IReadOnlyList<string>? subjectIds)
    {
        if (subjectIds is null || subjectIds.Count == 0)
        {
            return;
        }

        var names = new List<string>(subjectIds.Count);
        for (var index = 0; index < subjectIds.Count; index++)
        {
            var name = "$subject" + index;
            names.Add(name);
            parameters[name] = subjectIds[index];
        }

        sql.Append(" AND f.subject_id IN (").Append(string.Join(", ", names)).Append(')');
    }
}
