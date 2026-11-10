using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class SkillTests
{
    [Test]
    public async Task Skill_FileIsValidAndCommandsExist()
    {
        var text = File.ReadAllText(RepoFilePath("skills/dossier/SKILL.md"));
        var frontmatter = Regex.Match(text, @"\A---\r?\n(.*?)\r?\n---", RegexOptions.Singleline);
        await Assert.That(frontmatter.Success).IsTrue();

        string? Field(string name)
        {
            var match = Regex.Match(frontmatter.Groups[1].Value, $@"^{name}:\s*(.+)$", RegexOptions.Multiline);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }

        await Assert.That(Field("description")).IsNotNull();
        await Assert.That(Field("name")).IsEqualTo("dossier");

        var program = File.ReadAllText(RepoFilePath("src/Dossier/Program.cs"));
        var usage = Regex.Match(program, @"const string usage = ""(.*?)"";").Groups[1].Value;
        await Assert.That(usage).IsNotEmpty();

        var verbs = Regex.Matches(text, @"`dossier ([a-z]+)[^`]*`").Select(m => m.Groups[1].Value).Distinct().ToList();
        await Assert.That(verbs.Count).IsGreaterThan(0);
        foreach (var verb in verbs)
        {
            if (!Regex.IsMatch(usage, $@"(^|[<|\s]){verb}([\s|>\[]|$)"))
            {
                throw new Exception($"SKILL.md uses 'dossier {verb}' but the CLI usage string has no verb '{verb}'");
            }
        }
    }

    [Test]
    public async Task Skill_FileMentionsTheThreeHardFindings()
    {
        var text = File.ReadAllText(RepoFilePath("skills/dossier/SKILL.md"));
        var start = text.IndexOf("## Rules the schema cannot enforce", StringComparison.Ordinal);
        var end = text.IndexOf("## Commands", StringComparison.Ordinal);
        await Assert.That(start).IsGreaterThanOrEqualTo(0);
        await Assert.That(end).IsGreaterThan(start);
        var rules = text[start..end];

        await Assert.That(rules).Contains("zero edges");
        await Assert.That(rules).Contains("data");
        await Assert.That(rules).Contains("key");
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
