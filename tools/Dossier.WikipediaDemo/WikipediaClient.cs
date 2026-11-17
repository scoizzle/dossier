using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Dossier.WikipediaDemo;

internal sealed record Article(
    string Requested,
    string Title,
    string Extract,
    List<string> Links,
    string FetchedAt,
    string Url);

/// <summary>
/// The public MediaWiki API. Fetch the seeds, then enough of their wikilinks to reach
/// <c>--max-subjects</c>; links shared by several seeds come first because they make the busiest edges.
/// </summary>
internal sealed partial class WikipediaClient
{
    private const string UserAgent = "DossierDemo/1.0 (https://github.com/scoizzle/dossier; live demo script)";

    private readonly DemoConfig _config;
    private readonly HttpClient _http;
    private DateTime _lastCall = DateTime.MinValue;

    public WikipediaClient(DemoConfig config)
    {
        _config = config;
        _http = new HttpClient { Timeout = TimeSpan.FromSeconds(20) };
        _http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", UserAgent);
        _http.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
    }

    [GeneratedRegex(@"(\((identifier|disambiguation)\)|^Portal:|^Special:|^Help:|^File:|^Category:)", RegexOptions.IgnoreCase)]
    private static partial Regex SkipTitle();

    private async Task<JsonObject> QueryAsync(IReadOnlyList<KeyValuePair<string, string>> parameters)
    {
        var sinceLast = (DateTime.UtcNow - _lastCall).TotalMilliseconds;
        if (sinceLast < _config.ApiDelayMs)
        {
            await Task.Delay(Js.Delay(_config.ApiDelayMs - sinceLast));
        }

        _lastCall = DateTime.UtcNow;

        var query = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["action"] = "query",
            ["format"] = "json",
            ["formatversion"] = "2",
            ["redirects"] = "1",
        };
        foreach (var (key, value) in parameters)
        {
            query[key] = value;
        }

        var url = new StringBuilder($"https://{_config.Lang}.wikipedia.org/w/api.php");
        var first = true;

        void Append(string key, string value)
        {
            url.Append(first ? '?' : '&')
                .Append(Uri.EscapeDataString(key))
                .Append('=')
                .Append(Uri.EscapeDataString(value));
            first = false;
        }

        foreach (var (key, value) in query)
        {
            Append(key, value);
        }

