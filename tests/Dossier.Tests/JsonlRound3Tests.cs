using System.Runtime.InteropServices;
using System.Security.Cryptography;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>Fix round 3: device copy limit, explicit open() flag table, link check before size check.</summary>
public sealed class JsonlRound3Tests
{
    // ---- N1 -------------------------------------------------------------------------------------

    [Test]
    public async Task AssetCopyLimit_NeverExceedsWhatTheHandleHolds()
    {
        await Assert.That(DossierStore.AssetCopyLimit(1_000_000_000_000, 0)).IsEqualTo(0L);
        await Assert.That(DossierStore.AssetCopyLimit(10, 100)).IsEqualTo(10L);
        await Assert.That(DossierStore.AssetCopyLimit(100, 10)).IsEqualTo(10L);
        await Assert.That(DossierStore.AssetCopyLimit(-1, 5)).IsEqualTo(5L);
    }

    /// <summary>A seekable handle that reports Length 0 but never ends (a /dev/zero-like device) must not be copied for the declared size.</summary>
    private sealed class EndlessZeroLengthStream : Stream
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
            Served += count;
            if (Served > 1L << 30)
            {
                throw new InvalidOperationException("read past 1 GiB: the copy limit ignored the handle length");
            }

            Array.Clear(buffer, offset, count);
            return count;
        }

        public override long Seek(long offset, SeekOrigin origin) => 0;
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }

    [Test]
    public async Task CopyAtMost_WithAssetCopyLimitStopsOnZeroLengthEndlessHandle()
    {
        using var input = new EndlessZeroLengthStream();
        using var output = new MemoryStream();
        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        var limit = DossierStore.AssetCopyLimit(1_000_000_000_000, input.Length);
        var done = DossierStore.CopyAtMost(input, output, hash, limit);
        // The handle claims 0 bytes, so nothing is copied; ReadByte then sees "more data" and the copy reports it.
        await Assert.That(output.Length).IsEqualTo(0L);
        await Assert.That(input.Served).IsLessThan(1L << 20);
        await Assert.That(done).IsFalse();
    }

    [Test]
    public async Task Import_AssetFileEmptyButDeclaredHugeIsSkippedPromptlyWithoutTempFile()
    {
        if (OperatingSystem.IsWindows())
        {
            Skip.Test("Unix-only");
        }

        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        var asset = Directory.EnumerateFiles(Path.Combine(dir, "assets")).Single();
        File.WriteAllBytes(asset, []);
        var data = Path.Combine(dir, Jsonl.DataFiles(dir).Single());
        var text = File.ReadAllText(data, Jsonl.Utf8);
        var lines = text.Split('\n');
        var index = Array.FindIndex(lines, l => l.Contains("\"path\":\"assets/", StringComparison.Ordinal));
        if (index < 0)
        {
            throw new InvalidOperationException("no file asset record found");
        }

        lines[index] = System.Text.RegularExpressions.Regex.Replace(lines[index], "\"bytes\":\\d+", "\"bytes\":1000000000000");
        text = string.Join('\n', lines);
        var textBytes = Jsonl.Utf8.GetBytes(text);
        File.WriteAllBytes(data, textBytes);
        var manifestPath = Path.Combine(dir, "manifest.json");
        var manifest = System.Text.Json.Nodes.JsonNode.Parse(File.ReadAllText(manifestPath))!;
        var stat = manifest["file_stats"]![Path.GetFileName(data)]!;
        stat["bytes"] = textBytes.LongLength;
        stat["sha256"] = Convert.ToHexString(SHA256.HashData(textBytes)).ToLowerInvariant();
        File.WriteAllText(manifestPath, manifest.ToJsonString(), Jsonl.Utf8);

        using var b = new TempDb();
        var task = Task.Run(() => b.Store.Import(new ImportOptions { From = dir }));
        if (!task.Wait(TimeSpan.FromSeconds(10)))
        {
            throw new TimeoutException("import did not return promptly");
        }

        await Assert.That(task.Result.Blobs).IsEqualTo(0);
        await Assert.That(task.Result.Skipped.Count).IsGreaterThan(0);
        await Assert.That(task.Result.Skipped.All(s => !string.IsNullOrEmpty(s.Reason))).IsTrue();
        var blobs = Path.Combine(b.Directory, "blobs");
        await Assert.That(!Directory.Exists(blobs) || !Directory.EnumerateFiles(blobs).Any()).IsTrue();
    }

    // ---- N2 -------------------------------------------------------------------------------------

    [Test]
    [Arguments("macos", Architecture.Arm64, 0x1000104)]
    [Arguments("macos", Architecture.X64, 0x1000104)]
    [Arguments("freebsd", Architecture.X64, 0x100104)]
    [Arguments("freebsd", Architecture.Arm64, 0x100104)]
    [Arguments("linux", Architecture.X64, 0x80000 | 0x20000 | 0x800)]
    [Arguments("linux", Architecture.X86, 0x80000 | 0x20000 | 0x800)]
    [Arguments("linux", Architecture.RiscV64, 0x80000 | 0x20000 | 0x800)]
    [Arguments("linux", Architecture.LoongArch64, 0x80000 | 0x20000 | 0x800)]
    [Arguments("linux", Architecture.S390x, 0x80000 | 0x20000 | 0x800)]
    [Arguments("linux", Architecture.Arm64, 0x80000 | 0x8000 | 0x800)]
    [Arguments("linux", Architecture.Arm, 0x80000 | 0x8000 | 0x800)]
    [Arguments("linux", Architecture.Armv6, 0x80000 | 0x8000 | 0x800)]
    [Arguments("linux", Architecture.Ppc64le, 0x80000 | 0x8000 | 0x800)]
    public async Task UnixOpenFlags_ExplicitTableRows(string os, Architecture architecture, int expected)
    {
        await Assert.That(DossierStore.UnixOpenFlags(os, architecture)).IsEqualTo(expected);
    }

    [Test]
    [Arguments("ios", Architecture.Arm64)]
    [Arguments("illumos", Architecture.X64)]
    [Arguments("other", Architecture.X64)]
    [Arguments("linux", Architecture.Wasm)]
    [Arguments("linux", Architecture.Ppc64le + 99)]
    [Arguments("", Architecture.X64)]
    public async Task UnixOpenFlags_UnknownPlatformFailsClosed(string os, Architecture architecture)
    {
        var exception = Jsonl.Fails(() => DossierStore.UnixOpenFlags(os, architecture));
        await Assert.That(exception.Code).IsEqualTo("import_unsupported_platform");
    }

    [Test]
    public async Task UnixOpenFlags_CurrentHostResolvesToItsRow()
    {
        if (OperatingSystem.IsWindows())
        {
            Skip.Test("Unix-only");
        }

        var os = OperatingSystem.IsMacOS() ? "macos" : OperatingSystem.IsFreeBSD() ? "freebsd" : "linux";
        var flags = DossierStore.UnixOpenFlags(os, RuntimeInformation.ProcessArchitecture);
        await Assert.That(flags & 0x4 | flags & 0x800).IsNotEqualTo(0);
        if (OperatingSystem.IsMacOS())
        {
            await Assert.That(flags).IsEqualTo(0x1000104);
        }
    }

    // ---- N3 -------------------------------------------------------------------------------------

    [Test]
    [Arguments("jsonl")]
    [Arguments("md")]
    public async Task Import_ManifestSymlinkToHugeFileIsRefusedRegardlessOfSize(string format)
    {
        if (OperatingSystem.IsWindows())
        {
            Skip.Test("Unix-only");
        }

        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Format = format);
        var dir = Jsonl.Out(a);
        var big = Path.Combine(a.Directory, "big.json");
        using (var stream = new FileStream(big, FileMode.Create))
        {
            stream.SetLength(65L * 1024 * 1024);
        }

        File.Delete(Path.Combine(dir, "manifest.json"));
        File.CreateSymbolicLink(Path.Combine(dir, "manifest.json"), big);
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(exception.Code).IsEqualTo("import_unsafe_path");
    }
}
