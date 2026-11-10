using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Dossier;

/// <summary>
/// graph request: a bounded neighbourhood (or, without a subject, the subject tree) of the store.
/// Defaults: depth 1, facts true, max_nodes 500.
/// </summary>
public sealed class GraphRequest
{
    public const int DefaultDepth = 1;
    public const int DefaultMaxNodes = 500;
    public const int MaxNodesLimit = 2000;

    public string? Subject { get; init; }

    public int? Depth { get; init; }

    public bool? Facts { get; init; }

    public int? MaxNodes { get; init; }

    /// <summary>Parses the web query values; an invalid or out-of-range value is a named 400-class error.</summary>
    public static GraphRequest FromQuery(string? subject, string? depth, string? facts, string? maxNodes)
    {
        int? parsedDepth = null;
        if (depth is not null)
        {
            parsedDepth = int.TryParse(depth, NumberStyles.None, CultureInfo.InvariantCulture, out var d)
                ? d
                : throw new DossierRequestException("bad_depth", "depth must be an integer from 0 to 3");
        }

        bool? parsedFacts = null;
        if (facts is not null)
        {
            parsedFacts = facts switch
            {
                "true" or "1" => true,
                "false" or "0" => false,
                _ => throw new DossierRequestException("bad_facts", "facts must be true, false, 1 or 0"),
            };
        }

        int? parsedMax = null;
        if (maxNodes is not null)
        {
            parsedMax = int.TryParse(maxNodes, NumberStyles.None, CultureInfo.InvariantCulture, out var m)
                ? m
                : throw new DossierRequestException("bad_max_nodes", $"max_nodes must be an integer from 1 to {MaxNodesLimit}");
        }

        return new GraphRequest { Subject = subject, Depth = parsedDepth, Facts = parsedFacts, MaxNodes = parsedMax };
    }
}

/// <summary>The graph payload. Node ids are store ids; every list is in a deterministic order.</summary>
public sealed record GraphResponse(
    int Format,
    string Seed,
    [property: System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)] string? Root,
    List<GraphSubject> Subjects,
    List<GraphFact> Facts,
    List<GraphEdge> Edges,
    List<GraphHidden> Unresolved,
    GraphTruncated Truncated,
    GraphLimits Limits);

public sealed record GraphSubject(string Id, string Name, string Kind, string? Parent, long Facts, bool? Boundary);

public sealed record GraphFact(
    string Id,
    string Subject,
    string Kind,
    string? Key,
    string? Text,
    string Status,
    double Confidence,
    List<string> Tags,
    List<GraphExternalRef> Unresolved);

/// <summary>An external (non-node) ref kept on its fact: symbol, url and every other non-internal kind.</summary>
public sealed record GraphExternalRef(string Rel, string Basis, string Kind, string Target);

/// <summary>
/// One edge. kind: contains (subject to child subject), fact, subject, slot, or inbound (a fact of the
/// boundary subject refers to the admitted fact). Ambiguous marks a name that matched several subjects.
/// </summary>
public sealed record GraphEdge(
    string FromKind,
    string From,
    string ToKind,
    string To,
    string Rel,
    string Basis,
    string Kind,
    string? Slot,
    bool? Ambiguous);

/// <summary>An internal ref whose target is not in the payload. Reason: not_admitted or not_found.</summary>
public sealed record GraphHidden(string From, string Rel, string Kind, string Target, string Reason);

public sealed record GraphTruncated(int Subjects, int Facts, int Edges);

public sealed record GraphLimits(int MaxNodes, int Depth);

public sealed partial class DossierStore
{
    private const int GraphTextCap = 500;
    private const int GraphUnresolvedCap = 2000;
    private const int GraphBatchSize = 400;

