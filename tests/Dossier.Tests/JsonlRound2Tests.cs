using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json.Nodes;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>Fix round 2: allocation-free duplicate-asset check, bounded device reads, hidden files under assets/, open() errno mapping.</summary>
public sealed class JsonlRound2Tests
{
    private static void RequireUnix()
    {
        if (OperatingSystem.IsWindows())
        {
            Skip.Test("Unix-only");
        }
    }

    private static string Sha(byte[] bytes) => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();

    /// <summary>A stream that never ends and claims a Length of 0, like a seekable /dev/zero.</summary>
    private sealed class EndlessStream : Stream
    {
        public long Served;
        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => false;
        public override long Length => 0;
        public override long Position { get => 0; set { } }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count)
        {
            if (Served > 1L << 30)
            {
                throw new InvalidOperationException("read past 1 GiB: the reader is unbounded");
            }

            Served += count;
            Array.Fill(buffer, (byte)'x', offset, count);
            return count;
        }

        public override long Seek(long offset, SeekOrigin origin) => 0;
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }

    // ---- F1: duplicate-asset check does not materialise the data ---------------------------------

    [Test]
    public async Task Import_LargeEmbeddedAssetStaysWithinAllocationBudget()
    {
        using var a = new TempDb();
        var (small, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);

        var big = new byte[8 * 1024 * 1024];
        new Random(7).NextBytes(big);
        var bigSha = Sha(big);
        var path = Path.Combine(dir, "dossier-0001.jsonl");
        var lines = File.ReadAllText(path, Jsonl.Utf8).Split('\n').ToList();
        for (var i = 0; i < lines.Count; i++)
        {
            if (lines[i].Contains("\"type\":\"asset\"", StringComparison.Ordinal))
            {
                var node = JsonNode.Parse(lines[i])!;
                node["data"] = Convert.ToBase64String(big);
                node["bytes"] = big.LongLength;
                node["sha256"] = bigSha;
                lines[i] = node.ToJsonString(new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            }
            else
            {
                lines[i] = lines[i].Replace(small.Sha, bigSha, StringComparison.Ordinal);
            }
        }

        var text = string.Join('\n', lines);
        File.WriteAllText(path, text, Jsonl.Utf8);
        var textBytes = Jsonl.Utf8.GetBytes(text);
        var manifestPath = Path.Combine(dir, "manifest.json");
        var manifest = JsonNode.Parse(File.ReadAllText(manifestPath))!;
        var stat = manifest["file_stats"]!["dossier-0001.jsonl"]!;
        stat["bytes"] = textBytes.LongLength;
        stat["sha256"] = Sha(textBytes);
        File.WriteAllText(manifestPath, manifest.ToJsonString(), Jsonl.Utf8);

        var lineLength = lines.Max(l => Jsonl.Utf8.GetByteCount(l));
        using var warm = new TempDb();
        warm.Store.Import(new ImportOptions { From = dir });
        using var b = new TempDb();
        var before = GC.GetAllocatedBytesForCurrentThread();
        var result = b.Store.Import(new ImportOptions { From = dir });
        var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

        await Assert.That(string.Join("; ", result.Skipped.Select(x => x.Reason))).IsEqualTo(string.Empty);
        await Assert.That(result.Blobs).IsEqualTo(1);
        Console.WriteLine($"import allocated {allocated} bytes for a {lineLength}-byte asset line ({(double)allocated / lineLength:F2}x)");
        await Assert.That(allocated).IsLessThan((long)(lineLength * 5.5));
    }

    // ---- F2: bounded readers ---------------------------------------------------------------------

    [Test]
    public async Task ReadAtMost_StopsOnAnEndlessStream()
    {
        using var endless = new EndlessStream();
        var bytes = DossierStore.ReadAtMost(endless, Math.Min(endless.Length, 64L * 1024 * 1024));
        await Assert.That(bytes).IsNull();
        await Assert.That(endless.Served).IsLessThan(8192);

        using var more = new EndlessStream();
        await Assert.That(DossierStore.ReadAtMost(more, 1000)).IsNull();
        await Assert.That(more.Served).IsLessThan(8192);
    }

    [Test]
    public async Task CopyAtMost_StopsAtTheDeclaredBytes()
    {
        using var endless = new EndlessStream();
        using var output = new MemoryStream();
        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        var complete = DossierStore.CopyAtMost(endless, output, hash, 100_000);
        await Assert.That(complete).IsFalse();
        await Assert.That(output.Length).IsEqualTo(100_000);
        await Assert.That(endless.Served).IsLessThan(300_000);

        using var exact = new MemoryStream(new byte[500]);
        using var sink = new MemoryStream();
        await Assert.That(DossierStore.CopyAtMost(exact, sink, hash, 500)).IsTrue();
        await Assert.That(sink.Length).IsEqualTo(500);
    }

    // ---- F3: hidden files under assets/ ----------------------------------------------------------

    [Test]
    public async Task Import_HiddenFileUnderAssetsIsSkippedAndReported()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        File.WriteAllText(Path.Combine(dir, "assets", ".DS_Store"), "litter");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(result.Blobs).IsEqualTo(1);
        await Assert.That(result.Skipped.Any(s => s.Reason.StartsWith("hidden_file_ignored", StringComparison.Ordinal) && s.Path.EndsWith(".DS_Store", StringComparison.Ordinal))).IsTrue();
    }

    [Test]
    public async Task Import_NonHiddenUnlistedFileStillFails()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        File.WriteAllText(Path.Combine(dir, "assets", ".DS_Store"), "litter");
        File.WriteAllText(Path.Combine(dir, "assets", "stray.png"), "stray");
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(exception.Code).IsEqualTo("import_unlisted_file");
    }

    // ---- F5: open() errno mapping ---------------------------------------------------------------

    [Test]
    public async Task OpenRegularFile_MapsErrnoToAccurateCodes()
    {
        RequireUnix();
        using var db = new TempDb();
        var missing = Jsonl.Fails(() => DossierStore.OpenRegularFile(Path.Combine(db.Directory, "nope"), "nope", 4096).Dispose());
        await Assert.That(missing.Code).IsEqualTo("import_file_missing");

        var real = Path.Combine(db.Directory, "real");
        File.WriteAllText(real, "x");
        var link = Path.Combine(db.Directory, "link");
        File.CreateSymbolicLink(link, real);
        var loop = Jsonl.Fails(() => DossierStore.OpenRegularFile(link, "link", 4096).Dispose());
        await Assert.That(loop.Code).IsEqualTo("import_unsafe_path");

        using (var ok = DossierStore.OpenRegularFile(real, "real", 4096))
        {
            await Assert.That(ok.Length).IsEqualTo(1);
        }

        if (Environment.UserName != "root" && !OperatingSystem.IsWindows())
        {
            File.SetUnixFileMode(real, UnixFileMode.None);
            var denied = Jsonl.Fails(() => DossierStore.OpenRegularFile(real, "real", 4096).Dispose());
            File.SetUnixFileMode(real, UnixFileMode.UserRead | UnixFileMode.UserWrite);
            await Assert.That(denied.Code).IsEqualTo("import_unreadable_file");
        }
    }
}
