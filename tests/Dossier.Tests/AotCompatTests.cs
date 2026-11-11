using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// Pins the exact JSON every serialized type produces (the source-generated metadata must match the
/// reflection serializer it replaced) and the version command.
/// </summary>
public sealed class AotCompatTests
{
    private static string Json<T>(T value) => JsonSerializer.Serialize(value, JsonCodec.Options);

    private static T Parse<T>(string json) => JsonSerializer.Deserialize<T>(json, JsonCodec.Options)!;

    private static async Task<(int Exit, string Out, string Err)> Run(string? dbPath, params string[] args)
    {
        var info = new ProcessStartInfo("dotnet") { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in args)
        {
            info.ArgumentList.Add(arg);
        }

        if (dbPath is not null)
        {
            info.Environment["DOSSIER_DB"] = dbPath;
        }

        using var process = Process.Start(info)!;
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        return (process.ExitCode, await stdout, await stderr);
    }

    private static string ExpectedVersion()
    {
        var value = typeof(DossierStore).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
        var plus = value.IndexOf('+');
        return plus < 0 ? value : value[..plus];
    }

    [Test]
    public async Task Graph_SerializesWithSnakeCaseSourceGeneratedMetadata()
    {
        using var db = new TempDb();
        GraphSeed.Populate(db.Store);
        var request = new GraphRequest { Subject = GraphSeed.Root, Depth = 2 };
        var json = Ops.Graph(db.Store, request);

        await Assert.That(json).IsEqualTo(Json(db.Store.Graph(request)));
        foreach (var name in new[] { "\"format\":1", "\"max_nodes\":500", "\"from_kind\":", "\"to_kind\":", "\"truncated\":{\"subjects\":" })
        {
            await Assert.That(json.Contains(name)).IsTrue();
        }

        // WhenWritingNull: absent optional fields are omitted, not null.
        await Assert.That(json.Contains("\"ambiguous\":null")).IsFalse();
        await Assert.That(json.Contains("\"boundary\":null")).IsFalse();
    }

    [Test]
    public async Task Version_CommandsPrintInformationalVersionAndNothingElse()
    {
        var expected = ExpectedVersion();
        await Assert.That(expected.Contains('+')).IsFalse();
        foreach (var command in new[] { "version", "--version" })
        {
            var (exit, stdout, stderr) = await Run(null, command);
            await Assert.That(exit).IsEqualTo(0);
            await Assert.That(stdout).IsEqualTo(expected + "\n");
            await Assert.That(stderr).IsEqualTo(string.Empty);
        }
    }

    [Test]
    public async Task Version_McpServerInfoMatchesCommand()
    {
        using var db = new TempDb();
        var reply = new McpServer(db.Store).Handle("""{"jsonrpc":"2.0","id":1,"method":"initialize","params":{}}""")!;
        var info = JsonDocument.Parse(reply.ToJsonString()).RootElement.GetProperty("result").GetProperty("serverInfo");
        await Assert.That(info.GetProperty("version").GetString()).IsEqualTo(ExpectedVersion());
    }

    [Test]
    public async Task Version_UsageTextListsVersion()
    {
        var (exit, _, stderr) = await Run(null);
        await Assert.That(exit).IsEqualTo(1);
        await Assert.That(stderr.Contains("<init|version|", StringComparison.Ordinal)).IsTrue();
    }

