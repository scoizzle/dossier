using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>compile_dossier request, per contract/ops.schema.json (follow is accepted but not used until Gate B).</summary>
public sealed class CompileRequest
{
    public string Subject { get; set; } = string.Empty;
    public bool? Descendants { get; set; }
    public List<string>? Needs { get; set; }
    public int? Budget { get; set; }
    public string? Depth { get; set; }
    public string? Order { get; set; }
    public RankOptions? Rank { get; set; }
    public JsonElement? Follow { get; set; }
    public string? Format { get; set; }
}

public sealed class RankOptions
{
    public double? Recency { get; set; }
}

/// <summary>The compiled Dossier object, per contract/dossier.schema.json.</summary>
public sealed class CompiledDossier
{
    public DossierSubject Subject { get; set; } = new();
    public string Depth { get; set; } = "index";
    public List<string> Needs { get; set; } = new();
    public int BudgetTokens { get; set; }
    public int UsedTokens { get; set; }
    public List<FactView> Facts { get; set; } = new();
    public List<FactView> Linked { get; set; } = new();
    public List<DossierConflict> Conflicts { get; set; } = new();
    public List<DossierGap> Gaps { get; set; } = new();
    public List<string> Dropped { get; set; } = new();
    public string? Degraded { get; set; }
    public DossierSelfCheck SelfCheck { get; set; } = new();
}

public sealed class DossierSubject
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public string? Parent { get; set; }
    public List<string> Aliases { get; set; } = new();
    public DossierPin? Pin { get; set; }
}

public sealed class DossierPin
{
    public string Repo { get; set; } = string.Empty;
    public string Rev { get; set; } = string.Empty;
}

public sealed class DossierConflict
{
    public string Field { get; set; } = string.Empty;
    public List<ConflictValue> Values { get; set; } = new();

    /// <summary>Always null; emitted explicitly because the contract requires the key.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string? Resolution { get; set; }
}

public sealed class ConflictValue
{
    public string Fact { get; set; } = string.Empty;
    public JsonElement Value { get; set; }
}

public sealed class DossierGap
{
    public string Need { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
}

public sealed class DossierSelfCheck
{
    public int UncitedClaims { get; set; }
    public int ConflictsSurfaced { get; set; }
}

public sealed partial class DossierStore
{
    public const int DefaultBudgetTokens = 1200;
    public const double DefaultRecencyWeight = 0.2;
    private const int IndexTokenCap = 300;
    private const int IndexMaxFacts = 8;
    private const int IndexMinFacts = 3;
    private const int IndexLineLength = 120;
    private const int MaxDescendantDepth = 3;
    private const double DedupeThreshold = 0.85;
    private const int DedupeMinTokens = 4;

    private static readonly HashSet<string> Stopwords = new(StringComparer.Ordinal)
    {
        "a", "an", "and", "are", "as", "at", "be", "by", "for", "from", "has", "in", "is", "it", "of", "on",
        "or", "that", "the", "this", "to", "was", "were", "with",
    };

    /// <summary>Token estimator: ceil(length / 4).</summary>
    public static int EstimateTokens(string value) => (value.Length + 3) / 4;

    /// <summary>
    /// Estimated tokens of one fact as the caller receives it in the requested format:
    /// the serialized FactView for json, or the single rendered markdown line for markdown.
    /// </summary>
    public static int EstimateFactTokens(FactView fact, string format) => format == "markdown"
        ? EstimateTokens("- " + OneLine(fact.Text, int.MaxValue) + " [" + fact.Id + "]\n")
        : EstimateTokens(Serialize(fact));

    /// <summary>Estimated tokens of a whole dossier as the caller receives it in the requested format.</summary>
    public static int EstimateRenderedTokens(CompiledDossier dossier, string format) => format == "markdown"
        ? EstimateTokens(RenderMarkdown(dossier))
        : EstimateTokens(Serialize(dossier));

    /// <summary>
    /// What one index-depth fact spends against the index cap: its text payload for json, or the
    /// rendered line (text plus citation id) for markdown. The serialized envelope, per-fact JSON
    /// scaffolding, conflicts, and gaps are never charged to this cap, so a subject whose conflicts
    /// alone fill 300 tokens still gets a facts section.
    /// </summary>
    public static int EstimateIndexFactTokens(FactView fact, string format) => format == "markdown"
        ? EstimateFactTokens(fact, "markdown")
        : EstimateTokens(fact.Text);