    /// <summary>
    /// A bounded, deterministic neighbourhood of a subject (or the subject tree when no subject is
    /// given). Nodes never exceed max_nodes; within a hop the admission order is the ordinal id order.
    /// </summary>
    public GraphResponse Graph(GraphRequest request)
    {
        var depth = request.Depth ?? GraphRequest.DefaultDepth;
        var withFacts = request.Facts ?? true;
        var maxNodes = request.MaxNodes ?? GraphRequest.DefaultMaxNodes;
        if (depth < 0 || depth > MaxDescendantDepth)
        {
            throw new DossierRequestException("bad_depth", $"depth must be an integer from 0 to {MaxDescendantDepth}");
        }

        if (maxNodes < 1 || maxNodes > GraphRequest.MaxNodesLimit)
        {
            throw new DossierRequestException("bad_max_nodes", $"max_nodes must be an integer from 1 to {GraphRequest.MaxNodesLimit}");
        }

        using var connection = OpenConnection();
        return new GraphBuilder(connection, depth, withFacts, maxNodes).Build(request.Subject);
    }

    private sealed class GraphBuilder
    {
        private sealed record SubjectRow(string Id, string Name, string Kind, string? Parent, List<string> Aliases);

        private sealed record RefRow(string Rel, string Kind, string Target, string Basis);

        private sealed record FactRow(
            string Id,
            string SubjectId,
            string Kind,
            string? Key,
            string? Text,
            List<string> Tags,
            double Confidence,
            string Status,
            List<RefRow> Refs);

        private sealed record Inbound(string TargetFact, string Subject, string Rel, string Basis, string Kind, string? Slot);

        private readonly SqliteConnection connection;
        private readonly int depth;
        private readonly bool withFacts;
        private readonly int maxNodes;

        private readonly Dictionary<string, SubjectRow> subjects = new(StringComparer.Ordinal);
        private readonly Dictionary<string, List<string>> children = new(StringComparer.Ordinal);
        private readonly Dictionary<string, List<string>> byName = new(StringComparer.Ordinal);
        private readonly Dictionary<string, long> factCounts = new(StringComparer.Ordinal);
        private readonly Dictionary<(string Subject, string Key), List<string>> slots = new();
        private readonly Dictionary<string, List<FactRow>> factsBySubject = new(StringComparer.Ordinal);
        private readonly Dictionary<string, string?> factOwners = new(StringComparer.Ordinal);

        private readonly List<string> subjectOrder = new();
        private readonly HashSet<string> admittedSubjects = new(StringComparer.Ordinal);
        private readonly HashSet<string> boundarySubjects = new(StringComparer.Ordinal);
        private readonly HashSet<string> hiddenSubjects = new(StringComparer.Ordinal);
        private readonly List<FactRow> admittedFacts = new();
        private readonly HashSet<string> admittedFactIds = new(StringComparer.Ordinal);
        private int hiddenFacts;
        private int hiddenEdges;

        public GraphBuilder(SqliteConnection connection, int depth, bool withFacts, int maxNodes)
        {
            this.connection = connection;
            this.depth = depth;
            this.withFacts = withFacts;
            this.maxNodes = maxNodes;
        }

        private int Used => subjectOrder.Count + admittedFacts.Count;

