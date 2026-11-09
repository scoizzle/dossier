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

    private const string SamplePython = """"
        """Module docstring that is not an entity."""
        import os


        def top(a, b):
            """Add things.

            Second paragraph is ignored.
            """
            return a + b


        class Widget(Base):
            """A widget."""

            x = 1

            def first(self):
                return 1

            def second(self):
                def helper():
                    return 2
                return helper()

            async def third(self):
                return 3


        async def runner():
            pass
        """";

    private static DumpRequest CodeRequest(string source, bool entitySubjects = false) => new()
    {
        Source = source,
        Subject = "mod",
        Split = "code",
        EntitySubjects = entitySubjects ? true : null,
    };

    private static System.Text.Json.JsonElement FactData(TempDb db, string id) => db.Store.Show(id)!.Fact.Data!.Value;

    [Test]
    public async Task CodeSplit_EmitsOneFactPerEntity()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", SamplePython);

        var response = db.Store.Dump(CodeRequest(source));

        var texts = response.Created.Select(id => FactText(db, id)).ToList();
        await Assert.That(texts.SequenceEqual(new[]
        {
            "def top(a, b)",
            "class Widget(Base)",
            "def first(self)",
            "def second(self)",
            "def helper()",
            "async def third(self)",
            "async def runner()",
        })).IsTrue();
        await Assert.That(response.Errors.Count).IsEqualTo(0);
    }

    [Test]
    public async Task CodeSplit_NestsMethodsUnderClass()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "klass.py", "class K:\n    def a(self):\n        pass\n\n    def b(self):\n        pass\n\n    def c(self):\n        pass\n");

        var response = db.Store.Dump(CodeRequest(source));

        await Assert.That(response.Created.Count).IsEqualTo(4);
        var data = response.Created.Select(id => FactData(db, id)).ToList();
        await Assert.That(data[0].GetProperty("parent").GetString()).IsEqualTo("klass");
        await Assert.That(data[0].GetProperty("symbol").GetString()).IsEqualTo("K");
        for (var index = 1; index <= 3; index++)
        {
            await Assert.That(data[index].GetProperty("parent").GetString()).IsEqualTo("K");
            await Assert.That(data[index].GetProperty("entity_kind").GetString()).IsEqualTo("method");
        }

        await Assert.That(data[2].GetProperty("symbol").GetString()).IsEqualTo("K.b");
    }

    [Test]
    public async Task CodeSplit_ExtractsSignatureDocstringAndLocator()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", SamplePython);

        var response = db.Store.Dump(CodeRequest(source));

        var show = db.Store.Show(response.Created[0])!;
        await Assert.That(show.Fact.Text).IsEqualTo("def top(a, b)");
        await Assert.That(show.Fact.Tags!.Contains("entity:function")).IsTrue();
        var data = show.Fact.Data!.Value;
        await Assert.That(data.GetProperty("symbol").GetString()).IsEqualTo("top");
        await Assert.That(data.GetProperty("entity_kind").GetString()).IsEqualTo("function");
        await Assert.That(data.GetProperty("start_line").GetInt32()).IsEqualTo(5);
        await Assert.That(data.GetProperty("end_line").GetInt32()).IsEqualTo(10);

        var items = show.Fact.Items!.Value;
        await Assert.That(items.GetArrayLength()).IsEqualTo(1);
        await Assert.That(items[0].GetProperty("text").GetString()).IsEqualTo("Add things.");

        var locator = show.Refs.Single().Locator!.Value;
        await Assert.That(locator.GetProperty("line").GetInt32()).IsEqualTo(5);
        await Assert.That(locator.GetProperty("symbol").GetString()).IsEqualTo("top");
        await Assert.That(locator.GetProperty("selector").GetString()).IsEqualTo("L5-L10");
    }

    [Test]
    public async Task CodeSplit_HandlesDecoratorsAndMultiLineSignatures()
    {
        using var db = new TempDb();
        var longParams = string.Join(", ", Enumerable.Range(0, 60).Select(i => $"argument_{i}"));
        var content =
            "class C:\n" +
            "    @staticmethod\n" +
            "    def s(x):\n" +
            "        return x\n" +
            "\n" +
            "    @classmethod\n" +
            "    @other.deco(1, 2)\n" +
            "    def c(cls):\n" +
            "        return cls\n" +
            "\n" +
            "    def multi(\n" +
            "        self,\n" +
            "        a: int,\n" +
            "        b: str = \"x:y\",\n" +
            "    ) -> int:\n" +
            "        text = \"\"\"\n" +
            "def fake(): pass\n" +
            "\"\"\"\n" +
            "        return 1\n" +
            "\n" +
            $"    def wide(self, {longParams}):\n" +
            "        pass\n";
        var source = WriteSource(db, "deco.py", content);

        var response = db.Store.Dump(CodeRequest(source));

        await Assert.That(response.Created.Count).IsEqualTo(5);
        var shows = response.Created.Select(id => db.Store.Show(id)!).ToList();
        await Assert.That(shows[1].Fact.Data!.Value.GetProperty("entity_kind").GetString()).IsEqualTo("static_method");
        await Assert.That(shows[1].Fact.Tags!.Contains("decorator:staticmethod")).IsTrue();
        await Assert.That(shows[1].Fact.Data!.Value.GetProperty("start_line").GetInt32()).IsEqualTo(2);
        await Assert.That(shows[2].Fact.Data!.Value.GetProperty("entity_kind").GetString()).IsEqualTo("class_method");
        await Assert.That(shows[2].Fact.Tags!.Contains("decorator:classmethod")).IsTrue();
        await Assert.That(shows[2].Fact.Tags!.Contains("decorator:other.deco")).IsTrue();
        await Assert.That(shows[3].Fact.Text).IsEqualTo("def multi( self, a: int, b: str = \"x:y\", ) -> int");
        await Assert.That(shows[3].Fact.Data!.Value.GetProperty("start_line").GetInt32()).IsEqualTo(11);
        await Assert.That(shows[3].Fact.Data!.Value.GetProperty("end_line").GetInt32()).IsEqualTo(19);

        var wide = shows[4].Fact;
        await Assert.That(wide.Text!.Length).IsLessThanOrEqualTo(240);
        await Assert.That(wide.Text.EndsWith('\u2026')).IsTrue();
        await Assert.That(wide.Tags!.Contains("signature_truncated")).IsTrue();
        await Assert.That(shows[3].Fact.Tags!.Contains("signature_truncated")).IsFalse();
    }

    [Test]
    public async Task CodeSplit_NonPythonFallsBackToParagraph()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "notes.txt", "def not_python():\n    pass\n\nsecond paragraph");

        var response = db.Store.Dump(CodeRequest(source));

        await Assert.That(response.Created.Count).IsEqualTo(2);
        await Assert.That(FactText(db, response.Created[0])).IsEqualTo("def not_python():\n    pass");
        await Assert.That(response.Errors.Count).IsEqualTo(1);
        await Assert.That(response.Errors[0].Contains("split_fallback")).IsTrue();
    }

    [Test]
    public async Task EntitySubjects_CreateChildSubjectsWithParentAndContainsFact()
    {
        using var db = new TempDb();
        var source = WriteSource(db, "mod.py", SamplePython);

        var response = db.Store.Dump(CodeRequest(source, entitySubjects: true));

        // 7 entity facts + 3 contains facts (top, Widget, runner).
        await Assert.That(response.Errors.Count).IsEqualTo(0);
        await Assert.That(response.Created.Count).IsEqualTo(10);

        using var connection = db.Store.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, name, kind, parent_id FROM subjects ORDER BY name";
        var subjects = new List<(string Id, string Name, string Kind, string? Parent)>();
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                subjects.Add((reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.IsDBNull(3) ? null : reader.GetString(3)));
            }
        }

        var module = subjects.Single(s => s.Name == "mod");
        await Assert.That(subjects.Count).IsEqualTo(8);
        var second = subjects.Single(s => s.Name == "mod::Widget.second");
        await Assert.That(second.Kind).IsEqualTo("method");
        await Assert.That(second.Parent).IsEqualTo(module.Id);
        await Assert.That(subjects.Single(s => s.Name == "mod::Widget").Kind).IsEqualTo("class");
        await Assert.That(subjects.Single(s => s.Name == "mod::runner").Kind).IsEqualTo("async_function");

        var moduleFacts = db.Store.Search(new SearchRequest { Subject = module.Id, Limit = 50 }).Hits;
        await Assert.That(moduleFacts.Count).IsEqualTo(3);
        var texts = moduleFacts.Select(h => h.Text).OrderBy(t => t, StringComparer.Ordinal).ToList();
        await Assert.That(texts.SequenceEqual(new[] { "contains async_function runner", "contains class Widget", "contains function top" })).IsTrue();
        var widgetId = subjects.Single(s => s.Name == "mod::Widget").Id;
        var widgetEdge = db.Store.Show(moduleFacts.Single(h => h.Text == "contains class Widget").Id)!.Refs.Single();
        await Assert.That(widgetEdge.Rel).IsEqualTo("contains");
        await Assert.That(widgetEdge.Kind).IsEqualTo("subject");
        await Assert.That(widgetEdge.Target).IsEqualTo(widgetId);

        var widgetFacts = db.Store.Search(new SearchRequest { Subject = widgetId, Limit = 50 }).Hits;
        await Assert.That(widgetFacts.Count).IsEqualTo(1);
        await Assert.That(widgetFacts[0].Text).IsEqualTo("class Widget(Base)");
    }

    [Test]
    public async Task CodeSplit_IsDeterministicAcrossRuns()
    {
        using var first = new TempDb();
        using var second = new TempDb();
        var sourceA = WriteSource(first, "mod.py", SamplePython);
        var sourceB = WriteSource(second, "mod.py", SamplePython);

        var a = first.Store.Dump(CodeRequest(sourceA));
        var b = second.Store.Dump(CodeRequest(sourceB));
        var again = first.Store.Dump(CodeRequest(sourceA));

        string Signature(TempDb db, string id)
        {
            var fact = db.Store.Show(id)!.Fact;
            return fact.Text + "|" + fact.Data!.Value.GetRawText();
        }

        await Assert.That(a.Created.Select(id => Signature(first, id)).SequenceEqual(b.Created.Select(id => Signature(second, id)))).IsTrue();
        await Assert.That(again.Created.Count).IsEqualTo(0);
        await Assert.That(again.Deduped.SequenceEqual(a.Created)).IsTrue();
    }

    [Test]
    public async Task CodeSplit_IgnoresDefinitionsInsideStringsAndComments()
    {
        using var db = new TempDb();
        var content = "# def commented(): pass\nTEXT = \"\"\"\ndef in_string(): pass\nclass Nope: pass\n\"\"\"\n\ndef real(x):\n    \'\'\'One-line doc.\'\'\'\n    return x\n";
        var source = WriteSource(db, "str.py", content);

        var response = db.Store.Dump(CodeRequest(source));

        await Assert.That(response.Created.Count).IsEqualTo(1);
        var show = db.Store.Show(response.Created[0])!;
        await Assert.That(show.Fact.Text).IsEqualTo("def real(x)");
        await Assert.That(show.Fact.Data!.Value.GetProperty("start_line").GetInt32()).IsEqualTo(7);
        await Assert.That(show.Fact.Data!.Value.GetProperty("end_line").GetInt32()).IsEqualTo(9);
        await Assert.That(show.Fact.Items!.Value[0].GetProperty("text").GetString()).IsEqualTo("One-line doc.");
    }

    [Test]
    public async Task CodeSplit_IsAcceptedByContractSchema()
    {
        var path = RepoFilePath(Path.Combine("contract", "ops.schema.json"));
        using var schema = JsonDocument.Parse(File.ReadAllText(path));
        var dump = schema.RootElement.GetProperty("$defs").GetProperty("DumpRequest").GetProperty("properties");

        var split = dump.GetProperty("split").GetProperty("enum").EnumerateArray()
            .Select(value => value.GetString())
            .ToList();
        await Assert.That(split.Contains("code")).IsTrue();

        var entitySubjects = dump.GetProperty("entity_subjects");
        await Assert.That(entitySubjects.GetProperty("type").GetString()).IsEqualTo("boolean");
        await Assert.That(entitySubjects.TryGetProperty("default", out var fallback) && fallback.ValueKind == JsonValueKind.False).IsTrue();
        await Assert.That(entitySubjects.GetProperty("description").GetString()).Contains("default false");
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
