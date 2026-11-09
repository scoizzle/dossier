using System.Security.Cryptography;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class DumpTests
{
    private static string WriteSource(TempDb db, string name, string content)
    {
        var path = Path.Combine(db.Directory, name);
        File.WriteAllText(path, content);
        return path;
    }

    private static DumpRequest Request(
        string source,
        string? split = null,
        string? kind = null,
        List<string>? tags = null) => new()
    {
        Source = source,
        Subject = "Widget",
        Split = split,
        Kind = kind,
        Tags = tags,
    };

    private static string FactText(TempDb db, string id) => db.Store.Show(id)!.Fact.Text!;

    [Test]
    public async Task Dump_ManifestAccountsForEveryChunk()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "doc.md", "# One\nalpha\n#\n# Three\ncharlie\n");

        var response = db.Store.Dump(Request(source, "heading"));

        // Three chunks: "# One/alpha", "#", "# Three/charlie". The bare "#" is skipped, not lost.
        var accounted = response.Created.Count + response.Deduped.Count + response.Skipped.Count;
        await Assert.That(accounted).IsEqualTo(3);
        await Assert.That(response.Created.Count).IsEqualTo(2);
        await Assert.That(response.Skipped.Count).IsEqualTo(1);
        await Assert.That(response.Skipped[0].Reason).IsEqualTo("too_short");
        await Assert.That(response.Errors.Count).IsEqualTo(0);
    }

    [Test]
    public async Task Dump_IsIdempotent_SecondRunAllDeduped()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "doc.md", "# One\nalpha\n# Two\nbeta\n");

        var first = db.Store.Dump(Request(source, "heading"));
        var second = db.Store.Dump(Request(source, "heading"));

        await Assert.That(first.Created.Count).IsEqualTo(2);
        await Assert.That(second.Created.Count).IsEqualTo(0);
        await Assert.That(second.Deduped.Count).IsEqualTo(2);
        await Assert.That(second.Deduped.OrderBy(id => id, StringComparer.Ordinal)
            .SequenceEqual(first.Created.OrderBy(id => id, StringComparer.Ordinal))).IsTrue();
    }

    [Test]
    public async Task Dump_SplitsOnHeadings()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "notes.md", "intro line here\n# Alpha\nalpha body\n## Beta\nbeta body");

        // No split option: .md defaults to heading.
        var response = db.Store.Dump(Request(source));

        await Assert.That(response.Created.Count).IsEqualTo(3);
        var texts = response.Created.Select(id => FactText(db, id)).ToList();
        await Assert.That(texts.SequenceEqual(new[]
        {
            "intro line here",
            "# Alpha\nalpha body",
            "## Beta\nbeta body",
        })).IsTrue();
    }

    [Test]
    public async Task Dump_SplitsOnParagraphs()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "notes.txt", "para one\nline two\n\npara three\n\n\npara four");

        var response = db.Store.Dump(Request(source, "paragraph"));

        await Assert.That(response.Created.Count).IsEqualTo(3);
        var texts = response.Created.Select(id => FactText(db, id)).ToList();
        await Assert.That(texts.SequenceEqual(new[]
        {
            "para one\nline two",
            "para three",
            "para four",
        })).IsTrue();
    }

    [Test]
    public async Task Dump_StoresRawBlobBeforeParsing()
    {
        using var db = new TempDb();
        var bytes = new byte[] { 0xFF, 0xFE, 0x41 };
        var source = Path.Combine(db.Directory, "bad.md");
        File.WriteAllBytes(source, bytes);

        var response = db.Store.Dump(Request(source, "none"));

        var sha256 = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
        var blob = Path.Combine(db.Store.BlobRoot, sha256);
        await Assert.That(File.Exists(blob)).IsTrue();
        await Assert.That(new FileInfo(blob).Length).IsEqualTo(bytes.Length);
        await Assert.That(response.Errors.Count).IsGreaterThan(0);
        await Assert.That(response.Created.Count).IsEqualTo(0);
    }

    [Test]
    public async Task Dump_SkipsTooShortChunks()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "notes.txt", "ok paragraph\n\nab\n\nanother ok");

        var response = db.Store.Dump(Request(source, "paragraph"));

        await Assert.That(response.Created.Count).IsEqualTo(2);
        await Assert.That(response.Skipped.Count).IsEqualTo(1);
        await Assert.That(response.Skipped[0].Reason).IsEqualTo("too_short");

        var locator = response.Skipped[0].Locator!.Value;
        await Assert.That(locator.GetProperty("line").GetInt32()).IsEqualTo(3);
        await Assert.That(locator.GetProperty("selector").GetString()).IsEqualTo("L3-L3");
    }

    [Test]
    public async Task Dump_EveryFactHasFileRefWithLineRange()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "doc.md", "# One\nbody one\n# Two\nbody two");

        var response = db.Store.Dump(Request(source, "heading"));

        var expectedStarts = new[] { 1, 3 };
        var expectedSelectors = new[] { "L1-L2", "L3-L4" };
        await Assert.That(response.Created.Count).IsEqualTo(2);

        for (var index = 0; index < response.Created.Count; index++)
        {
            var reference = db.Store.Show(response.Created[index])!.Refs.Single();
            await Assert.That(reference.Rel).IsEqualTo("derived_from");
            await Assert.That(reference.Kind).IsEqualTo("file");
            await Assert.That(reference.Target).IsEqualTo(source);
            await Assert.That(reference.Basis).IsEqualTo("observed");

            var locator = reference.Locator!.Value;
            await Assert.That(locator.GetProperty("line").GetInt32()).IsEqualTo(expectedStarts[index]);
            await Assert.That(locator.GetProperty("selector").GetString()).IsEqualTo(expectedSelectors[index]);
        }
    }

    [Test]
    public async Task Dump_TruncationNeverHappens()
    {
        using var db = new TempDb();
        var content = new string('x', 1000);
        var source = WriteSource(db, "long.txt", content);

        var response = db.Store.Dump(Request(source, "none"));

        await Assert.That(response.Created.Count).IsEqualTo(1);
        var text = FactText(db, response.Created[0]);
        await Assert.That(text).IsEqualTo(content);
        await Assert.That(text.Length).IsEqualTo(1000);
    }
}
