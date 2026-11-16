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

        public McpChild(string dbPath, string? agent = null)
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
            if (agent is not null)
            {
                info.Environment["DOSSIER_AGENT"] = agent;
            }

            process = Process.Start(info)!;
            process.ErrorDataReceived += (_, _) => { };
            process.BeginErrorReadLine();
        }

        /// <summary>initialize with a client-supplied name, or with none when <paramref name="name"/> is null.</summary>
        public Task<JsonElement> Initialize(string? name) => name is null
            ? CallRaw("initialize", """{"protocolVersion":"2025-06-18","capabilities":{},"clientInfo":{"version":"0"}}""")
            : Call("initialize", new { protocolVersion = "2025-06-18", capabilities = new { }, clientInfo = new { name, version = "0" } });

        public async Task<JsonElement> CallRaw(string method, string parameters)
        {
            var id = nextId++;
            await process.StandardInput.WriteLineAsync($$"""{"jsonrpc":"2.0","id":{{id}},"method":"{{method}}","params":{{parameters}}}""");
            await process.StandardInput.FlushAsync();
            var line = await process.StandardOutput.ReadLineAsync().WaitAsync(TimeSpan.FromSeconds(60));
            var reply = JsonDocument.Parse(line ?? throw new InvalidOperationException("server closed stdout")).RootElement.Clone();
            if (reply.GetProperty("id").GetInt32() != id)
            {
                throw new InvalidOperationException("mismatched response id");
            }

            return reply;
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
            foreach (var expected in new[] { "dump", "post_facts", "correlate", "search", "get_fact", "compile_dossier", "check" })
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
    public async Task Mcp_DumpToolAdvertisesSplitEnum()
    {
        using var db = new TempDb();
        var server = new McpServer(db.Store);

        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var tool = list.GetProperty("result").GetProperty("tools").EnumerateArray()
            .Single(t => t.GetProperty("name").GetString() == "dump");
        var split = tool.GetProperty("inputSchema").GetProperty("properties").GetProperty("split");
        var values = split.GetProperty("enum").EnumerateArray().Select(e => e.GetString()).ToList();

        await Assert.That(values.SequenceEqual(new[] { "heading", "file", "none" })).IsTrue();
    }

    [Test]
    public async Task Mcp_CheckToolIsListedAndCallable()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var server = new McpServer(db.Store);

        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var tools = list.GetProperty("result").GetProperty("tools").EnumerateArray().ToList();
        await Assert.That(tools.Count).IsEqualTo(7);
        var tool = tools.Single(t => t.GetProperty("name").GetString() == "check");
        await Assert.That(tool.GetProperty("description").GetString()!.Contains("untrusted data")).IsTrue();

        var reply = JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 2,
            method = "tools/call",
            @params = new { name = "check", arguments = new { subject = "widget", drafts = new[] { new { kind = "note", text = "fresh" } } } },
        }))!.ToJsonString()).RootElement;
        var text = reply.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!;
        var body = JsonDocument.Parse(text).RootElement;
        await Assert.That(body.GetProperty("subject").GetProperty("match").GetString()).IsEqualTo("exact_name");
        await Assert.That(body.GetProperty("drafts")[0].GetProperty("status").GetString()).IsEqualTo("new");
        await Assert.That(db.Store.Search(new SearchRequest { Q = "fresh" }).Total).IsEqualTo(0);
    }

    [Test]
    public async Task Mcp_PostFactsDryRunStillWritesNothing()
    {
        using var db = new TempDb();
        var server = new McpServer(db.Store);
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

    /// <summary>The fact's provenance stamp, straight from the row the writer committed.</summary>
    private static JsonElement Provenance(DossierStore store, string factId)
    {
        using var connection = store.OpenConnection();
        var raw = (string?)Fixtures.Scalar(connection, "SELECT provenance FROM facts WHERE id = $id", ("$id", factId));
        return JsonDocument.Parse(raw!).RootElement.Clone();
    }

    private static string PostInProcess(McpServer server, string text)
    {
        var reply = JsonDocument.Parse(server.Handle(JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 9,
            method = "tools/call",
            @params = new { name = "post_facts", arguments = new { subject = new { name = "Widget" }, facts = new[] { new { kind = "note", text } } } },
        }))!.ToJsonString()).RootElement;
        var payload = JsonDocument.Parse(
            reply.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!).RootElement;
        return payload.GetProperty("response").GetProperty("facts")[0].GetProperty("id").GetString()!;
    }

    /// <summary>An initialize request with a client-supplied name, or with none when it is null.</summary>
    private static string Initialize(string? name) => name is null
        ? """{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2025-06-18","capabilities":{},"clientInfo":{"version":"0"}}}"""
        : JsonSerializer.Serialize(new
        {
            jsonrpc = "2.0",
            id = 1,
            method = "initialize",
            @params = new { protocolVersion = "2025-06-18", capabilities = new { }, clientInfo = new { name, version = "0" } },
        });

    [Test]
    public async Task Mcp_ClientInfoNameLandsInProvenance()
    {
        using var db = new TempDb();
        var zero = new McpServer(db.Store);
        var one = new McpServer(db.Store);

        // Each server names itself once, at initialize, exactly as a real client does.
        await Assert.That(zero.Handle(Initialize("agent-0"))!.ContainsKey("result")).IsTrue();
        await Assert.That(one.Handle(Initialize("agent-1"))!.ContainsKey("result")).IsTrue();

        var fromZero = Provenance(db.Store, PostInProcess(zero, "fact from agent zero"));
        var fromOne = Provenance(db.Store, PostInProcess(one, "fact from agent one"));

        await Assert.That(fromZero.GetProperty("actor").GetString()).IsEqualTo("agent-0");
        await Assert.That(fromZero.GetProperty("channel").GetString()).IsEqualTo("mcp");
        await Assert.That(fromZero.GetProperty("actor_type").GetString()).IsEqualTo("agent");
        await Assert.That(fromOne.GetProperty("actor").GetString()).IsEqualTo("agent-1");
        await Assert.That(fromOne.GetProperty("channel").GetString()).IsEqualTo("mcp");
        await Assert.That(fromOne.GetProperty("actor_type").GetString()).IsEqualTo("agent");
    }

    [Test]
    public async Task Mcp_ClientInfoNameIsSanitized()
    {
        using var db = new TempDb();

        // A bidi override and a control character are not a name; they become one '-'.
        var hostile = new McpServer(db.Store);
        var hostileInit = hostile.Handle(Initialize("\u202Eevil\u0007agent"));
        await Assert.That(hostileInit!.ContainsKey("result")).IsTrue();
        var hostileActor = Provenance(db.Store, PostInProcess(hostile, "hostile name")).GetProperty("actor").GetString();
        await Assert.That(hostileActor).IsEqualTo("evil-agent");

        // An overlong name is capped, and every character left is from the allowlist.
        var longName = new string('a', 200);
        var longServer = new McpServer(db.Store);
        await Assert.That(longServer.Handle(Initialize(longName))!.ContainsKey("result")).IsTrue();
        var longActor = Provenance(db.Store, PostInProcess(longServer, "long name")).GetProperty("actor").GetString()!;
        await Assert.That(longActor.Length).IsEqualTo(64);
        await Assert.That(longActor).IsEqualTo(new string('a', 64));

        // A non-string name does not fail initialize, and it is not a name: the default is used.
        var numeric = new McpServer(db.Store);
        var numericInit = numeric.Handle("""{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"clientInfo":{"name":42}}}""");
        await Assert.That(numericInit!.ContainsKey("result")).IsTrue();
        await Assert.That(Provenance(db.Store, PostInProcess(numeric, "numeric name")).GetProperty("actor").GetString())
            .IsEqualTo("mcp-client");
    }

    [Test]
    public async Task Mcp_DossierAgentEnvIsTheFallback()
    {
        using var db = new TempDb();

        // The env var names the writer when initialize carries no clientInfo.name.
        var plain = new McpChild(db.DbPath, agent: "env-agent");
        try
        {
            await plain.Initialize(name: null);
            var call = await plain.Call("tools/call", new
            {
                name = "post_facts",
                arguments = new { subject = new { name = "Widget" }, facts = new[] { new { kind = "note", text = "from env" } } },
            });
            var payload = JsonDocument.Parse(
                call.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!).RootElement;
            var id = payload.GetProperty("response").GetProperty("facts")[0].GetProperty("id").GetString()!;
            await Assert.That(Provenance(db.Store, id).GetProperty("actor").GetString()).IsEqualTo("env-agent");
        }
        finally
        {
            plain.Dispose();
        }

        // clientInfo.name wins over the environment.
        var named = new McpChild(db.DbPath, agent: "env-agent");
        try
        {
            await named.Initialize("client-agent");
            var call = await named.Call("tools/call", new
            {
                name = "post_facts",
                arguments = new { subject = new { name = "Widget" }, facts = new[] { new { kind = "note", text = "from client" } } },
            });
            var payload = JsonDocument.Parse(
                call.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!).RootElement;
            var id = payload.GetProperty("response").GetProperty("facts")[0].GetProperty("id").GetString()!;
            await Assert.That(Provenance(db.Store, id).GetProperty("actor").GetString()).IsEqualTo("client-agent");
        }
        finally
        {
            named.Dispose();
        }
    }

    [Test]
    public async Task Mcp_IdenticalPostsFromTwoAgentsStillDedupe()
    {
        using var db = new TempDb();
        var zero = new McpServer(db.Store);
        var one = new McpServer(db.Store);
        zero.Handle(Initialize("agent-0"));
        one.Handle(Initialize("agent-1"));

        const string Text = "the same fact from both";
        var first = PostInProcess(zero, Text);
        var second = PostInProcess(one, Text);

        // Provenance is not in content_hash, so the second write dedupes onto the first fact.
        await Assert.That(second).IsEqualTo(first);
        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts WHERE text = $text", ("$text", Text))).IsEqualTo(1);
        await Assert.That(Provenance(db.Store, first).GetProperty("actor").GetString()).IsEqualTo("agent-0");
    }
}
