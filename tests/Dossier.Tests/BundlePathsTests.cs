namespace Dossier.Tests;

public class BundlePathsTests
{
    [Test]
    [Arguments("index/1.md", "../shards/1.md#a", "shards/1.md#a")]
    [Arguments("INDEX.md", "shards/1.md#a", "shards/1.md#a")]
    [Arguments("subjects/s/facts/f.md", "../../t/facts/g.md", "subjects/t/facts/g.md")]
    [Arguments("subjects\\s\\index.md", "facts\\f.md", "subjects/s/facts/f.md")]
    [Arguments("a/b.md", "./c.md", "a/c.md")]
    public async Task Resolve_YieldsSlashJoinedBundleRelativePath(string from, string target, string expected)
    {
        await Assert.That(BundlePaths.Resolve(from, target)).IsEqualTo(expected);
    }

    [Test]
    public async Task ToBundle_ConvertsWindowsSeparators()
    {
        await Assert.That(BundlePaths.ToBundle("subjects\\login\\facts\\a.md")).IsEqualTo("subjects/login/facts/a.md");
    }
}
