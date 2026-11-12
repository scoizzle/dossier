using System.Text.Json;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Docs are claims too: the check example in docs/cli.md must show the labels and counts the
/// resolve ladder actually produces for the seeded Memos/Home subject.
/// </summary>
public sealed class DocsTests
{
    [Test]
    public async Task CheckExampleMatchesTheResolveLadder()
    {
        using var db = new TempDb();

        var seed = JsonDocument.Parse(File.ReadAllText(RepoFilePath("scripts/seed/memos.json"))).RootElement;
        var homeFacts = seed.GetProperty("facts").GetArrayLength();
        await Assert.That(homeFacts).IsGreaterThan(0);

        var root = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Memos", Kind = "product" },
            Facts = { Fixtures.Fact("Memos is the product the demo documents.") },
        }).Response.Subject.Id;

        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Memos/Home", Kind = "screen", Aliases = new List<string> { "Home" }, Parent = root },
            Facts = Enumerable.Range(0, homeFacts).Select(i => Fixtures.Fact($"Home claim {i}.")).ToList(),
        });

        var doc = File.ReadAllText(RepoFilePath("docs/cli.md"));
        var examples = Regex.Matches(doc, @"^\$ d check --subject ""(?<subject>[^""]+)""", RegexOptions.Multiline);
        await Assert.That(examples.Count).IsGreaterThan(0);

        var checkedSubjects = new List<string>();
        foreach (Match example in examples)
        {
            var subject = example.Groups["subject"].Value;
            // The subject object is shown as {"id":…,"name":…,"aliases":…,"facts":N,"match":"label"}.
            var shown = Regex.Match(BlockAfter(doc, example.Index + example.Length), @"""facts"":(?<facts>\d+),""match"":""(?<match>[a-z_]+)""");
            if (!shown.Success)
            {
                // An example with no shown subject object, such as the --drafts line.
                continue;
            }

            var result = db.Store.Check(new CheckRequest { Subject = subject });
            await Assert.That(result.Subject).IsNotNull();
            await Assert.That(result.Subject!.Match).IsEqualTo(shown.Groups["match"].Value);
            await Assert.That(result.Subject.Facts).IsEqualTo(int.Parse(shown.Groups["facts"].Value));
            checkedSubjects.Add(subject);
        }

        // Both spellings stay documented: the exact name and the space-separated one.
        await Assert.That(checkedSubjects).Contains("memos/home");
        await Assert.That(checkedSubjects).Contains("memos home");
        await Assert.That(checkedSubjects.Count).IsGreaterThanOrEqualTo(2);
    }

    /// <summary>The doc lines printed after an example, up to the next example or a blank line.</summary>
    private static string BlockAfter(string text, int index)
    {
        var lines = new List<string>();
        foreach (var raw in text[index..].Split('\n'))
        {
            var line = raw.TrimEnd('\r');
            if (line.Length == 0 || line.StartsWith("$ ", StringComparison.Ordinal))
            {
                break;
            }

            lines.Add(line);
        }

        return string.Join("\n", lines);
    }

    private static string RepoFilePath(string relative)
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
        {
            var candidate = Path.Combine(dir.FullName, relative);
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        throw new FileNotFoundException($"could not find {relative} above {AppContext.BaseDirectory}");
    }
}