        public GraphResponse Build(string? subject)
        {
            LoadSubjects();
            string? root = null;
            if (subject is not null)
            {
                var matches = ResolveSubjects(subject);
                if (matches.Count == 0)
                {
                    throw new DossierRequestException("subject_not_found", $"subject \"{subject}\" was not found");
                }

                // An exact id match wins over name/alias matches, as in compile.
                root = matches.Contains(subject, StringComparer.Ordinal) ? subject : matches[0];
                AdmitNeighbourhood(root);
            }
            else
            {
                AdmitTree();
            }

            var edges = new List<GraphEdge>();
            var unresolved = new List<GraphHidden>();
            foreach (var id in subjectOrder)
            {
                var parent = subjects[id].Parent;
                if (parent is not null && admittedSubjects.Contains(parent))
                {
                    edges.Add(new GraphEdge("subject", parent, "subject", id, "contains", "structure", "contains", null, null));
                }
            }

            BuildRefEdges(edges, unresolved);
            BuildInboundEdges(edges);

            var subjectNodes = subjectOrder
                .Select(id => new GraphSubject(
                    id,
                    subjects[id].Name,
                    subjects[id].Kind,
                    subjects[id].Parent,
                    factCounts.GetValueOrDefault(id),
                    boundarySubjects.Contains(id) ? true : null))
                .ToList();
            var factNodes = admittedFacts
                .Select(f => new GraphFact(
                    f.Id,
                    f.SubjectId,
                    f.Kind,
                    f.Key,
                    Cap(f.Text),
                    f.Status,
                    f.Confidence,
                    f.Tags,
                    f.Refs
                        .Where(r => !IsInternalKind(r.Kind))
                        .Select(r => new GraphExternalRef(r.Rel, r.Basis, r.Kind, r.Target))
                        .ToList()))
                .ToList();

            var hiddenSubjectCount = hiddenSubjects.Count(id => !admittedSubjects.Contains(id));
            return new GraphResponse(
                1,
                Seed(root),
                root,
                subjectNodes,
                factNodes,
                edges,
                unresolved,
                new GraphTruncated(hiddenSubjectCount, hiddenFacts, hiddenEdges),
                new GraphLimits(maxNodes, depth));
        }