    private static int EstimateConflictTokens(DossierConflict conflict, string format) => format == "markdown"
        ? EstimateTokens("- " + conflict.Field + ": " + string.Join("; ", conflict.Values.Select(v => $"{v.Value.GetRawText()} [{v.Fact}]")) + "\n")
        : EstimateTokens(Serialize(conflict));

    private static int EstimateGapTokens(DossierGap gap, string format) => format == "markdown"
        ? EstimateTokens("- " + gap.Need + ": " + gap.Reason + "\n")
        : EstimateTokens(Serialize(gap));

    private sealed class Candidate
    {
        public string Id = string.Empty;
        public string SubjectId = string.Empty;
        public string Kind = string.Empty;
        public string? Key;
        public string ContentHash = string.Empty;
        public string Text = string.Empty;
        public List<string> Tags = new();
        public double Confidence;
        public string Status = string.Empty;
        public string? DataJson;
        public string CreatedAt = string.Empty;
        public DateTimeOffset CreatedTime;
        public int Inbound;
        public double Relevance;
        public double Explicitness;
        public double Score;
        public HashSet<string> TextTokens = new(StringComparer.Ordinal);
        public List<string> Collapsed = new();
    }

    /// <summary>
    /// Total order over candidates that never consults the random fact id: score descending, then
    /// key (when present), kind, text and finally content_hash ascending. content_hash comes last
    /// because it folds in resolved ref targets, which for fact-to-fact refs are random ids; placed
    /// earlier it would reintroduce id dependence. Two stores holding the same logical
    /// facts therefore rank, select and drop identically whatever ids they assigned.
    /// </summary>
    private sealed class RankOrder : IComparer<Candidate>
    {
        public int Compare(Candidate? x, Candidate? y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            var byScore = y!.Score.CompareTo(x!.Score);
            if (byScore != 0)
            {
                return byScore;
            }

            var byKey = string.CompareOrdinal(x.Key ?? string.Empty, y.Key ?? string.Empty);
            if (byKey != 0)
            {
                return byKey;
            }

            var byKind = string.CompareOrdinal(x.Kind, y.Kind);
            if (byKind != 0)
            {
                return byKind;
            }

            var byText = string.CompareOrdinal(x.Text, y.Text);
            return byText != 0 ? byText : string.CompareOrdinal(x.ContentHash, y.ContentHash);
        }
    }

    private static readonly IComparer<Candidate> RankComparer = new RankOrder();