        using var response = await _http.GetAsync(url.ToString());
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"Wikipedia API {(int)response.StatusCode} {response.ReasonPhrase}");
        }

        var text = await response.Content.ReadAsStringAsync();
        if (JsonNode.Parse(text) is not JsonObject body)
        {
            throw new InvalidOperationException("Wikipedia API returned invalid JSON");
        }

        if (body["error"] is JsonObject error)
        {
            throw new InvalidOperationException($"Wikipedia API {error["code"]}: {error["info"]}".Trim());
        }

        return body;
    }

    /// <summary>The article, or null when Wikipedia has no page for the title.</summary>
    public async Task<Article?> FetchArticleAsync(string title)
    {
        var body = await QueryAsync(
        [
            Pair("prop", "extracts"),
            Pair("explaintext", "1"),
            Pair("exsectionformat", "plain"),
            Pair("exlimit", "1"),
            Pair("titles", title),
        ]);

        var pages = body["query"]?["pages"] as JsonArray;
        if (pages is not { Count: > 0 } || pages[0] is not JsonObject page || page["missing"]?.GetValue<bool>() == true)
        {
            return null;
        }

        var pageTitle = page["title"]?.GetValue<string>() ?? title;

        // Lead-section wikilinks only: they are the curated "see also" links of the
        // article (infobox and first paragraphs), not hundreds of citation links.
        var parsed = await QueryAsync(
        [
            Pair("action", "parse"),
            Pair("page", pageTitle),
            Pair("prop", "links"),
            Pair("section", "0"),
        ]);

        var links = new List<string>();
        var seen = new HashSet<string>(StringComparer.Ordinal);
        if (parsed["parse"]?["links"] is JsonArray rawLinks)
        {
            foreach (var item in rawLinks.OfType<JsonObject>())
            {
                if (item["ns"]?.GetValue<int>() != 0)
                {
                    continue;
                }

                if (item["exists"]?.GetValue<bool>() == false)
                {
                    continue;
                }

                var link = item["title"]?.GetValue<string>();
                if (!string.IsNullOrEmpty(link) && seen.Add(link))
                {
                    links.Add(link);
                }
            }
        }

        links = links.Where(link => !SkipTitle().IsMatch(link)).ToList();

        return new Article(
            title,
            pageTitle,
            page["extract"]?.GetValue<string>() ?? "",
            links,
            DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'"),
            $"https://{_config.Lang}.wikipedia.org/wiki/{Js.EncodeUriComponent(pageTitle.Replace(' ', '_'))}");
    }

    public async Task<List<Article>> CollectArticlesAsync()
    {
        var chosen = new Dictionary<string, Article>(StringComparer.Ordinal);
        var order = new List<string>();

        foreach (var seed in _config.Seeds)
        {
            if (chosen.Count >= _config.MaxSubjects)
            {
                break;
            }

            try
            {
                var article = await FetchArticleAsync(seed);
                if (article is null)
                {
                    DemoLog.Warn($"no Wikipedia article for \"{seed}\"");
                    continue;
                }

                if (chosen.TryAdd(article.Title, article))
                {
                    order.Add(article.Title);
                }

                DemoLog.Line($"seed {article.Title}: {article.Links.Count} links");
            }
            catch (Exception error) when (error is not DemoFailure)
            {
                DemoLog.Warn($"{seed}: {error.Message}");
            }
        }

        if (chosen.Count == 0)
        {
            throw new DemoFailure("none of the seed articles could be fetched");
        }

        var frequency = new Dictionary<string, int>(StringComparer.Ordinal);
        var frequencyOrder = new List<string>();
        foreach (var title in order)
        {
            foreach (var link in chosen[title].Links)
            {
                if (chosen.ContainsKey(link))
                {
                    continue;
                }

                if (!frequency.TryAdd(link, 1))
                {
                    frequency[link]++;
                }
                else
                {
                    frequencyOrder.Add(link);
                }
            }
        }

        var candidates = frequencyOrder.OrderByDescending(title => frequency[title]).ToList();
        foreach (var title in candidates)
        {
            if (chosen.Count >= _config.MaxSubjects)
            {
                break;
            }

            try
            {
                var article = await FetchArticleAsync(title);
                if (article is null || chosen.ContainsKey(article.Title))
                {
                    continue;
                }

                chosen[article.Title] = article;
                order.Add(article.Title);
                DemoLog.Line($"link {article.Title}: {article.Links.Count} links");
            }
            catch (Exception error) when (error is not DemoFailure)
            {
                DemoLog.Warn($"{title}: {error.Message}");
            }
        }

        return order.Select(title => chosen[title]).ToList();
    }

    private static KeyValuePair<string, string> Pair(string key, string value) => new(key, value);
}

/// <summary>The few JavaScript URI rules the demo depends on.</summary>
internal static class Js
{
    /// <summary><c>encodeURIComponent</c>: leaves <c>! ' ( ) * ~</c> alone, unlike <see cref="Uri.EscapeDataString"/>.</summary>
    public static string EncodeUriComponent(string value) =>
        Uri.EscapeDataString(value)
            .Replace("%21", "!", StringComparison.Ordinal)
            .Replace("%27", "'", StringComparison.Ordinal)
            .Replace("%28", "(", StringComparison.Ordinal)
            .Replace("%29", ")", StringComparison.Ordinal)
            .Replace("%2A", "*", StringComparison.Ordinal)
            .Replace("%7E", "~", StringComparison.Ordinal);

    /// <summary><c>setTimeout</c> clamps a delay above int.MaxValue milliseconds to 1.</summary>
    public static TimeSpan Delay(double milliseconds) =>
        TimeSpan.FromMilliseconds(milliseconds > int.MaxValue ? 1 : milliseconds);
}