        private string Seed(string? root)
        {
            var text = string.Join('\n', root ?? string.Empty, depth.ToString(CultureInfo.InvariantCulture), withFacts ? "1" : "0", maxNodes.ToString(CultureInfo.InvariantCulture));
            return Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes(text)))[..8];
        }

        private static string? Cap(string? text)
        {
            if (text is null || text.Length <= GraphTextCap)
            {
                return text;
            }

            var length = char.IsHighSurrogate(text[GraphTextCap - 1]) ? GraphTextCap - 1 : GraphTextCap;
            return text[..length];
        }

        private static bool IsInternalKind(string kind) => kind is "fact" or "subject" or "slot";

        // ---- preload (a fixed number of queries per request) -----------------------------------

        private void LoadSubjects()
        {
            using (var command = Command(connection, null, "SELECT id, name, kind, parent_id, aliases FROM subjects ORDER BY id"))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var row = new SubjectRow(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.IsDBNull(3) ? null : reader.GetString(3),
                        ParseAliases(reader.GetString(4)));
                    subjects[row.Id] = row;
                }
            }

            foreach (var row in subjects.Values.OrderBy(s => s.Id, StringComparer.Ordinal))
            {
                if (row.Parent is not null)
                {
                    if (!children.TryGetValue(row.Parent, out var kids))
                    {
                        children[row.Parent] = kids = new List<string>();
                    }

                    kids.Add(row.Id);
                }

                foreach (var name in row.Aliases.Prepend(row.Name))
                {
                    var normalized = Names.Normalize(name);
                    if (normalized.Length == 0)
                    {
                        continue;
                    }

                    if (!byName.TryGetValue(normalized, out var ids))
                    {
                        byName[normalized] = ids = new List<string>();
                    }

                    if (!ids.Contains(row.Id, StringComparer.Ordinal))
                    {
                        ids.Add(row.Id);
                    }
                }
            }

            using (var command = Command(connection, null, "SELECT subject_id, COUNT(*) FROM facts GROUP BY subject_id ORDER BY subject_id"))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    factCounts[reader.GetString(0)] = reader.GetInt64(1);
                }
            }

            if (!withFacts)
            {
                return;
            }

            using var slotCommand = Command(connection, null, "SELECT subject_id, key, fact_id FROM slots ORDER BY subject_id, key, fact_id");
            using var slotReader = slotCommand.ExecuteReader();
            while (slotReader.Read())
            {
                var key = (slotReader.GetString(0), slotReader.GetString(1));
                if (!slots.TryGetValue(key, out var occupants))
                {
                    slots[key] = occupants = new List<string>();
                }

                var fact = slotReader.GetString(2);
                if (!occupants.Contains(fact, StringComparer.Ordinal))
                {
                    occupants.Add(fact);
                }
            }
        }

        /// <summary>id, name and alias resolution against the preloaded maps; ordinal id order.</summary>
        private List<string> ResolveSubjects(string value)
        {
            var found = new SortedSet<string>(StringComparer.Ordinal);
            if (subjects.ContainsKey(value))
            {
                found.Add(value);
            }

            var normalized = Names.Normalize(value);
            if (normalized.Length > 0 && byName.TryGetValue(normalized, out var ids))
            {
                found.UnionWith(ids);
            }

            return found.ToList();
        }

        private static (string SubjectPart, string Key)? SplitSlot(string target)
        {
            // Same split as the store's ResolveSlotTarget: first '#', non-empty subject and key.
            var hash = target.IndexOf('#');
            if (hash <= 0 || hash == target.Length - 1)
            {
                return null;
            }

            return (target[..hash], target[(hash + 1)..]);
        }

        private List<string> SlotOccupants(string subjectId, string key) =>
            slots.TryGetValue((subjectId, key), out var list) ? list : new List<string>();

        private void LoadFacts(IEnumerable<string> subjectIds)
        {
            var wanted = subjectIds.Where(id => !factsBySubject.ContainsKey(id)).Distinct(StringComparer.Ordinal).ToList();
            foreach (var chunk in wanted.Chunk(GraphBatchSize))
            {
                foreach (var id in chunk)
                {
                    factsBySubject[id] = new List<FactRow>();
                }

                var byId = new Dictionary<string, FactRow>(StringComparer.Ordinal);
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT id, subject_id, kind, key, text, tags, confidence, status FROM facts WHERE subject_id IN ("
                        + Placeholders(command, chunk) + ") ORDER BY subject_id, created_at, id";
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var row = new FactRow(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3),
                            reader.IsDBNull(4) ? null : reader.GetString(4),
                            ParseAliases(reader.GetString(5)),
                            reader.GetDouble(6),
                            reader.GetString(7),
                            new List<RefRow>());
                        byId[row.Id] = row;
                        factsBySubject[row.SubjectId].Add(row);
                        factOwners[row.Id] = row.SubjectId;
                    }
                }

                using var refCommand = connection.CreateCommand();
                refCommand.CommandText =
                    "SELECT r.fact_id, r.rel, r.kind, r.target, r.basis FROM refs r JOIN facts f ON f.id = r.fact_id WHERE f.subject_id IN ("
                    + Placeholders(refCommand, chunk) + ") ORDER BY r.fact_id, r.seq";
                using var refReader = refCommand.ExecuteReader();
                while (refReader.Read())
                {
                    if (byId.TryGetValue(refReader.GetString(0), out var fact))
                    {
                        fact.Refs.Add(new RefRow(refReader.GetString(1), refReader.GetString(2), refReader.GetString(3), refReader.GetString(4)));
                    }
                }
            }
        }

        private static string Placeholders(SqliteCommand command, IEnumerable<string> values)
        {
            var names = new List<string>();
            var index = 0;
            foreach (var value in values)
            {
                var name = "$p" + index++.ToString(CultureInfo.InvariantCulture);
                Bind(command, name, value);
                names.Add(name);
            }

            return string.Join(',', names);
        }

        /// <summary>Owner subject of each fact id (null when the fact does not exist), one batched query per 400 ids.</summary>
        private void EnsureOwners(IEnumerable<string> factIds)
        {
            var wanted = factIds.Where(id => !factOwners.ContainsKey(id)).Distinct(StringComparer.Ordinal).ToList();
            foreach (var chunk in wanted.Chunk(GraphBatchSize))
            {
                using var command = connection.CreateCommand();
                command.CommandText = "SELECT id, subject_id FROM facts WHERE id IN (" + Placeholders(command, chunk) + ") ORDER BY id";
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    factOwners[reader.GetString(0)] = reader.GetString(1);
                }

                foreach (var id in chunk)
                {
                    factOwners.TryAdd(id, null);
                }
            }
        }

        // ---- admission -----------------------------------------------------------------------

        private bool AdmitSubject(string id)
        {
            if (Used >= maxNodes || !admittedSubjects.Add(id))
            {
                return false;
            }

            subjectOrder.Add(id);
            return true;
        }

        private void AdmitTree()
        {
            var roots = subjects.Values
                .Where(s => s.Parent is null || !subjects.ContainsKey(s.Parent))
                .Select(s => s.Id)
                .OrderBy(id => id, StringComparer.Ordinal)
                .ToList();
            var seen = new HashSet<string>(roots, StringComparer.Ordinal);
            var level = roots;
            while (level.Count > 0)
            {
                var admitted = new List<string>();
                foreach (var id in level)
                {
                    if (AdmitSubject(id))
                    {
                        admitted.Add(id);
                    }
                    else
                    {
                        hiddenSubjects.Add(id);
                    }
                }

                var next = new SortedSet<string>(StringComparer.Ordinal);
                foreach (var id in level)
                {
                    foreach (var kid in children.GetValueOrDefault(id) ?? new List<string>())
                    {
                        if (seen.Add(kid))
                        {
                            next.Add(kid);
                        }
                    }
                }

                level = next.ToList();
            }

            // Subjects unreachable from a root (a parent cycle) are not in the tree; they still count as hidden.
            foreach (var id in subjects.Keys)
            {
                if (!admittedSubjects.Contains(id))
                {
                    hiddenSubjects.Add(id);
                }
            }
        }

        private void AdmitNeighbourhood(string root)
        {
            AdmitSubject(root);

            // The parent chain, nearest first; clamped by the cap.
            var chainSeen = new HashSet<string>(StringComparer.Ordinal) { root };
            var cursor = subjects[root].Parent;
            while (cursor is not null && subjects.ContainsKey(cursor) && chainSeen.Add(cursor))
            {
                if (!AdmitSubject(cursor))
                {
                    hiddenSubjects.Add(cursor);
                }

                cursor = subjects[cursor].Parent;
            }

            var frontier = new List<string> { root };
            for (var hop = 1; hop <= depth && frontier.Count > 0 && Used < maxNodes; hop++)
            {
                var candidates = new SortedSet<string>(StringComparer.Ordinal);
                if (withFacts)
                {
                    LoadFacts(frontier);
                    EnsureOwners(frontier
                        .SelectMany(s => factsBySubject[s])
                        .SelectMany(f => f.Refs)
                        .Where(r => r.Kind == "fact")
                        .Select(r => r.Target));
                }

                foreach (var id in frontier)
                {
                    foreach (var kid in children.GetValueOrDefault(id) ?? new List<string>())
                    {
                        candidates.Add(kid);
                    }

                    if (!withFacts)
                    {
                        continue;
                    }

                    foreach (var fact in factsBySubject[id])
                    {
                        foreach (var reference in fact.Refs)
                        {
                            foreach (var reached in ReachedSubjects(reference))
                            {
                                candidates.Add(reached);
                            }
                        }
                    }
                }

                var admitted = new List<string>();
                foreach (var id in candidates)
                {
                    if (admittedSubjects.Contains(id))
                    {
                        continue;
                    }

                    if (AdmitSubject(id))
                    {
                        admitted.Add(id);
                    }
                    else
                    {
                        hiddenSubjects.Add(id);
                    }
                }

                frontier = admitted;
            }

            if (!withFacts)
            {
                return;
            }

            LoadFacts(subjectOrder);
            foreach (var id in subjectOrder.ToList())
            {
                foreach (var fact in factsBySubject[id])
                {
                    if (Used < maxNodes)
                    {
                        admittedFacts.Add(fact);
                        admittedFactIds.Add(fact.Id);
                    }
                    else
                    {
                        hiddenFacts++;
                    }
                }
            }

            AdmitBoundary();
        }

        /// <summary>Subjects an internal ref leads to (for the BFS): subject targets, fact owners, slot owners.</summary>
        private IEnumerable<string> ReachedSubjects(RefRow reference)
        {
            switch (reference.Kind)
            {
                case "subject":
                    return ResolveSubjects(reference.Target);
                case "fact":
                    return factOwners.GetValueOrDefault(reference.Target) is { } owner ? new[] { owner } : Array.Empty<string>();
                case "slot":
                    return SplitSlot(reference.Target) is { } split ? ResolveSubjects(split.SubjectPart) : Array.Empty<string>();
                default:
                    return Array.Empty<string>();
            }
        }

        private readonly List<Inbound> inbound = new();

        private void AdmitBoundary()
        {
            if (admittedFacts.Count == 0)
            {
                return;
            }

            var found = new List<Inbound>();
            foreach (var chunk in admittedFacts.Select(f => f.Id).Chunk(GraphBatchSize))
            {
                using var command = connection.CreateCommand();
                command.CommandText =
                    "SELECT r.target, f.subject_id, r.rel, r.basis FROM refs r JOIN facts f ON f.id = r.fact_id WHERE r.kind = 'fact' AND r.target IN ("
                    + Placeholders(command, chunk) + ") ORDER BY r.target, f.subject_id, r.rel, r.basis, f.id, r.seq";
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    found.Add(new Inbound(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "fact", null));
                }
            }

            using (var command = Command(
                connection,
                null,
                "SELECT r.target, f.subject_id, r.rel, r.basis FROM refs r JOIN facts f ON f.id = r.fact_id WHERE r.kind = 'slot' ORDER BY f.id, r.seq"))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var target = reader.GetString(0);
                    if (SplitSlot(target) is not { } split)
                    {
                        continue;
                    }

                    foreach (var subjectId in ResolveSubjects(split.SubjectPart))
                    {
                        foreach (var occupant in SlotOccupants(subjectId, split.Key))
                        {
                            if (admittedFactIds.Contains(occupant))
                            {
                                found.Add(new Inbound(occupant, reader.GetString(1), reader.GetString(2), reader.GetString(3), "slot", split.Key));
                            }
                        }
                    }
                }
            }

            var candidates = new SortedSet<string>(StringComparer.Ordinal);
            foreach (var item in found)
            {
                if (!admittedSubjects.Contains(item.Subject) && subjects.ContainsKey(item.Subject))
                {
                    candidates.Add(item.Subject);
                }
            }

            foreach (var id in candidates)
            {
                if (AdmitSubject(id))
                {
                    boundarySubjects.Add(id);
                }
                else
                {
                    hiddenSubjects.Add(id);
                }
            }

            inbound.AddRange(found
                .OrderBy(i => i.TargetFact, StringComparer.Ordinal)
                .ThenBy(i => i.Subject, StringComparer.Ordinal)
                .ThenBy(i => i.Rel, StringComparer.Ordinal)
                .ThenBy(i => i.Basis, StringComparer.Ordinal)
                .ThenBy(i => i.Kind, StringComparer.Ordinal)
                .ThenBy(i => i.Slot, StringComparer.Ordinal));
        }

        // ---- edges ----------------------------------------------------------------------------

        private void BuildRefEdges(List<GraphEdge> edges, List<GraphHidden> unresolved)
        {
            var seen = new HashSet<string>(StringComparer.Ordinal);

            void Emit(GraphEdge edge)
            {
                if (seen.Add(string.Join('\u001f', edge.FromKind, edge.From, edge.ToKind, edge.To, edge.Rel, edge.Basis, edge.Kind, edge.Slot ?? string.Empty)))
                {
                    edges.Add(edge);
                }
            }

            void Hide(FactRow fact, RefRow reference, string reason)
            {
                if (reason == "not_admitted")
                {
                    hiddenEdges++;
                }

                if (unresolved.Count < GraphUnresolvedCap)
                {
                    unresolved.Add(new GraphHidden(fact.Id, reference.Rel, reference.Kind, reference.Target, reason));
                }
            }

            if (admittedFacts.Count > 0)
            {
                EnsureOwners(admittedFacts.SelectMany(f => f.Refs).Where(r => r.Kind == "fact").Select(r => r.Target));
            }

            foreach (var fact in admittedFacts)
            {
                // Refs arrive ordered by (fact, seq); seq is unique per fact, so rel and target never reorder them.
                foreach (var reference in fact.Refs)
                {
                    switch (reference.Kind)
                    {
                        case "fact":
                            if (admittedFactIds.Contains(reference.Target))
                            {
                                Emit(new GraphEdge("fact", fact.Id, "fact", reference.Target, reference.Rel, reference.Basis, "fact", null, null));
                            }
                            else
                            {
                                Hide(fact, reference, factOwners.GetValueOrDefault(reference.Target) is null ? "not_found" : "not_admitted");
                            }

                            break;

                        case "subject":
                        {
                            var matches = ResolveSubjects(reference.Target);
                            if (matches.Count == 0)
                            {
                                Hide(fact, reference, "not_found");
                                break;
                            }

                            var hidden = false;
                            foreach (var match in matches)
                            {
                                if (admittedSubjects.Contains(match))
                                {
                                    Emit(new GraphEdge("fact", fact.Id, "subject", match, reference.Rel, reference.Basis, "subject", null, matches.Count > 1 ? true : null));
                                }
                                else
                                {
                                    hidden = true;
                                }
                            }

                            if (hidden)
                            {
                                Hide(fact, reference, "not_admitted");
                            }

                            break;
                        }

                        case "slot":
                            EmitSlot(fact, reference, Emit, Hide);
                            break;
                    }
                }
            }
        }

        private void EmitSlot(FactRow fact, RefRow reference, Action<GraphEdge> emit, Action<FactRow, RefRow, string> hide)
        {
            if (SplitSlot(reference.Target) is not { } split)
            {
                hide(fact, reference, "not_found");
                return;
            }

            var matches = ResolveSubjects(split.SubjectPart);
            if (matches.Count == 0)
            {
                hide(fact, reference, "not_found");
                return;
            }

            bool? ambiguous = matches.Count > 1 ? true : null;
            var occupants = matches.SelectMany(m => SlotOccupants(m, split.Key)).Distinct(StringComparer.Ordinal).ToList();
            var hidden = false;
            if (occupants.Count > 0)
            {
                // One edge per current occupant, as the store's ResolveSlotTarget resolves the target.
                foreach (var occupant in occupants)
                {
                    if (admittedFactIds.Contains(occupant))
                    {
                        emit(new GraphEdge("fact", fact.Id, "fact", occupant, reference.Rel, reference.Basis, "slot", split.Key, ambiguous));
                    }
                    else
                    {
                        hidden = true;
                    }
                }
            }
            else
            {
                // An empty slot falls back to the owning subject.
                foreach (var match in matches)
                {
                    if (admittedSubjects.Contains(match))
                    {
                        emit(new GraphEdge("fact", fact.Id, "subject", match, reference.Rel, reference.Basis, "slot", split.Key, ambiguous));
                    }
                    else
                    {
                        hidden = true;
                    }
                }
            }

            if (hidden)
            {
                hide(fact, reference, "not_admitted");
            }
        }

        private void BuildInboundEdges(List<GraphEdge> edges)
        {
            var seen = new HashSet<string>(StringComparer.Ordinal);
            foreach (var item in inbound)
            {
                var key = string.Join('\u001f', item.TargetFact, item.Subject, item.Rel, item.Basis, item.Kind, item.Slot ?? string.Empty);
                if (!seen.Add(key))
                {
                    continue;
                }

                if (admittedSubjects.Contains(item.Subject))
                {
                    // A fact of an admitted subject: its own fact edge (when admitted) already shows it.
                    if (boundarySubjects.Contains(item.Subject))
                    {
                        edges.Add(new GraphEdge("fact", item.TargetFact, "subject", item.Subject, item.Rel, item.Basis, "inbound", item.Slot, null));
                    }
                }
                else if (subjects.ContainsKey(item.Subject))
                {
                    hiddenEdges++;
                }
            }
        }
    }
}
