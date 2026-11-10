using System.Diagnostics;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class McpTests
{
    private sealed class McpChild : IDisposable
    {
        private readonly Process process;
        private int nextId = 1;

        public McpChild(string dbPath)
        {
            var info = new ProcessStartInfo("dotnet")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            };
            info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
            info.ArgumentList.Add("mcp");
            info.Environment["DOSSIER_DB"] = dbPath;
            process = Process.Start(info)!;
            process.ErrorDataReceived += (_, _) => { };
            process.BeginErrorReadLine();
        }

        public async Task<JsonElement> Call(string method, object? parameters = null)
        {
            var id = nextId++;
            var message = JsonSerializer.Serialize(new { jsonrpc = "2.0", id, method, @params = parameters });
            await process.StandardInput.WriteLineAsync(message);
            await process.StandardInput.FlushAsync();
            var line = await process.StandardOutput.ReadLineAsync().WaitAsync(TimeSpan.FromSeconds(60));
            var reply = JsonDocument.Parse(line ?? throw new InvalidOperationException("server closed stdout")).RootElement.Clone();
            if (reply.GetProperty("id").GetInt32() != id)
            {
                throw new InvalidOperationException("mismatched response id");
            }

            return reply;
        }

        public async Task Notify(string method)
        {
            await process.StandardInput.WriteLineAsync(JsonSerializer.Serialize(new { jsonrpc = "2.0", method }));
            await process.StandardInput.FlushAsync();
        }

        public void Dispose()
        {
            try
            {
                if (!process.HasExited)
                {
                    process.Kill(entireProcessTree: true);
                }
            }
            catch (InvalidOperationException)
            {
            }

            process.Dispose();
        }
    }

    [Test]
    public async Task Mcp_InitializeThenListToolsThenCallSearch()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("the quick alpha fact")));

        var child = new McpChild(db.DbPath);
        try
        {
            var init = await child.Call("initialize", new
            {
                protocolVersion = "2025-06-18",
                capabilities = new { },
                clientInfo = new { name = "test", version = "0" },
            });
            var initResult = init.GetProperty("result");
            await Assert.That(initResult.GetProperty("protocolVersion").GetString()).IsEqualTo("2025-06-18");
            await Assert.That(initResult.GetProperty("serverInfo").GetProperty("name").GetString()).IsEqualTo("dossier");
            await child.Notify("notifications/initialized");

            var list = await child.Call("tools/list");
            var names = list.GetProperty("result").GetProperty("tools").EnumerateArray()
                .Select(tool => tool.GetProperty("name").GetString()).ToList();
            foreach (var expected in new[] { "dump", "post_facts", "correlate", "search", "get_fact", "compile_dossier", "resolve_subject" })
            {
                await Assert.That(names.Contains(expected)).IsTrue();
            }

            await Assert.That(names.Count).IsEqualTo(7);

            foreach (var tool in list.GetProperty("result").GetProperty("tools").EnumerateArray())
            {
                await Assert.That(tool.GetProperty("description").GetString()!.Contains("untrusted data")).IsTrue();
            }

            var call = await child.Call("tools/call", new { name = "search", arguments = new { q = "alpha" } });
            var result = call.GetProperty("result");
            await Assert.That(result.GetProperty("isError").GetBoolean()).IsFalse();
            var content = result.GetProperty("content")[0];
            await Assert.That(content.GetProperty("type").GetString()).IsEqualTo("text");
            var payload = JsonDocument.Parse(content.GetProperty("text").GetString()!).RootElement;
            await Assert.That(payload.GetProperty("total").GetInt32()).IsEqualTo(1);
            await Assert.That(payload.GetProperty("hits")[0].GetProperty("text").GetString()).IsEqualTo("the quick alpha fact");

            var compile = await child.Call("tools/call", new { name = "compile_dossier", arguments = new { subject = "Widget" } });
            await Assert.That(compile.GetProperty("result").GetProperty("isError").GetBoolean()).IsFalse();
        }
        finally
        {
            child.Dispose();
        }
    }

    [Test]
    public async Task Mcp_GetFactToolMatchesCoreShow()
    {
        using var db = new TempDb();
        var factId = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body"))).Response.Facts[0].Id;
        var server = new McpServer(db.Store);

        var reply = server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 1,
            method = "tools/call",
            @params = new { name = "get_fact", arguments = new { id = factId } },
        }))!.ToJsonString();
        var text = JsonDocument.Parse(reply).RootElement.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString();

        await Assert.That(text).IsEqualTo(JsonSerializer.Serialize(db.Store.Show(factId), JsonCodec.Options));
    }

    [Test]
    public async Task Mcp_ErrorsAndNotifications()
    {
        using var db = new TempDb();
        var server = new McpServer(db.Store);

        await Assert.That(server.Handle("""{"jsonrpc":"2.0","method":"notifications/initialized"}""")).IsNull();

        var unknown = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"nope"}""")!.ToJsonString()).RootElement;
        await Assert.That(unknown.GetProperty("error").GetProperty("code").GetInt32()).IsEqualTo(-32601);

        var missing = JsonDocument.Parse(server.Handle(
            """{"jsonrpc":"2.0","id":2,"method":"tools/call","params":{"name":"get_fact","arguments":{"id":"nope"}}}""")!.ToJsonString()).RootElement;
        await Assert.That(missing.GetProperty("result").GetProperty("isError").GetBoolean()).IsTrue();

        var bad = JsonDocument.Parse(server.Handle("not json")!.ToJsonString()).RootElement;
        await Assert.That(bad.GetProperty("error").GetProperty("code").GetInt32()).IsEqualTo(-32700);
    }

    [Test]
    public async Task Mcp_ResourcesListIncludesSubjectsAndFactTemplates()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));

        var server = new McpServer(db.Store);
        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"resources/list"}""")!.ToJsonString()).RootElement;
        var resources = list.GetProperty("result").GetProperty("resources").EnumerateArray()
            .Select(r => r.GetProperty("uri").GetString()).ToList();
        await Assert.That(resources.Contains("dossier://subjects")).IsTrue();

        var templates = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":2,"method":"resources/templates/list"}""")!.ToJsonString()).RootElement;
        var uris = templates.GetProperty("result").GetProperty("resourceTemplates").EnumerateArray()
            .Select(r => r.GetProperty("uriTemplate").GetString()).ToList();
        await Assert.That(uris.Contains("dossier://subject/{id}")).IsTrue();
        await Assert.That(uris.Contains("dossier://fact/{id}")).IsTrue();

        var subjectId = db.Store.ListSubjects().Single().Id;
        var read = JsonDocument.Parse(server.Handle(
            JsonSerializer.Serialize(new { jsonrpc = "2.0", id = 3, method = "resources/read", @params = new { uri = "dossier://subject/" + subjectId } }))!.ToJsonString()).RootElement;
        var text = read.GetProperty("result").GetProperty("contents")[0].GetProperty("text").GetString()!;
        await Assert.That(JsonDocument.Parse(text).RootElement.GetProperty("subject").GetProperty("id").GetString()).IsEqualTo(subjectId);
    }

    [Test]
    public async Task Mcp_ResolveSubjectToolIsListedAndCallable()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var server = new McpServer(db.Store);

        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var tools = list.GetProperty("result").GetProperty("tools").EnumerateArray().ToList();
        await Assert.That(tools.Count).IsEqualTo(7);
        var tool = tools.Single(t => t.GetProperty("name").GetString() == "resolve_subject");
        await Assert.That(tool.GetProperty("description").GetString()!.Contains("untrusted data")).IsTrue();

        var reply = JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 2,
            method = "tools/call",
            @params = new { name = "resolve_subject", arguments = new { q = "widget" } },
        }))!.ToJsonString()).RootElement;
        var text = reply.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!;
        var matches = JsonDocument.Parse(text).RootElement;
        await Assert.That(matches[0].GetProperty("match").GetString()).IsEqualTo("exact_name");
        await Assert.That(matches[0].GetProperty("name").GetString()).IsEqualTo("Widget");

        var dry = JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 3,
            method = "tools/call",
            @params = new { name = "post_facts", arguments = new { dry_run = true, subject = new { name = "Widget" }, facts = new[] { new { kind = "note", text = "fresh" } } } },
        }))!.ToJsonString()).RootElement;
        await Assert.That(dry.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!.Contains("\"new\"")).IsTrue();
        await Assert.That(db.Store.Search(new SearchRequest { Q = "fresh" }).Total).IsEqualTo(0);
    }
}