    [Test]
    public async Task Shape_PostFactsRequest_ParsesSnakeCaseCaseInsensitiveAndRoundTrips()
    {
        const string input = """
            {"IDEMPOTENCY_KEY":"k1","subject":{"name":"Widget","kind":"thing","aliases":["w"]},"redact":["x"],"dry_run":true,
             "facts":[{"key":"a","local_id":"l1","kind":"note","text":"hi","data":{"z":1},"items":[{"key":"i","text":"t","locator":{"line":2}}],
             "tags":["t1"],"confidence":0.5,"refs":[{"rel":"mentions","kind":"fact","target":"l2","locator":{"line":1},"basis":"observed","confidence":0.25,"seq":3,"rev":"r","snapshot":"s","snapshot_hash":"h","etag":"e","verified_at":"2020","valid":true}],
             "attachments":[{"sha256":"ab","filename":"f","mime":"m","bytes":9,"perceptual":{"p":1}}]}]}
            """;
        var request = Parse<PostFactsRequest>(input);
        await Assert.That(request.IdempotencyKey).IsEqualTo("k1");
        await Assert.That(request.DryRun).IsTrue();
        await Assert.That(request.Facts[0].LocalId).IsEqualTo("l1");
        await Assert.That(request.Facts[0].Refs![0].SnapshotHash).IsEqualTo("h");
        await Assert.That(request.Facts[0].Attachments![0].Bytes).IsEqualTo(9L);
        await Assert.That(Json(request)).IsEqualTo(
            """{"idempotency_key":"k1","subject":{"name":"Widget","kind":"thing","aliases":["w"]},"redact":["x"],"dry_run":true,"facts":[{"key":"a","local_id":"l1","kind":"note","text":"hi","data":{"z":1},"items":[{"key":"i","text":"t","locator":{"line":2}}],"tags":["t1"],"confidence":0.5,"refs":[{"rel":"mentions","kind":"fact","target":"l2","locator":{"line":1},"basis":"observed","confidence":0.25,"seq":3,"rev":"r","snapshot":"s","snapshot_hash":"h","etag":"e","verified_at":"2020","valid":true}],"attachments":[{"sha256":"ab","filename":"f","mime":"m","bytes":9,"perceptual":{"p":1}}]}]}""");
    }

    [Test]
    public async Task Shape_PostResultAndResponses()
    {
        var response = new PostFactsResponse
        {
            Subject = new SubjectResponse { Id = "s1", Name = "W", Created = true },
            Facts = new List<FactResult> { new() { Id = "f1", Status = "new" }, new() { Id = "f2", Status = "deduped", DuplicateOf = "f1" } },
        };
        await Assert.That(Json(response)).IsEqualTo(
            """{"subject":{"id":"s1","name":"W","created":true},"facts":[{"id":"f1","status":"new"},{"id":"f2","status":"deduped","duplicate_of":"f1"}]}""");
        var result = new PostResult(response, new List<PostError> { new(1, "bad", "msg") });
        await Assert.That(Json(result)).IsEqualTo(
            """{"response":{"subject":{"id":"s1","name":"W","created":true},"facts":[{"id":"f1","status":"new"},{"id":"f2","status":"deduped","duplicate_of":"f1"}]},"errors":[{"index":1,"code":"bad","message":"msg"}]}""");
    }

    [Test]
    public async Task Shape_SearchBriefCheckAndSubjectLists()
    {
        var search = new SearchResponse
        {
            Hits = new List<FactView> { new() { Id = "f", SubjectId = "s", Kind = "note", Text = "t", Tags = new List<string> { "a" }, Confidence = 1, Status = "live", Score = 0.5 } },
            Total = 1,
            Complete = true,
            Next = "n",
        };
        await Assert.That(Json(search)).IsEqualTo(
            """{"hits":[{"id":"f","subject_id":"s","kind":"note","text":"t","tags":["a"],"confidence":1,"status":"live","score":0.5}],"total":1,"complete":true,"next":"n"}""");
        var brief = new BriefSearchResponse { Hits = new List<BriefHit> { new() { Id = "f", Kind = "k", Status = "live", Text = "t" } }, Total = 1, Refine = "r" };
        await Assert.That(Json(brief)).IsEqualTo("""{"hits":[{"id":"f","kind":"k","status":"live","text":"t"}],"total":1,"complete":false,"refine":"r"}""");
        var check = new CheckResponse
        {
            Subject = new SubjectMatch { Id = "s", Name = "N", Kind = "k", Aliases = new List<string> { "a" }, Facts = 2, Match = "exact" },
            Summary = new CheckSummary { Facts = 2, Top = new List<CheckTop> { new() { Key = "k", Text = "t" } } },
            Drafts = new List<DraftVerdict> { new() { Index = 0, Status = "new", Near = new List<string> { "x" }, Error = new PostError(0, "c", "m") } },
        };
        await Assert.That(Json(check)).IsEqualTo(
            """{"subject":{"id":"s","name":"N","kind":"k","aliases":["a"],"facts":2,"match":"exact"},"summary":{"facts":2,"conflicts":0,"gaps":0,"top":[{"key":"k","text":"t"}]},"drafts":[{"index":0,"status":"new","near":["x"],"error":{"index":0,"code":"c","message":"m"}}]}""");
        var subjects = new List<SubjectSummary> { new() { Id = "s", Name = "N", Kind = "k", Aliases = new List<string> { "a" }, Facts = 3 } };
        await Assert.That(Json(subjects)).IsEqualTo("""[{"id":"s","name":"N","kind":"k","aliases":["a"],"facts":3}]""");
    }

