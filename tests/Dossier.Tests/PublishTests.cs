using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

public sealed class PublishTests
{
    private static readonly string LongText = string.Join(' ', Enumerable.Range(0, 400).Select(i => $"word{i}"));

    private sealed record Seeded(string AppId, string ScreenId, string[] ScreenFactIds, string PointerId, string TargetId, string LongId, string ConflictAId);

    private static Seeded Seed(TempDb db)
    {
        var app = db.Store.PostFacts(Fixtures.Post(
            "My App",
            Fixtures.Fact("The app is a notes tool.")));
        var appId = app.Response.Subject.Id;

        var screen = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Home Screen", Kind = "screen", Parent = appId },
            Facts =
            {
                Fixtures.Fact("The header is 64 pixels tall.", key: "header-a", data: Fixtures.Json("{\"headerHeight\":64}")),
                Fixtures.Fact("The header is 72 pixels tall.", key: "header-b", data: Fixtures.Json("{\"headerHeight\":72}")),
                Fixtures.Fact("The target fact.", localId: "t"),
                Fixtures.Fact(
                    "The pointer fact.",
                    refs: new List<RefInput>
                    {
                        new() { Rel = "supports", Kind = "fact", Target = "@t", Basis = "observed", Confidence = 0.9, Rev = "abc123" },
                    }),
                Fixtures.Fact(LongText, key: "long"),
            },
        });
        var other = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Settings Screen", Kind = "screen", Parent = appId },
            Facts = { Fixtures.Fact("Settings has a theme toggle.") },
        });

        var ids = screen.Response.Facts.Select(f => f.Id).ToArray();
        _ = other;
        return new Seeded(appId, screen.Response.Subject.Id, ids, ids[3], ids[2], ids[4], ids[0]);
    }

    private static string Out(TempDb db) => Path.Combine(db.Directory, "bundle");

    private static PublishOptions Options(TempDb db, Action<PublishOptions>? tweak = null)
    {
        var options = new PublishOptions { Out = Out(db), Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero) };
        tweak?.Invoke(options);
        return options;
    }

    private static Dictionary<string, string> ReadAll(string dir) =>
        Directory.EnumerateFiles(dir, "*", SearchOption.AllDirectories)
            .ToDictionary(p => Path.GetRelativePath(dir, p).Replace('\\', '/'), File.ReadAllText, StringComparer.Ordinal);

    private static (string Key, string Path) FactOf(Dictionary<string, string> files, string id)
    {
        var facts = JsonDocument.Parse(files["manifest.json"]).RootElement.GetProperty("facts");
        var entry = facts.EnumerateObject().Single(p => p.Value.GetProperty("id").GetString() == id);
        return (entry.Name, entry.Value.GetProperty("path").GetString()!);
    }

    private static bool IsFactFile(string path) =>
        path.StartsWith("subjects/", StringComparison.Ordinal) && path.Contains("/facts/", StringComparison.Ordinal);

    private static bool IsAssetFile(string path) =>
        path.StartsWith("subjects/", StringComparison.Ordinal) && path.Contains("/assets/", StringComparison.Ordinal);

    private static bool IsSubjectIndex(string path) =>
        path.StartsWith("subjects/", StringComparison.Ordinal) && path.EndsWith("/index.md", StringComparison.Ordinal);

    /// <summary>Resolves a relative link written in the bundle file <paramref name="from"/> to a bundle-relative path.</summary>
    private static string Resolve(string from, string target)
    {
        var dir = from.Contains('/') ? from[..from.LastIndexOf('/')] : string.Empty;
        return Path.GetFullPath(Path.Combine("/r", dir, target))[3..];
    }

    private static string FileName(string path) => path[(path.LastIndexOf('/') + 1)..];

    [Test]
    public async Task Publish_WritesFullLayout()
    {
        using var db = new TempDb();
        Seed(db);

        var result = db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        foreach (var required in new[] { "AGENTS.md", "README.md", "INDEX.md", "manifest.json", "conflicts.md", "gaps.md" })
        {
            await Assert.That(files.ContainsKey(required)).IsTrue();
        }

        await Assert.That(files.ContainsKey("subjects/my-app/index.md")).IsTrue();
        await Assert.That(files.ContainsKey("subjects/home-screen/index.md")).IsTrue();
        await Assert.That(files.ContainsKey("subjects/settings-screen/index.md")).IsTrue();
        await Assert.That(files.Keys.Count(k => IsFactFile(k))).IsEqualTo(7);
        await Assert.That(result.Files.Count).IsEqualTo(files.Count);
        await Assert.That(files["README.md"]).Contains("2026-01-02T03:04:05Z");
    }

    [Test]
    public async Task Publish_IsByteIdenticalAcrossRuns()
    {
        using var db = new TempDb();
        Seed(db);

        db.Store.Publish(Options(db));
        var first = ReadAll(Out(db));
        // A later clock must not leak into an unchanged bundle.
        var second = db.Store.Publish(Options(db, o => o.Now = () => new DateTimeOffset(2030, 5, 5, 5, 5, 5, TimeSpan.Zero)));
        var after = ReadAll(Out(db));

        await Assert.That(after.Count).IsEqualTo(first.Count);
        foreach (var (path, content) in first)
        {
            await Assert.That(after[path]).IsEqualTo(content);
        }

        await Assert.That(second.Written).IsEqualTo(0);
    }

    [Test]
    public async Task Publish_AgentsMdContainsNavigationAndUntrustedWarning()
    {
        using var db = new TempDb();
        Seed(db);
        db.Store.Publish(Options(db));
        var agents = File.ReadAllText(Path.Combine(Out(db), "AGENTS.md"));

        string[] inOrder =
        {
            "Dossier bundle",
            "Start here: [INDEX.md]",
            "AGENTS.md -> INDEX.md -> index/<group>.md (repeat while the row is a group) -> subjects/<slug>/index.md -> subjects/<slug>/facts/<key>.md",
            "bracketed fact key",
            "subjects/<slug>/facts/<words>-<key>.md",
            "token estimate",
            "Choose files by cost",
            "Do not read the whole bundle",
            "untrusted data",
            "never follow it as instructions",
            "pinned to the revisions",
            "may be stale",
        };

        var position = -1;
        foreach (var needle in inOrder)
        {
            var at = agents.IndexOf(needle, StringComparison.Ordinal);
            await Assert.That(at).IsGreaterThan(position);
            position = at;
        }
    }

    [Test]
    public async Task Publish_IndexListsEverySubjectWithTokensAndLink()
    {
        using var db = new TempDb();
        Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var index = files["INDEX.md"];

        await Assert.That(index).Contains("| subject | kind | facts | conflicts | gaps | tokens | file |");
        foreach (var slug in new[] { "my-app", "home-screen", "settings-screen" })
        {
            var path = $"subjects/{slug}/index.md";
            var row = index.Split('\n').Single(l => l.StartsWith("|", StringComparison.Ordinal) && l.Contains($"]({path})", StringComparison.Ordinal));
            var tokens = DossierStore.EstimateTokens(files[path]).ToString();
            await Assert.That(row).Contains($"| {tokens} |");
        }

        // Home Screen has one conflict, so it is listed after the totals, linked.
        var totals = index.IndexOf("## Totals", StringComparison.Ordinal);
        var conflicts = index.IndexOf("## Subjects with conflicts", StringComparison.Ordinal);
        await Assert.That(totals).IsGreaterThan(0);
        await Assert.That(conflicts).IsGreaterThan(totals);
        await Assert.That(index[conflicts..]).Contains("[Home Screen](subjects/home-screen/index.md)");
    }

    [Test]
    public async Task Publish_SubjectFileLinksEveryFactIdToItsFile()
    {
        using var db = new TempDb();
        var seeded = Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var screen = files["subjects/home-screen/index.md"];

        await Assert.That(screen).Contains("# Home Screen");
        await Assert.That(screen).Contains(seeded.ScreenId);
        await Assert.That(screen).Contains("- Budget: 1200 tokens");
        await Assert.That(screen).Contains("- Used: ");
        await Assert.That(screen).Contains("- Conflicts: 1");
        await Assert.That(screen).Contains("- Gaps: 0");
        foreach (var id in seeded.ScreenFactIds)
        {
            var (key, path) = FactOf(files, id);
            await Assert.That(screen).Contains($"[{key}]({path["subjects/home-screen/".Length..]})");
            await Assert.That(files.ContainsKey(path)).IsTrue();
        }

        await Assert.That(screen).Contains("## Conflicts");
        await Assert.That(screen).Contains("headerHeight");
    }

    [Test]
    public async Task Publish_FactFileHasFullTextRefsAndInbound()
    {
        using var db = new TempDb();
        var seeded = Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var (pointerKey, pointerPath) = FactOf(files, seeded.PointerId);
        var (targetKey, targetPath) = FactOf(files, seeded.TargetId);
        var pointer = files[pointerPath];
        await Assert.That(pointer).Contains("The pointer fact.");
        await Assert.That(pointer).Contains("- Kind: note");
        await Assert.That(pointer).Contains("- Status: live");
        await Assert.That(pointer).Contains("- Confidence: 1");
        await Assert.That(pointer).Contains("- actor: `dossier-cli`");
        await Assert.That(pointer).Contains("- actor_type: `tool`");
        await Assert.That(pointer).Contains("- channel: `cli`");
        await Assert.That(pointer).Contains("- posted_at: ");
        await Assert.That(pointer).Contains("- rel: supports");
        await Assert.That(pointer).Contains($"- target: [{targetKey}]({FileName(targetPath)})");
        await Assert.That(pointer).Contains("- basis: observed");
        await Assert.That(pointer).Contains("- confidence: 0.9");
        await Assert.That(pointer).Contains("- locator: none");
        await Assert.That(pointer).Contains("rev: `abc123`");
        await Assert.That(pointer).Contains("(../index.md)");

        var target = files[targetPath];
        await Assert.That(target).Contains("## Referenced by");
        await Assert.That(target).Contains($"[{pointerKey}]({FileName(pointerPath)})");

        var conflicted = files[FactOf(files, seeded.ConflictAId).Path];
        await Assert.That(conflicted).Contains("```json");
        await Assert.That(conflicted).Contains("\"headerHeight\": 64");
    }

    [Test]
    public async Task Publish_ManifestIsSortedAndComplete()
    {
        using var db = new TempDb();
        var seeded = Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var manifest = JsonDocument.Parse(files["manifest.json"]).RootElement;

        string[] keys = manifest.EnumerateObject().Select(p => p.Name).ToArray();
        await Assert.That(keys.SequenceEqual(keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        foreach (var section in new[] { "subjects", "facts", "tokens", "options" })
        {
            var names = manifest.GetProperty(section).EnumerateObject().Select(p => p.Name).ToArray();
            await Assert.That(names.SequenceEqual(names.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        }

        var listed = manifest.GetProperty("files").EnumerateArray().Select(e => e.GetString()!).ToArray();
        await Assert.That(listed.SequenceEqual(listed.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        await Assert.That(listed.OrderBy(k => k, StringComparer.Ordinal).SequenceEqual(files.Keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();

        var home = manifest.GetProperty("subjects").GetProperty(seeded.ScreenId);
        await Assert.That(home.GetProperty("slug").GetString()).IsEqualTo("home-screen");
        await Assert.That(home.GetProperty("path").GetString()).IsEqualTo("subjects/home-screen/index.md");
        var (pointerKey, pointerPath) = FactOf(files, seeded.PointerId);
        var pointerEntry = manifest.GetProperty("facts").GetProperty(pointerKey);
        await Assert.That(pointerEntry.GetProperty("path").GetString()).IsEqualTo(pointerPath);
        await Assert.That(pointerEntry.GetProperty("id").GetString()).IsEqualTo(seeded.PointerId);
        await Assert.That(pointerEntry.GetProperty("subject_slug").GetString()).IsEqualTo("home-screen");
        await Assert.That(manifest.GetProperty("tokens").GetProperty("INDEX.md").GetInt32())
            .IsEqualTo(DossierStore.EstimateTokens(files["INDEX.md"]));
        await Assert.That(manifest.GetProperty("options").GetProperty("budget").GetInt32()).IsEqualTo(1200);
        await Assert.That(manifest.GetProperty("options").GetProperty("depth").GetString()).IsEqualTo("full");
        await Assert.That(manifest.GetProperty("options").GetProperty("facts").GetString()).IsEqualTo("detail");
        await Assert.That(files["manifest.json"]).DoesNotContain("2026-01-02");
    }

    [Test]
    public async Task Publish_RepublishRemovesStaleAndPreservesForeignFiles()
    {
        using var db = new TempDb();
        var seeded = Seed(db);
        db.Store.Publish(Options(db));
        var gone = FactOf(ReadAll(Out(db)), seeded.LongId).Path;

        var foreign = Path.Combine(Out(db), "notes.txt");
        var foreignInSubjects = Path.Combine(Out(db), "subjects", "mine.md");
        File.WriteAllText(foreign, "keep me");
        File.WriteAllText(foreignInSubjects, "keep me too");

        db.Store.Publish(Options(db));
        await Assert.That(File.Exists(foreign)).IsTrue();

        db.Store.Retract(seeded.LongId);
        var result = db.Store.Publish(Options(db));

        await Assert.That(File.Exists(Path.Combine(Out(db), gone))).IsFalse();
        await Assert.That(result.Removed).Contains(gone);
        await Assert.That(File.ReadAllText(foreign)).IsEqualTo("keep me");
        await Assert.That(File.ReadAllText(foreignInSubjects)).IsEqualTo("keep me too");
        await Assert.That(File.ReadAllText(Path.Combine(Out(db), "manifest.json"))).DoesNotContain(seeded.LongId);
        await Assert.That(File.ReadAllText(Path.Combine(Out(db), "INDEX.md"))).Contains("| 4 |");
    }

    [Test]
    public async Task Publish_SubjectFilterScopesToSubtree()
    {
        using var db = new TempDb();
        Seed(db);

        var filtered = db.Store.Publish(Options(db, o => o.Subject = "Home Screen"));
        var files = ReadAll(Out(db));

        await Assert.That(filtered.Subjects).IsEqualTo(1);
        await Assert.That(files.ContainsKey("subjects/home-screen/index.md")).IsTrue();
        await Assert.That(files.ContainsKey("subjects/my-app/index.md")).IsFalse();
        await Assert.That(files.ContainsKey("subjects/settings-screen/index.md")).IsFalse();
        await Assert.That(files.Keys.Count(k => IsFactFile(k))).IsEqualTo(5);

        var wide = db.Store.Publish(Options(db, o =>
        {
            o.Out = Path.Combine(db.Directory, "wide");
            o.Subject = "My App";
        }));
        await Assert.That(wide.Subjects).IsEqualTo(3);
    }

    [Test]
    public async Task Publish_FactsNoneOmitsFactFiles()
    {
        using var db = new TempDb();
        Seed(db);

        db.Store.Publish(Options(db));
        db.Store.Publish(Options(db, o => o.Facts = "none"));
        var files = ReadAll(Out(db));

        await Assert.That(files.Keys.Any(k => IsFactFile(k))).IsFalse();
        await Assert.That(Directory.Exists(Path.Combine(Out(db), "facts"))).IsFalse();
        await Assert.That(files["subjects/home-screen/index.md"]).DoesNotContain("facts/");
        await Assert.That(files["AGENTS.md"]).Contains("--facts none");
        await Assert.That(files.ContainsKey("INDEX.md")).IsTrue();
    }

    [Test]
    public async Task Publish_NeverTruncatesFactText()
    {
        using var db = new TempDb();
        var seeded = Seed(db);

        db.Store.Publish(Options(db, o => o.Depth = "index"));
        var files = ReadAll(Out(db));

        var longPath = FactOf(files, seeded.LongId).Path;
        await Assert.That(files[longPath]).Contains(LongText);
        await Assert.That(files[longPath]).DoesNotContain("...");

        db.Store.Publish(Options(db, o => o.Depth = "full"));
        await Assert.That(File.ReadAllText(Path.Combine(Out(db), "subjects", "home-screen", "index.md"))).Contains(LongText);
    }

    [Test]
    public async Task Publish_IndexShowsOwnNameAndIndentsByDepth()
    {
        using var db = new TempDb();
        var root = db.Store.PostFacts(Fixtures.Post("Memos", Fixtures.Fact("Memos is a notes app.")));
        var rootId = root.Response.Subject.Id;
        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Memos/Archived", Kind = "screen", Parent = rootId },
            Facts = { Fixtures.Fact("Archived memos live here.") },
        });

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var index = files["INDEX.md"];

        static string SubjectCell(string index, string slug)
        {
            var file = $"subjects/{slug}/index.md";
            var row = index.Split('\n').Single(l => l.StartsWith("|", StringComparison.Ordinal) && l.Contains($"]({file})", StringComparison.Ordinal));
            // Column 0 is the empty text before the leading '|'; column 1 is the subject cell.
            // Drop exactly the single space that separates the cell from its '|'.
            return row.Split('|')[1][1..];
        }

        var childCell = SubjectCell(index, "memos-archived");
        var rootCell = SubjectCell(index, "memos");

        // The child's own name is shown once, with no parent prefix.
        await Assert.That(childCell.TrimEnd()).IsEqualTo("  Memos/Archived");
        await Assert.That(Count(childCell, "Memos/Archived")).IsEqualTo(1);
        await Assert.That(childCell.Contains("Memos / ", StringComparison.Ordinal)).IsFalse();

        // A direct child of the root is indented two spaces; a root subject starts at column zero.
        await Assert.That(childCell.StartsWith("  ", StringComparison.Ordinal)).IsTrue();
        await Assert.That(rootCell.TrimEnd()).IsEqualTo("Memos");
        await Assert.That(rootCell.StartsWith("Memos", StringComparison.Ordinal)).IsTrue();

        // The subject file's own H1 still shows the full subject name.
        await Assert.That(files["subjects/memos-archived/index.md"]).Contains("# Memos/Archived");
    }

    private static int Count(string haystack, string needle)
    {
        var count = 0;
        var at = 0;
        while ((at = haystack.IndexOf(needle, at, StringComparison.Ordinal)) >= 0)
        {
            count++;
            at += needle.Length;
        }

        return count;
    }

    [Test]
    public async Task Publish_SlugCollisionsGetDeterministicSuffixes()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Same Name!", Fixtures.Fact("first")));
        db.Store.PostFacts(Fixtures.Post("same-name", Fixtures.Fact("second")));

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        await Assert.That(files.ContainsKey("subjects/same-name/index.md")).IsTrue();
        await Assert.That(files.ContainsKey("subjects/same-name-2/index.md")).IsTrue();
        await Assert.That(DossierStore.Slugify("  Héllo / World!! ")).IsEqualTo("h-llo-world");
        await Assert.That(DossierStore.Slugify("***")).IsEqualTo("subject");
    }

    private static string Sha8(string input) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(input))).ToLowerInvariant()[..8];

    private static readonly Regex GuidPattern = new("[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}", RegexOptions.Compiled);

    private static void SeedLogical(TempDb db)
    {
        var app = db.Store.PostFacts(Fixtures.Post("Logical App", Fixtures.Fact("The logical app exists.")));
        var parent = app.Response.Subject.Id;
        var facts = new List<FactInput>();
        for (var i = 0; i < 9; i++)
        {
            facts.Add(Fixtures.Fact(
                $"Logical fact number {i} about area{i}.",
                key: i % 3 == 0 ? $"k{i}" : null,
                localId: i < 2 ? $"h{i}" : null,
                refs: i >= 2 ? new List<RefInput> { Fixtures.Ref($"@h{i % 2}") } : null,
                data: i % 2 == 0 ? Fixtures.Json($"{{\"b\": {i}, \"a\": \"v{i}\"}}") : null));
        }

        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Logical Screen", Kind = "screen", Parent = parent },
            Facts = facts,
        });
        db.Store.PostFacts(Fixtures.Post("Other Screen", Fixtures.Fact("Another  logical\tfact.")));
        db.Store.PostFacts(Fixtures.Post("Third Screen", Fixtures.Fact("Third logical fact.")));
    }

    [Test]
    public async Task Publish_FactFileNameIsContentAddressed()
    {
        using var db = new TempDb();
        var post = db.Store.PostFacts(Fixtures.Post("Naming", Fixtures.Fact("The Quick  brown fox, jumps over the lazy dog!")));
        var id = post.Response.Facts[0].Id;

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var key = Sha8("The Quick brown fox, jumps over the lazy dog!\u001f\u001fnote\u001f");
        var expected = $"subjects/naming/facts/the-quick-brown-fox-jumps-over-{key}.md";
        await Assert.That(files.ContainsKey(expected)).IsTrue();
        await Assert.That(FactOf(files, id).Path).IsEqualTo(expected);
        await Assert.That(key.Length).IsEqualTo(8);
        await Assert.That(GuidPattern.IsMatch(expected)).IsFalse();
        await Assert.That(expected.Contains(id[..8], StringComparison.Ordinal)).IsFalse();
        await Assert.That(files[expected]).Contains($"# Fact {key}");
    }

    [Test]
    public async Task Publish_BundleIsStableAcrossIndependentSeeds()
    {
        using var first = new TempDb();
        using var second = new TempDb();
        SeedLogical(first);
        SeedLogical(second);
        // posted_at is the wall clock at post time and the store has no clock seam, so pin it:
        // the two seeds are otherwise the same logical content.
        foreach (var db in new[] { first, second })
        {
            using var connection = db.Store.OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE facts SET provenance = json_set(provenance, '$.posted_at', '2026-01-01T00:00:00Z')";
            command.ExecuteNonQuery();
        }

        first.Store.Publish(Options(first));
        second.Store.Publish(Options(second));
        var a = ReadAll(Out(first)).Where(kv => IsFactFile(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
        var b = ReadAll(Out(second)).Where(kv => IsFactFile(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);

        // Store ids are random per seed: the Store id line and the ids inside the machine record
        // (id, subject_id, fact-ref targets) are the only content allowed to differ.
        static string Strip(string content) =>
            Regex.Replace(
                string.Join('\n', content.Split('\n').Where(l => !l.StartsWith("Store id:", StringComparison.Ordinal))),
                "[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}",
                "<id>");

        await Assert.That(a.Count).IsEqualTo(12);
        await Assert.That(a.Keys.OrderBy(k => k, StringComparer.Ordinal).SequenceEqual(b.Keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        foreach (var (path, content) in a)
        {
            await Assert.That(Strip(b[path])).IsEqualTo(Strip(content));
        }
    }

    [Test]
    public async Task Publish_CitationsUseBundleKeysAndResolve()
    {
        using var db = new TempDb();
        Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var anchor = new Regex(@"\[([^\]]+)\]\((facts/[^)]+\.md)\)");
        var total = 0;
        foreach (var (path, content) in files.Where(kv => IsSubjectIndex(kv.Key)))
        {
            foreach (Match match in anchor.Matches(content))
            {
                total++;
                await Assert.That(files.ContainsKey(Resolve(path, match.Groups[2].Value))).IsTrue();
                await Assert.That(match.Groups[1].Value.Length).IsEqualTo(8);
                await Assert.That(GuidPattern.IsMatch(match.Groups[1].Value)).IsFalse();
                await Assert.That(match.Groups[2].Value).Contains("-" + match.Groups[1].Value + ".md");
            }
        }

        await Assert.That(total).IsGreaterThan(0);
        // Every claim line in a subject file ends in a bracketed key link.
        foreach (var line in files["subjects/home-screen/index.md"].Split('\n').Where(l => l.StartsWith("- ", StringComparison.Ordinal)).Skip(0))
        {
            if (line.Contains("](facts/", StringComparison.Ordinal))
            {
                await Assert.That(anchor.IsMatch(line)).IsTrue();
            }
        }
    }

    [Test]
    public async Task Publish_KeyCollisionWidensDeterministically()
    {
        static string Collide(string input) =>
            input.Contains("twin", StringComparison.Ordinal)
                ? "deadbeef" + Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(input))).ToLowerInvariant()[8..]
                : Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(input))).ToLowerInvariant();

        HashSet<string> Run()
        {
            using var db = new TempDb();
            db.Store.PostFacts(Fixtures.Post("Twins", new FactInput[]
            {
                Fixtures.Fact("twin fact", key: "a", data: Fixtures.Json("{\"v\":1}")),
                Fixtures.Fact("twin fact", key: "b", data: Fixtures.Json("{\"v\":1}")),
                Fixtures.Fact("plain fact"),
            }));
            db.Store.Publish(Options(db, o => o.BundleHash = Collide));
            return ReadAll(Out(db)).Keys.Where(k => IsFactFile(k)).ToHashSet(StringComparer.Ordinal);
        }

        var first = Run();
        var second = Run();

        await Assert.That(first.Count).IsEqualTo(3);
        await Assert.That(first.SetEquals(second)).IsTrue();
        var twins = first.Where(k => k.StartsWith("subjects/twins/facts/twin-fact-", StringComparison.Ordinal)).ToList();
        await Assert.That(twins.Count).IsEqualTo(2);
        foreach (var twin in twins)
        {
            var key = twin["subjects/twins/facts/twin-fact-".Length..^3];
            await Assert.That(key.Length).IsEqualTo(12);
            await Assert.That(key).StartsWith("deadbeef");
        }

        var plain = first.Single(k => k.StartsWith("subjects/twins/facts/plain-fact-", StringComparison.Ordinal));
        await Assert.That(plain["subjects/twins/facts/plain-fact-".Length..^3].Length).IsEqualTo(8);
    }

    [Test]
    public async Task Publish_FactFileKeepsStoreId()
    {
        using var db = new TempDb();
        var seeded = Seed(db);
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        foreach (var id in seeded.ScreenFactIds)
        {
            var lines = files[FactOf(files, id).Path].Split('\n').Where(l => l.StartsWith("Store id: ", StringComparison.Ordinal)).ToList();
            await Assert.That(lines.Count).IsEqualTo(1);
            await Assert.That(lines[0]).IsEqualTo("Store id: " + id);
        }
    }

    // ---- assets ----------------------------------------------------------------------------

    private sealed record Shot(string Sha, byte[] Bytes, string Filename, string Mime);

    private static Shot WriteBlob(TempDb db, string content, string filename, string mime)
    {
        var bytes = Encoding.UTF8.GetBytes(content);
        var sha = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
        Directory.CreateDirectory(db.Store.BlobRoot);
        File.WriteAllBytes(Path.Combine(db.Store.BlobRoot, sha), bytes);
        return new Shot(sha, bytes, filename, mime);
    }

    private static FactInput ShotFact(string text, Shot shot) => Fixtures.Fact(
        text,
        attachments: new List<AttachmentInput>
        {
            new() { Sha256 = shot.Sha, Filename = shot.Filename, Mime = shot.Mime, Bytes = shot.Bytes.Length },
        });

    private static PostFactsRequest ShotRequest(string subject, params FactInput[] facts)
    {
        var request = new PostFactsRequest { Subject = new SubjectInput { Name = subject, Kind = "screen" } };
        request.Facts.AddRange(facts);
        return request;
    }

    [Test]
    public async Task Publish_WritesAssetFilesPerSubject()
    {
        using var db = new TempDb();
        var one = WriteBlob(db, "first screenshot bytes", "shots/Login Screen.PNG", "image/png");
        var two = WriteBlob(db, "second document bytes!!", "notes", "application/pdf");
        db.Store.PostFacts(ShotRequest("Login", ShotFact("Shows the login form.", one), ShotFact("Has a spec sheet.", two)));

        var result = db.Store.Publish(Options(db));

        var first = $"subjects/login/assets/{one.Sha[..8]}-login-screen.png";
        var second = $"subjects/login/assets/{two.Sha[..8]}-notes.pdf";
        await Assert.That(File.ReadAllBytes(Path.Combine(Out(db), first)).SequenceEqual(one.Bytes)).IsTrue();
        await Assert.That(File.ReadAllBytes(Path.Combine(Out(db), second)).SequenceEqual(two.Bytes)).IsTrue();
        await Assert.That(new FileInfo(Path.Combine(Out(db), second)).Length).IsEqualTo((long)two.Bytes.Length);
        await Assert.That(result.Files.Contains(first)).IsTrue();
        await Assert.That(result.Warnings.Count).IsEqualTo(0);

        var manifest = JsonDocument.Parse(File.ReadAllText(Path.Combine(Out(db), "manifest.json"))).RootElement;
        var entry = manifest.GetProperty("assets").GetProperty(first);
        await Assert.That(entry.GetProperty("sha256").GetString()).IsEqualTo(one.Sha);
        await Assert.That(entry.GetProperty("bytes").GetInt64()).IsEqualTo((long)one.Bytes.Length);
        await Assert.That(entry.GetProperty("mime").GetString()).IsEqualTo("image/png");
        await Assert.That(entry.GetProperty("missing").GetBoolean()).IsFalse();
        await Assert.That(manifest.GetProperty("files").EnumerateArray().Any(e => e.GetString() == first)).IsTrue();
    }

    [Test]
    public async Task Publish_SubjectFileLinksAssetsWithCorrectRelativePath()
    {
        using var db = new TempDb();
        var one = WriteBlob(db, "alpha", "a.png", "image/png");
        var two = WriteBlob(db, "beta", "b", "image/jpeg");
        db.Store.PostFacts(ShotRequest("Login", ShotFact("Shows the login form.", one), ShotFact("Has a second view.", two)));

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var link = new Regex(@"\]\(((?:\.\./)?assets/[^)]+)\)");

        var subject = files["subjects/login/index.md"];
        await Assert.That(subject).Contains("## Assets");
        var subjectLinks = link.Matches(subject).Select(m => m.Groups[1].Value).ToList();
        await Assert.That(subjectLinks.Count).IsEqualTo(2);
        foreach (var rel in subjectLinks)
        {
            await Assert.That(File.Exists(Path.GetFullPath(Path.Combine(Out(db), "subjects", "login", rel)))).IsTrue();
        }

        var factFiles = files.Where(kv => IsFactFile(kv.Key) && kv.Value.Contains("## Attachments")).ToList();
        await Assert.That(factFiles.Count).IsEqualTo(2);
        foreach (var (_, content) in factFiles)
        {
            var links = link.Matches(content).Select(m => m.Groups[1].Value).ToList();
            await Assert.That(links.Count).IsEqualTo(1);
            await Assert.That(links[0]).StartsWith("../assets/");
            await Assert.That(File.Exists(Path.GetFullPath(Path.Combine(Out(db), "subjects", "login", "facts", links[0])))).IsTrue();
        }

        await Assert.That(subject).Contains("(image/png, 5 bytes, from [");
        await Assert.That(subjectLinks.Any(l => l.EndsWith("-b.jpg", StringComparison.Ordinal))).IsTrue();
    }

    [Test]
    public async Task Publish_MissingBlobIsFailOpen()
    {
        using var db = new TempDb();
        var gone = WriteBlob(db, "will vanish", "gone.png", "image/png");
        var kept = WriteBlob(db, "stays here", "kept.png", "image/png");
        db.Store.PostFacts(ShotRequest("Login", ShotFact("Has a vanished shot.", gone), ShotFact("Has a kept shot.", kept)));
        File.Delete(Path.Combine(db.Store.BlobRoot, gone.Sha));

        var result = db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        await Assert.That(result.Warnings.Count).IsEqualTo(1);
        await Assert.That(result.Warnings[0]).Contains(gone.Sha);
        await Assert.That(files["subjects/login/index.md"]).Contains("MISSING " + gone.Sha);
        await Assert.That(files.Where(kv => IsFactFile(kv.Key)).Any(kv => kv.Value.Contains("MISSING " + gone.Sha))).IsTrue();
        await Assert.That(files.Keys.Any(k => IsAssetFile(k) && k.Contains(gone.Sha[..8], StringComparison.Ordinal))).IsFalse();
        await Assert.That(files.Keys.Count(k => IsAssetFile(k))).IsEqualTo(1);

        var assets = JsonDocument.Parse(files["manifest.json"]).RootElement.GetProperty("assets");
        var entry = assets.GetProperty($"subjects/login/assets/{gone.Sha[..8]}-gone.png");
        await Assert.That(entry.GetProperty("missing").GetBoolean()).IsTrue();
        await Assert.That(entry.GetProperty("sha256").GetString()).IsEqualTo(gone.Sha);
        await Assert.That(assets.GetProperty($"subjects/login/assets/{kept.Sha[..8]}-kept.png").GetProperty("missing").GetBoolean()).IsFalse();
    }

    [Test]
    public async Task Publish_AssetsNoneOmitsDirectory()
    {
        using var db = new TempDb();
        var one = WriteBlob(db, "alpha", "a.png", "image/png");
        db.Store.PostFacts(ShotRequest("Login", ShotFact("Shows the login form.", one)));

        db.Store.Publish(Options(db, o => o.Assets = "none"));
        var files = ReadAll(Out(db));

        await Assert.That(Directory.Exists(Path.Combine(Out(db), "assets"))).IsFalse();
        await Assert.That(files.Keys.Any(k => IsAssetFile(k))).IsFalse();
        await Assert.That(files["subjects/login/index.md"]).Contains("`" + one.Sha + "` (image/png, 5 bytes, from [");
        await Assert.That(files["subjects/login/index.md"]).DoesNotContain("assets/");
        foreach (var fact in files.Where(kv => IsFactFile(kv.Key) && kv.Value.Contains("## Attachments")))
        {
            var section = fact.Value[fact.Value.IndexOf("## Attachments", StringComparison.Ordinal)..];
            section = section[..section.IndexOf("## Referenced by", StringComparison.Ordinal)];
            await Assert.That(section).DoesNotContain("](");
            await Assert.That(fact.Value).DoesNotContain("../assets");
        }

        var manifest = JsonDocument.Parse(files["manifest.json"]).RootElement;
        await Assert.That(manifest.GetProperty("assets").EnumerateObject().Count()).IsEqualTo(0);
    }

    [Test]
    public async Task Publish_RepublishRemovesStaleAssets()
    {
        using var db = new TempDb();
        var one = WriteBlob(db, "alpha", "a.png", "image/png");
        var posted = db.Store.PostFacts(ShotRequest("Login", ShotFact("Shows the login form.", one), Fixtures.Fact("A plain fact.")));
        var withAsset = posted.Response.Facts[0].Id;

        db.Store.Publish(Options(db));
        var assetPath = Path.Combine(Out(db), $"subjects/login/assets/{one.Sha[..8]}-a.png");
        var foreign = Path.Combine(Out(db), "subjects", "login", "assets", "mine.txt");
        File.WriteAllText(foreign, "not generated");
        await Assert.That(File.Exists(assetPath)).IsTrue();

        db.Store.Retract(withAsset);
        var result = db.Store.Publish(Options(db));

        await Assert.That(File.Exists(assetPath)).IsFalse();
        await Assert.That(result.Removed.Contains($"subjects/login/assets/{one.Sha[..8]}-a.png")).IsTrue();
        await Assert.That(File.Exists(foreign)).IsTrue();
        await Assert.That(JsonDocument.Parse(File.ReadAllText(Path.Combine(Out(db), "manifest.json"))).RootElement
            .GetProperty("assets").EnumerateObject().Count()).IsEqualTo(0);
    }

    [Test]
    public async Task Publish_AssetNamesAreStableAcrossStores()
    {
        using var one = new TempDb();
        using var two = new TempDb();
        var shotOne = WriteBlob(one, "identical bytes", "Home Page.png", "image/png");
        var shotTwo = WriteBlob(two, "identical bytes", "Home Page.png", "image/png");
        one.Store.PostFacts(ShotRequest("Home", ShotFact("Home has a hero image.", shotOne)));
        two.Store.PostFacts(ShotRequest("Home", ShotFact("Home has a hero image.", shotTwo)));

        one.Store.Publish(Options(one));
        two.Store.Publish(Options(two));

        string[] AssetPaths(TempDb db) => ReadAll(Out(db)).Keys.Where(k => IsAssetFile(k)).OrderBy(k => k, StringComparer.Ordinal).ToArray();
        var a = AssetPaths(one);
        var b = AssetPaths(two);
        await Assert.That(a.Length).IsEqualTo(1);
        await Assert.That(a[0]).IsEqualTo($"subjects/home/assets/{shotOne.Sha[..8]}-home-page.png");
        await Assert.That(b.SequenceEqual(a)).IsTrue();
        await Assert.That(File.ReadAllBytes(Path.Combine(Out(one), a[0])).SequenceEqual(File.ReadAllBytes(Path.Combine(Out(two), b[0])))).IsTrue();
    }

    // ---- tiered index ----------------------------------------------------------------------

    private static void SeedTree(TempDb db, int areas, int itemsPerArea)
    {
        for (var a = 0; a < areas; a++)
        {
            for (var i = 0; i < itemsPerArea; i++)
            {
                db.Store.PostFacts(Fixtures.Post($"area-{a:00}/item-{i:00}", Fixtures.Fact($"Item {i} of area {a} does something.")));
            }
        }
    }

    private static Dictionary<string, string> IndexFiles(Dictionary<string, string> files) =>
        files.Where(kv => kv.Key == "INDEX.md" || kv.Key.StartsWith("index/", StringComparison.Ordinal))
            .ToDictionary(kv => kv.Key, kv => kv.Value, StringComparer.Ordinal);

    [Test]
    public async Task Publish_IndexRespectsTokenCap()
    {
        using var db = new TempDb();
        SeedTree(db, 20, 20);

        // The single flat index would be far over the cap.
        var cap = 1500;
        db.Store.Publish(Options(db, o => o.IndexMaxTokens = 1_000_000));
        var single = File.ReadAllText(Path.Combine(Out(db), "INDEX.md"));
        await Assert.That(DossierStore.EstimateTokens(single)).IsGreaterThan(cap);

        db.Store.Publish(Options(db, o => o.IndexMaxTokens = cap));
        var indexes = IndexFiles(ReadAll(Out(db)));
        await Assert.That(indexes.Count).IsGreaterThan(1);
        foreach (var (path, content) in indexes)
        {
            await Assert.That(DossierStore.EstimateTokens(content)).IsLessThanOrEqualTo(cap);
        }

        var root = indexes["INDEX.md"];
        await Assert.That(root).Contains($"- Index files: {indexes.Count}");
        var largest = indexes.Values.Max(DossierStore.EstimateTokens);
        await Assert.That(root).Contains($"- Largest index file, tokens: {largest}");
    }

    [Test]
    public async Task Publish_IndexIsDeterministic()
    {
        using var one = new TempDb();
        using var two = new TempDb();
        SeedTree(one, 12, 12);
        SeedTree(two, 12, 12);

        one.Store.Publish(Options(one, o => o.IndexMaxTokens = 800));
        two.Store.Publish(Options(two, o => o.IndexMaxTokens = 800));
        one.Store.Publish(Options(one, o => o.IndexMaxTokens = 800));

        var a = IndexFiles(ReadAll(Out(one)));
        var b = IndexFiles(ReadAll(Out(two)));
        await Assert.That(a.Count).IsGreaterThan(1);
        await Assert.That(a.Keys.OrderBy(k => k, StringComparer.Ordinal).SequenceEqual(b.Keys.OrderBy(k => k, StringComparer.Ordinal))).IsTrue();
        foreach (var (path, content) in a)
        {
            await Assert.That(b[path]).IsEqualTo(content);
        }
    }

    [Test]
    public async Task Publish_IndexLinksResolveAndReachEverySubject()
    {
        using var db = new TempDb();
        SeedTree(db, 15, 15);
        db.Store.PostFacts(Fixtures.Post("Top Level", Fixtures.Fact("Lives at the root.")));
        db.Store.Publish(Options(db, o => o.IndexMaxTokens = 700));
        var files = ReadAll(Out(db));

        var link = new Regex(@"\]\(([^)]+)\)", RegexOptions.Compiled);
        // Every link in every index file exists.
        foreach (var (path, content) in IndexFiles(files))
        {
            foreach (Match m in link.Matches(content))
            {
                var target = m.Groups[1].Value;
                if (target.EndsWith(".md", StringComparison.Ordinal) && !target.StartsWith("http", StringComparison.Ordinal))
                {
                    await Assert.That(files.ContainsKey(Resolve(path, target))).IsTrue();
                }
            }
        }

        // Follow only group rows from INDEX.md; collect subject files reached.
        var seen = new HashSet<string>(StringComparer.Ordinal);
        var reached = new HashSet<string>(StringComparer.Ordinal);
        var queue = new Queue<string>();
        queue.Enqueue("INDEX.md");
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (!seen.Add(current))
            {
                continue;
            }

            foreach (var row in files[current].Split('\n').Where(l => l.StartsWith("| ", StringComparison.Ordinal) && !l.StartsWith("| ---", StringComparison.Ordinal) && !l.StartsWith("| subject", StringComparison.Ordinal)))
            {
                var cells = row.Split('|');
                var target = link.Match(cells[^2]).Groups[1].Value;
                var resolved = Resolve(current, target);
                if (cells[2].Trim() == "group")
                {
                    queue.Enqueue(resolved);
                }
                else
                {
                    reached.Add(resolved);
                }
            }
        }

        var subjectFiles = files.Keys.Where(IsSubjectIndex).ToHashSet(StringComparer.Ordinal);
        await Assert.That(subjectFiles.Count).IsEqualTo(15 * 15 + 1);
        await Assert.That(reached.SetEquals(subjectFiles)).IsTrue();
        await Assert.That(seen.Count).IsEqualTo(IndexFiles(files).Count);
    }

    [Test]
    public async Task Publish_IndexShowsGroupsWhenTooLarge()
    {
        using var db = new TempDb();
        for (var g = 0; g < 4; g++)
        {
            for (var i = 0; i < 10; i++)
            {
                db.Store.PostFacts(Fixtures.Post($"big/g{g}/leaf-{i}", Fixtures.Fact($"Leaf {i} in g{g} does something.")));
            }
        }

        db.Store.PostFacts(Fixtures.Post("small/only", Fixtures.Fact("A small group.")));
        db.Store.Publish(Options(db, o => o.IndexMaxTokens = 700));
        var files = ReadAll(Out(db));

        var big = files["index/big.md"];
        await Assert.That(big).Contains("| g0/ | group |");
        await Assert.That(big).Contains("(big-g0.md)");
        await Assert.That(big.Contains("](../subjects/", StringComparison.Ordinal)).IsFalse();
        await Assert.That(files["index/big-g0.md"]).Contains("](../subjects/big-g0-leaf-0/index.md)");
        await Assert.That(files["index/big-g0.md"]).Contains("Up: [index/big.md](big.md)");

        var root = files["INDEX.md"];
        await Assert.That(root).Contains("](index/big.md)");
        await Assert.That(root).Contains("](index/small.md)");

        var manifest = JsonDocument.Parse(files["manifest.json"]).RootElement.GetProperty("index_files");
        await Assert.That(manifest.GetProperty("index/big.md").GetInt32()).IsEqualTo(DossierStore.EstimateTokens(big));
        await Assert.That(manifest.EnumerateObject().Count()).IsEqualTo(IndexFiles(files).Count);
    }

    [Test]
    public async Task Publish_AgentsMdDescribesTieredIndex()
    {
        using var db = new TempDb();
        Seed(db);
        db.Store.Publish(Options(db));
        var agents = File.ReadAllText(Path.Combine(Out(db), "AGENTS.md"));

        await Assert.That(agents).Contains("index/<group>.md (repeat while the row is a group)");
        await Assert.That(agents).Contains("index/");
        await Assert.That(agents).Contains("a row being a folder is normal");
    }

    [Test]
    public async Task Publish_SmallBundleHasOnlyRootIndex()
    {
        using var db = new TempDb();
        Seed(db);
        db.Store.Publish(Options(db));
        await Assert.That(IndexFiles(ReadAll(Out(db))).Count).IsEqualTo(1);
    }

    // ---- fact files under their subject, and links that resolve ---------------------------

    private static readonly Regex MarkdownLink = new(@"\]\((?:<([^>]+)>|([^)\s]+))\)", RegexOptions.Compiled);

    private static IEnumerable<string> LinkTargets(string content) =>
        MarkdownLink.Matches(content).Select(m => m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value);

    private static bool IsExternal(string target) =>
        target.StartsWith("http://", StringComparison.Ordinal) || target.StartsWith("https://", StringComparison.Ordinal);

    private static string TargetLine(string factFile, string needle) =>
        factFile.Split('\n').Single(l => l.StartsWith("  - target: ", StringComparison.Ordinal) && l.Contains(needle, StringComparison.Ordinal));

    [Test]
    public async Task Publish_EachFactLivesUnderItsSubject()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Trio",
            Fixtures.Fact("First fact of the trio."),
            Fixtures.Fact("Second fact of the trio."),
            Fixtures.Fact("Third fact of the trio.")));

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var factPaths = posted.Response.Facts.Select(f => FactOf(files, f.Id).Path).ToList();
        await Assert.That(factPaths.Count).IsEqualTo(3);
        foreach (var path in factPaths)
        {
            await Assert.That(path).StartsWith("subjects/trio/facts/");
            await Assert.That(files.ContainsKey(path)).IsTrue();
        }

        await Assert.That(files.Keys.Count(k => k.StartsWith("subjects/trio/facts/", StringComparison.Ordinal))).IsEqualTo(3);
        await Assert.That(files.ContainsKey("subjects/trio/index.md")).IsTrue();
        await Assert.That(files.Keys.Any(k => k.StartsWith("facts/", StringComparison.Ordinal))).IsFalse();
        await Assert.That(Directory.Exists(Path.Combine(Out(db), "facts"))).IsFalse();
    }

    [Test]
    public async Task Publish_FactRefLinksResolve()
    {
        using var db = new TempDb();
        var other = db.Store.PostFacts(Fixtures.Post("Beta Subject", Fixtures.Fact("The far fact lives in beta.")));
        var farId = other.Response.Facts[0].Id;
        var near = db.Store.PostFacts(Fixtures.Post(
            "Alpha Subject",
            Fixtures.Fact("The near fact lives in alpha.", localId: "near"),
            Fixtures.Fact(
                "The pointer fact depends on two others.",
                refs: new List<RefInput>
                {
                    Fixtures.Ref("@near", rel: "depends_on"),
                    Fixtures.Ref(farId, rel: "depends_on"),
                })));
        var nearId = near.Response.Facts[0].Id;
        var pointerId = near.Response.Facts[1].Id;

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var (nearKey, nearPath) = FactOf(files, nearId);
        var (farKey, farPath) = FactOf(files, farId);
        var (pointerKey, pointerPath) = FactOf(files, pointerId);
        var pointer = files[pointerPath];

        // Same subject: a bare file name. Other subject: up out of facts/ and the subject directory.
        await Assert.That(pointer).Contains($"- target: [{nearKey}]({FileName(nearPath)})");
        await Assert.That(pointer).Contains($"- target: [{farKey}](../../beta-subject/facts/{FileName(farPath)})");
        await Assert.That(File.Exists(Path.Combine(Out(db), nearPath))).IsTrue();
        await Assert.That(File.Exists(Path.Combine(Out(db), farPath))).IsTrue();
        await Assert.That(File.Exists(Path.GetFullPath(Path.Combine(Out(db), "subjects/alpha-subject/facts", "../../beta-subject/facts", FileName(farPath))))).IsTrue();

        // The far fact links back, with the referring fact's kind and rel.
        var far = files[farPath];
        await Assert.That(far).Contains($"- [{pointerKey}](../../alpha-subject/facts/{FileName(pointerPath)}) (note, rel: depends_on)");
    }

    [Test]
    public async Task Publish_SlotRefResolvesToLiveFact()
    {
        using var db = new TempDb();
        var first = db.Store.PostFacts(Fixtures.Post("Config", Fixtures.Fact("The theme is dark.", key: "theme")));
        var darkId = first.Response.Facts[0].Id;
        var reader = db.Store.PostFacts(Fixtures.Post(
            "Reader",
            Fixtures.Fact(
                "The reader honours the theme setting.",
                refs: new List<RefInput> { Fixtures.Ref("Config#theme", kind: "slot", rel: "reads") })));
        var readerId = reader.Response.Facts[0].Id;

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var (darkKey, darkPath) = FactOf(files, darkId);
        var readerPath = FactOf(files, readerId).Path;
        await Assert.That(TargetLine(files[readerPath], "Config#theme")).Contains($"[{darkKey}](../../config/facts/{FileName(darkPath)})");
        await Assert.That(files[darkPath]).Contains("(note, rel: reads)");

        // Supersede the slot's occupant: the link follows the slot to the new head.
        var second = db.Store.PostFacts(Fixtures.Post("Config", Fixtures.Fact("The theme is light.", key: "theme")));
        var lightId = second.Response.Facts[0].Id;
        await Assert.That(lightId).IsNotEqualTo(darkId);

        db.Store.Publish(Options(db));
        files = ReadAll(Out(db));
        var (lightKey, lightPath) = FactOf(files, lightId);
        var line = TargetLine(files[readerPath], "Config#theme");
        await Assert.That(line).Contains($"[{lightKey}](../../config/facts/{FileName(lightPath)})");
        await Assert.That(line).DoesNotContain(FileName(darkPath));
        await Assert.That(files.ContainsKey(darkPath)).IsFalse();
        await Assert.That(files.ContainsKey(lightPath)).IsTrue();
        await Assert.That(files[lightPath]).Contains("rel: reads");
    }

    [Test]
    public async Task Publish_SubjectRefLinksToSubjectIndex()
    {
        using var db = new TempDb();
        var team = db.Store.PostFacts(Fixtures.Post("Team Atlas", Fixtures.Fact("Atlas owns the maps.")));
        var teamId = team.Response.Subject.Id;
        var child = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Team Atlas Docs", Kind = "docs", Parent = teamId },
            Facts = { Fixtures.Fact("The docs describe the maps.") },
        });
        var service = db.Store.PostFacts(Fixtures.Post(
            "Service",
            Fixtures.Fact(
                "The service is run by a team.",
                refs: new List<RefInput>
                {
                    Fixtures.Ref(teamId, kind: "subject", rel: "owned_by"),
                    Fixtures.Ref("team atlas docs", kind: "subject", rel: "documented_in"),
                })));
        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var factPath = FactOf(files, service.Response.Facts[0].Id).Path;

        var fact = files[factPath];
        await Assert.That(TargetLine(fact, "Team Atlas](")).Contains("[Team Atlas](../../team-atlas/index.md)");
        await Assert.That(TargetLine(fact, "Docs](")).Contains("[Team Atlas Docs](../../team-atlas-docs/index.md)");

        // From a subject index the neighbours are sibling directories.
        await Assert.That(files["subjects/team-atlas/index.md"]).Contains("[Team Atlas Docs](../team-atlas-docs/index.md)");
        await Assert.That(files["subjects/team-atlas-docs/index.md"]).Contains("- Parent: [Team Atlas](../team-atlas/index.md)");
        _ = child;
    }

    private static AttachmentInput ShotAttachment(Shot shot) =>
        new() { Sha256 = shot.Sha, Filename = shot.Filename, Mime = shot.Mime, Bytes = shot.Bytes.Length };

    [Test]
    public async Task Publish_UnresolvedSlotStaysText()
    {
        using var db = new TempDb();
        db.Store.PostFacts(Fixtures.Post("Config", Fixtures.Fact("The theme is dark.", key: "theme")));
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Reader",
            Fixtures.Fact(
                "The reader looks for a slot nobody filled.",
                refs: new List<RefInput>
                {
                    Fixtures.Ref("Config#missing", kind: "slot", rel: "reads"),
                    Fixtures.Ref("Nowhere#theme", kind: "slot", rel: "reads"),
                })));

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var fact = files[FactOf(files, posted.Response.Facts[0].Id).Path];

        foreach (var target in new[] { "Config#missing", "Nowhere#theme" })
        {
            var line = TargetLine(fact, target);
            await Assert.That(line).Contains("unresolved slot");
            await Assert.That(line).Contains("`" + target + "`");
            await Assert.That(line).DoesNotContain("](");
        }
    }

    [Test]
    public async Task Publish_ExternalRefsStayTextExceptHttpLinks()
    {
        using var db = new TempDb();
        var posted = db.Store.PostFacts(Fixtures.Post(
            "Docs",
            Fixtures.Fact(
                "The fact cites outside material.",
                refs: new List<RefInput>
                {
                    Fixtures.Ref("https://example.com/spec?a=1&b=(2)", kind: "http", rel: "cites"),
                    Fixtures.Ref("src/Program.cs", kind: "file", rel: "cites"),
                    Fixtures.Ref("deadbeef", kind: "git", rel: "cites"),
                })));

        db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));
        var fact = files[FactOf(files, posted.Response.Facts[0].Id).Path];

        await Assert.That(TargetLine(fact, "example.com")).Contains("(<https://example.com/spec?a=1&b=(2)>)");
        await Assert.That(TargetLine(fact, "Program.cs")).IsEqualTo("  - target: `src/Program.cs`");
        await Assert.That(TargetLine(fact, "deadbeef")).IsEqualTo("  - target: `deadbeef`");
    }

    [Test]
    public async Task Publish_EveryInternalLinkResolves()
    {
        // A small stand-in for the Django-sized bundle: a nested subject tree, keyed slots, fact,
        // slot and subject refs across subjects, an unresolvable ref, attachments, a budget that drops
        // facts from subject indexes, and a token cap small enough to force a tiered index.
        using var db = new TempDb();
        var shot = WriteBlob(db, "shot bytes", "shot.png", "image/png");
        var rootId = db.Store.PostFacts(Fixtures.Post("Pkg", Fixtures.Fact("The package root."))).Response.Subject.Id;
        var factIds = new List<string>();
        var subjectIds = new List<string> { rootId };
        for (var m = 0; m < 6; m++)
        {
            var module = db.Store.PostFacts(new PostFactsRequest
            {
                Subject = new SubjectInput { Name = $"Pkg/mod{m}", Kind = "module", Parent = rootId },
                Facts = { Fixtures.Fact($"Module {m} exists.", key: "summary") },
            });
            var moduleId = module.Response.Subject.Id;
            subjectIds.Add(moduleId);
            factIds.Add(module.Response.Facts[0].Id);
            for (var c = 0; c < 4; c++)
            {
                var refs = new List<RefInput>
                {
                    Fixtures.Ref(factIds[^1], rel: "extends"),
                    Fixtures.Ref($"Pkg/mod{(m + 1) % 6}#summary", kind: "slot", rel: "uses"),
                    Fixtures.Ref(subjectIds[(m + c) % subjectIds.Count], kind: "subject", rel: "see_also"),
                    Fixtures.Ref("Pkg/gone#nothing", kind: "slot", rel: "uses"),
                    Fixtures.Ref("https://example.com/m" + m, kind: "http", rel: "cites"),
                    Fixtures.Ref("pkg/mod" + m + ".py", kind: "file", rel: "defined_in"),
                };
                var attachments = c == 0 ? new List<AttachmentInput> { ShotAttachment(shot) } : null;
                var posted = db.Store.PostFacts(new PostFactsRequest
                {
                    Subject = new SubjectInput { Name = $"Pkg/mod{m}/cls{c}", Kind = "class", Parent = moduleId },
                    Facts = { Fixtures.Fact($"Class {c} of module {m} does something worth {LongText}.", refs: refs, attachments: attachments) },
                });
                factIds.Add(posted.Response.Facts[0].Id);
                subjectIds.Add(posted.Response.Subject.Id);
            }
        }

        foreach (var budget in new[] { 1200, 60 })
        {
            db.Store.Publish(Options(db, o =>
            {
                o.IndexMaxTokens = 700;
                o.Budget = budget;
            }));
            var files = ReadAll(Out(db));
            await Assert.That(files.Keys.Count(IsFactFile)).IsEqualTo(factIds.Count + 1);

            var internalLinks = 0;
            foreach (var (path, content) in files.Where(kv => kv.Key.EndsWith(".md", StringComparison.Ordinal)))
            {
                foreach (var target in LinkTargets(content).Where(t => !IsExternal(t)))
                {
                    internalLinks++;
                    var resolved = Resolve(path, target);
                    await Assert.That(files.ContainsKey(resolved)).IsTrue();
                }
            }

            // The corpus really exercised every link family.
            await Assert.That(internalLinks).IsGreaterThan(factIds.Count * 6);
            var all = string.Concat(files.Where(kv => IsFactFile(kv.Key)).Select(kv => kv.Value));
            await Assert.That(all).Contains("(slot `Pkg/mod");
            await Assert.That(all).Contains("unresolved slot");
            await Assert.That(all).Contains("index.md)");
            await Assert.That(all).Contains("](../assets/");
        }
    }

    [Test]
    public async Task Publish_SubjectDirectoryIsRemovedWhenSubjectIsGone()
    {
        using var db = new TempDb();
        var doomed = db.Store.PostFacts(Fixtures.Post("Doomed", Fixtures.Fact("First doomed fact."), Fixtures.Fact("Second doomed fact.")));
        db.Store.PostFacts(Fixtures.Post("Survivor", Fixtures.Fact("The survivor stays.")));

        db.Store.Publish(Options(db));
        await Assert.That(Directory.Exists(Path.Combine(Out(db), "subjects", "doomed", "facts"))).IsTrue();

        var foreign = Path.Combine(Out(db), "subjects", "survivor", "notes.txt");
        File.WriteAllText(foreign, "keep me");

        foreach (var fact in doomed.Response.Facts)
        {
            db.Store.Retract(fact.Id);
        }

        var result = db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        await Assert.That(Directory.Exists(Path.Combine(Out(db), "subjects", "doomed"))).IsFalse();
        await Assert.That(files.Keys.Any(k => k.StartsWith("subjects/doomed", StringComparison.Ordinal))).IsFalse();
        await Assert.That(result.Removed.Contains("subjects/doomed/index.md")).IsTrue();
        await Assert.That(File.ReadAllText(foreign)).IsEqualTo("keep me");
        await Assert.That(files.ContainsKey("subjects/survivor/index.md")).IsTrue();
        await Assert.That(files["INDEX.md"]).DoesNotContain("Doomed");
    }

    // ---- machine record --------------------------------------------------------------------

    private static JsonElement MachineRecordOf(string fileContent)
    {
        var heading = "\n## Machine record\n\n";
        var at = fileContent.LastIndexOf(heading, StringComparison.Ordinal);
        var lines = fileContent[(at + heading.Length)..].TrimEnd('\n').Split('\n');
        return JsonDocument.Parse(string.Join('\n', lines[1..^1])).RootElement.Clone();
    }

    [Test]
    public async Task Publish_EmitsMachineRecord()
    {
        using var db = new TempDb();
        var target = db.Store.PostFacts(Fixtures.Post("Rec", Fixtures.Fact("Target text.", key: "slot-one", tags: new List<string> { "x" })));
        var targetId = target.Response.Facts[0].Id;
        db.Store.PostFacts(Fixtures.Post(
            "Rec",
            Fixtures.Fact(
                "Pointer text.",
                key: "ptr",
                data: Fixtures.Json("{\"b\":2,\"a\":1.50}"),
                refs: new List<RefInput> { new() { Rel = "supports", Kind = "fact", Target = targetId, Basis = "observed", Confidence = 0.7, Rev = "r1" } })));

        var result = db.Store.Publish(Options(db));
        var files = ReadAll(Out(db));

        var pointer = files.Single(kv => IsFactFile(kv.Key) && kv.Value.Contains("Pointer text.")).Value;
        await Assert.That(pointer.TrimEnd('\n').EndsWith("```")).IsTrue();
        var record = MachineRecordOf(pointer);
        var stored = db.Store.Show(db.Store.Search(new SearchRequest { Q = "Pointer" }).Hits.Single().Id)!;

        await Assert.That(record.GetProperty("id").GetString()).IsEqualTo(stored.Fact.Id);
        await Assert.That(record.GetProperty("subject_id").GetString()).IsEqualTo(stored.Fact.SubjectId);
        await Assert.That(record.GetProperty("subject_name").GetString()).IsEqualTo("Rec");
        await Assert.That(record.GetProperty("key").GetString()).IsEqualTo("ptr");
        await Assert.That(record.GetProperty("kind").GetString()).IsEqualTo(stored.Fact.Kind);
        await Assert.That(record.GetProperty("text").GetString()).IsEqualTo(stored.Fact.Text);
        await Assert.That(record.GetProperty("status").GetString()).IsEqualTo(stored.Fact.Status);
        await Assert.That(record.GetProperty("confidence").GetDouble()).IsEqualTo(stored.Fact.Confidence);
        await Assert.That(CanonicalJson.Write(record.GetProperty("data"))).IsEqualTo("{\"a\":1.50,\"b\":2}");
        await Assert.That(record.GetProperty("provenance").GetProperty("posted_at").GetString()).IsEqualTo(stored.Fact.Provenance!.Value.GetProperty("posted_at").GetString());
        await Assert.That(record.GetProperty("provenance").GetProperty("actor").GetString()).IsEqualTo("dossier-cli");

        var reference = record.GetProperty("refs").EnumerateArray().Single();
        await Assert.That(reference.GetProperty("target").GetString()).IsEqualTo(targetId);
        await Assert.That(reference.GetProperty("rel").GetString()).IsEqualTo("supports");
        await Assert.That(reference.GetProperty("kind").GetString()).IsEqualTo("fact");
        await Assert.That(reference.GetProperty("basis").GetString()).IsEqualTo("observed");
        await Assert.That(reference.GetProperty("confidence").GetDouble()).IsEqualTo(0.7);
        await Assert.That(reference.GetProperty("rev").GetString()).IsEqualTo("r1");
        await Assert.That(reference.TryGetProperty("etag", out _)).IsFalse();

        // Prose shows the bundle key for that ref; the record keeps the store id.
        await Assert.That(pointer.Contains(targetId + ")")).IsFalse();

        var plain = files.Single(kv => IsFactFile(kv.Key) && kv.Value.Contains("Target text.")).Value;
        var plainRecord = MachineRecordOf(plain);
        await Assert.That(plainRecord.GetProperty("key").GetString()).IsEqualTo("slot-one");
        await Assert.That(plainRecord.GetProperty("tags").EnumerateArray().Single().GetString()).IsEqualTo("x");
        await Assert.That(plainRecord.TryGetProperty("data", out _)).IsFalse();
        _ = result;
    }
}
