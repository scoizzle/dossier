using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class ImportTests
{
    private const string CommandLine = "dossier publish --out bundle";

    private sealed record Shot(string Sha, byte[] Bytes);

    private static Shot WriteBlob(TempDb db, string content)
    {
        var bytes = Encoding.UTF8.GetBytes(content);
        var sha = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
        Directory.CreateDirectory(db.Store.BlobRoot);
        File.WriteAllBytes(Path.Combine(db.Store.BlobRoot, sha), bytes);
        return new Shot(sha, bytes);
    }

    private static void PublishTo(TempDb db, string name, Action<PublishOptions>? tweak = null)
    {
        var options = new PublishOptions
        {
            Out = Path.Combine(db.Directory, name),
            CommandLine = CommandLine,
            Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero),
        };
        tweak?.Invoke(options);
        db.Store.Publish(options);
    }

    /// <summary>A store with hierarchy, aliases, a pin, every ref kind, data, items, tags, a keyed slot, a superseded fact and an attachment.</summary>
    private static Shot Seed(TempDb db)
    {
        var shot = WriteBlob(db, "screenshot bytes for the round trip");
        var app = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "My App", Kind = "app", Aliases = new List<string> { "the app", "myapp" } },
            Facts = { Fixtures.Fact("The app is a notes tool.", tags: new List<string> { "overview", "notes" }) },
        });
        var appId = app.Response.Subject.Id;
        using (var connection = db.Store.OpenConnection())
        {
            using var pin = connection.CreateCommand();
            pin.CommandText = "UPDATE subjects SET pin = '{\"repo\":\"https://example.test/app.git\",\"rev\":\"abc123\"}' WHERE id = $id";
            pin.Parameters.AddWithValue("$id", appId);
            pin.ExecuteNonQuery();
        }

        // First post of "header-a" is superseded by the second; only the second is published.
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Home Screen", Kind = "screen", Parent = appId },
            Facts = { Fixtures.Fact("The header is 60 pixels tall.", key: "header-a") },
        });

        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Home Screen", Kind = "screen", Parent = appId },
            Facts =
            {
                Fixtures.Fact("The header is 64 pixels tall.", key: "header-a", data: Fixtures.Json("{\"headerHeight\":64,\"theme\":{\"b\":1.50,\"a\":[1,2]}}")),
                Fixtures.Fact("The target fact.", localId: "t", tags: new List<string> { "target" }),
                new FactInput
                {
                    Kind = "behavior",
                    Text = "The pointer fact, with `backticks` and ``` a fence.",
                    Confidence = 0.8,
                    Items = new List<ItemInput> { new() { Key = "one", Text = "first item", Locator = Fixtures.Json("{\"line\":3}") } },
                    Refs = new List<RefInput>
                    {
                        new() { Rel = "supports", Kind = "fact", Target = "@t", Basis = "observed", Confidence = 0.9, Rev = "abc123", Snapshot = "snap", SnapshotHash = "deadbeef", Etag = "W/1", VerifiedAt = "2026-01-01T00:00:00Z", Valid = true },
                        new() { Rel = "defines", Kind = "slot", Target = "Home Screen#header-a", Basis = "derived" },
                        new() { Rel = "about", Kind = "subject", Target = "My App", Basis = "inferred", Confidence = 0.4 },
                        new() { Rel = "see", Kind = "url", Target = "https://example.test/spec?a=1", Basis = "observed", Locator = Fixtures.Json("{\"anchor\":\"x\",\"line\":9}") },
                    },
                    Attachments = new List<AttachmentInput>
                    {
                        new() { Sha256 = shot.Sha, Filename = "shots/Home Screen.PNG", Mime = "image/png", Bytes = shot.Bytes.Length, Perceptual = Fixtures.Json("{\"algo\":\"phash\",\"value\":\"ff00\"}") },
                    },
                },
            },
        });
        return shot;
    }

    private sealed record Row(string Id, string SubjectId, string Kind, string? Key, string Text, string Status);

    private static List<Row> Facts(DossierStore store)
    {
        using var connection = store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, subject_id, kind, key, text, status FROM facts ORDER BY id";
        using var reader = command.ExecuteReader();
        var rows = new List<Row>();
        while (reader.Read())
        {
            rows.Add(new Row(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.IsDBNull(3) ? null : reader.GetString(3), reader.GetString(4), reader.GetString(5)));
        }

        return rows;
    }

    private static List<string> Refs(DossierStore store)
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

    private static Dictionary<string, byte[]> ReadAll(string dir) =>
        Directory.EnumerateFiles(dir, "*", SearchOption.AllDirectories)
            .ToDictionary(p => Path.GetRelativePath(dir, p).Replace('\\', '/'), File.ReadAllBytes, StringComparer.Ordinal);

    private static string StripGeneratedAt(byte[] readme) =>
        Regex.Replace(Encoding.UTF8.GetString(readme), "(?m)^- Generated at: `[^`]*`$", "- Generated at: `X`");

    private static DossierRequestException Fails(Action action)
    {
        try
        {
            action();
        }
        catch (DossierRequestException exception)
        {
            return exception;
        }

        throw new InvalidOperationException("expected the import to fail with a DossierRequestException");
    }

    [Test]
    public async Task Import_RestoresIdsTextsAndRefs()
    {
        using var a = new TempDb();
        Seed(a);
        PublishTo(a, "bundle");

        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = Path.Combine(a.Directory, "bundle") });

        var source = Facts(a.Store).Where(f => f.Status is not ("superseded" or "retracted")).ToList();
        var restored = Facts(b.Store);
        await Assert.That(restored.Count).IsEqualTo(source.Count);
        await Assert.That(restored.SequenceEqual(source)).IsTrue();
        await Assert.That(result.Facts).IsEqualTo(source.Count);
        await Assert.That(result.Skipped.Count).IsEqualTo(0);

        // Refs of the published facts (rel, kind, target, basis, confidence, rev, locator and freshness metadata).
        var liveIds = source.Select(f => f.Id).ToHashSet();
        var expectedRefs = Refs(a.Store).Where(r => liveIds.Contains(r.Split('|')[0])).ToList();
        await Assert.That(expectedRefs.Count).IsEqualTo(4);
        await Assert.That(Refs(b.Store).SequenceEqual(expectedRefs)).IsTrue();
        await Assert.That(result.Refs).IsEqualTo(4);

        // The fact ref keeps the original fact id, not the bundle key.
        var pointer = source.Single(f => f.Kind == "behavior");
        var target = source.Single(f => f.Text == "The target fact.");
        await Assert.That(Refs(b.Store).Any(r => r.StartsWith(pointer.Id + "|0|supports|fact|" + target.Id + "|"))).IsTrue();

        // Subjects: hierarchy, aliases and pin.
        using var connection = b.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects")).IsEqualTo(2L);
        await Assert.That(Fixtures.Scalar(connection, "SELECT aliases FROM subjects WHERE name = 'My App'") as string).IsEqualTo("[\"the app\",\"myapp\"]");
        await Assert.That(Fixtures.Scalar(connection, "SELECT kind FROM subjects WHERE name = 'My App'") as string).IsEqualTo("app");
        var appId = (string)Fixtures.Scalar(connection, "SELECT id FROM subjects WHERE name = 'My App'")!;
        await Assert.That(Fixtures.Scalar(connection, "SELECT parent_id FROM subjects WHERE name = 'Home Screen'") as string).IsEqualTo(appId);
        await Assert.That((Fixtures.Scalar(connection, "SELECT pin FROM subjects WHERE name = 'My App'") as string)!.Contains("abc123")).IsTrue();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM slots")).IsEqualTo(1L);
    }

    [Test]
    public async Task Import_RestoresAttachments()
    {
        using var a = new TempDb();
        var shot = Seed(a);
        PublishTo(a, "bundle");

        using var b = new TempDb();
        Directory.CreateDirectory(b.Store.BlobRoot);
        var result = b.Store.Import(new ImportOptions { From = Path.Combine(a.Directory, "bundle") });

        var blob = Path.Combine(b.Store.BlobRoot, shot.Sha);
        await Assert.That(File.Exists(blob)).IsTrue();
        var bytes = File.ReadAllBytes(blob);
        await Assert.That(Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()).IsEqualTo(shot.Sha);
        await Assert.That(bytes.Length).IsEqualTo(shot.Bytes.Length);
        await Assert.That(result.Attachments).IsEqualTo(1);
        await Assert.That(result.Blobs).IsEqualTo(1);

        using var connection = b.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM attachments WHERE sha256 = $s AND bytes = $n AND filename = 'shots/Home Screen.PNG' AND mime = 'image/png' AND perceptual = '{\"algo\":\"phash\",\"value\":\"ff00\"}'", ("$s", shot.Sha), ("$n", (long)shot.Bytes.Length))).IsEqualTo(1L);
    }

    [Test]
    public async Task RoundTrip_PublishImportPublishIsIdentical()
    {
        using var a = new TempDb();
        Seed(a);
        PublishTo(a, "bundle");

        using var b = new TempDb();
        b.Store.Import(new ImportOptions { From = Path.Combine(a.Directory, "bundle") });
        PublishTo(b, "bundle");

        var first = ReadAll(Path.Combine(a.Directory, "bundle"));
        var second = ReadAll(Path.Combine(b.Directory, "bundle"));
        await Assert.That(second.Keys.OrderBy(k => k, StringComparer.Ordinal).SequenceEqual(first.Keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        await Assert.That(first.Count > 10).IsTrue();
        foreach (var (path, bytes) in first)
        {
            if (path == "README.md")
            {
                await Assert.That(StripGeneratedAt(second[path])).IsEqualTo(StripGeneratedAt(bytes));
            }
            else
            {
                await Assert.That(second[path].SequenceEqual(bytes)).IsTrue();
            }
        }
    }

    [Test]
    public async Task Import_FailsClosedOnDuplicateLiveSlot()
    {
        using var a = new TempDb();
        a.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Slots" },
            Facts = { Fixtures.Fact("Width is 10.", key: "width"), Fixtures.Fact("Other fact.") },
        });
        PublishTo(a, "bundle");

        // Forge a second live claim on the same slot by copying the fact file with a new id.
        var bundle = Path.Combine(a.Directory, "bundle");
        var original = Directory.EnumerateFiles(bundle, "*.md", SearchOption.AllDirectories).Single(p => File.ReadAllText(p).Contains("\"key\": \"width\""));
        var originalId = Regex.Match(File.ReadAllText(original), "\"id\": \"([^\"]+)\"").Groups[1].Value;
        var copyId = "00000000-0000-0000-0000-000000000001";
        File.WriteAllText(Path.Combine(Path.GetDirectoryName(original)!, "forged-0000.md"), File.ReadAllText(original).Replace(originalId, copyId));

        using var b = new TempDb();
        var ex = Fails(() => b.Store.Import(new ImportOptions { From = bundle }));
        await Assert.That(ex.Message.Contains(originalId)).IsTrue();
        await Assert.That(ex.Message.Contains(copyId)).IsTrue();
        await Assert.That(ex.Code).IsEqualTo("import_slot_conflict");

        using var connection = b.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts")).IsEqualTo(0L);
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects")).IsEqualTo(0L);
    }

    [Test]
    public async Task Import_RejectsBundleWithoutFactFiles()
    {
        using var a = new TempDb();
        Seed(a);
        PublishTo(a, "bundle", o => o.Facts = "none");

        using var b = new TempDb();
        var ex = Fails(() => b.Store.Import(new ImportOptions { From = Path.Combine(a.Directory, "bundle") }));
        await Assert.That(ex.Code).IsEqualTo("bundle_has_no_facts");
        await Assert.That(ex.Message.Contains("--facts detail")).IsTrue();
        using var connection = b.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects")).IsEqualTo(0L);
    }

    [Test]
    public async Task Import_SkipsFactFileWithoutMachineRecordAndSaysWhy()
    {
        using var a = new TempDb();
        Seed(a);
        PublishTo(a, "bundle");
        var bundle = Path.Combine(a.Directory, "bundle");
        var victim = Directory.EnumerateFiles(bundle, "*.md", SearchOption.AllDirectories)
            .Where(p => BundlePaths.ToBundle(p).Contains("/facts/", StringComparison.Ordinal) && File.ReadAllText(p).Contains("The target fact."))
            .Single();
        var content = File.ReadAllText(victim);
        File.WriteAllText(victim, content[..content.LastIndexOf("\n## Machine record", StringComparison.Ordinal)] + "\n");

        using var b = new TempDb();
        var result = b.Store.Import(new ImportOptions { From = bundle });

        await Assert.That(result.Skipped.Count).IsEqualTo(1);
        await Assert.That(result.Skipped[0].Path).IsEqualTo(Path.GetRelativePath(bundle, victim).Replace('\\', '/'));
        await Assert.That(result.Skipped[0].Reason.Contains("Machine record")).IsTrue();
        await Assert.That(result.Facts).IsEqualTo(Facts(a.Store).Count(f => f.Status == "live") - 1);
    }
}