    [Test]
    public async Task Shape_CompiledDossierKeepsExplicitNullResolution()
    {
        var dossier = new CompiledDossier
        {
            Subject = new DossierSubject { Id = "s", Name = "N", Kind = "k", Pin = new DossierPin { Repo = "r", Rev = "v" } },
            Facts = new List<FactView> { new() { Id = "f", SubjectId = "s", Kind = "k", Text = "t", Section = "sec", Cites = new List<string> { "c" } } },
            Conflicts = new List<DossierConflict>
            {
                new() { Field = "f", Values = new List<ConflictValue> { new() { Fact = "x", Value = JsonDocument.Parse("""{"a":[1,2]}""").RootElement.Clone() } } },
            },
            Gaps = new List<DossierGap> { new() { Need = "n", Reason = "r" } },
            Dropped = new List<string> { "d" },
            Degraded = "deg",
        };
        await Assert.That(Json(dossier)).IsEqualTo(
            """{"subject":{"id":"s","name":"N","kind":"k","aliases":[],"pin":{"repo":"r","rev":"v"}},"depth":"index","needs":[],"budget_mode":"complete","budget_tokens":0,"used_tokens":0,"facts":[{"id":"f","subject_id":"s","kind":"k","text":"t","tags":[],"confidence":0,"status":"","section":"sec","cites":["c"]}],"linked":[],"conflicts":[{"field":"f","values":[{"fact":"x","value":{"a":[1,2]}}],"resolution":null}],"gaps":[{"need":"n","reason":"r"}],"dropped":["d"],"degraded":"deg","self_check":{"uncited_claims":0,"conflicts_surfaced":0}}""");
        var request = Parse<CompileRequest>("""{"subject":"s","budget":10,"needs":["a"],"rank":{"recency":0.5},"budget_mode":"strict","descendants":true,"follow":{"x":1}}""");
        await Assert.That(request.BudgetMode).IsEqualTo("strict");
        await Assert.That(request.Rank!.Recency).IsEqualTo(0.5);
        await Assert.That(request.Follow!.Value.GetRawText()).IsEqualTo("""{"x":1}""");
    }

