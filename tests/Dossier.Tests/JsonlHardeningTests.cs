using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json.Nodes;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>Review fixes for JSONL import/export: non-regular files, file-index parsing, unlisted assets, duplicate assets, memory ceiling.</summary>
public sealed class JsonlHardeningTests
{
    private static string Sha(byte[] bytes) => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();

    private static void RequireUnix()
    {
        if (OperatingSystem.IsWindows())
        {
            Skip.Test("named pipes and /dev/zero symlinks are Unix-only");
        }
    }

    private static void Mkfifo(string path)
    {
        var info = new ProcessStartInfo("mkfifo") { UseShellExecute = false };
        info.ArgumentList.Add(path);
        using var process = Process.Start(info)!;
        process.WaitForExit();
        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException("mkfifo failed");
        }
    }

    /// <summary>Creates a symbolic link; skips the test when the platform refuses (Windows without the privilege).</summary>
    private static void Link(string link, string target)
    {
        try
        {
            File.CreateSymbolicLink(link, target);
        }
        catch (Exception exception) when (exception is UnauthorizedAccessException or IOException && OperatingSystem.IsWindows())
        {
            Skip.Test("cannot create symbolic links here: " + exception.Message);
        }
    }

    /// <summary>Runs an import that must fail, giving up after five seconds so a regression cannot hang the run.</summary>
    private static DossierRequestException ImportFails(DossierStore store, string dir, long maxLine = 0)
    {
        var task = Task.Run(() => Jsonl.Fails(() => store.Import(new ImportOptions { From = dir, MaxLineBytes = maxLine })));
        if (!task.Wait(TimeSpan.FromSeconds(5)))
        {
            throw new TimeoutException("import did not return within 5 seconds (hung on a non-regular file?)");
        }

        return task.Result;
    }

    private static string Published(TempDb a, string assets)
    {
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = assets);
        return Jsonl.Out(a);
    }

    private static void EditManifest(string dir, Action<JsonNode> edit)
    {
        var path = Path.Combine(dir, "manifest.json");
        var manifest = JsonNode.Parse(File.ReadAllText(path))!;
        edit(manifest);
        File.WriteAllText(path, manifest.ToJsonString(), Jsonl.Utf8);
    }

    /// <summary>Rewrites dossier-0001.jsonl and keeps manifest file_stats consistent.</summary>
    private static void Tamper(string dir, Func<string, string> transform)
    {
        var path = Path.Combine(dir, "dossier-0001.jsonl");
        var text = transform(File.ReadAllText(path, Jsonl.Utf8));
        File.WriteAllText(path, text, Jsonl.Utf8);
        var bytes = Jsonl.Utf8.GetBytes(text);
        EditManifest(dir, m =>
        {
            var stat = m["file_stats"]!["dossier-0001.jsonl"]!;
            stat["bytes"] = bytes.LongLength;
            stat["lines"] = text.Count(c => c == '\n');
            stat["sha256"] = Sha(bytes);
        });
    }

    private static int FactCount(DossierStore store)
    {
        using var connection = store.OpenConnection();
        return Convert.ToInt32(Fixtures.Scalar(connection, "SELECT COUNT(*) FROM facts"));
    }

    // ---- JR1: non-regular files ------------------------------------------------------------

    [Test]
    public async Task Import_FifoManifestFailsFast()
    {
        RequireUnix();
        using var b = new TempDb();
        var dir = Path.Combine(b.Directory, "bundle");
        Directory.CreateDirectory(dir);
        Mkfifo(Path.Combine(dir, "manifest.json"));
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_not_regular_file");
    }

    [Test]
    public async Task Import_FifoDataFileFailsFast()
    {
        RequireUnix();
        using var a = new TempDb();
        var dir = Published(a, "none");
        var data = Path.Combine(dir, "dossier-0001.jsonl");
        File.Delete(data);
        Mkfifo(data);
        using var b = new TempDb();
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_not_regular_file");
        await Assert.That(FactCount(b.Store)).IsEqualTo(0);
    }

    [Test]
    public async Task Import_ManifestSymlinkedToDevZeroFailsFast()
    {
        RequireUnix();
        using var b = new TempDb();
        var dir = Path.Combine(b.Directory, "bundle");
        Directory.CreateDirectory(dir);
        Link(Path.Combine(dir, "manifest.json"), "/dev/zero");
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_unsafe_path");
    }

    [Test]
    public async Task Import_FifoAssetFileIsSkippedNotRead()
    {
        RequireUnix();
        using var a = new TempDb();
        var dir = Published(a, "files");
        var asset = Directory.EnumerateFiles(Path.Combine(dir, "assets")).Single();
        File.Delete(asset);
        Mkfifo(asset);
        using var b = new TempDb();
        var task = Task.Run(() => b.Store.Import(new ImportOptions { From = dir }));
        if (!task.Wait(TimeSpan.FromSeconds(5)))
        {
            throw new TimeoutException("import hung on a FIFO asset");
        }

        await Assert.That(task.Result.Blobs).IsEqualTo(0);
        await Assert.That(task.Result.Skipped.Single().Reason.Contains("regular file", StringComparison.Ordinal)).IsTrue();
    }

    // ---- JR5: symlink and escape coverage ---------------------------------------------------

    [Test]
    public async Task Import_SymlinkedManifestIsRejected()
    {
        using var a = new TempDb();
        var dir = Published(a, "none");
        var real = Path.Combine(a.Directory, "real-manifest.json");
        File.Move(Path.Combine(dir, "manifest.json"), real);
        Link(Path.Combine(dir, "manifest.json"), real);
        using var b = new TempDb();
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_unsafe_path");
        await Assert.That(FactCount(b.Store)).IsEqualTo(0);
    }

    [Test]
    public async Task Import_SymlinkedAssetsDirectoryIsNotFollowed()
    {
        using var a = new TempDb();
        var dir = Published(a, "files");
        var real = Path.Combine(a.Directory, "real-assets");
        Directory.Move(Path.Combine(dir, "assets"), real);
        try
        {
            Directory.CreateSymbolicLink(Path.Combine(dir, "assets"), real);
        }
        catch (Exception exception) when (exception is UnauthorizedAccessException or IOException && OperatingSystem.IsWindows())
        {
            Skip.Test("cannot create symbolic links here: " + exception.Message);
        }

        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(result.Blobs).IsEqualTo(0);
        await Assert.That(result.Skipped.Single().Reason.Contains("symbolic link", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(b.Store.BlobRoot) && Directory.EnumerateFileSystemEntries(b.Store.BlobRoot).Any()).IsFalse();
    }

    [Test]
    public async Task Import_EmbeddedDataWithJsonEscapesIsSkipped()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);
        var good = Convert.ToBase64String(shot.Bytes);
        var escaped = $"\\u{(int)good[0]:x4}" + good[1..];
        Tamper(dir, t => t.Replace(good, escaped, StringComparison.Ordinal));
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(result.Blobs).IsEqualTo(0);
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Single().Reason.Contains("escapes", StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    public async Task Republish_FailingALimitLeavesEveryOldFileUntouched()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var before = Jsonl.ReadAll(Jsonl.Out(a));
        var exception = Jsonl.Fails(() => Jsonl.Publish(a, o =>
        {
            o.Assets = "files";
            o.MaxFileBytes = 50;
        }));
        await Assert.That(exception.Message.Contains("nothing was written", StringComparison.Ordinal)).IsTrue();
        var after = Jsonl.ReadAll(Jsonl.Out(a));
        await Assert.That(after.Keys.OrderBy(k => k, StringComparer.Ordinal).SequenceEqual(before.Keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        foreach (var (name, bytes) in before)
        {
            await Assert.That(after[name].AsSpan().SequenceEqual(bytes)).IsTrue();
        }
    }

    // ---- JR6: file index ---------------------------------------------------------------------

    [Test]
    public async Task Import_DataFileNumberThatOverflowsIsABadManifest()
    {
        using var a = new TempDb();
        var dir = Published(a, "none");
        var name = "dossier-99999999999999999999.jsonl";
        File.Copy(Path.Combine(dir, "dossier-0001.jsonl"), Path.Combine(dir, name));
        EditManifest(dir, m =>
        {
            m["files"]!.AsArray().Add(name);
            m["file_stats"]![name] = m["file_stats"]!["dossier-0001.jsonl"]!.DeepClone();
        });
        using var b = new TempDb();
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_bad_manifest");
    }

    [Test]
    public async Task Import_DuplicateNamesInManifestFilesAreABadManifest()
    {
        using var a = new TempDb();
        var dir = Published(a, "none");
        EditManifest(dir, m => m["files"]!.AsArray().Add("dossier-0001.jsonl"));
        using var b = new TempDb();
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_bad_manifest");
        await Assert.That(FactCount(b.Store)).IsEqualTo(0);
    }

    // ---- JR7: embedded blob writes -----------------------------------------------------------

    [Test]
    public async Task Import_EmbeddedBlobLandsWithoutTemporaryFiles()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });
        await Assert.That(result.Blobs).IsEqualTo(1);
        var names = Directory.EnumerateFileSystemEntries(b.Store.BlobRoot).Select(p => Path.GetFileName(p)).ToList();
        await Assert.That(names.Count).IsEqualTo(1);
        await Assert.That(names[0]).IsEqualTo(shot.Sha);
        await Assert.That(File.ReadAllBytes(Path.Combine(b.Store.BlobRoot, shot.Sha)).AsSpan().SequenceEqual(shot.Bytes)).IsTrue();
    }

    // ---- JR8: unlisted files under assets/ --------------------------------------------------

    [Test]
    public async Task Import_UnlistedFileUnderAssetsIsRejected()
    {
        using var a = new TempDb();
        var dir = Published(a, "files");
        File.WriteAllText(Path.Combine(dir, "assets", new string('b', 64) + ".png"), "stray");
        using var b = new TempDb();
        var exception = ImportFails(b.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_unlisted_file");
        await Assert.That(exception.Message.Contains("assets/", StringComparison.Ordinal)).IsTrue();
        await Assert.That(FactCount(b.Store)).IsEqualTo(0);
    }

    // ---- JR9: duplicate asset records -------------------------------------------------------

    [Test]
    public async Task Import_DuplicateAssetRecordsMustAgree()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);
        var original = File.ReadAllText(Path.Combine(dir, "dossier-0001.jsonl"), Jsonl.Utf8);
        var manifest = File.ReadAllText(Path.Combine(dir, "manifest.json"));
        var assetLine = original.Split('\n').Single(l => l.Contains("\"type\":\"asset\"", StringComparison.Ordinal)) + "\n";

        // An identical duplicate is accepted.
        Tamper(dir, t => t + assetLine);
        using var ok = new TempDb();
        var accepted = ok.Store.Import(new ImportOptions { From = dir });
        await Assert.That(accepted.Blobs).IsEqualTo(1);

        // A duplicate that disagrees (mime) is rejected.
        File.WriteAllText(Path.Combine(dir, "dossier-0001.jsonl"), original, Jsonl.Utf8);
        File.WriteAllText(Path.Combine(dir, "manifest.json"), manifest);
        Tamper(dir, t => t + assetLine.Replace("image/png", "image/jpeg", StringComparison.Ordinal));
        using var bad = new TempDb();
        var exception = ImportFails(bad.Store, dir);
        await Assert.That(exception.Code).IsEqualTo("import_bad_record");
        await Assert.That(exception.Message.Contains(shot.Sha, StringComparison.Ordinal)).IsTrue();
        await Assert.That(FactCount(bad.Store)).IsEqualTo(0);
    }

    // ---- JR2: export memory ceiling ----------------------------------------------------------

    [Test]
    public async Task Publish_FileBeyondTheMemoryCeilingFailsClosed()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        var exception = Jsonl.Fails(() => Jsonl.Publish(a, o =>
        {
            o.Assets = "files";
            o.MemoryCeilingBytes = 400;
        }));
        await Assert.That(exception.Code).IsEqualTo("bundle_too_large_for_memory");
        await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(Jsonl.Out(a))).IsFalse();
    }

    [Test]
    public async Task Publish_EmbeddedAssetBeyondTheMemoryCeilingFailsClosed()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        // The base64 line of the embedded asset alone is larger than this ceiling.
        var exception = Jsonl.Fails(() => Jsonl.Publish(a, o =>
        {
            o.Assets = "embed";
            o.MemoryCeilingBytes = 40;
        }));
        await Assert.That(exception.Code).IsEqualTo("bundle_too_large_for_memory");
        await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(Jsonl.Out(a))).IsFalse();
    }
}
