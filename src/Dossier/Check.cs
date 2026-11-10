using System.Text.Json;

namespace Dossier;

/// <summary>check: resolve a subject, summarise what is known, optionally judge draft facts.</summary>
public sealed class CheckRequest
{
    public string? Subject { get; set; }
    public List<FactInput>? Drafts { get; set; }
    public int? Limit { get; set; }
}

public sealed class CheckResponse
{
    public SubjectMatch? Subject { get; set; }
    public List<SubjectMatch>? Others { get; set; }
    public CheckSummary Summary { get; set; } = new();
    public List<DraftVerdict>? Drafts { get; set; }
}

public sealed class CheckSummary
{
    public int Facts { get; set; }
    public int Conflicts { get; set; }
    public int Gaps { get; set; }
    public List<CheckTop> Top { get; set; } = new();
}

public sealed class CheckTop
{
    public string Key { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}

/// <summary>
/// The verdict the write path would give a draft. near is advisory only: posting a near-duplicate
/// still creates a separate fact with status new.
/// </summary>
public sealed class DraftVerdict
{
    public int Index { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? Id { get; set; }
    public string? DuplicateOf { get; set; }
    public string? Replaced { get; set; }
    public List<string> Near { get; set; } = new();
    public PostError? Error { get; set; }
}

public sealed partial class DossierStore
{
    public const int CheckTopCount = 8;
    public const int CheckTopTextLength = 120;
    public const int CheckNearCount = 3;
    private const double CheckNearThreshold = 0.85;

    /// <summary>
    /// check. Resolves the subject exactly like name matching always did (casefold, collapsed
    /// whitespace, exact name, exact alias, prefix, fuzzy), summarises its live facts with the
    /// compile ranking, and, when drafts are given, runs the real post path in a rolled-back
    /// transaction so each verdict is the one a real post would produce. Writes nothing.
    /// </summary>
    public CheckResponse Check(CheckRequest request)
    {
        var text = request.Subject;
        if (Names.Normalize(text).Length == 0)
        {
            throw new DossierRequestException("invalid_request", "check requires a subject");
        }

        var matches = ResolveSubjects(text);
        var exactId = FindSubjectById(text!.Trim());
        if (exactId is not null)
        {
            matches.RemoveAll(m => m.Id == exactId.Id);
            matches.Insert(0, exactId);
        }

        var drafts = request.Drafts;
        var looksLikeId = Guid.TryParse(text!.Trim(), out _);
        if (matches.Count == 0 && looksLikeId)
        {
            // Same fail-closed rule as post: an unknown id never materialises a subject.
            throw new DossierRequestException("subject_not_found", $"subject \"{text}\" does not exist");
        }

        var response = new CheckResponse { Subject = matches.FirstOrDefault() };
        var limit = request.Limit ?? 1;
        if (limit > 1 && matches.Count > 1)
        {
            response.Others = matches.Skip(1).Take(limit - 1).ToList();
        }

        List<Candidate> candidates = new();
        if (response.Subject is not null)
        {
            using var connection = OpenConnection();
            candidates = LoadCandidates(connection, new List<string> { response.Subject.Id });
            ScoreCandidates(connection, candidates, new List<string>(), DefaultRecencyWeight);
            var ranked = candidates.OrderBy(c => c, RankComparer).ToList();
            response.Summary = new CheckSummary
            {
                Facts = candidates.Count,
                Conflicts = FindConflicts(candidates, response.Subject.Id).Count,
                Gaps = 0,
                Top = ranked.Take(CheckTopCount).Select(c => new CheckTop
                {
                    Key = c.Key ?? c.Id,
                    Text = OneLine(c.Text, CheckTopTextLength),
                }).ToList(),
            };
        }

        if (drafts is not null)
        {
            response.Drafts = JudgeDrafts(response.Subject, text!, drafts, candidates);
        }

        return response;
    }

    private SubjectMatch? FindSubjectById(string value) =>
        ListSubjects().Where(s => string.Equals(s.Id, value, StringComparison.Ordinal))
            .Select(s => new SubjectMatch
            {
                Id = s.Id,
                Name = s.Name,
                Kind = s.Kind,
                Aliases = s.Aliases,
                Facts = s.Facts,
                Match = "exact_id",
            })
            .FirstOrDefault();

    private List<DraftVerdict> JudgeDrafts(SubjectMatch? subject, string subjectText, List<FactInput> drafts, List<Candidate> live)
    {
        var post = PostFacts(new PostFactsRequest
        {
            Subject = subject is not null ? new SubjectInput { Id = subject.Id } : new SubjectInput { Name = subjectText },
            Facts = drafts,
            DryRun = true,
        });

        var errors = post.Errors.ToDictionary(e => e.Index);
        var results = new Queue<FactResult>(post.Response.Facts);
        var verdicts = new List<DraftVerdict>();

        for (var index = 0; index < drafts.Count; index++)
        {
            if (errors.TryGetValue(index, out var error))
            {
                verdicts.Add(new DraftVerdict { Index = index, Status = "error", Error = error });
                continue;
            }

            var result = results.Dequeue();
            var verdict = new DraftVerdict
            {
                Index = index,
                Status = result.Status,
                Id = result.Id,
                DuplicateOf = result.DuplicateOf,
                Replaced = result.Replaced,
            };

            var excluded = new HashSet<string>(StringComparer.Ordinal);
            if (result.DuplicateOf is not null)
            {
                excluded.Add(result.DuplicateOf);
            }

            if (result.Replaced is not null)
            {
                excluded.Add(result.Replaced);
            }

            var tokens = Tokenize(drafts[index]?.Text).ToHashSet(StringComparer.Ordinal);
            if (tokens.Count > 0)
            {
                verdict.Near = live
                    .Where(c => c.Status == "live" && !excluded.Contains(c.Id))
                    .Select(c => (c.Id, Similarity: Jaccard(tokens, c.TextTokens)))
                    .Where(p => p.Similarity >= CheckNearThreshold)
                    .OrderByDescending(p => p.Similarity)
                    .ThenBy(p => p.Id, StringComparer.Ordinal)
                    .Take(CheckNearCount)
                    .Select(p => p.Id)
                    .ToList();
            }

            verdicts.Add(verdict);
        }

        return verdicts;
    }

    /// <summary>Parses a drafts payload: a JSON array of facts, or an object with a "facts" array.</summary>
    public static List<FactInput> ParseDrafts(string json)
    {
        using var document = JsonDocument.Parse(json);
        var element = document.RootElement;
        if (element.ValueKind == JsonValueKind.Object && element.TryGetProperty("facts", out var facts))
        {
            element = facts;
        }

        if (element.ValueKind != JsonValueKind.Array)
        {
            throw new ArgumentException("drafts must be a JSON array of facts or an object with a facts array");
        }

        return JsonCodec.Deserialize<List<FactInput>>(element.GetRawText()) ?? new List<FactInput>();
    }
}