    [Test]
    public async Task Shape_ShowResultWithJsonElementFields()
    {
        var show = new ShowResult
        {
            Fact = new FactRecord
            {
                Id = "f", SubjectId = "s", Kind = "k", Text = "t", Data = JsonDocument.Parse("""{"b":1}""").RootElement.Clone(),
                Items = JsonDocument.Parse("""[{"text":"i"}]""").RootElement.Clone(), Provenance = JsonDocument.Parse("""{"actor":"a"}""").RootElement.Clone(),
                ContentHash = "h", CreatedAt = "c",
            },
            Refs = new List<RefRecord> { new() { Rel = "r", Kind = "fact", Target = "t", Basis = "observed", Seq = 1, Valid = false } },
            Attachments = new List<AttachmentRecord> { new() { Sha256 = "s", Filename = "f", Mime = "m", Bytes = 4 } },
        };
        await Assert.That(Json(show)).IsEqualTo(
            """{"fact":{"id":"f","subject_id":"s","kind":"k","text":"t","data":{"b":1},"items":[{"text":"i"}],"tags":[],"confidence":0,"status":"","provenance":{"actor":"a"},"content_hash":"h","created_at":"c"},"refs":[{"rel":"r","kind":"fact","target":"t","basis":"observed","seq":1,"valid":false}],"attachments":[{"sha256":"s","filename":"f","mime":"m","bytes":4}],"inbound":[]}""");
    }

    [Test]
    public async Task Shape_DumpCorrelateAndRequestTypes()
    {
        var dump = new DumpResponse
        {
            Created = new List<string> { "a" },
            Skipped = new List<SkippedChunk> { new() { Locator = JsonDocument.Parse("""{"line":1}""").RootElement.Clone(), Reason = "r" } },
        };
        await Assert.That(Json(dump)).IsEqualTo("""{"created":["a"],"deduped":[],"skipped":[{"locator":{"line":1},"reason":"r"}],"errors":[]}""");
        var correlate = new CorrelateResponse { Proposed = new List<CorrelationProposal> { new() { FactId = "f", Ref = new RefInput { Rel = "r", Seq = 2 } } }, Truncated = true };
        await Assert.That(Json(correlate)).IsEqualTo("""{"proposed":[{"fact_id":"f","ref":{"rel":"r","seq":2}}],"truncated":true}""");

        // entity_subjects was removed from the contract; an old client that still sends it is ignored.
        var dumpRequest = Parse<DumpRequest>("""{"source":"p","subject":"s","entity_subjects":true,"tags":["t"]}""");
        await Assert.That(dumpRequest.Source).IsEqualTo("p");
        await Assert.That(dumpRequest.Tags![0]).IsEqualTo("t");
        var search = Parse<SearchRequest>("""{"q":"a","ref_target":"x","limit":3,"brief":true}""");
        await Assert.That(search.RefTarget).IsEqualTo("x");
        await Assert.That(search.Brief).IsTrue();
        var check = Parse<CheckRequest>("""{"subject":"s","drafts":[{"kind":"note","text":"d"}],"limit":2}""");
        await Assert.That(check.Drafts![0].Text).IsEqualTo("d");
        var correlateRequest = Parse<CorrelateRequest>("""{"subject":"s","matchers":["m"]}""");
        await Assert.That(correlateRequest.Matchers![0]).IsEqualTo("m");
    }

    [Test]
    public async Task Shape_CliSummaryAndErrorEnvelopeOutputs()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var id = posted.Response.Facts[0].Id;

        var outDir = Path.Combine(db.Directory, "bundle");
        var (publishExit, published, _) = await Run(db.DbPath, "publish", "--out", outDir);
        await Assert.That(publishExit).IsEqualTo(0);
        var summary = JsonDocument.Parse(published.Split('\n')[0]).RootElement;
        await Assert.That(string.Join(",", summary.EnumerateObject().Select(p => p.Name))).IsEqualTo("out,files,written,subjects,facts,removed");

        var importDb = Path.Combine(db.Directory, "import.db");
        var (importExit, imported, _) = await Run(importDb, "import", "--from", outDir);
        await Assert.That(importExit).IsEqualTo(0);
        var importSummary = JsonDocument.Parse(imported).RootElement;
        await Assert.That(string.Join(",", importSummary.EnumerateObject().Select(p => p.Name))).IsEqualTo("subjects,facts,refs,attachments,blobs,skipped");

        var (exit, retracted, _) = await Run(db.DbPath, "retract", id);
        await Assert.That(exit).IsEqualTo(0);
        await Assert.That(retracted.Trim()).IsEqualTo($$"""{"id":"{{id}}","status":"retracted"}""");

