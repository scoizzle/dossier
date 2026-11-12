using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// The demo seed is the first thing a new checkout runs, so the database it leaves behind must be
/// publishable without a "missing blob" warning: scripts/seed.sh stores the attachment blobs that
/// scripts/seed/memos.json declares.
/// </summary>
public sealed class SeedTests
{
    [Test]
    public async Task SeedScriptStoresTheDeclaredAttachmentBlob()
    {
        var declared = DeclaredAttachment();

        var shot = RepoFilePath(declared.Filename);
        var bytes = File.ReadAllBytes(shot);
        await Assert.That(Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()).IsEqualTo(declared.Sha256);
        await Assert.That((long)bytes.Length).IsEqualTo(declared.Bytes);

        var seed = File.ReadAllText(RepoFilePath("scripts/seed.sh"));
        await Assert.That(seed).Contains("dirname \"$DOSSIER_DB\"");
        await Assert.That(Regex.IsMatch(seed, @"/blobs""")).IsTrue();
        await Assert.That(Regex.IsMatch(seed, @"cp\s+""\$SHOT""\s+""\$BLOBS/")).IsTrue();
        await Assert.That(Regex.IsMatch(seed, @"(shasum -a 256|sha256sum)")).IsTrue();

        var demo = File.ReadAllText(RepoFilePath("scripts/publish-demo.sh"));
        await Assert.That(demo).Contains("scripts/seed.sh");
        await Assert.That(demo).DoesNotContain("blobs");
    }

    /// <summary>
    /// Characterisation test: it mirrors what scripts/seed.sh does — post the five seed files, then
    /// place the declared blob — so the publish path the demo relies on is pinned in-process. It is
    /// not a test of the script; SeedScriptStoresTheDeclaredAttachmentBlob covers the script itself.
    /// </summary>
    [Test]
    public async Task SeededDataPublishesWithNoMissingBlobWarning()
    {
        var declared = DeclaredAttachment();
        using var db = new TempDb();

        var root = ReadRequest("scripts/seed/memos-root.json");
        var rootId = db.Store.PostFacts(root).Response.Subject.Id;

        foreach (var file in new[] { "memos-signin.json", "memos-memodetail.json", "memos-archived.json", "memos.json" })
        {
            var request = ReadRequest("scripts/seed/" + file);
            request.Subject!.Parent = rootId;
            db.Store.PostFacts(request);
        }

        var shot = File.ReadAllBytes(RepoFilePath(declared.Filename));
        var sha = Convert.ToHexString(SHA256.HashData(shot)).ToLowerInvariant();
        Directory.CreateDirectory(db.Store.BlobRoot);
        File.WriteAllBytes(Path.Combine(db.Store.BlobRoot, sha), shot);

        var outDir = Path.Combine(db.Directory, "bundle");
        var result = db.Store.Publish(new PublishOptions
        {
            Out = outDir,
            Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero),
        });

        await Assert.That(result.Warnings.Count).IsEqualTo(0);
        var assets = result.Files.Where(f => f.Contains("/assets/", StringComparison.Ordinal)).ToList();
        await Assert.That(assets.Count).IsEqualTo(1);
        await Assert.That(Path.GetFileName(assets[0])).StartsWith(sha[..8]);
        await Assert.That(File.ReadAllBytes(Path.Combine(outDir, assets[0])).SequenceEqual(shot)).IsTrue();
    }

    private sealed record Declared(string Sha256, string Filename, long Bytes);

    private static Declared DeclaredAttachment()
    {
        var root = JsonDocument.Parse(File.ReadAllText(RepoFilePath("scripts/seed/memos.json"))).RootElement;
        foreach (var fact in root.GetProperty("facts").EnumerateArray())
        {
            if (!fact.TryGetProperty("attachments", out var attachments))
            {
                continue;
            }

            foreach (var attachment in attachments.EnumerateArray())
            {
                return new Declared(
                    attachment.GetProperty("sha256").GetString()!,
                    attachment.GetProperty("filename").GetString()!,
                    attachment.GetProperty("bytes").GetInt64());
            }
        }

        throw new InvalidOperationException("scripts/seed/memos.json declares no attachment");
    }

    private static PostFactsRequest ReadRequest(string relative) =>
        JsonCodec.Deserialize<PostFactsRequest>(File.ReadAllText(RepoFilePath(relative)))
        ?? throw new InvalidOperationException($"{relative} is not a post_facts request");

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
