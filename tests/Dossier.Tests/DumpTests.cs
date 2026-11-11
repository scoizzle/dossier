using System.Security.Cryptography;
using System.Text.Json;
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
        var source = WriteSource(db, "notes.md", "# ok heading\nok body\n#\n# another\nok body");

        var response = db.Store.Dump(Request(source, "heading"));

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

    [Test]
    public async Task ContractSchema_SplitEnumIsHeadingFileNone_AndEntitySubjectsIsAbsent()
    {
        var path = RepoFilePath(Path.Combine("contract", "ops.schema.json"));
        using var schema = JsonDocument.Parse(File.ReadAllText(path));
        var dump = schema.RootElement.GetProperty("$defs").GetProperty("DumpRequest").GetProperty("properties");

        var split = dump.GetProperty("split").GetProperty("enum").EnumerateArray()
            .Select(value => value.GetString())
            .ToList();
        await Assert.That(split.SequenceEqual(new[] { "heading", "file", "none" })).IsTrue();
        await Assert.That(dump.TryGetProperty("entity_subjects", out _)).IsFalse();
    }

    [Test]
    public async Task InvalidSplit_WritesNoBlob()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n");

        var response = db.Store.Dump(Request(source, "paragraph"));

        var root = db.Store.BlobRoot;
        await Assert.That(!Directory.Exists(root) || !Directory.EnumerateFileSystemEntries(root).Any()).IsTrue();
        await Assert.That(response.Errors.Count).IsEqualTo(1);
        await Assert.That(response.Errors[0].StartsWith("invalid_split:", StringComparison.Ordinal)).IsTrue();
        await Assert.That(response.Created.Count).IsEqualTo(0);
    }

    [Test]
    public async Task SplitFile_Markdown_IsOneChunkWithWholeFileSelector()
    {
        // Characterization: green on arrival.
        using var db = new TempDb();
        var source = WriteSource(db, "doc.md", "# One\nalpha\n## Two\nbeta\n");

        var response = db.Store.Dump(Request(source, "file"));

        await Assert.That(response.Created.Count).IsEqualTo(1);
        var shown = db.Store.Show(response.Created[0])!;
        await Assert.That(shown.Fact.Text!.Contains("# One", StringComparison.Ordinal)).IsTrue();
        await Assert.That(shown.Fact.Text!.Contains("## Two", StringComparison.Ordinal)).IsTrue();
        await Assert.That(shown.Refs.Single().Locator!.Value.GetRawText().Contains("L1-L4", StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    [Arguments("notes.txt")]
    [Arguments("mod.py")]
    public async Task NoSplit_NonMarkdown_IsOneWholeFileChunk(string name)
    {
        // Characterization: green on arrival.
        using var db = new TempDb();
        var source = WriteSource(db, name, "# not a heading\nline two\nline three\n");

        var response = db.Store.Dump(Request(source));

        await Assert.That(response.Created.Count).IsEqualTo(1);
        var shown = db.Store.Show(response.Created[0])!;
        await Assert.That(shown.Refs.Single().Locator!.Value.GetRawText().Contains("L1-L3", StringComparison.Ordinal)).IsTrue();
    }

    private const string InvalidSplitMessage = "invalid_split: split must be heading, file, or none";

    [Test]
    [Arguments("paragraph")]
    [Arguments("code")]
    public async Task RemovedSplit_IsRejectedAsInvalidSplit_Library(string split)
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n\nsecond paragraph\n");

        var response = db.Store.Dump(Request(source, split));

        await Assert.That(response.Created.Count).IsEqualTo(0);
        await Assert.That(response.Errors.Count).IsEqualTo(1);
        await Assert.That(response.Errors[0].StartsWith(InvalidSplitMessage, StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    [Arguments("paragraph")]
    [Arguments("code")]
    public async Task RemovedSplit_IsRejectedAsInvalidSplit_Mcp(string split)
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n\nsecond paragraph\n");
        var arguments = JsonSerializer.Serialize(new { source, subject = "Widget", split });
        var reply = new McpServer(db.Store).Handle(
            "{\"jsonrpc\":\"2.0\",\"id\":1,\"method\":\"tools/call\",\"params\":{\"name\":\"dump\",\"arguments\":" + arguments + "}}")!;
        var text = JsonDocument.Parse(reply.ToJsonString()).RootElement
            .GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!;
        var manifest = JsonDocument.Parse(text).RootElement;

        await Assert.That(manifest.GetProperty("created").GetArrayLength()).IsEqualTo(0);
        var error = manifest.GetProperty("errors")[0].GetString()!;
        await Assert.That(error.StartsWith(InvalidSplitMessage, StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    [Arguments("paragraph")]
    [Arguments("code")]
    public async Task RemovedSplit_IsRejectedAsInvalidSplit_Cli(string split)
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n\nsecond paragraph\n");

        var (_, output) = await RunCli(db, "dump", "--source", source, "--subject", "Widget", "--split", split);

        var manifest = JsonDocument.Parse(output).RootElement;
        await Assert.That(manifest.GetProperty("created").GetArrayLength()).IsEqualTo(0);
        var error = manifest.GetProperty("errors")[0].GetString()!;
        await Assert.That(error.StartsWith(InvalidSplitMessage, StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    public async Task EntitySubjects_IsIgnored_Library()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n\nsecond paragraph\n");
        var request = JsonSerializer.Deserialize<DumpRequest>(
            JsonSerializer.Serialize(new { source, subject = "Widget", entity_subjects = true }), JsonCodec.Options)!;

        var response = db.Store.Dump(request);

        await Assert.That(response.Errors.Count).IsEqualTo(0);
        await Assert.That(response.Created.Count).IsEqualTo(1);
        await Assert.That(SubjectCount(db)).IsEqualTo(1);
    }

    [Test]
    public async Task EntitySubjects_FlagIsIgnored_Cli()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", "def f():\n    pass\n\nsecond paragraph\n");

        var (exit, output) = await RunCli(db, "dump", "--source", source, "--subject", "Widget", "--entity-subjects");

        await Assert.That(exit).IsEqualTo(0);
        var manifest = JsonDocument.Parse(output).RootElement;
        await Assert.That(manifest.GetProperty("errors").GetArrayLength()).IsEqualTo(0);
        await Assert.That(manifest.GetProperty("created").GetArrayLength()).IsEqualTo(1);
        await Assert.That(SubjectCount(db)).IsEqualTo(1);
    }

    private static long SubjectCount(TempDb db)
    {
        using var connection = db.Store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT COUNT(*) FROM subjects";
        return (long)command.ExecuteScalar()!;
    }

    private static async Task<(int Exit, string Out)> RunCli(TempDb db, params string[] args)
    {
        var info = new System.Diagnostics.ProcessStartInfo("dotnet") { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in args)
        {
            info.ArgumentList.Add(arg);
        }

        info.Environment["DOSSIER_DB"] = db.DbPath;
        using var process = System.Diagnostics.Process.Start(info)!;
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        _ = await stderr;
        return (process.ExitCode, await stdout);
    }

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
