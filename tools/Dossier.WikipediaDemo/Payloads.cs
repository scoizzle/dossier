using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Dossier.WikipediaDemo;

/// <summary>Turn a fetched article into the subject/facts/refs shape the demo posts.</summary>
internal static partial class Payloads
{
    private const int MinParagraph = 80;

    [GeneratedRegex(@"\[\d+\]")]
    private static partial Regex CitationMarker();

    [GeneratedRegex(@"\s+")]
    private static partial Regex Whitespace();

    [GeneratedRegex(@"\n+")]
    private static partial Regex BlankLines();

    [GeneratedRegex(@"[.!?]$")]
    private static partial Regex SentenceEnd();

    private static string CleanParagraph(string text) =>
        Whitespace().Replace(CitationMarker().Replace(text, ""), " ").Trim();

    /// <summary>Trim to a sentence boundary near <paramref name="max"/>, with an ellipsis when cut.</summary>
    public static string Clamp(string text, int max)
    {
        if (text.Length <= max)
        {
            return text;
        }

        var cut = text[..(max - 1)];
        var stop = Math.Max(
            Math.Max(cut.LastIndexOf(". ", StringComparison.Ordinal), cut.LastIndexOf("! ", StringComparison.Ordinal)),
            cut.LastIndexOf("? ", StringComparison.Ordinal));
        var body = stop > max * 0.4 ? cut[..(stop + 1)] : cut.TrimEnd();
        return body + "…";
    }

    public static List<string> ParagraphsOf(string extract) =>
        BlankLines().Split(extract)
            .Select(CleanParagraph)
            .Where(paragraph => paragraph.Length >= MinParagraph && SentenceEnd().IsMatch(paragraph))
            .ToList();

    // verified_at is freshness metadata: ContentHash deliberately excludes it, so a
    // rerun with a new fetch time still dedupes against the earlier post.
    private static JsonObject UrlRef(Article article) => new()
    {
        ["rel"] = "derived_from",
        ["kind"] = "url",
        ["target"] = article.Url,
        ["basis"] = "observed",
        ["verified_at"] = article.FetchedAt,
    };

    private static JsonArray Tags(string lang) => ["source:wikipedia", $"lang:{lang}"];

    public static JsonObject ArticlePayload(Article article, HashSet<string> selected, string? parentId, DemoConfig config)
    {
        var paragraphs = ParagraphsOf(article.Extract);
        var facts = new JsonArray();

        var summary = paragraphs.Count > 0
            ? paragraphs[0]
            : $"{article.Title} has no plain-text summary in the Wikipedia extract for this article.";
        var summaryRefs = new JsonArray { UrlRef(article) };
        summaryRefs.Add(new JsonObject
        {
            ["rel"] = "about",
            ["kind"] = "subject",
            ["target"] = article.Title,
            ["basis"] = "observed",
        });
        facts.Add(new JsonObject
        {
            ["kind"] = "summary",
            ["text"] = Clamp(summary, 600),
            ["data"] = new JsonObject { ["title"] = article.Title, ["url"] = article.Url },
            ["tags"] = Tags(config.Lang),
            ["refs"] = summaryRefs,
        });

        foreach (var paragraph in paragraphs.Skip(1).Take(config.FactsPerSubject))
        {
            facts.Add(new JsonObject
            {
                ["kind"] = "paragraph",
                ["text"] = Clamp(paragraph, 500),
                ["data"] = new JsonObject { ["title"] = article.Title },
                ["tags"] = Tags(config.Lang),
                ["refs"] = new JsonArray { UrlRef(article) },
            });
        }

        var targets = article.Links
            .Where(link => link != article.Title && selected.Contains(link))
            .Take(config.RefsPerSubject)
            .ToList();
        if (targets.Count > 0)
        {
            var shown = string.Join(", ", targets.Take(5));
            var more = targets.Count > 5 ? $" and {targets.Count - 5} more" : "";
            var linkRefs = new JsonArray { UrlRef(article) };
            foreach (var target in targets)
            {
                linkRefs.Add(new JsonObject
                {
                    ["rel"] = "mentions",
                    ["kind"] = "subject",
                    ["target"] = target,
                    ["basis"] = "derived",
                });
            }

            var linkTags = Tags(config.Lang);
            linkTags.Add("section:links");
            facts.Add(new JsonObject
            {
                ["kind"] = "links",
                ["text"] =
                    $"{article.Title} links to {targets.Count} other article{(targets.Count == 1 ? "" : "s")} in this demo: {shown}{more}.",
                ["tags"] = linkTags,
                ["refs"] = linkRefs,
            });
        }

        var subject = new JsonObject
        {
            ["name"] = article.Title,
            ["kind"] = "article",
        };
        if (parentId is not null)
        {
            subject["parent"] = parentId;
        }

        subject["aliases"] = new JsonArray(article.Title.Replace(' ', '_'));

        return new JsonObject
        {
            ["subject"] = subject,
            ["facts"] = facts,
        };
    }

    public static JsonObject RootPayload(IReadOnlyList<Article> articles, DemoConfig config)
    {
        var refs = new JsonArray();
        foreach (var article in articles)
        {
            refs.Add(new JsonObject
            {
                ["rel"] = "contains",
                ["kind"] = "subject",
                ["target"] = article.Title,
                ["basis"] = "observed",
            });
        }

        return new JsonObject
        {
            ["subject"] = new JsonObject
            {
                ["name"] = config.RootName,
                ["kind"] = "collection",
                ["aliases"] = new JsonArray("wikipedia-demo"),
            },
            ["facts"] = new JsonArray
            {
                new JsonObject
                {
                    ["kind"] = "collection",
                    ["text"] =
                        $"A live demo collection of {articles.Count} Wikipedia articles in {config.Lang}, fetched from the public MediaWiki API and posted one subject at a time.",
                    ["tags"] = Tags(config.Lang),
                    ["refs"] = refs,
                },
            },
        };
    }
}