    /// <summary>
    /// compile_dossier: rank, dedupe, budget, surface conflicts and gaps, and emit a cited Dossier.
    /// Ranking is arithmetic and SQL only; identical store state and request give identical output.
    /// </summary>
    public CompiledDossier Compile(CompileRequest request)
    {
        var depth = request.Depth ?? "index";
        if (depth is not ("index" or "full"))
        {
            throw new DossierRequestException("invalid_depth", $"depth must be \"index\" or \"full\", got \"{depth}\"");
        }

        var order = request.Order ?? "rank";
        if (order is not ("rank" or "seq"))
        {
            throw new DossierRequestException("invalid_order", $"order must be \"rank\" or \"seq\", got \"{order}\"");
        }

        var budget = request.Budget ?? DefaultBudgetTokens;
        if (budget < 0)
        {
            throw new DossierRequestException("invalid_budget", "budget must be zero or greater");
        }

        var recencyWeight = request.Rank?.Recency ?? DefaultRecencyWeight;
        if (recencyWeight is < 0 or > 1)
        {
            throw new DossierRequestException("invalid_recency", "rank.recency must be between 0 and 1");
        }

        var needs = (request.Needs ?? new List<string>()).ToList();
        var format = request.Format ?? "json";

        using var connection = OpenConnection();
        var subject = ResolveCompileSubject(connection, request.Subject);
        var subjectIds = new List<string> { subject.Id };
        if (request.Descendants == true)
        {
            subjectIds.AddRange(DescendantIds(connection, subject.Id));
        }

        var candidates = LoadCandidates(connection, subjectIds);
        ScoreCandidates(connection, candidates, needs, recencyWeight);

        var ranked = candidates.OrderBy(c => c, RankComparer).ToList();

        var representatives = Dedupe(ranked);
        var conflicts = FindConflicts(candidates, subject.Id);

        var views = representatives.ToDictionary(c => c.Id, ToDossierView, StringComparer.Ordinal);
        var emitted = new List<Candidate>();

        if (depth == "full")
        {
            // Greedy fill: a candidate that does not fit is skipped, not fatal, so a later smaller
            // fact can still use the remaining slice. Everything not emitted lands in Dropped below.
            var factSlice = (int)Math.Floor(budget * 0.75);
            var running = 0;
            foreach (var candidate in representatives)
            {
                var cost = EstimateFactTokens(views[candidate.Id], format);
                if (running + cost <= factSlice)
                {
                    running += cost;
                    emitted.Add(candidate);
                }
            }
        }
        else
        {
            foreach (var candidate in representatives)
            {
                views[candidate.Id].Text = OneLine(candidate.Text, IndexLineLength);
            }

            // The index cap bounds the fact content itself, never the serialized envelope and never
            // conflicts or gaps. Counting the envelope is what previously left the facts array empty:
            // the JSON scaffolding plus any conflicts could exceed the cap before a fact was tried.
            var cap = Math.Min(budget, IndexTokenCap);
            var floor = Math.Min(IndexMinFacts, representatives.Count);
            var factTokens = 0;
            foreach (var candidate in representatives)
            {
                if (emitted.Count >= IndexMaxFacts)
                {
                    break;
                }

                var cost = EstimateIndexFactTokens(views[candidate.Id], format);
                if (emitted.Count < floor || factTokens + cost <= cap)
                {
                    emitted.Add(candidate);
                    factTokens += cost;
                }
            }
        }

        var gaps = FindGaps(needs, emitted);

        if (order == "seq")
        {
            emitted = emitted
                .OrderBy(c => c.CreatedAt, StringComparer.Ordinal)
                .ThenBy(c => c, RankComparer)
                .ToList();
        }

        var dossier = BuildDossier(subject, depth, needs, budget, emitted, views, conflicts, gaps, representatives);
        dossier.UsedTokens =
            dossier.Facts.Sum(f => EstimateFactTokens(f, format))
            + dossier.Conflicts.Sum(c => EstimateConflictTokens(c, format))
            + dossier.Gaps.Sum(g => EstimateGapTokens(g, format));
        return dossier;
    }

    private static CompiledDossier BuildDossier(
        DossierSubject subject,
        string depth,
        List<string> needs,
        int budget,
        List<Candidate> emitted,
        Dictionary<string, FactView> views,
        List<DossierConflict> conflicts,
        List<DossierGap> gaps,
        List<Candidate> ranked)
    {
        var facts = emitted.Select(c => views[c.Id]).ToList();
        return new CompiledDossier
        {
            Subject = subject,
            Depth = depth,
            Needs = needs,
            BudgetTokens = budget,
            UsedTokens = 0,
            Facts = facts,
            Linked = new List<FactView>(),
            Conflicts = conflicts,
            Gaps = gaps,
            Dropped = depth == "index"
                ? new List<string>()
                : ranked.Where(c => !emitted.Contains(c)).Select(c => c.Id).ToList(),
            SelfCheck = new DossierSelfCheck
            {
                UncitedClaims = facts.Count(f => f.Cites is null || f.Cites.Count == 0),
                ConflictsSurfaced = conflicts.Count,
            },
        };
    }

    private static string Serialize<T>(T value) => JsonSerializer.Serialize(value, JsonCodec.Options);

    private static DossierSubject ResolveCompileSubject(SqliteConnection connection, string value)
    {
        var ids = ResolveSubjectIds(connection, value).OrderBy(id => id, StringComparer.Ordinal).ToList();
        if (ids.Count == 0)
        {
            throw new DossierRequestException("subject_not_found", $"subject \"{value}\" was not found");
        }

        // An exact id match wins over name/alias matches.
        var id = ids.Contains(value, StringComparer.Ordinal) ? value : ids[0];
        using var command = Command(connection, null, "SELECT id, name, kind, parent_id, aliases, pin FROM subjects WHERE id = $id");
        Bind(command, "$id", id);
        using var reader = command.ExecuteReader();
        reader.Read();
        DossierPin? pin = null;
        if (!reader.IsDBNull(5))
        {
            pin = JsonSerializer.Deserialize<DossierPin>(reader.GetString(5), JsonCodec.Options);
        }

        return new DossierSubject
        {
            Id = reader.GetString(0),
            Name = reader.GetString(1),
            Kind = reader.GetString(2),
            Parent = reader.IsDBNull(3) ? null : reader.GetString(3),
            Aliases = ParseAliases(reader.GetString(4)),
            Pin = pin,
        };
    }