        var server = new McpServer(db.Store);
        var reply = server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/call","params":{"name":"get_fact","arguments":{"id":"nope"}}}""")!;
        var text = JsonDocument.Parse(reply.ToJsonString()).RootElement.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString();
        await Assert.That(text).IsEqualTo("""{"error":{"code":"fact_not_found","message":"fact not found: nope"}}""");

        var post = server.Handle("""{"jsonrpc":"2.0","id":2,"method":"tools/call","params":{"name":"post_facts","arguments":{"subject":{"name":"W2"},"facts":[{"kind":"note","text":"x"}],"dry_run":true}}}""")!;
        var postText = JsonDocument.Parse(post.ToJsonString()).RootElement.GetProperty("result").GetProperty("content")[0].GetProperty("text").GetString()!;
        await Assert.That(string.Join(",", JsonDocument.Parse(postText).RootElement.EnumerateObject().Select(p => p.Name))).IsEqualTo("response,errors");
    }

    [Test]
    public async Task Shape_SearchCursorKeepsUpperCasePropertyNames()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("one"), Fixtures.Fact("two"), Fixtures.Fact("three")));
        var page = db.Store.Search(new SearchRequest { Limit = 1 });
        await Assert.That(page.Next).IsNotNull();
        var padded = page.Next!.Replace('-', '+').Replace('_', '/');
        padded += new string('=', (4 - padded.Length % 4) % 4);
        var json = JsonDocument.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(padded))).RootElement;
        await Assert.That(string.Join(",", json.EnumerateObject().Select(p => p.Name))).IsEqualTo("C,I,S");
        var second = db.Store.Search(new SearchRequest { Limit = 1, Cursor = page.Next });
        await Assert.That(second.Hits.Count).IsEqualTo(1);
    }

    [Test]
    public async Task Shape_DumpStoresSnakeCaseDataAndLocators()
    {
        using var db = new TempDb();
        var file = Path.Combine(db.Directory, "sample.py");
        File.WriteAllText(file, "def top(a, b):\n    \"\"\"Doc.\"\"\"\n    return a\n");
        var response = db.Store.Dump(new DumpRequest { Source = file, Subject = "Code/Sample", Split = "none" });
        await Assert.That(response.Created.Count).IsEqualTo(1);

        // The snake_case data-key coverage moved here: dump no longer writes data, so post a fact with it.
        var posted = db.Store.PostFacts(Fixtures.Post("Code/Sample", new FactInput
        {
            Kind = "note",
            Text = "snake case data",
            Data = JsonDocument.Parse("""{"start_line":1,"end_line":3,"entity_kind":"function","symbol":"top"}""").RootElement.Clone(),
        }));
        var dataShow = JsonDocument.Parse(JsonSerializer.Serialize(db.Store.Show(posted.Response.Facts[0].Id)!, JsonCodec.Options)).RootElement;
        var data = dataShow.GetProperty("fact").GetProperty("data");
        await Assert.That(string.Join(",", data.EnumerateObject().Select(p => p.Name))).IsEqualTo("end_line,entity_kind,start_line,symbol");

        var show = db.Store.Show(response.Created[0])!;
        var fact = JsonDocument.Parse(JsonSerializer.Serialize(show, JsonCodec.Options)).RootElement;
        var locator = fact.GetProperty("refs")[0].GetProperty("locator");
        await Assert.That(locator.GetProperty("selector").GetString()!.StartsWith("L1-L", StringComparison.Ordinal)).IsTrue();
        var provenance = fact.GetProperty("fact").GetProperty("provenance").GetRawText();
        await Assert.That(provenance).IsEqualTo("""{"actor":"dossier-cli","actor_type":"tool","channel":"cli","posted_at":""" + JsonSerializer.Serialize(fact.GetProperty("fact").GetProperty("provenance").GetProperty("posted_at").GetString()) + "}");
    }
}
