using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class JsonlImportTests
{
    private static string Sha(byte[] bytes) => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();

    private static List<string> FactRows(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, subject_id, kind, key, text, data, items, tags, confidence, status, provenance, content_hash FROM facts ORDER BY id";
        using var reader = command.ExecuteReader();
        var rows = new List<string>();
        while (reader.Read())
        {
            rows.Add(string.Join("|", Enumerable.Range(0, reader.FieldCount).Select(i => reader.IsDBNull(i) ? "~" : Convert.ToString(reader.GetValue(i), System.Globalization.CultureInfo.InvariantCulture))));
        }

        return rows;
    }

    private static List<string> RefRows(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT fact_id, seq, rel, kind, target, basis, confidence, rev, locator, snapshot, snapshot_hash, etag, verified_at, valid FROM refs ORDER BY fact_id, seq";
        using var reader = command.ExecuteReader();
        var rows = new List<string>();
        while (reader.Read())
        {
            rows.Add(string.Join("|", Enumerable.Range(0, reader.FieldCount).Select(i => reader.IsDBNull(i) ? "~" : Convert.ToString(reader.GetValue(i), System.Globalization.CultureInfo.InvariantCulture))));
        }

        return rows;
    }

    private static List<string> SubjectRows(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, name, kind, parent_id, aliases, pin FROM subjects ORDER BY id";
        using var reader = command.ExecuteReader();
        var rows = new List<string>();
        while (reader.Read())
        {
            rows.Add(string.Join("|", Enumerable.Range(0, reader.FieldCount).Select(i => reader.IsDBNull(i) ? "~" : reader.GetString(i))));
        }

        return rows;
    }

    private static string SourceId(TempDb db, string name)
    {
        using var connection = db.Store.OpenConnection();
        return (string)Fixtures.Scalar(connection, "SELECT id FROM subjects WHERE name = $n", ("$n", name))!;
    }

    /// <summary>Rewrites dossier-0001.jsonl and keeps manifest file_stats consistent, so only the tampered content differs.</summary>
    private static void Tamper(string dir, Func<string, string> transform, bool refreshStats = true)
    {
        var path = Path.Combine(dir, "dossier-0001.jsonl");
        var text = transform(File.ReadAllText(path, Jsonl.Utf8));
        File.WriteAllText(path, text, Jsonl.Utf8);
        if (!refreshStats)
        {
            return;
        }

        var bytes = Jsonl.Utf8.GetBytes(text);
        var manifestPath = Path.Combine(dir, "manifest.json");
        var manifest = JsonNode.Parse(File.ReadAllText(manifestPath))!;
        var stat = manifest["file_stats"]!["dossier-0001.jsonl"]!;
        stat["bytes"] = bytes.LongLength;
        stat["lines"] = text.Count(c => c == '\n');
        stat["sha256"] = Sha(bytes);
        File.WriteAllText(manifestPath, manifest.ToJsonString(), Jsonl.Utf8);
    }

    private static void EditManifest(string dir, Action<JsonNode> edit)
    {
        var manifestPath = Path.Combine(dir, "manifest.json");
        var manifest = JsonNode.Parse(File.ReadAllText(manifestPath))!;
        edit(manifest);
        File.WriteAllText(manifestPath, manifest.ToJsonString(), Jsonl.Utf8);
    }

    private static string Line(string dir, string type, int index = 0) =>
        File.ReadAllText(Path.Combine(dir, "dossier-0001.jsonl"), Jsonl.Utf8).Split('\n').SkipLast(1).Where(l => l.Contains($"\"type\":\"{type}\"")).ElementAt(index);

    // ---- round trip ------------------------------------------------------------------------

    [Test]
    [Arguments("embed")]
    [Arguments("files")]
    [Arguments("none")]
    public async Task RoundTrip_RestoresFactsRefsSubjectsAndCompileSearchOutput(string mode)
    {
        using var a = new TempDb();
        var (shot, appId, screenId) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = mode);
        var bundle = Jsonl.Out(a);

        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = bundle });

        // Exported facts only: the superseded fact is not in the bundle, so it is not restored.
        var live = FactRows(a.Store).Where(r => !r.Split('|')[9].Equals("superseded")).ToList();
        await Assert.That(FactRows(b.Store).SequenceEqual(live)).IsTrue();
        var liveIds = live.Select(r => r.Split('|')[0]).ToHashSet();
        await Assert.That(RefRows(b.Store).SequenceEqual(RefRows(a.Store).Where(r => liveIds.Contains(r.Split('|')[0])))).IsTrue();
        await Assert.That(SubjectRows(b.Store).SequenceEqual(SubjectRows(a.Store))).IsTrue();
        await Assert.That(result.Facts).IsEqualTo(live.Count);
        await Assert.That(result.Subjects).IsEqualTo(2);
        await Assert.That(result.Refs).IsEqualTo(4);
        await Assert.That(result.Attachments).IsEqualTo(1);

        // Compile and search output match for the exported facts.
        foreach (var id in new[] { appId, screenId })
        {
            var request = new CompileRequest { Subject = id, Format = "markdown" };
            await Assert.That(DossierStore.RenderMarkdown(b.Store.Compile(request))).IsEqualTo(DossierStore.RenderMarkdown(a.Store.Compile(request)));
        }

        var search = new SearchRequest { Q = "pixels" };
        // created_at is the store's insertion clock (import uses the recorded posted_at, as markdown import does) and score is bm25 over the
        // whole FTS corpus (the source also indexes the superseded fact, which is not exported), so both are projected out.
        static string NoClock(string json) => Regex.Replace(json, "\"(created_at\":\"[^\"]*\"|score\":[-0-9.eE]+),?", string.Empty);
        await Assert.That(NoClock(Ops.Search(b.Store, search))).IsEqualTo(NoClock(Ops.Search(a.Store, search)));
        await Assert.That(Ops.Search(b.Store, search).Contains("pixels", StringComparison.Ordinal)).IsTrue();

        // Re-publishing the imported store reproduces the data file byte for byte.
        Jsonl.Publish(b, o => o.Assets = mode, name: "again");
        await Assert.That(File.ReadAllBytes(Path.Combine(Jsonl.Out(b, "again"), "dossier-0001.jsonl")).SequenceEqual(File.ReadAllBytes(Path.Combine(bundle, "dossier-0001.jsonl")))).IsTrue();

        var blob = Path.Combine(b.Store.BlobRoot, shot.Sha);
        if (mode == "none")
        {
            await Assert.That(File.Exists(blob)).IsFalse();
            await Assert.That(result.Skipped.Count).IsEqualTo(1);
            await Assert.That(result.Skipped[0].Reason.Contains("absent", StringComparison.Ordinal)).IsTrue();
            await Assert.That(result.Blobs).IsEqualTo(0);
        }
        else
        {
            await Assert.That(File.ReadAllBytes(blob).SequenceEqual(shot.Bytes)).IsTrue();
            await Assert.That(result.Skipped.Count).IsEqualTo(0);
            await Assert.That(result.Blobs).IsEqualTo(1);
        }
    }

    [Test]
    public async Task RoundTrip_MarkdownRepublishOfImportedStoreMatches()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        using var b = new TempDb();
        b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });

        string Md(TempDb db, string name)
        {
            db.Store.Publish(new PublishOptions { Out = Jsonl.Out(db, name), CommandLine = "x", Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero) });
            return Jsonl.Out(db, name);
        }

        var fromA = Jsonl.ReadAll(Md(a, "md"));
        var fromB = Jsonl.ReadAll(Md(b, "md"));
        // Superseded history is not exported, so compare what is published for both.
        await Assert.That(fromA.Keys.SequenceEqual(fromB.Keys)).IsTrue();
        foreach (var (name, content) in fromA.Where(kv => kv.Key.Contains("/facts/") || kv.Key.EndsWith("index.md", StringComparison.Ordinal)))
        {
            await Assert.That(Encoding.UTF8.GetString(content)).IsEqualTo(Encoding.UTF8.GetString(fromB[name]));
        }
    }

    [Test]
    public async Task RoundTrip_SubjectScopeWithOutsideParentImports()
    {
        using var a = new TempDb();
        var (_, _, screenId) = Jsonl.Seed(a);
        Jsonl.Publish(a, o =>
        {
            o.Assets = "embed";
            o.Subject = "Home Screen";
        });
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });
        await Assert.That(result.Subjects).IsEqualTo(1);
        using var connection = b.Store.OpenConnection();
        await Assert.That(Fixtures.Scalar(connection, "SELECT parent_id FROM subjects WHERE id = $i", ("$i", screenId))).IsEqualTo(DBNull.Value);
    }

    [Test]
    public async Task RoundTrip_MultiFileBundleImportsInOrder()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => { o.Assets = "embed"; o.MaxFileBytes = 1400; });
        await Assert.That(Jsonl.DataFiles(Jsonl.Out(a)).Count).IsGreaterThan(2);
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });
        await Assert.That(result.Facts).IsEqualTo(4);
        await Assert.That(result.Blobs).IsEqualTo(1);
    }

    [Test]
    public async Task Import_UnicodeSeparatorsSurvive()
    {
        using var a = new TempDb();
        a.Store.PostFacts(Fixtures.Post("Seps", Fixtures.Fact("a\u2028b\u2029c\u0085d end")));
        Jsonl.Publish(a, o => o.Assets = "none");
        using var b = new TempDb();
        b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });
        await Assert.That(FactRows(b.Store).SequenceEqual(FactRows(a.Store))).IsTrue();
    }

    // ---- fail closed on the manifest and the file set --------------------------------------

    [Test]
    public async Task Reject_UnlistedDataFile()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        File.Copy(Path.Combine(dir, "dossier-0001.jsonl"), Path.Combine(dir, "dossier-0002.jsonl"));
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(exception.Code).IsEqualTo("import_unlisted_file");
        await Assert.That(exception.Message.Contains("dossier-0002.jsonl", StringComparison.Ordinal)).IsTrue();
        await Assert.That(FactRows(b.Store).Count).IsEqualTo(0);
    }

    [Test]
    public async Task Reject_ListedFileMissingOrWithoutStats()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        using var b = new TempDb();

        EditManifest(dir, m => m["file_stats"]!.AsObject().Remove("dossier-0001.jsonl"));
        var noStats = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(noStats.Code).IsEqualTo("import_file_mismatch");

        Jsonl.Publish(a, o => o.Assets = "none");
        File.Delete(Path.Combine(dir, "dossier-0001.jsonl"));
        var missing = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(missing.Code).IsEqualTo("import_file_missing");
    }

    [Test]
    public async Task Reject_StatsMismatchOnSameLengthEditAndOnTruncation()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        using var b = new TempDb();

        // Same length, different content: the sha256 catches it.
        Tamper(dir, t => t.Replace("notes tool", "notes tooL"), refreshStats: false);
        var sha = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(sha.Code).IsEqualTo("import_file_mismatch");
        await Assert.That(sha.Message.Contains("sha256", StringComparison.Ordinal)).IsTrue();

        // Truncated: the byte count catches it.
        Jsonl.Publish(a, o => o.Assets = "none");
        var path = Path.Combine(dir, "dossier-0001.jsonl");
        File.WriteAllBytes(path, File.ReadAllBytes(path)[..^10]);
        var truncated = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(truncated.Code).IsEqualTo("import_file_mismatch");
        await Assert.That(FactRows(b.Store).Count).IsEqualTo(0);
    }

    [Test]
    public async Task Reject_LineWithoutTerminatingNewlineEvenWhenStatsMatch()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        Tamper(dir, t => t.TrimEnd('\n'));
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(exception.Code).IsEqualTo("import_file_mismatch");
    }

    [Test]
    public async Task Reject_UnknownFormatAndUnknownListedFiles()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        using var b = new TempDb();

        EditManifest(dir, m => m["format"] = "dossier-jsonl/99");
        var format = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(format.Code).IsEqualTo("unsupported_bundle_format");

        Jsonl.Publish(a, o => o.Assets = "none");
        EditManifest(dir, m => m["files"]!.AsArray().Add("../../etc/hosts"));
        var listed = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(listed.Code).IsEqualTo("import_unlisted_file");
    }

    [Test]
    public async Task Reject_SymlinkedDataFile()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        var real = Path.Combine(a.Directory, "real.jsonl");
        File.Move(Path.Combine(dir, "dossier-0001.jsonl"), real);
        File.CreateSymbolicLink(Path.Combine(dir, "dossier-0001.jsonl"), real);
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(exception.Code).IsEqualTo("import_unsafe_path");
        await Assert.That(FactRows(b.Store).Count).IsEqualTo(0);
    }

    [Test]
    public async Task Reject_OversizeLine()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        using var b = new TempDb();
        var exception = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = Jsonl.Out(a), MaxLineBytes = 300 }));
        await Assert.That(exception.Code).IsEqualTo("import_line_too_long");
        await Assert.That(exception.Message.Contains("dossier-0001.jsonl:", StringComparison.Ordinal)).IsTrue();
        await Assert.That(FactRows(b.Store).Count).IsEqualTo(0);
    }

    [Test]
    public async Task Reject_InvalidJsonLineAndDuplicateFactIds()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        using var b = new TempDb();

        var first = Line(dir, "fact");
        Tamper(dir, t => t + "{not json\n");
        var bad = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(bad.Code).IsEqualTo("import_bad_record");
        await Assert.That(bad.Message.Contains("dossier-0001.jsonl:", StringComparison.Ordinal)).IsTrue();

        Jsonl.Publish(a, o => o.Assets = "none");
        Tamper(dir, t => t + first + "\n");
        var dup = Jsonl.Fails(() => b.Store.Import(new ImportOptions { From = dir }));
        await Assert.That(dup.Code).IsEqualTo("import_duplicate_id");
        await Assert.That(FactRows(b.Store).Count).IsEqualTo(0);
    }

    [Test]
    public async Task Import_UnknownRecordTypeIsSkippedWithAReason()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        Tamper(dir, t => t + "{\"type\":\"future\",\"x\":1}\n");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(result.Facts).IsEqualTo(4);
        await Assert.That(result.Skipped.Any(s => s.Reason.Contains("future", StringComparison.Ordinal) && s.Path.StartsWith("dossier-0001.jsonl:", StringComparison.Ordinal))).IsTrue();
    }

    [Test]
    public async Task Import_FactWithoutRequiredFieldsIsSkipped()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "none");
        var dir = Jsonl.Out(a);
        Tamper(dir, t => t + "{\"type\":\"fact\",\"id\":\"only-an-id\"}\n");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(result.Facts).IsEqualTo(4);
        await Assert.That(result.Skipped.Count(s => s.Reason.Contains("lacks", StringComparison.Ordinal))).IsEqualTo(1);
    }

    // ---- asset hardening -------------------------------------------------------------------

    [Test]
    public async Task Asset_PathTraversalIsNeverReadEvenWhenTheTargetHashesCorrectly()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        // A file outside the bundle whose bytes match the declared sha256: reading it would succeed.
        File.WriteAllBytes(Path.Combine(a.Directory, "outside.png"), shot.Bytes);
        Tamper(dir, t => t.Replace($"\"path\":\"assets/{shot.Sha}.png\"", "\"path\":\"../outside.png\""));
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Count).IsEqualTo(1);
        await Assert.That(result.Skipped[0].Reason.Contains("path", StringComparison.Ordinal)).IsTrue();
        await Assert.That(result.Blobs).IsEqualTo(0);
    }

    [Test]
    public async Task Asset_PathMustMatchTheGeneratedPatternExactly()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        // Another file inside the bundle that hashes correctly but is not the generated name.
        File.WriteAllBytes(Path.Combine(dir, "other.png"), shot.Bytes);
        Tamper(dir, t => t.Replace($"\"path\":\"assets/{shot.Sha}.png\"", "\"path\":\"other.png\""));
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Count).IsEqualTo(1);

        // A path naming another blob's hash is not this asset's path either.
        Jsonl.Publish(a, o => o.Assets = "files");
        var other = new string('a', 64);
        File.WriteAllBytes(Path.Combine(dir, "assets", other + ".png"), shot.Bytes);
        Tamper(dir, t => t.Replace($"\"path\":\"assets/{shot.Sha}.png\"", $"\"path\":\"assets/{other}.png\""));
        EditManifest(dir, m => m["files"]!.AsArray().Add($"assets/{other}.png"));
        using var c = new TempDb();
        var swapped = c.Store.Import(new ImportOptions { From = dir });
        await Assert.That(swapped.Skipped.Count).IsEqualTo(1);
        await Assert.That(File.Exists(Path.Combine(c.Store.BlobRoot, shot.Sha))).IsFalse();
    }

    [Test]
    public async Task Asset_SymlinkedAssetFileIsRejected()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        var assetPath = Path.Combine(dir, "assets", shot.Sha + ".png");
        var real = Path.Combine(a.Directory, "real.png");
        File.Move(assetPath, real);
        File.CreateSymbolicLink(assetPath, real);
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Count).IsEqualTo(1);
        await Assert.That(result.Skipped[0].Reason.Contains("symbolic link", StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    public async Task Asset_FilesModeHashMismatchIsSkipped()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "files");
        var dir = Jsonl.Out(a);
        File.WriteAllText(Path.Combine(dir, "assets", shot.Sha + ".png"), "tampered");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Single().Reason.Contains("sha256", StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    public async Task Asset_EmbeddedShaMismatchIsSkippedLikeMarkdown()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);
        var good = Convert.ToBase64String(shot.Bytes);
        var other = Convert.ToBase64String(Jsonl.Utf8.GetBytes(new string('z', shot.Bytes.Length)));
        await Assert.That(other.Length).IsEqualTo(good.Length);
        Tamper(dir, t => t.Replace(good, other));
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = dir });
        await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
        await Assert.That(result.Skipped.Single().Reason.Contains("sha256", StringComparison.Ordinal)).IsTrue();
        await Assert.That(result.Facts).IsEqualTo(4);
    }

    [Test]
    public async Task Asset_BadBase64LengthEncodingAndOversizeDeclarationAreSkipped()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);
        var good = Convert.ToBase64String(shot.Bytes);
        var original = File.ReadAllText(Path.Combine(dir, "dossier-0001.jsonl"), Jsonl.Utf8);
        var manifest = File.ReadAllText(Path.Combine(dir, "manifest.json"));

        async Task Case(string label, Func<string, string> edit, string reasonPart)
        {
            File.WriteAllText(Path.Combine(dir, "dossier-0001.jsonl"), original, Jsonl.Utf8);
            File.WriteAllText(Path.Combine(dir, "manifest.json"), manifest);
            Tamper(dir, edit);
            using var b = new TempDb();
            var result = b.Store.Import(new ImportOptions { From = dir });
            await Assert.That(File.Exists(Path.Combine(b.Store.BlobRoot, shot.Sha))).IsFalse();
            var reason = result.Skipped.Single().Reason;
            if (!reason.Contains(reasonPart, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException($"{label}: expected reason containing '{reasonPart}', got '{reason}'");
            }
        }

        await Case("truncated data", t => t.Replace(good, good[..^4]), "length");
        await Case("padded data", t => t.Replace(good, good + "AAAA"), "length");
        await Case("wrong encoding", t => t.Replace("\"encoding\":\"base64\"", "\"encoding\":\"hex\""), "encoding");
        await Case("not base64", t => t.Replace(good, new string('!', good.Length)), "base64");
        await Case("oversize declaration", t => t.Replace($"\"bytes\":{shot.Bytes.Length},\"data\"", $"\"bytes\":{DossierStore.MaxEmbedAssetBytes + 1},\"data\""), "limit");
    }

    [Test]
    public async Task Asset_NonHexShaIsNeverUsedAsABlobName()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        Jsonl.Publish(a, o => o.Assets = "embed");
        var dir = Jsonl.Out(a);
        var evil = "../../evil";
        var tampered = new TempDb();
        using (tampered)
        {
            Tamper(dir, t => t.Replace(shot.Sha, evil));
            var result = tampered.Store.Import(new ImportOptions { From = dir });
            await Assert.That(Directory.Exists(tampered.Store.BlobRoot) && Directory.EnumerateFileSystemEntries(tampered.Store.BlobRoot).Any()).IsFalse();
            await Assert.That(File.Exists(Path.Combine(tampered.Directory, "evil"))).IsFalse();
            await Assert.That(result.Skipped.Count).IsGreaterThan(0);
        }
    }

    [Test]
    public async Task Asset_MissingAtPublishIsSkippedWithAReason()
    {
        using var a = new TempDb();
        var (shot, _, _) = Jsonl.Seed(a);
        File.Delete(Path.Combine(a.Store.BlobRoot, shot.Sha));
        Jsonl.Publish(a, o => o.Assets = "embed");
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Jsonl.Out(a) });
        await Assert.That(result.Facts).IsEqualTo(4);
        await Assert.That(result.Skipped.Single().Reason.Contains("missing", StringComparison.Ordinal)).IsTrue();
        await Assert.That(result.Attachments).IsEqualTo(1);
    }

    [Test]
    public async Task Import_ExistingMarkdownBundleStillImports()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        a.Store.Publish(new PublishOptions { Out = Jsonl.Out(a, "md"), CommandLine = "x" });
        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Jsonl.Out(a, "md") });
        await Assert.That(result.Facts).IsEqualTo(4);
    }

    [Test]
    public async Task Cli_ImportReadsAJsonlBundle()
    {
        using var a = new TempDb();
        Jsonl.Seed(a);
        var (pubExit, _, _) = await Jsonl.Cli(a.DbPath, "publish", "--out", Jsonl.Out(a, "cli"), "--format", "jsonl", "--assets", "embed");
        await Assert.That(pubExit).IsEqualTo(0);
        using var b = new TempDb();
        var (exit, stdout, stderr) = await Jsonl.Cli(b.DbPath, "import", "--from", Jsonl.Out(a, "cli"));
        await Assert.That(exit).IsEqualTo(0);
        await Assert.That(Regex.IsMatch(stdout, "\"facts\":4")).IsTrue();
        _ = stderr;
    }
}
