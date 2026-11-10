using System.Diagnostics;
using System.Text.Json;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class CheckTests
{
    private static long[] Counts(DossierStore store)
    {
        using var connection = store.OpenConnection();
        return new[]
        {
            Fixtures.Count(connection, "SELECT COUNT(*) FROM subjects"),
            Fixtures.Count(connection, "SELECT COUNT(*) FROM facts"),
            Fixtures.Count(connection, "SELECT COUNT(*) FROM refs"),
            Fixtures.Count(connection, "SELECT COUNT(*) FROM slots"),
            Fixtures.Count(connection, "SELECT COUNT(*) FROM facts_fts"),
        };
    }

    private static CheckRequest Req(string subject, params FactInput[] drafts) => new()
    {
        Subject = subject,
        Drafts = drafts.Length == 0 ? null : drafts.ToList(),
    };

    [Test]
    public async Task Check_ResolvesNameAliasPrefixAndFuzzy()
    {
        using var db = new TempDb();
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Billing", Aliases = new List<string> { "Invoices" } }, Facts = { Fixtures.Fact("a") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Payments", Aliases = new List<string> { "Billing Core" } }, Facts = { Fixtures.Fact("b") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Billing Gateway" }, Facts = { Fixtures.Fact("c") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Biling" }, Facts = { Fixtures.Fact("d") } });
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Unrelated" }, Facts = { Fixtures.Fact("e") } });

        var exact = db.Store.Check(new CheckRequest { Subject = "  BILLING ", Limit = 10 });
        await Assert.That(exact.Subject!.Match).IsEqualTo("exact_name");
        await Assert.That(exact.Subject.Name).IsEqualTo("Billing");
        await Assert.That(exact.Subject.Facts).IsEqualTo(1);
        await Assert.That(exact.Subject.Aliases.Contains("Invoices")).IsTrue();
        await Assert.That(exact.Others!.Select(m => m.Match).ToList()).IsEquivalentTo(new[] { "prefix", "prefix", "fuzzy" });

        var alias = db.Store.Check(new CheckRequest { Subject = "invoices" });
        await Assert.That(alias.Subject!.Match).IsEqualTo("exact_alias");
        await Assert.That(alias.Subject.Name).IsEqualTo("Billing");

        var prefix = db.Store.Check(new CheckRequest { Subject = "billing gat" });
        await Assert.That(prefix.Subject!.Match).IsEqualTo("prefix");

        var fuzzy = db.Store.Check(new CheckRequest { Subject = "Bilingg" });
        await Assert.That(fuzzy.Subject!.Match).IsEqualTo("fuzzy");
    }

    [Test]
    public async Task Check_NoMatchReturnsNullSubjectAndZeroSummary()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("a")));

        var result = db.Store.Check(new CheckRequest { Subject = "zzzzzzzzzz" });
        await Assert.That(result.Subject).IsNull();
        await Assert.That(result.Summary.Facts).IsEqualTo(0);
        await Assert.That(result.Drafts).IsNull();
    }

    [Test]
    public async Task Check_SummaryHasCountsAndAtMostEightClaims()
    {
        using var db = new TempDb();
        var facts = Enumerable.Range(0, 12).Select(i => Fixtures.Fact($"claim {i} " + new string('x', 200) + $" unique{i}")).ToList();
        facts.Add(Fixtures.Fact("first", data: Fixtures.Json("""{"owner":"a"}""")));
        facts.Add(Fixtures.Fact("second", data: Fixtures.Json("""{"owner":"b"}""")));
        db.Store.PostFacts(new PostFactsRequest { Subject = new SubjectInput { Name = "Widget" }, Facts = facts });

        var result = db.Store.Check(new CheckRequest { Subject = "widget" });
        await Assert.That(result.Summary.Facts).IsEqualTo(14);
        await Assert.That(result.Summary.Conflicts).IsEqualTo(1);
        await Assert.That(result.Summary.Gaps).IsEqualTo(0);
        await Assert.That(result.Summary.Top.Count).IsEqualTo(8);
        foreach (var top in result.Summary.Top)
        {
            await Assert.That(top.Text.Length).IsLessThanOrEqualTo(120);
            await Assert.That(top.Key).IsNotEmpty();
        }
    }

    [Test]
    public async Task Check_NoDraftsWritesNothing()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body", key: "k", refs: new List<RefInput> { Fixtures.Ref("src/x.cs", kind: "file") })));
        var before = Counts(db.Store);

        db.Store.Check(new CheckRequest { Subject = "Widget" });
        db.Store.Check(new CheckRequest { Subject = "nothing like it" });

        await Assert.That(Counts(db.Store)).IsEquivalentTo(before);
    }

    [Test]
    public async Task Check_DraftsAlsoWriteNothing()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body", key: "k")));
        var before = Counts(db.Store);

        db.Store.Check(Req("Widget", Fixtures.Fact("fresh"), Fixtures.Fact("body2", key: "k")));
        db.Store.Check(Req("Brand New", Fixtures.Fact("fresh")));

        await Assert.That(Counts(db.Store)).IsEquivalentTo(before);
    }

    [Test]
    public async Task Check_DraftVerdictsMatchRealPost()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("already here"), Fixtures.Fact("old value", key: "slot")));

        FactInput[] Drafts() => new[]
        {
            Fixtures.Fact("brand new claim"),
            Fixtures.Fact("already here"),
            Fixtures.Fact("replacement value", key: "slot"),
        };

        var check = db.Store.Check(Req("Widget", Drafts()));
        var real = db.Store.PostFacts(Fixtures.Post("Widget", Drafts()));

        await Assert.That(check.Drafts!.Select(d => d.Status).ToList()).IsEquivalentTo(new[] { "new", "deduped", "replaced" });
        await Assert.That(check.Drafts!.Select(d => d.Status).ToList()).IsEquivalentTo(real.Response.Facts.Select(f => f.Status).ToList());
        await Assert.That(check.Drafts![1].DuplicateOf).IsEqualTo(real.Response.Facts[1].DuplicateOf);
        await Assert.That(check.Drafts![2].Replaced).IsEqualTo(real.Response.Facts[2].Replaced);
        await Assert.That(check.Drafts.Select(d => d.Index).ToList()).IsEquivalentTo(new[] { 0, 1, 2 });
    }

    [Test]
    public async Task Check_ReportsNearButStillPostsSeparately()
    {
        using var db = new TempDb();
        var original = "the billing service retries failed card charges three times with exponential backoff before giving up entirely";
        var nearText = original + " today";
        var posted = db.Store.PostFacts(Fixtures.Post("Billing", Fixtures.Fact(original)));
        var existingId = posted.Response.Facts[0].Id;

        var check = db.Store.Check(Req("Billing", Fixtures.Fact(nearText)));
        await Assert.That(check.Drafts![0].Status).IsEqualTo("new");
        await Assert.That(check.Drafts![0].Near.Contains(existingId)).IsTrue();

        var real = db.Store.PostFacts(Fixtures.Post("Billing", Fixtures.Fact(nearText)));
        await Assert.That(real.Response.Facts[0].Status).IsEqualTo("new");
        await Assert.That(real.Response.Facts[0].Id).IsNotEqualTo(existingId);

        using var connection = db.Store.OpenConnection();
        await Assert.That(Fixtures.Count(connection, "SELECT COUNT(*) FROM facts WHERE status = 'live'")).IsEqualTo(2);
    }

    [Test]
    public async Task Check_NearExcludesAlreadyReportedDuplicates()
    {
        using var db = new TempDb();
        var text = "the billing service retries failed card charges three times with exponential backoff";
        var posted = db.Store.PostFacts(Fixtures.Post("Billing", Fixtures.Fact(text)));

        var check = db.Store.Check(Req("Billing", Fixtures.Fact(text)));
        var verdict = check.Drafts![0];
        await Assert.That(verdict.Status).IsEqualTo("deduped");
        await Assert.That(verdict.DuplicateOf).IsEqualTo(posted.Response.Facts[0].Id);
        await Assert.That(verdict.Near.Count).IsEqualTo(0);
    }

    [Test]
    public async Task Check_FailsClosedLikePost()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var badRef = Fixtures.Fact("x", refs: new List<RefInput> { Fixtures.Ref("src/x.cs", basis: null, kind: "file") });

        var check = db.Store.Check(Req("Widget", Fixtures.Fact("ok"), badRef));
        await Assert.That(check.Drafts!.Count).IsEqualTo(2);
        await Assert.That(check.Drafts![0].Status).IsEqualTo("new");
        await Assert.That(check.Drafts![1].Status).IsEqualTo("error");
        await Assert.That(check.Drafts![1].Error!.Code).IsEqualTo("missing_basis");

        var unknown = Guid.NewGuid().ToString("D");
        var thrown = Assert.Throws<DossierRequestException>(() => db.Store.Check(Req(unknown, Fixtures.Fact("x"))));
        await Assert.That(thrown.Code).IsEqualTo("subject_not_found");
        await Assert.That(Counts(db.Store)[0]).IsEqualTo(1);
    }

    [Test]
    public async Task Check_ResolvesSubjectById()
    {
        using var db = new TempDb();
        var id = db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body"))).Response.Subject.Id;
        var result = db.Store.Check(new CheckRequest { Subject = id });
        await Assert.That(result.Subject!.Name).IsEqualTo("Widget");
    }

    [Test]
    public async Task Check_ReplacesResolve()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));

        var info = new ProcessStartInfo("dotnet") { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        info.ArgumentList.Add("resolve");
        info.ArgumentList.Add("--q");
        info.ArgumentList.Add("widget");
        info.Environment["DOSSIER_DB"] = db.DbPath;
        using var process = Process.Start(info)!;
        await process.StandardOutput.ReadToEndAsync();
        await process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        await Assert.That(process.ExitCode).IsNotEqualTo(0);

        var server = new McpServer(db.Store);
        var list = JsonDocument.Parse(server.Handle("""{"jsonrpc":"2.0","id":1,"method":"tools/list"}""")!.ToJsonString()).RootElement;
        var names = list.GetProperty("result").GetProperty("tools").EnumerateArray().Select(t => t.GetProperty("name").GetString()).ToList();
        await Assert.That(names.Contains("check")).IsTrue();
        await Assert.That(names.Contains("resolve_subject")).IsFalse();
        await Assert.That(names.Count).IsEqualTo(7);
    }

    [Test]
    public async Task Check_CliAcceptsDraftsFileAndPrintsVerdicts()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Widget", Fixtures.Fact("body")));
        var file = Path.Combine(db.Directory, "drafts.json");
        File.WriteAllText(file, """[{"kind":"note","text":"body"},{"kind":"note","text":"other"}]""");

        var info = new ProcessStartInfo("dotnet") { RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false };
        info.ArgumentList.Add(Path.Combine(AppContext.BaseDirectory, "Dossier.dll"));
        foreach (var arg in new[] { "check", "--subject", "widget", "--drafts", file })
        {
            info.ArgumentList.Add(arg);
        }

        info.Environment["DOSSIER_DB"] = db.DbPath;
        using var process = Process.Start(info)!;
        var output = await process.StandardOutput.ReadToEndAsync();
        await process.WaitForExitAsync();
        await Assert.That(process.ExitCode).IsEqualTo(0);
        var drafts = JsonDocument.Parse(output).RootElement.GetProperty("drafts");
        await Assert.That(drafts[0].GetProperty("status").GetString()).IsEqualTo("deduped");
        await Assert.That(drafts[1].GetProperty("status").GetString()).IsEqualTo("new");
    }

    [Test]
    public async Task Skill_DoesNotClaimNearDuplicateStatus()
    {
        var text = File.ReadAllText(RepoFilePath("skills/dossier/SKILL.md"));
        await Assert.That(text.Contains("near_duplicate", StringComparison.Ordinal)).IsFalse();
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

        throw new FileNotFoundException($"could not find {relative}");
    }
}
