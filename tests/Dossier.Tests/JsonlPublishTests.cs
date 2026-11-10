using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class JsonlPublishTests
{
    private static string[] Types(string dir) => Jsonl.Records(dir).Select(r => r.GetProperty("type").GetString()!).ToArray();

    [Test]
    public async Task Jsonl_WritesSubjectFactAssetLinesAndManifest()
    {
        using var db = new TempDb();
        var (shot, appId, _) = Jsonl.Seed(db);
        var result = Jsonl.Publish(db, o => o.Assets = "files");
        var dir = Jsonl.Out(db);

        var files = Jsonl.DataFiles(dir);
        await Assert.That(files.Count).IsEqualTo(1);
        await Assert.That(files[0]).IsEqualTo("dossier-0001.jsonl");

        var bytes = File.ReadAllBytes(Path.Combine(dir, files[0]));
        await Assert.That(bytes.Length > 0 && bytes[^1] == (byte)'\n').IsTrue();
        await Assert.That(bytes.Take(3).SequenceEqual(new byte[] { 0xEF, 0xBB, 0xBF })).IsFalse();

        // subject, its facts, next subject, its facts; the asset follows the fact that cites it.
        var types = Types(dir);
        await Assert.That(string.Join(",", types)).IsEqualTo("subject,fact,subject,fact,asset,fact,fact");
        await Assert.That(result.Subjects).IsEqualTo(2);
        await Assert.That(result.Facts).IsEqualTo(4);

        var records = Jsonl.Records(dir);
        var subject = records[0];
        await Assert.That(subject.GetProperty("id").GetString()).IsEqualTo(appId);
        await Assert.That(subject.GetProperty("path").GetString()).IsEqualTo("My App");
        await Assert.That(subject.TryGetProperty("parent", out _)).IsFalse();
        await Assert.That(subject.GetProperty("pin").GetProperty("rev").GetString()).IsEqualTo("abc123");
        await Assert.That(records[2].GetProperty("path").GetString()).IsEqualTo("My App / Home Screen");
        await Assert.That(records[2].GetProperty("parent").GetString()).IsEqualTo(appId);

        var fact = records[1];
        foreach (var name in new[] { "id", "subject_id", "kind", "text", "tags", "confidence", "status", "provenance", "content_hash", "subject_name", "bundle_key", "type" })
        {
            await Assert.That(fact.TryGetProperty(name, out _)).IsTrue();
        }

        await Assert.That(fact.GetProperty("subject_name").GetString()).IsEqualTo("My App");

        // Keys sorted at the top level of every line.
        foreach (var line in File.ReadAllText(Path.Combine(dir, files[0])).Split('\n').SkipLast(1))
        {
            var keys = JsonDocument.Parse(line).RootElement.EnumerateObject().Select(p => p.Name).ToList();
            await Assert.That(keys.SequenceEqual(keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        }

        var asset = records[4];
        await Assert.That(asset.GetProperty("sha256").GetString()).IsEqualTo(shot.Sha);
        await Assert.That(asset.GetProperty("path").GetString()).IsEqualTo($"assets/{shot.Sha}.png");
        await Assert.That(asset.GetProperty("bytes").GetInt64()).IsEqualTo((long)shot.Bytes.Length);
        await Assert.That(asset.TryGetProperty("data", out _)).IsFalse();
        await Assert.That(File.ReadAllBytes(Path.Combine(dir, "assets", shot.Sha + ".png")).SequenceEqual(shot.Bytes)).IsTrue();

        var manifest = Jsonl.Manifest(dir);
        await Assert.That(manifest.GetProperty("format").GetString()).IsEqualTo("dossier-jsonl/1");
        var listed = manifest.GetProperty("files").EnumerateArray().Select(e => e.GetString()!).ToList();
        await Assert.That(string.Join(",", listed)).IsEqualTo($"assets/{shot.Sha}.png,dossier-0001.jsonl,manifest.json");
        var stats = manifest.GetProperty("file_stats").GetProperty("dossier-0001.jsonl");
        await Assert.That(stats.GetProperty("bytes").GetInt64()).IsEqualTo((long)bytes.Length);
        await Assert.That(stats.GetProperty("lines").GetInt32()).IsEqualTo(7);
        await Assert.That(stats.GetProperty("sha256").GetString()).IsEqualTo(Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant());
        await Assert.That(manifest.GetProperty("counts").GetProperty("subjects").GetInt32()).IsEqualTo(2);
        await Assert.That(manifest.GetProperty("counts").GetProperty("facts").GetInt32()).IsEqualTo(4);
        await Assert.That(manifest.GetProperty("counts").GetProperty("assets").GetInt32()).IsEqualTo(1);
        await Assert.That(manifest.GetProperty("assets").GetProperty(shot.Sha).GetProperty("missing").GetBoolean()).IsFalse();
    }

    [Test]
    public async Task Jsonl_ExportsOnlyLiveFacts()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        Jsonl.Publish(db, o => o.Assets = "none");
        var texts = Jsonl.Records(Jsonl.Out(db)).Where(r => r.GetProperty("type").GetString() == "fact").Select(r => r.GetProperty("text").GetString()).ToList();
        await Assert.That(texts.Contains("The header is 60 pixels tall.")).IsFalse();
        await Assert.That(texts.Contains("The header is 64 pixels tall.")).IsTrue();
    }

    [Test]
    public async Task Jsonl_EmbedWritesBase64AssetLine()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        Jsonl.Publish(db, o => o.Assets = "embed");
        var dir = Jsonl.Out(db);
        var asset = Jsonl.Records(dir).Single(r => r.GetProperty("type").GetString() == "asset");
        await Assert.That(asset.GetProperty("encoding").GetString()).IsEqualTo("base64");
        await Assert.That(asset.TryGetProperty("path", out _)).IsFalse();
        await Assert.That(Convert.FromBase64String(asset.GetProperty("data").GetString()!).SequenceEqual(shot.Bytes)).IsTrue();
        await Assert.That(asset.GetProperty("filename").GetString()).IsEqualTo("shots/Home Screen.PNG");
        await Assert.That(Directory.Exists(Path.Combine(dir, "assets"))).IsFalse();
    }

    [Test]
    public async Task Jsonl_AssetsNoneWritesNoAssetLinesButKeepsAttachmentMetadata()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        Jsonl.Publish(db, o => o.Assets = "none");
        var records = Jsonl.Records(Jsonl.Out(db));
        await Assert.That(records.Any(r => r.GetProperty("type").GetString() == "asset")).IsFalse();
        var pointer = records.Single(r => r.GetProperty("type").GetString() == "fact" && r.GetProperty("kind").GetString() == "behavior");
        await Assert.That(pointer.GetProperty("attachments")[0].GetProperty("sha256").GetString()).IsEqualTo(shot.Sha);
    }

    [Test]
    public async Task Jsonl_DefaultAssetsModeIsFiles()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        Jsonl.Publish(db);
        await Assert.That(File.Exists(Path.Combine(Jsonl.Out(db), "assets", shot.Sha + ".png"))).IsTrue();
    }

    [Test]
    public async Task Jsonl_MissingBlobEmitsMissingAssetLineAndWarning()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        File.Delete(Path.Combine(db.Store.BlobRoot, shot.Sha));
        var result = Jsonl.Publish(db, o => o.Assets = "embed");
        var asset = Jsonl.Records(Jsonl.Out(db)).Single(r => r.GetProperty("type").GetString() == "asset");
        await Assert.That(asset.GetProperty("missing").GetBoolean()).IsTrue();
        await Assert.That(asset.TryGetProperty("data", out _)).IsFalse();
        await Assert.That(asset.TryGetProperty("path", out _)).IsFalse();
        await Assert.That(result.Warnings.Any(w => w.Contains(shot.Sha))).IsTrue();
        await Assert.That(Jsonl.Manifest(Jsonl.Out(db)).GetProperty("assets").GetProperty(shot.Sha).GetProperty("missing").GetBoolean()).IsTrue();
    }

    [Test]
    public async Task Jsonl_DuplicateAttachmentsEmitOneAssetLine()
    {
        using var db = new TempDb();
        var shot = Jsonl.WriteBlob(db, "shared bytes");
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Dup" },
            Facts =
            {
                new FactInput { Kind = "note", Text = "one", Attachments = new List<AttachmentInput> { new() { Sha256 = shot.Sha, Filename = "a.txt", Mime = "text/plain", Bytes = shot.Bytes.Length } } },
                new FactInput { Kind = "note", Text = "two", Attachments = new List<AttachmentInput> { new() { Sha256 = shot.Sha, Filename = "b.txt", Mime = "text/plain", Bytes = shot.Bytes.Length } } },
            },
        });
        Jsonl.Publish(db, o => o.Assets = "embed");
        await Assert.That(Types(Jsonl.Out(db)).Count(t => t == "asset")).IsEqualTo(1);
    }

    [Test]
    public async Task Jsonl_IsByteIdenticalAcrossRunsAndBundleHashIsStable()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        Jsonl.Publish(db, o => o.Assets = "embed", name: "a");
        Jsonl.Publish(db, o => o.Assets = "embed", name: "b");
        var a = Jsonl.ReadAll(Jsonl.Out(db, "a"));
        var b = Jsonl.ReadAll(Jsonl.Out(db, "b"));
        await Assert.That(a.Keys.SequenceEqual(b.Keys)).IsTrue();
        foreach (var (name, content) in a)
        {
            await Assert.That(content.SequenceEqual(b[name])).IsTrue();
        }

        var hash = Jsonl.Manifest(Jsonl.Out(db, "a")).GetProperty("bundle_hash").GetString();
        await Assert.That(hash).IsEqualTo(Jsonl.Manifest(Jsonl.Out(db, "b")).GetProperty("bundle_hash").GetString());
        await Assert.That(hash!.Length).IsEqualTo(64);

        // The hash changes when the content changes.
        db.Store.PostFacts(Fixtures.Post("My App", Fixtures.Fact("A brand new fact.")));
        Jsonl.Publish(db, o => o.Assets = "embed", name: "c");
        await Assert.That(Jsonl.Manifest(Jsonl.Out(db, "c")).GetProperty("bundle_hash").GetString()).IsNotEqualTo(hash);
    }

    [Test]
    public async Task Jsonl_EscapesLineSeparators()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Seps", Fixtures.Fact("a\u2028b\u2029c\u0085d end")));
        Jsonl.Publish(db, o => o.Assets = "none");
        var raw = File.ReadAllBytes(Path.Combine(Jsonl.Out(db), "dossier-0001.jsonl"));
        var text = Jsonl.Utf8.GetString(raw);
        await Assert.That(text.Contains('\u2028')).IsFalse();
        await Assert.That(text.Contains('\u2029')).IsFalse();
        await Assert.That(text.Contains('\u0085')).IsFalse();
        await Assert.That(text.Contains("\\u2028")).IsTrue();
        await Assert.That(text.Split('\n').SkipLast(1).All(l => l.Length > 0)).IsTrue();
        var fact = Jsonl.Records(Jsonl.Out(db)).Single(r => r.GetProperty("type").GetString() == "fact");
        await Assert.That(fact.GetProperty("text").GetString()).IsEqualTo("a\u2028b\u2029c\u0085d end");
    }

    [Test]
    public async Task Jsonl_SubjectScopeOmitsParentOutsideTheBundle()
    {
        using var db = new TempDb();
        var (_, _, screenId) = Jsonl.Seed(db);
        Jsonl.Publish(db, o =>
        {
            o.Assets = "none";
            o.Subject = "Home Screen";
        });
        var subject = Jsonl.Records(Jsonl.Out(db)).Single(r => r.GetProperty("type").GetString() == "subject");
        await Assert.That(subject.GetProperty("id").GetString()).IsEqualTo(screenId);
        await Assert.That(subject.TryGetProperty("parent", out _)).IsFalse();
        await Assert.That(Jsonl.Manifest(Jsonl.Out(db)).GetProperty("options").GetProperty("subject").GetString()).IsEqualTo("Home Screen");
    }

    // ---- packing ---------------------------------------------------------------------------

    private static (TempDb Db, List<int> LineBytes) PackingStore()
    {
        var db = new TempDb();
        Jsonl.Seed(db);
        db.Store.PostFacts(Fixtures.Post("My App", Fixtures.Fact(new string('x', 400))));
        Jsonl.Publish(db, o => o.Assets = "none", name: "probe");
        var lines = File.ReadAllText(Path.Combine(Jsonl.Out(db, "probe"), "dossier-0001.jsonl"), Jsonl.Utf8)
            .Split('\n').SkipLast(1).Select(l => Jsonl.Utf8.GetByteCount(l) + 1).ToList();
        return (db, lines);
    }

    [Test]
    public async Task Packing_ExactFitStaysOneFileAndOneByteLessSplits()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            var total = lines.Sum();
            Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxFileBytes = total; }, name: "fit");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "fit")).Count).IsEqualTo(1);

            Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxFileBytes = total - 1; }, name: "split");
            var files = Jsonl.DataFiles(Jsonl.Out(db, "split"));
            await Assert.That(files.Count).IsEqualTo(2);
            await Assert.That(files[1]).IsEqualTo("dossier-0002.jsonl");
            foreach (var name in files)
            {
                await Assert.That(new FileInfo(Path.Combine(Jsonl.Out(db, "split"), name)).Length <= total - 1).IsTrue();
            }

            // No record is ever split: every line of every file parses and the record order is preserved.
            await Assert.That(Types(Jsonl.Out(db, "split")).SequenceEqual(Types(Jsonl.Out(db, "fit")))).IsTrue();
            var stats = Jsonl.Manifest(Jsonl.Out(db, "split")).GetProperty("file_stats");
            await Assert.That(stats.EnumerateObject().Sum(p => p.Value.GetProperty("lines").GetInt32())).IsEqualTo(lines.Count);
        }
    }

    [Test]
    public async Task Packing_RecordLargerThanMaxFileBytesFailsClosed()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxFileBytes = lines.Max() - 1; }, name: "big"));
            await Assert.That(exception.Code).IsEqualTo("record_exceeds_max_file_bytes");
            await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
            await Assert.That(exception.Message.Contains("--assets files", StringComparison.Ordinal)).IsTrue();
            await Assert.That(Directory.Exists(Jsonl.Out(db, "big"))).IsFalse();
        }
    }

    [Test]
    public async Task Packing_EmbeddedAssetTooLargeSuggestsFilesOrNone()
    {
        using var db = new TempDb();
        var big = Jsonl.WriteBlob(db, new string('b', 6000));
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Big" },
            Facts = { new FactInput { Kind = "note", Text = "has a big blob", Attachments = new List<AttachmentInput> { new() { Sha256 = big.Sha, Filename = "big.bin", Mime = "application/octet-stream", Bytes = big.Bytes.Length } } } },
        });
        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "embed"; o.MaxFileBytes = 3000; }));
        await Assert.That(exception.Code).IsEqualTo("record_exceeds_max_file_bytes");
        await Assert.That(exception.Message.Contains("asset " + big.Sha, StringComparison.Ordinal)).IsTrue();
        await Assert.That(exception.Message.Contains("--assets files", StringComparison.Ordinal)).IsTrue();
        await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(Jsonl.Out(db))).IsFalse();

        // files mode: the asset file is 6000 bytes, over the same limit.
        var asFile = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "files"; o.MaxFileBytes = 3000; }, name: "files"));
        await Assert.That(asFile.Code).IsEqualTo("record_exceeds_max_file_bytes");
        Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxFileBytes = 3000; }, name: "none");
    }

    [Test]
    public async Task Limits_MaxFilesCountsDataFilesAndNotTheManifest()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            // Two jsonl files + one asset file = 3 data files; manifest.json is not counted.
            var total = lines.Sum();
            Jsonl.Publish(db, o => { o.Assets = "files"; o.MaxFileBytes = total - 1; o.MaxFiles = 3; }, name: "ok");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "ok")).Count).IsEqualTo(2);

            var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "files"; o.MaxFileBytes = total - 1; o.MaxFiles = 2; }, name: "no"));
            await Assert.That(exception.Code).IsEqualTo("max_files_exceeded");
            await Assert.That(exception.Message.Contains("manifest.json", StringComparison.Ordinal)).IsTrue();
            await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
            await Assert.That(Directory.Exists(Jsonl.Out(db, "no"))).IsFalse();
        }
    }

    [Test]
    public async Task Limits_MaxTotalBytesFailsClosedAtTheExactBoundary()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            var total = lines.Sum();
            Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxTotalBytes = total; }, name: "ok");
            var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "none"; o.MaxTotalBytes = total - 1; }, name: "no"));
            await Assert.That(exception.Code).IsEqualTo("max_total_bytes_exceeded");
            await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
            await Assert.That(Directory.Exists(Jsonl.Out(db, "no"))).IsFalse();
        }
    }

    [Test]
    public async Task Limits_AssetFilesCountAgainstMaxFileBytesAndTotal()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "files"; o.MaxFileBytes = shot.Bytes.Length - 1; }));
        await Assert.That(exception.Code).IsEqualTo("record_exceeds_max_file_bytes");
        await Assert.That(exception.Message.Contains("assets/", StringComparison.Ordinal)).IsTrue();
    }

    // ---- profiles --------------------------------------------------------------------------

    [Test]
    public async Task Profile_AloneOnlyReportsAndRespectLimitsEnforces()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            var limit = lines.Sum() - 1;
            var profile = Jsonl.WriteProfile(db, $"{{\"name\":\"p\",\"max_file_bytes\":{limit},\"allowed_extensions\":[\"jsonl\"]}}");

            var report = Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; }, name: "report");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "report")).Count).IsEqualTo(1);
            await Assert.That(report.Compliance).IsNotNull();
            await Assert.That(report.Compliance!.Rows.Single(r => r.Limit == "max_file_bytes").Pass).IsFalse();
            await Assert.That(report.Compliance.Scope.Contains("manifest.json", StringComparison.Ordinal)).IsTrue();
            await Assert.That(report.Compliance.Render().Contains("format gap", StringComparison.Ordinal)).IsFalse();

            var enforced = Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; o.RespectLimits = true; }, name: "enforce");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "enforce")).Count).IsEqualTo(2);
            await Assert.That(enforced.Compliance!.Rows.Single(r => r.Limit == "max_file_bytes").Pass).IsTrue();
            await Assert.That(Jsonl.Manifest(Jsonl.Out(db, "enforce")).GetProperty("options").GetProperty("respect_limits").GetBoolean()).IsTrue();
        }
    }

    [Test]
    public async Task Profile_StricterOfFlagAndProfileWins()
    {
        var (db, lines) = PackingStore();
        using (db)
        {
            var total = lines.Sum();
            // Profile allows everything, the flag splits.
            var profile = Jsonl.WriteProfile(db, $"{{\"name\":\"p\",\"max_file_bytes\":{total * 10}}}");
            Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; o.RespectLimits = true; o.MaxFileBytes = total - 1; }, name: "flag");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "flag")).Count).IsEqualTo(2);

            // Flag allows everything, the profile splits.
            var tight = Jsonl.WriteProfile(db, $"{{\"name\":\"p\",\"max_file_bytes\":{total - 1}}}");
            Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = tight; o.RespectLimits = true; o.MaxFileBytes = total * 10; }, name: "prof");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "prof")).Count).IsEqualTo(2);

            // A profile limit is not enforced without --respect-limits even if a flag is set elsewhere.
            Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = tight; o.MaxFileBytes = total * 10; }, name: "noenforce");
            await Assert.That(Jsonl.DataFiles(Jsonl.Out(db, "noenforce")).Count).IsEqualTo(1);
        }
    }

    [Test]
    public async Task Profile_AllowedExtensionsMissIsAFailRowOrAHardErrorUnderRespectLimits()
    {
        using var db = new TempDb();
        var (shot, _, _) = Jsonl.Seed(db);
        var profile = Jsonl.WriteProfile(db, "{\"name\":\"md-only\",\"allowed_extensions\":[\"md\",\"txt\"]}");

        var report = Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; }, name: "report");
        var row = report.Compliance!.Rows.Single(r => r.Limit == "allowed_extensions");
        await Assert.That(row.Pass).IsFalse();
        await Assert.That(row.Actual.Contains("jsonl", StringComparison.Ordinal)).IsTrue();
        await Assert.That(report.Compliance.Render().Contains("format gap", StringComparison.Ordinal)).IsTrue();
        await Assert.That(report.Compliance.Render().Contains("jsonl", StringComparison.Ordinal)).IsTrue();

        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; o.RespectLimits = true; }, name: "enforce"));
        await Assert.That(exception.Code).IsEqualTo("profile_extension_not_allowed");
        await Assert.That(exception.Message.EndsWith("; nothing was written", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(Jsonl.Out(db, "enforce"))).IsFalse();

        // Asset files are checked too: jsonl allowed, png not.
        var jsonlOnly = Jsonl.WriteProfile(db, "{\"name\":\"j\",\"allowed_extensions\":[\"jsonl\"]}");
        var assets = Jsonl.Fails(() => Jsonl.Publish(db, o => { o.Assets = "files"; o.ProfilePath = jsonlOnly; o.RespectLimits = true; }, name: "assets"));
        await Assert.That(assets.Code).IsEqualTo("profile_extension_not_allowed");
        await Assert.That(assets.Message.Contains("png", StringComparison.Ordinal)).IsTrue();
        Jsonl.Publish(db, o => { o.Assets = "embed"; o.ProfilePath = jsonlOnly; o.RespectLimits = true; }, name: "embed");
        _ = shot;
    }

    [Test]
    public async Task Profile_MinFileBytesIsReportOnly()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var profile = Jsonl.WriteProfile(db, "{\"name\":\"p\",\"min_file_bytes\":100000000}");
        var result = Jsonl.Publish(db, o => { o.Assets = "none"; o.ProfilePath = profile; o.RespectLimits = true; });
        await Assert.That(result.Compliance!.Rows.Single(r => r.Limit == "min_file_bytes").Pass).IsFalse();
        await Assert.That(Jsonl.DataFiles(Jsonl.Out(db)).Count).IsEqualTo(1);
    }

    [Test]
    public async Task Profile_RespectLimitsStillRequiresAProfile()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var exception = Jsonl.Fails(() => Jsonl.Publish(db, o => o.RespectLimits = true));
        await Assert.That(exception.Code).IsEqualTo("invalid_profile");
    }

    // ---- md stays md -----------------------------------------------------------------------

    [Test]
    public async Task Markdown_IsUnchangedByTheFormatOption()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var explicitMd = new PublishOptions { Out = Jsonl.Out(db, "explicit"), Format = "md", CommandLine = "x", Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero) };
        var implicitMd = new PublishOptions { Out = Jsonl.Out(db, "implicit"), CommandLine = "x", Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero) };
        db.Store.Publish(explicitMd);
        db.Store.Publish(implicitMd);
        var a = Jsonl.ReadAll(Jsonl.Out(db, "explicit"));
        var b = Jsonl.ReadAll(Jsonl.Out(db, "implicit"));
        await Assert.That(a.Keys.SequenceEqual(b.Keys)).IsTrue();
        foreach (var (name, content) in a)
        {
            await Assert.That(content.SequenceEqual(b[name])).IsTrue();
        }

        var manifest = Jsonl.Manifest(Jsonl.Out(db, "explicit"));
        await Assert.That(manifest.GetProperty("format").GetInt32()).IsEqualTo(1);
        await Assert.That(a.Keys.Any(k => k.EndsWith(".jsonl", StringComparison.Ordinal))).IsFalse();

        // The markdown machine record is still the indented record with no jsonl-only keys.
        var factFile = a.Single(kv => kv.Key.Contains("/facts/") && Encoding.UTF8.GetString(kv.Value).Contains("pointer fact"));
        var text = Encoding.UTF8.GetString(factFile.Value);
        var record = text[(text.LastIndexOf("```json\n", StringComparison.Ordinal) + 8)..];
        await Assert.That(record.StartsWith("{\n  \"attachments\": [", StringComparison.Ordinal)).IsTrue();
        await Assert.That(record.Contains("\"bundle_key\"", StringComparison.Ordinal)).IsFalse();
        await Assert.That(record.Contains("\"content_hash\"", StringComparison.Ordinal)).IsFalse();
        await Assert.That(record.Contains("\"type\"", StringComparison.Ordinal)).IsFalse();
    }

    // ---- validation ------------------------------------------------------------------------

    [Test]
    public async Task Validation_AssetsAllowedSetDiffersPerFormat()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var jsonl = Jsonl.Fails(() => Jsonl.Publish(db, o => o.Assets = "detail"));
        await Assert.That(jsonl.Message.Contains("embed", StringComparison.Ordinal) && jsonl.Message.Contains("files", StringComparison.Ordinal) && jsonl.Message.Contains("none", StringComparison.Ordinal)).IsTrue();
        var md = Jsonl.Fails(() => db.Store.Publish(new PublishOptions { Out = Jsonl.Out(db, "md"), Format = "md", Assets = "embed" }));
        await Assert.That(md.Message.Contains("detail", StringComparison.Ordinal)).IsTrue();
        var format = Jsonl.Fails(() => Jsonl.Publish(db, o => o.Format = "xml"));
        await Assert.That(format.Code).IsEqualTo("invalid_format");
        var negative = Jsonl.Fails(() => Jsonl.Publish(db, o => o.MaxFiles = -1));
        await Assert.That(negative.Code).IsEqualTo("invalid_limit");
    }

    [Test]
    public async Task Cli_JsonlPublishWritesBundleAndPrintsSummary()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db, "cli");
        var (exit, stdout, _) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--format", "jsonl", "--max-file-bytes", "5000000");
        await Assert.That(exit).IsEqualTo(0);
        await Assert.That(stdout.Contains("\"format\":\"jsonl\"", StringComparison.Ordinal)).IsTrue();
        await Assert.That(File.Exists(Path.Combine(dir, "dossier-0001.jsonl"))).IsTrue();
        await Assert.That(Jsonl.Manifest(dir).GetProperty("options").GetProperty("max_file_bytes").GetInt64()).IsEqualTo(5000000L);

        // A markdown publish prints the summary it always did (no format field).
        var (mdExit, mdOut, _) = await Jsonl.Cli(db.DbPath, "publish", "--out", Jsonl.Out(db, "climd"));
        await Assert.That(mdExit).IsEqualTo(0);
        await Assert.That(mdOut.Contains("\"format\"", StringComparison.Ordinal)).IsFalse();
    }

    [Test]
    public async Task Cli_RejectsMarkdownOnlyFlagsWithJsonlEvenAtDefaultValues()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        foreach (var (flag, value) in new[] { ("--budget", "4000"), ("--budget-mode", "complete"), ("--depth", "full"), ("--facts", "detail"), ("--index-max-tokens", "6000") })
        {
            var (exit, stdout, stderr) = await Jsonl.Cli(db.DbPath, "publish", "--out", Jsonl.Out(db, "cli"), "--format", "jsonl", flag, value);
            await Assert.That(exit).IsEqualTo(1);
            await Assert.That(stderr.Contains(flag, StringComparison.Ordinal) && stderr.Contains("markdown", StringComparison.Ordinal)).IsTrue();
            await Assert.That(stdout).IsEqualTo(string.Empty);
            await Assert.That(Directory.Exists(Jsonl.Out(db, "cli"))).IsFalse();
        }
    }

    [Test]
    public async Task Cli_ValidatesAssetsFormatAndLimitFlags()
    {
        using var db = new TempDb();
        Jsonl.Seed(db);
        var dir = Jsonl.Out(db, "cli");
        var (e1, _, err1) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--format", "jsonl", "--assets", "detail");
        await Assert.That(e1).IsEqualTo(1);
        await Assert.That(err1.Contains("embed|files|none", StringComparison.Ordinal)).IsTrue();
        var (e2, _, err2) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--assets", "embed");
        await Assert.That(e2).IsEqualTo(1);
        await Assert.That(err2.Contains("detail|none", StringComparison.Ordinal)).IsTrue();
        var (e3, _, err3) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--format", "yaml");
        await Assert.That(e3).IsEqualTo(1);
        await Assert.That(err3.Contains("md|jsonl", StringComparison.Ordinal)).IsTrue();
        var (e4, _, err4) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--format", "jsonl", "--max-file-bytes", "10K");
        await Assert.That(e4).IsEqualTo(1);
        await Assert.That(err4.Contains("--max-file-bytes", StringComparison.Ordinal)).IsTrue();
        var (e5, _, err5) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--max-files", "3");
        await Assert.That(e5).IsEqualTo(1);
        await Assert.That(err5.Contains("--format jsonl", StringComparison.Ordinal)).IsTrue();
        var (e6, _, err6) = await Jsonl.Cli(db.DbPath, "publish", "--out", dir, "--format", "jsonl", "--max-total-bytes", "-5");
        await Assert.That(e6).IsEqualTo(1);
        await Assert.That(err6.Contains("--max-total-bytes", StringComparison.Ordinal)).IsTrue();
        await Assert.That(Directory.Exists(dir)).IsFalse();
    }
}
