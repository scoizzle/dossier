using System.Diagnostics;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// The journal as an agent reads it: the same page <c>/api/changes</c> serves, over MCP and the CLI,
/// with an optional subject filter so an agent can follow one subject from a cursor.
/// </summary>
public sealed class ChangesToolTests
{
    private static JsonElement CallTool(McpServer server, string name, object arguments)
    {
        var reply = server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 1,
            method = "tools/call",
            @params = new { name, arguments },
        }))!.ToJsonString();
        return JsonDocument.Parse(reply).RootElement.GetProperty("result").Clone();
    }

    private static JsonElement Payload(JsonElement result) =>
        JsonDocument.Parse(result.GetProperty("content")[0].GetProperty("text").GetString()!).RootElement.Clone();

    [Test]
    public async Task SubjectFilter_ReturnsOnlyThatSubjectsRows_AndTheCursorReachesTheHead()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta one")));
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha two")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta two")));

        var page = db.Store.ReadChanges(0, 100, "alpha");

        await Assert.That(page.Reset).IsFalse();
        await Assert.That(page.Changes.Count).IsGreaterThan(0);
        await Assert.That(page.Changes.All(row => row.SubjectName == "Alpha")).IsTrue();
        await Assert.That(page.Changes.Count(row => row.Tbl == "facts" && row.Op == "insert")).IsEqualTo(2);

        // Nothing of Alpha is left behind the page, so the cursor skips Beta's trailing rows.
        await Assert.That(page.Truncated).IsFalse();
        await Assert.That(page.Next).IsEqualTo(db.Store.Revision());
        await Assert.That(db.Store.ReadChanges(page.Next, 100, "alpha").Changes.Count).IsEqualTo(0);
    }

    [Test]
    public async Task SubjectFilter_PagesEveryRowExactlyOnce()
    {
        using var db = new TempDb();
        for (var index = 0; index < 5; index++)
        {
            db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact($"alpha {index}")));
            db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact($"beta {index}")));
        }

        var expected = db.Store.ReadChanges(0, 500, "Alpha").Changes.Select(row => row.Seq).ToList();
        var seen = new List<long>();
        long cursor = 0;
        for (var guard = 0; guard < 20; guard++)
        {
            var page = db.Store.ReadChanges(cursor, 2, "Alpha");
            seen.AddRange(page.Changes.Select(row => row.Seq));
            await Assert.That(page.Changes.Count).IsLessThanOrEqualTo(2);
            cursor = page.Next;
            if (!page.Truncated)
            {
                break;
            }
        }

        await Assert.That(seen.SequenceEqual(expected)).IsTrue();
        await Assert.That(cursor).IsEqualTo(db.Store.Revision());
    }

    [Test]
    public async Task SubjectFilter_Last_ReturnsTheNewestRowsOfThatSubject()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one"), Fixtures.Fact("alpha two")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta one")));

        var page = db.Store.ReadChangesLast(1, "Alpha");

        await Assert.That(page.Changes.Count).IsEqualTo(1);
        await Assert.That(page.Changes[0].SubjectName).IsEqualTo("Alpha");
        await Assert.That(page.Changes[0].Text).IsEqualTo("alpha two");
        await Assert.That(page.Truncated).IsTrue();
        await Assert.That(page.Next).IsEqualTo(db.Store.Revision());
    }

    [Test]
    public async Task SubjectFilter_UnknownSubject_FailsClosed()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));

        DossierRequestException? thrown = null;
        try
        {
            db.Store.ReadChanges(0, 100, "no such subject");
        }
        catch (DossierRequestException exception)
        {
            thrown = exception;
        }

        // A typo must not read as "nothing changed".
        await Assert.That(thrown).IsNotNull();
        await Assert.That(thrown!.Code).IsEqualTo("subject_not_found");
    }

    [Test]
    public async Task Unfiltered_PageIsUnchangedByTheNewParameter()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta one")));

        var plain = JsonSerializer.Serialize(db.Store.ReadChanges(0, 3), JsonCodec.Options);
        var withNull = JsonSerializer.Serialize(db.Store.ReadChanges(0, 3, null), JsonCodec.Options);

        await Assert.That(withNull).IsEqualTo(plain);
    }

    [Test]
    public async Task Mcp_ChangesToolIsListed_AndServesTheSamePageAsTheStore()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta one")));
        var server = new McpServer(db.Store);

        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var tool = list.GetProperty("result").GetProperty("tools").EnumerateArray()
            .Single(t => t.GetProperty("name").GetString() == "changes");
        await Assert.That(tool.GetProperty("description").GetString()!.Contains("untrusted data")).IsTrue();

        var result = CallTool(server, "changes", new { since = 0, limit = 100, subject = "Alpha" });
        await Assert.That(result.GetProperty("isError").GetBoolean()).IsFalse();
        var expected = JsonSerializer.Serialize(db.Store.ReadChanges(0, 100, "Alpha"), JsonCodec.Options);
        await Assert.That(result.GetProperty("content")[0].GetProperty("text").GetString()).IsEqualTo(expected);

        // The first call of a session: ask for the newest row and keep `next` as the cursor.
        var head = Payload(CallTool(server, "changes", new { last = 1 }));
        await Assert.That(head.GetProperty("next").GetInt64()).IsEqualTo(db.Store.Revision());
        await Assert.That(head.GetProperty("changes").GetArrayLength()).IsEqualTo(1);
    }

    [Test]
    public async Task Mcp_ChangesTool_RejectsABadCursorAndAnUnknownSubject()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        var server = new McpServer(db.Store);

        var negative = CallTool(server, "changes", new { since = -1 });
        await Assert.That(negative.GetProperty("isError").GetBoolean()).IsTrue();
        await Assert.That(Payload(negative).GetProperty("error").GetProperty("code").GetString()).IsEqualTo("invalid_request");

        var unknown = CallTool(server, "changes", new { since = 0, subject = "nope" });
        await Assert.That(unknown.GetProperty("isError").GetBoolean()).IsTrue();
        await Assert.That(Payload(unknown).GetProperty("error").GetProperty("code").GetString()).IsEqualTo("subject_not_found");
    }

    [Test]
    public async Task ChangesTool_RejectsANonPositiveLastOrLimit_OverMcpAndTheCli()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        var server = new McpServer(db.Store);

        // The contract gives last and limit a minimum of 1; a zero or negative value is a mistake to
        // report, not a request for one row.
        foreach (var arguments in new object[] { new { last = 0 }, new { last = -3 }, new { since = 0, limit = 0 }, new { since = 0, limit = -1 } })
        {
            var result = CallTool(server, "changes", arguments);
            await Assert.That(result.GetProperty("isError").GetBoolean()).IsTrue();
            await Assert.That(Payload(result).GetProperty("error").GetProperty("code").GetString()).IsEqualTo("invalid_request");
        }

        foreach (var args in new[] { new[] { "changes", "--last", "0" }, new[] { "changes", "--last", "-1" }, new[] { "changes", "--limit", "0" } })
        {
            var (exit, stdout, stderr) = await Run(db.DbPath, args);
            await Assert.That(exit).IsEqualTo(1);
            await Assert.That(stdout).IsEqualTo(string.Empty);
            await Assert.That(stderr).Contains("at least 1");
        }

        // A limit above the page cap is still clamped, as it is on /api/changes.
        var large = Payload(CallTool(server, "changes", new { since = 0, limit = 100000 }));
        await Assert.That(large.GetProperty("changes").GetArrayLength()).IsGreaterThan(0);
    }

    [Test]
    public async Task Mcp_ChangesTool_ReportsAResetForACursorAheadOfTheHead()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        var server = new McpServer(db.Store);

        var page = Payload(CallTool(server, "changes", new { since = db.Store.Revision() + 50 }));

        await Assert.That(page.GetProperty("reset").GetBoolean()).IsTrue();
        await Assert.That(page.GetProperty("changes").GetArrayLength()).IsEqualTo(0);
        await Assert.That(page.GetProperty("next").GetInt64()).IsEqualTo(db.Store.Revision());
    }

    [Test]
    public async Task Cli_ChangesPrintsThePage_AndRejectsABadCursor()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Alpha", Fixtures.Fact("alpha one")));
        db.Store.PostFacts(Fixtures.Post("Beta", Fixtures.Fact("beta one")));

        var (exit, stdout, _) = await Run(db.DbPath, "changes", "--since", "0", "--subject", "Alpha");
        await Assert.That(exit).IsEqualTo(0);
        var page = JsonDocument.Parse(stdout).RootElement;
        await Assert.That(page.GetProperty("next").GetInt64()).IsEqualTo(db.Store.Revision());
        await Assert.That(page.GetProperty("changes").EnumerateArray().All(row => row.GetProperty("subject_name").GetString() == "Alpha")).IsTrue();

        var (lastExit, lastOut, _) = await Run(db.DbPath, "changes", "--last", "1");
        await Assert.That(lastExit).IsEqualTo(0);
        await Assert.That(JsonDocument.Parse(lastOut).RootElement.GetProperty("changes").GetArrayLength()).IsEqualTo(1);

        var (badExit, badOut, badErr) = await Run(db.DbPath, "changes", "--since", "soon");
        await Assert.That(badExit).IsEqualTo(1);
        await Assert.That(badOut).IsEqualTo(string.Empty);
        await Assert.That(badErr).Contains("--since");

        var (typoExit, _, typoErr) = await Run(db.DbPath, "changes", "--sinse", "0");
        await Assert.That(typoExit).IsEqualTo(1);
        await Assert.That(typoErr).Contains("unknown option \"--sinse\"");
    }

    private static async Task<(int Exit, string Out, string Err)> Run(string dbPath, params string[] args)
    {
        var info = new ProcessStartInfo("dotnet")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            WorkingDirectory = Path.GetDirectoryName(dbPath)!,
        };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in args)
        {
            info.ArgumentList.Add(arg);
        }

        info.Environment["DOSSIER_DB"] = dbPath;
        using var process = Process.Start(info)!;
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        return (process.ExitCode, await stdout, await stderr);
    }
}