    private static List<string> DescendantIds(SqliteConnection connection, string rootId)
    {
        var children = new Dictionary<string, List<string>>(StringComparer.Ordinal);
        using (var command = Command(connection, null, "SELECT id, parent_id FROM subjects WHERE parent_id IS NOT NULL ORDER BY id"))
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var parent = reader.GetString(1);
                if (!children.TryGetValue(parent, out var list))
                {
                    children[parent] = list = new List<string>();
                }

                list.Add(reader.GetString(0));
            }
        }

        var result = new List<string>();
        var seen = new HashSet<string>(StringComparer.Ordinal) { rootId };
        var frontier = new List<string> { rootId };
        for (var level = 0; level < MaxDescendantDepth; level++)
        {
            var next = new List<string>();
            foreach (var parent in frontier)
            {
                if (!children.TryGetValue(parent, out var kids))
                {
                    continue;
                }

                foreach (var kid in kids)
                {
                    if (seen.Add(kid))
                    {
                        next.Add(kid);
                        result.Add(kid);
                    }
                }
            }

            frontier = next;
        }

        return result;
    }

    private static List<Candidate> LoadCandidates(SqliteConnection connection, List<string> subjectIds)
    {
        var parameters = new Dictionary<string, object?>(StringComparer.Ordinal);
        var list = BindList(parameters, "cs", subjectIds);
        var candidates = new List<Candidate>();

        using var command = Command(
            connection,
            null,
            $"""
            SELECT f.id, f.subject_id, f.kind, f.text, f.data, f.tags, f.confidence, f.status, f.created_at, f.key, f.content_hash,
                   (SELECT COUNT(*) FROM refs r WHERE r.target = f.id) AS inbound,
                   (SELECT CASE MAX(CASE r.basis WHEN 'observed' THEN 2 WHEN 'derived' THEN 1 ELSE 0 END)
                                WHEN 2 THEN 1.0 WHEN 1 THEN 0.5 ELSE 0.25 END
                      FROM refs r WHERE r.fact_id = f.id) AS explicitness
            FROM facts f
            WHERE f.subject_id IN ({list})
              AND f.status NOT IN ('superseded', 'retracted')
              AND f.kind <> 'dossier'
            ORDER BY f.key, f.kind, f.text, f.content_hash, f.id
            """);
        BindAll(command, parameters);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var createdAt = reader.GetString(8);
            candidates.Add(new Candidate
            {
                Id = reader.GetString(0),
                SubjectId = reader.GetString(1),
                Kind = reader.GetString(2),
                Text = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                DataJson = reader.IsDBNull(4) ? null : reader.GetString(4),
                Tags = ParseAliases(reader.GetString(5)),
                Confidence = reader.GetDouble(6),
                Status = reader.GetString(7),
                CreatedAt = createdAt,
                Key = reader.IsDBNull(9) ? null : reader.GetString(9),
                ContentHash = reader.GetString(10),
                CreatedTime = DateTimeOffset.TryParse(createdAt, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var parsed)
                    ? parsed
                    : DateTimeOffset.MinValue,
                Inbound = reader.GetInt32(11),
                Explicitness = reader.IsDBNull(12) ? 0.25 : reader.GetDouble(12),
            });
        }

        foreach (var candidate in candidates)
        {
            candidate.TextTokens = Tokenize(candidate.Text).ToHashSet(StringComparer.Ordinal);
        }

        return candidates;
    }

    private static void ScoreCandidates(SqliteConnection connection, List<Candidate> candidates, List<string> needs, double recencyWeight)
    {
        if (candidates.Count == 0)
        {
            return;
        }

        // relevance: bm25 (text weight 10, tags 3), negated so higher is better, clamped at 0, / max.
        var terms = needs.SelectMany(NeedTokens).Distinct(StringComparer.Ordinal).OrderBy(t => t, StringComparer.Ordinal).ToList();
        if (terms.Count > 0)
        {
            var match = string.Join(" OR ", terms.Select(t => "\"" + t + "\""));
            var byId = candidates.ToDictionary(c => c.Id, StringComparer.Ordinal);
            using var command = Command(
                connection,
                null,
                "SELECT f.id, bm25(facts_fts, 10.0, 3.0) FROM facts f JOIN facts_fts ON facts_fts.rowid = f.rowid WHERE facts_fts MATCH $q");
            Bind(command, "$q", match);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (byId.TryGetValue(reader.GetString(0), out var candidate))
                {
                    candidate.Relevance = Math.Max(0, -reader.GetDouble(1));
                }
            }

            var maxRelevance = candidates.Max(c => c.Relevance);
            foreach (var candidate in candidates)
            {
                candidate.Relevance = maxRelevance > 0 ? candidate.Relevance / maxRelevance : 0;
            }
        }

        var maxInbound = candidates.Max(c => c.Inbound);
        var newest = candidates.Max(c => c.CreatedTime);
        var oldest = candidates.Min(c => c.CreatedTime);
        var span = (newest - oldest).TotalMilliseconds;

        foreach (var candidate in candidates)
        {
            var centrality = maxInbound > 0 ? (double)candidate.Inbound / maxInbound : 0;
            var recency = span > 0 ? (candidate.CreatedTime - oldest).TotalMilliseconds / span : 1.0;
            candidate.Score = 2.0 * candidate.Relevance
                + 1.0 * centrality
                + 1.0 * candidate.Confidence
                + recencyWeight * recency
                + 0.5 * candidate.Explicitness;
        }
    }

    /// <summary>
    /// Greedy clustering in rank order: a not-yet-collapsed fact becomes a representative and absorbs
    /// later facts whose token-set Jaccard similarity to it is at least 0.85. Short facts never cluster.
    /// </summary>
    private static List<Candidate> Dedupe(List<Candidate> ranked)
    {
        var representatives = new List<Candidate>();
        var collapsed = new HashSet<string>(StringComparer.Ordinal);

        for (var i = 0; i < ranked.Count; i++)
        {
            var head = ranked[i];
            if (collapsed.Contains(head.Id))
            {
                continue;
            }

            representatives.Add(head);
            if (head.TextTokens.Count < DedupeMinTokens)
            {
                continue;
            }

            for (var j = i + 1; j < ranked.Count; j++)
            {
                var other = ranked[j];
                if (collapsed.Contains(other.Id) || other.TextTokens.Count < DedupeMinTokens)
                {
                    continue;
                }

                if (Jaccard(head.TextTokens, other.TextTokens) >= DedupeThreshold)
                {
                    collapsed.Add(other.Id);
                    head.Collapsed.Add(other.Id);
                }
            }

        }

        return representatives;
    }

    private static double Jaccard(HashSet<string> left, HashSet<string> right)
    {
        var intersection = left.Count(right.Contains);
        var union = left.Count + right.Count - intersection;
        return union == 0 ? 0 : (double)intersection / union;
    }

    private static FactView ToDossierView(Candidate candidate)
    {
        var section = candidate.Tags
            .Where(t => t.StartsWith("section:", StringComparison.Ordinal) && t.Length > "section:".Length)
            .Select(t => t["section:".Length..])
            .FirstOrDefault() ?? candidate.Kind;

        var cites = new List<string> { candidate.Id };
        cites.AddRange(candidate.Collapsed);
        return new FactView
        {
            Id = candidate.Id,
            SubjectId = candidate.SubjectId,
            Kind = candidate.Kind,
            Text = candidate.Text,
            Tags = candidate.Tags,
            Confidence = candidate.Confidence,
            Status = candidate.Status,
            Section = section,
            Cites = cites,
        };
    }

    /// <summary>Conflicts over live facts on the subject itself whose data is a JSON object.</summary>
    private static List<DossierConflict> FindConflicts(List<Candidate> candidates, string subjectId)
    {
        var byPath = new SortedDictionary<string, List<(string Fact, JsonElement Value, Candidate Source)>>(StringComparer.Ordinal);
        foreach (var candidate in candidates
                     .Where(c => c.SubjectId == subjectId && c.Status == "live" && c.DataJson is not null)
                     .OrderBy(c => c, RankComparer))
        {
            using var document = JsonDocument.Parse(candidate.DataJson!);
            if (document.RootElement.ValueKind != JsonValueKind.Object)
            {
                continue;
            }

            foreach (var (path, value) in Flatten(document.RootElement, string.Empty))
            {
                if (!byPath.TryGetValue(path, out var list))
                {
                    byPath[path] = list = new List<(string, JsonElement, Candidate)>();
                }

                list.Add((candidate.Id, value.Clone(), candidate));
            }
        }

        var conflicts = new List<DossierConflict>();
        foreach (var (path, entries) in byPath)
        {
            var distinctFacts = entries.Select(e => e.Fact).Distinct(StringComparer.Ordinal).Count();
            var distinctValues = entries.Select(e => e.Value.GetRawText()).Distinct(StringComparer.Ordinal).Count();
            if (distinctFacts < 2 || distinctValues < 2)
            {
                continue;
            }

            conflicts.Add(new DossierConflict
            {
                Field = path,
                Values = entries
                    .OrderBy(e => e.Source, RankComparer)
                    .Select(e => new ConflictValue { Fact = e.Fact, Value = e.Value })
                    .ToList(),
            });
        }

        return conflicts;
    }

    private static IEnumerable<(string Path, JsonElement Value)> Flatten(JsonElement element, string prefix)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                foreach (var property in element.EnumerateObject())
                {
                    var path = prefix.Length == 0 ? property.Name : prefix + "." + property.Name;
                    foreach (var leaf in Flatten(property.Value, path))
                    {
                        yield return leaf;
                    }
                }

                break;
            case JsonValueKind.Array:
                var index = 0;
                foreach (var item in element.EnumerateArray())
                {
                    var path = prefix + "." + index++.ToString(CultureInfo.InvariantCulture);
                    foreach (var leaf in Flatten(item, path))
                    {
                        yield return leaf;
                    }
                }

                break;
            default:
                if (prefix.Length > 0)
                {
                    yield return (prefix, element);
                }

                break;
        }
    }

    private static List<DossierGap> FindGaps(List<string> needs, List<Candidate> selected)
    {
        var factTokens = selected
            .Select(c => Tokenize(c.Text).Concat(c.Tags.SelectMany(Tokenize)).Concat(Tokenize(c.Kind)).ToHashSet(StringComparer.Ordinal))
            .ToList();

        var gaps = new List<DossierGap>();
        foreach (var need in needs)
        {
            var tokens = NeedTokens(need).ToList();
            if (!factTokens.Any(set => tokens.All(set.Contains)))
            {
                gaps.Add(new DossierGap { Need = need, Reason = "no fact" });
            }
        }

        return gaps;
    }

    private static IEnumerable<string> NeedTokens(string need) =>
        Tokenize(need).Where(t => t.Length >= 3 && !Stopwords.Contains(t));

    /// <summary>Lower-case and split on non-alphanumerics.</summary>
    private static IEnumerable<string> Tokenize(string? value)
    {
        if (string.IsNullOrEmpty(value))
        {
            yield break;
        }

        var builder = new StringBuilder();
        foreach (var character in value.ToLowerInvariant())
        {
            if (char.IsLetterOrDigit(character))
            {
                builder.Append(character);
            }
            else if (builder.Length > 0)
            {
                yield return builder.ToString();
                builder.Clear();
            }
        }

        if (builder.Length > 0)
        {
            yield return builder.ToString();
        }
    }

    private static string OneLine(string text, int max)
    {
        var line = string.Join(' ', text.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries));
        return line.Length <= max ? line : line[..(max - 3)] + "...";
    }

    /// <summary>Markdown rendering of a compiled dossier; every emitted fact id appears in brackets.</summary>
    public static string RenderMarkdown(CompiledDossier dossier)
    {
        var builder = new StringBuilder();
        builder.Append("# ").Append(dossier.Subject.Name).Append('\n');
        builder.Append('\n');
        foreach (var fact in dossier.Facts)
        {
            builder.Append("- ").Append(OneLine(fact.Text, int.MaxValue)).Append(" [").Append(fact.Id).Append("]\n");
        }

        if (dossier.Conflicts.Count > 0)
        {
            builder.Append("\n## Conflicts\n\n");
            foreach (var conflict in dossier.Conflicts)
            {
                var values = string.Join("; ", conflict.Values.Select(v => $"{v.Value.GetRawText()} [{v.Fact}]"));
                builder.Append("- ").Append(conflict.Field).Append(": ").Append(values).Append('\n');
            }
        }

        if (dossier.Gaps.Count > 0)
        {
            builder.Append("\n## Gaps\n\n");
            foreach (var gap in dossier.Gaps)
            {
                builder.Append("- ").Append(gap.Need).Append(": ").Append(gap.Reason).Append('\n');
            }
        }

        return builder.ToString();
    }
}
