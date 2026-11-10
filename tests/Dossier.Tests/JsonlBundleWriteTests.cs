using System.Text;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class JsonlBundleWriteTests
{
    private static PublishResult Md(TempDb db, string name = "out") => db.Store.Publish(new PublishOptions
    {
        Out = Jsonl.Out(db, name),
        CommandLine = "dossier publish --out out",
        Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero),
    });

    [Test]
    public async Task Republish_LeavesIdenticalBytesAlone()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var first = Jsonl.Publish(db, o => o.Assets = "files");
        var dir = Jsonl.Out(db);
        var stamp = File.GetLastWriteTimeUtc(Path.Combine(dir, "dossier-0001.jsonl"));
        var second = Jsonl.Publish(db, o => o.Assets = "files");
        await Assert.That(first.Written).IsGreaterThan(0);
        await Assert.That(second.Written).IsEqualTo(0);
        await Assert.That(File.GetLastWriteTimeUtc(Path.Combine(dir, "dossier-0001.jsonl"))).IsEqualTo(stamp);
        await Assert.That(second.Removed.Count).IsEqualTo(0);
    }

    [Test]
    public async Task Prune_MarkdownThenJsonlRemovesMarkdownFilesAndKeepsForeignOnes()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Md(db);
        File.WriteAllText(Path.Combine(dir, "notes.txt"), "mine");
        await Assert.That(Directory.Exists(Path.Combine(dir, "subjects"))).IsTrue();

        var result = Jsonl.Publish(db, o => o.Assets = "files");
        var remaining = Jsonl.ReadAll(dir).Keys.OrderBy(k => k, StringComparer.Ordinal).ToList();
        await Assert.That(remaining.Any(k => k.EndsWith(".md", StringComparison.Ordinal))).IsFalse();
        await Assert.That(Directory.Exists(Path.Combine(dir, "subjects"))).IsFalse();
        await Assert.That(remaining.Contains("notes.txt")).IsTrue();
        await Assert.That(remaining.Contains("dossier-0001.jsonl")).IsTrue();
        await Assert.That(remaining.Contains("manifest.json")).IsTrue();
        await Assert.That(result.Removed.Count).IsGreaterThan(5);
        await Assert.That(Jsonl.Manifest(dir).GetProperty("format").GetString()).IsEqualTo("dossier-jsonl/1");
    }

    [Test]
    public async Task Prune_JsonlThenMarkdownRemovesDataFilesAndAssetsAndEmptyDirectories()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Jsonl.Publish(db, o => o.Assets = "files");
        File.WriteAllText(Path.Combine(dir, "notes.txt"), "mine");
        await Assert.That(File.Exists(Path.Combine(dir, "assets", shot.Sha + ".png"))).IsTrue();

        var result = Md(db);
        var remaining = Jsonl.ReadAll(dir).Keys.ToList();
        await Assert.That(remaining.Any(k => k.EndsWith(".jsonl", StringComparison.Ordinal))).IsFalse();
        await Assert.That(Directory.Exists(Path.Combine(dir, "assets"))).IsFalse();
        await Assert.That(remaining.Contains("notes.txt")).IsTrue();
        await Assert.That(result.Removed.Contains("dossier-0001.jsonl")).IsTrue();
        await Assert.That(result.Removed.Contains($"assets/{shot.Sha}.png")).IsTrue();
        await Assert.That(Jsonl.Manifest(dir).GetProperty("format").GetInt32()).IsEqualTo(1);
    }

    [Test]
    public async Task Prune_JsonlRepublishWithFewerFilesRemovesTheExtraOnes()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Jsonl.Publish(db, o => { o.Assets = "files"; o.MaxFileBytes = 1400; });
        await Assert.That(Jsonl.DataFiles(dir).Count).IsGreaterThan(2);

        var result = Jsonl.Publish(db, o => o.Assets = "none");
        await Assert.That(Jsonl.DataFiles(dir).Count).IsEqualTo(1);
        await Assert.That(Directory.Exists(Path.Combine(dir, "assets"))).IsFalse();
        await Assert.That(result.Removed.Contains("dossier-0002.jsonl")).IsTrue();
        await Assert.That(result.Removed.Contains($"assets/{shot.Sha}.png")).IsTrue();
    }

    [Test]
    public async Task Foreign_DataFileWithDifferentBytesIsRefusedAndNothingIsWritten()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Directory.CreateDirectory(dir);
        File.WriteAllText(Path.Combine(dir, "dossier-0001.jsonl"), "{\"someone\":\"else\"}\n");

        var exception = Jsonl.Fails(() => Jsonl.Publish(db));
        await Assert.That(exception.Code).IsEqualTo("publish_conflict");
        await Assert.That(exception.Message.Contains("dossier-0001.jsonl", StringComparison.Ordinal)).IsTrue();
        await Assert.That(File.ReadAllText(Path.Combine(dir, "dossier-0001.jsonl"))).IsEqualTo("{\"someone\":\"else\"}\n");
        await Assert.That(File.Exists(Path.Combine(dir, "manifest.json"))).IsFalse();
        await Assert.That(Directory.Exists(Path.Combine(dir, "assets"))).IsFalse();
    }

    [Test]
    public async Task Foreign_AssetFileWithDifferentBytesIsRefused()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Directory.CreateDirectory(Path.Combine(dir, "assets"));
        File.WriteAllText(Path.Combine(dir, "assets", shot.Sha + ".png"), "not the blob");

        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => o.Assets = "files"));
        await Assert.That(exception.Code).IsEqualTo("publish_conflict");
        await Assert.That(exception.Message.Contains($"assets/{shot.Sha}.png", StringComparison.Ordinal)).IsTrue();
        await Assert.That(File.Exists(Path.Combine(dir, "dossier-0001.jsonl"))).IsFalse();

        // The same bytes are not foreign.
        File.WriteAllBytes(Path.Combine(dir, "assets", shot.Sha + ".png"), shot.Bytes);
        Jsonl.Publish(db, o => o.Assets = "files");
    }

    [Test]
    public async Task Foreign_UnlistedLookalikeIsNeitherOverwrittenNorPruned()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Jsonl.Publish(db, o => o.Assets = "none");
        // Not in the previous manifest, so it is not ours: never pruned.
        File.WriteAllText(Path.Combine(dir, "dossier-0009.jsonl"), "mine\n");
        Jsonl.Publish(db, o => o.Assets = "none");
        await Assert.That(File.ReadAllText(Path.Combine(dir, "dossier-0009.jsonl"))).IsEqualTo("mine\n");
    }

    [Test]
    public async Task Manifest_ExistingManifestIsOverwrittenAndTraversalEntriesAreNeverDeleted()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db);
        Directory.CreateDirectory(dir);
        var victim = Path.Combine(db.Directory, "victim.txt");
        File.WriteAllText(victim, "keep");
        File.WriteAllText(
            Path.Combine(dir, "manifest.json"),
            "{\"bundle_hash\":\"x\",\"files\":[\"../victim.txt\",\"assets/../../victim.txt\",\"/etc/hosts\",\"assets/ZZ.png\"]}");

        Jsonl.Publish(db, o => o.Assets = "none");
        await Assert.That(File.ReadAllText(victim)).IsEqualTo("keep");
        await Assert.That(Jsonl.Manifest(dir).GetProperty("format").GetString()).IsEqualTo("dossier-jsonl/1");
    }

    [Test]
    public async Task WriteBundle_DoesNotDecodeDataFilesAsText()
    {
        // A data file starting with a UTF-8 BOM differs from the generated bytes and is foreign, even though a text read would hide the BOM.
        using var db = new TempDb();
        Jsonl.Seed(db);
        Jsonl.Publish(db, o => o.Assets = "none", name: "probe");
        var generated = File.ReadAllBytes(Path.Combine(Jsonl.Out(db, "probe"), "dossier-0001.jsonl"));
        var dir = Jsonl.Out(db);
        Directory.CreateDirectory(dir);
        File.WriteAllBytes(Path.Combine(dir, "dossier-0001.jsonl"), new byte[] { 0xEF, 0xBB, 0xBF }.Concat(generated).ToArray());
        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => o.Assets = "none"));
        await Assert.That(exception.Code).IsEqualTo("publish_conflict");
    }
}
