using System.Text.Json;
using System.Text.RegularExpressions;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace Dossier.Tests;

/// <summary>
/// The JSONL contract schemas (contract/jsonl-*.schema.json) against what publish really emits. There is no
/// JSON-schema library in the test project, so a small validator for the keywords the contracts use does the
/// checking; the negative tests prove it is not vacuous.
/// </summary>
public sealed class JsonlSchemaTests
{
    private static string RepoFile(string relative)
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

    private static JsonElement Load(string name) => JsonDocument.Parse(File.ReadAllText(RepoFile("contract/" + name))).RootElement.Clone();

    private static readonly Dictionary<string, JsonElement> Documents = new(StringComparer.Ordinal);

    private static JsonElement Doc(string name)
    {
        lock (Documents)
        {
            if (!Documents.TryGetValue(name, out var doc))
            {
                Documents[name] = doc = Load(name);
            }

            return doc;
        }
    }

    private static string Errors(string schemaFile, JsonElement instance)
    {
        var errors = new List<string>();
        Validate(schemaFile, Doc(schemaFile), schemaFile, instance, "$", errors);
        return string.Join("; ", errors);
    }

    private static bool Valid(string schemaFile, JsonElement instance) => Errors(schemaFile, instance).Length == 0;

    private static JsonElement Resolve(string file, string reference, out string targetFile)
    {
        var hash = reference.IndexOf('#', StringComparison.Ordinal);
        var filePart = hash < 0 ? reference : reference[..hash];
        var pointer = hash < 0 ? string.Empty : reference[(hash + 1)..];
        targetFile = filePart.Length == 0 ? file : filePart;
        var node = Doc(targetFile);
        foreach (var segment in pointer.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            node = node.GetProperty(segment.Replace("~1", "/", StringComparison.Ordinal).Replace("~0", "~", StringComparison.Ordinal));
        }

        return node;
    }

    private static bool TypeMatches(string type, JsonElement value) => type switch
    {
        "object" => value.ValueKind == JsonValueKind.Object,
        "array" => value.ValueKind == JsonValueKind.Array,
        "string" => value.ValueKind == JsonValueKind.String,
        "boolean" => value.ValueKind is JsonValueKind.True or JsonValueKind.False,
        "null" => value.ValueKind == JsonValueKind.Null,
        "number" => value.ValueKind == JsonValueKind.Number,
        "integer" => value.ValueKind == JsonValueKind.Number && value.TryGetInt64(out _),
        _ => throw new NotSupportedException("type " + type),
    };

    private static readonly HashSet<string> Annotations = new(StringComparer.Ordinal)
    {
        "$schema", "$id", "title", "description", "$defs", "format", "default", "examples",
    };

    private static void Validate(string file, JsonElement schema, string schemaFile, JsonElement value, string path, List<string> errors)
    {
        if (schema.ValueKind != JsonValueKind.Object)
        {
            throw new NotSupportedException("boolean schemas are not used by the contracts");
        }

        foreach (var keyword in schema.EnumerateObject())
        {
            var k = keyword.Name;
            var v = keyword.Value;
            switch (k)
            {
                case "$ref":
                    var target = Resolve(file, v.GetString()!, out var targetFile);
                    Validate(targetFile, target, targetFile, value, path, errors);
                    break;
                case "type":
                    var types = v.ValueKind == JsonValueKind.Array ? v.EnumerateArray().Select(t => t.GetString()!).ToArray() : new[] { v.GetString()! };
                    if (!types.Any(t => TypeMatches(t, value)))
                    {
                        errors.Add($"{path}: expected {string.Join("|", types)}");
                    }

                    break;
                case "const":
                    if (!JsonEquals(v, value))
                    {
                        errors.Add($"{path}: expected const {v.GetRawText()}");
                    }

                    break;
                case "enum":
                    if (!v.EnumerateArray().Any(o => JsonEquals(o, value)))
                    {
                        errors.Add($"{path}: not in enum {v.GetRawText()}");
                    }

                    break;
                case "pattern":
                    if (value.ValueKind == JsonValueKind.String && !Regex.IsMatch(value.GetString()!, v.GetString()!))
                    {
                        errors.Add($"{path}: does not match /{v.GetString()}/");
                    }

                    break;
                case "minLength":
                    if (value.ValueKind == JsonValueKind.String && value.GetString()!.Length < v.GetInt32())
                    {
                        errors.Add($"{path}: shorter than {v.GetInt32()}");
                    }

                    break;
                case "minimum":
                    if (value.ValueKind == JsonValueKind.Number && value.GetDouble() < v.GetDouble())
                    {
                        errors.Add($"{path}: below {v.GetDouble()}");
                    }

                    break;
                case "maximum":
                    if (value.ValueKind == JsonValueKind.Number && value.GetDouble() > v.GetDouble())
                    {
                        errors.Add($"{path}: above {v.GetDouble()}");
                    }

                    break;
                case "minItems":
                    if (value.ValueKind == JsonValueKind.Array && value.GetArrayLength() < v.GetInt32())
                    {
                        errors.Add($"{path}: fewer than {v.GetInt32()} items");
                    }

                    break;
                case "maxItems":
                    if (value.ValueKind == JsonValueKind.Array && value.GetArrayLength() > v.GetInt32())
                    {
                        errors.Add($"{path}: more than {v.GetInt32()} items");
                    }

                    break;
                case "items":
                    if (value.ValueKind == JsonValueKind.Array)
                    {
                        var index = 0;
                        foreach (var item in value.EnumerateArray())
                        {
                            Validate(file, v, schemaFile, item, $"{path}[{index++}]", errors);
                        }
                    }

                    break;
                case "required":
                    if (value.ValueKind == JsonValueKind.Object)
                    {
                        foreach (var name in v.EnumerateArray().Select(n => n.GetString()!).Where(n => !value.TryGetProperty(n, out _)))
                        {
                            errors.Add($"{path}: missing required '{name}'");
                        }
                    }

                    break;
                case "properties":
                    if (value.ValueKind == JsonValueKind.Object)
                    {
                        foreach (var property in v.EnumerateObject())
                        {
                            if (value.TryGetProperty(property.Name, out var child))
                            {
                                Validate(file, property.Value, schemaFile, child, $"{path}.{property.Name}", errors);
                            }
                        }
                    }

                    break;
                case "additionalProperties":
                    if (value.ValueKind == JsonValueKind.Object)
                    {
                        var declared = schema.TryGetProperty("properties", out var props) ? props : default;
                        foreach (var member in value.EnumerateObject())
                        {
                            if (declared.ValueKind == JsonValueKind.Object && declared.TryGetProperty(member.Name, out _))
                            {
                                continue;
                            }

                            if (v.ValueKind == JsonValueKind.False)
                            {
                                errors.Add($"{path}: unexpected property '{member.Name}'");
                            }
                            else if (v.ValueKind == JsonValueKind.Object)
                            {
                                Validate(file, v, schemaFile, member.Value, $"{path}.{member.Name}", errors);
                            }
                        }
                    }

                    break;
                case "propertyNames":
                    if (value.ValueKind == JsonValueKind.Object)
                    {
                        foreach (var member in value.EnumerateObject())
                        {
                            using var name = JsonDocument.Parse(JsonSerializer.Serialize(member.Name));
                            Validate(file, v, schemaFile, name.RootElement, $"{path}.{member.Name}(name)", errors);
                        }
                    }

                    break;
                case "allOf":
                    foreach (var sub in v.EnumerateArray())
                    {
                        Validate(file, sub, schemaFile, value, path, errors);
                    }

                    break;
                case "oneOf":
                    var matching = 0;
                    var branchErrors = new List<string>();
                    foreach (var sub in v.EnumerateArray())
                    {
                        var branch = new List<string>();
                        Validate(file, sub, schemaFile, value, path, branch);
                        if (branch.Count == 0)
                        {
                            matching++;
                        }
                        else
                        {
                            branchErrors.Add("[" + string.Join(", ", branch) + "]");
                        }
                    }

                    if (matching != 1)
                    {
                        errors.Add($"{path}: matches {matching} oneOf branches {string.Join(" ", branchErrors)}");
                    }

                    break;
                default:
                    if (!Annotations.Contains(k))
                    {
                        throw new NotSupportedException($"validator does not implement keyword '{k}' ({schemaFile})");
                    }

                    break;
            }
        }
    }

    private static bool JsonEquals(JsonElement a, JsonElement b) => a.ValueKind == b.ValueKind && a.GetRawText() == b.GetRawText();

    private static JsonElement Parse(string json) => JsonDocument.Parse(json).RootElement.Clone();

    /// <summary>The JSONL seed with refs that conform to ref.schema.json (the store also accepts open relations and locator keys the strict contract rejects).</summary>
    private static (Jsonl.Shot Shot, string AppId, string ScreenId) SeedConforming(TempDb db)
    {
        var shot = Jsonl.WriteBlob(db, "screenshot bytes for the round trip");
        var app = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "My App", Kind = "app", Aliases = new List<string> { "the app", "myapp" } },
            Facts = { Fixtures.Fact("The app is a notes tool.", tags: new List<string> { "overview", "notes" }) },
        });
        var appId = app.Response.Subject.Id;
        using (var connection = db.Store.OpenConnection())
        {
            using var pin = connection.CreateCommand();
            pin.CommandText = "UPDATE subjects SET pin = '{\"repo\":\"https://example.test/app.git\",\"rev\":\"abc123\"}' WHERE id = $id";
            pin.Parameters.AddWithValue("$id", appId);
            pin.ExecuteNonQuery();
        }

        db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Home Screen", Kind = "screen", Parent = appId },
            Facts = { Fixtures.Fact("The header is 60 pixels tall.", key: "header-a") },
        });

        var screen = db.Store.PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = "Home Screen", Kind = "screen", Parent = appId },
            Facts =
            {
                Fixtures.Fact("The header is 64 pixels tall.", key: "header-a", data: Fixtures.Json("{\"headerHeight\":64,\"theme\":{\"b\":1.50,\"a\":[1,2]}}")),
                Fixtures.Fact("The target fact.", localId: "t", tags: new List<string> { "target" }),
                new FactInput
                {
                    Kind = "behavior",
                    Text = "The pointer fact, with `backticks` and ``` a fence.",
                    Confidence = 0.8,
                    Items = new List<ItemInput> { new() { Key = "one", Text = "first item", Locator = Fixtures.Json("{\"line\":3}") } },
                    Refs = new List<RefInput>
                    {
                        new() { Rel = "supports", Kind = "fact", Target = "@t", Basis = "observed", Confidence = 0.9, Rev = "abc123", Snapshot = "snap", SnapshotHash = "deadbeef", Etag = "W/1", VerifiedAt = "2026-01-01T00:00:00Z", Valid = true },
                        new() { Rel = "mentions", Kind = "slot", Target = "Home Screen#header-a", Basis = "derived" },
                        new() { Rel = "about", Kind = "subject", Target = "My App", Basis = "inferred", Confidence = 0.4 },
                        new() { Rel = "derived_from", Kind = "url", Target = "https://example.test/spec?a=1", Basis = "observed", Locator = Fixtures.Json("{\"selector\":\"x\",\"line\":9}") },
                    },
                    Attachments = new List<AttachmentInput>
                    {
                        new() { Sha256 = shot.Sha, Filename = "shots/Home Screen.PNG", Mime = "image/png", Bytes = shot.Bytes.Length, Perceptual = Fixtures.Json("{\"algo\":\"phash\",\"value\":\"ff00\"}") },
                    },
                },
            },
        });
        return (shot, appId, screen.Response.Subject.Id);
    }

    private static async Task AssertBundleValid(string dir)
    {
        var lines = 0;
        foreach (var record in Jsonl.Records(dir))
        {
            var errors = Errors("jsonl-record.schema.json", record);
            if (errors.Length > 0)
            {
                throw new InvalidOperationException(errors + " :: " + record.GetRawText());
            }

            lines++;
        }

        await Assert.That(lines).IsGreaterThan(0);
        var manifestErrors = Errors("jsonl-manifest.schema.json", Jsonl.Manifest(dir));
        await Assert.That(manifestErrors).IsEqualTo(string.Empty);
    }

    [Test]
    [Arguments("embed")]
    [Arguments("files")]
    [Arguments("none")]
    public async Task Schemas_AcceptEmittedLinesAndManifest(string mode)
    {
        using var db = new TempDb();
        SeedConforming(db);
        Jsonl.Publish(db, o => o.Assets = mode);
        await AssertBundleValid(Jsonl.Out(db));
        var types = Jsonl.Records(Jsonl.Out(db)).Select(r => r.GetProperty("type").GetString()!).Distinct().OrderBy(t => t, StringComparer.Ordinal).ToArray();
        await Assert.That(types).IsEquivalentTo(mode == "none" ? new[] { "fact", "subject" } : new[] { "asset", "fact", "subject" });
    }

    [Test]
    public async Task Schemas_AcceptMissingAssetAndScopedSubjectWithoutParent()
    {
        using var db = new TempDb();
        var (shot, _, screenId) = SeedConforming(db);
        File.Delete(Path.Combine(db.Store.BlobRoot, shot.Sha));
        Jsonl.Publish(db, o =>
        {
            o.Assets = "embed";
            o.Subject = screenId;
        });
        await AssertBundleValid(Jsonl.Out(db));
        var records = Jsonl.Records(Jsonl.Out(db));
        await Assert.That(records.Any(r => r.TryGetProperty("missing", out _))).IsTrue();
        var root = records.First(r => r.GetProperty("type").GetString() == "subject");
        await Assert.That(root.TryGetProperty("parent", out _)).IsFalse();
    }

    [Test]
    public async Task Schemas_AcceptManifestWithProfileOptions()
    {
        using var db = new TempDb();
        SeedConforming(db);
        var profile = Jsonl.WriteProfile(db, "{\"name\":\"p\",\"max_files\":50,\"max_file_bytes\":1000000,\"allowed_extensions\":[\"jsonl\"]}");
        Jsonl.Publish(db, o =>
        {
            o.Assets = "embed";
            o.ProfilePath = profile;
            o.RespectLimits = true;
        });
        var manifest = Jsonl.Manifest(Jsonl.Out(db));
        await Assert.That(manifest.GetProperty("options").TryGetProperty("profile", out _)).IsTrue();
        await Assert.That(Errors("jsonl-manifest.schema.json", manifest)).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task Schemas_RejectMalformedRecords()
    {
        using var db = new TempDb();
        SeedConforming(db);
        Jsonl.Publish(db, o => o.Assets = "embed");
        var records = Jsonl.Records(Jsonl.Out(db));
        var fact = records.First(r => r.GetProperty("type").GetString() == "fact");
        var subject = records.First(r => r.GetProperty("type").GetString() == "subject");
        var asset = records.First(r => r.GetProperty("type").GetString() == "asset");

        string Mutate(JsonElement element, Action<Dictionary<string, JsonElement>> change)
        {
            var map = element.EnumerateObject().ToDictionary(p => p.Name, p => p.Value, StringComparer.Ordinal);
            change(map);
            return JsonSerializer.Serialize(map);
        }

        var bad = new[]
        {
            Mutate(fact, m => m.Remove("content_hash")),
            Mutate(fact, m => m.Remove("bundle_key")),
            Mutate(fact, m => m["extra"] = Parse("1")),
            Mutate(fact, m => m["content_hash"] = Parse("\"ABC\"")),
            Mutate(fact, m => m["status"] = Parse("\"weird\"")),
            Mutate(fact, m => m["confidence"] = Parse("1.5")),
            Mutate(fact, m => m["type"] = Parse("\"note\"")),
            Mutate(subject, m => m.Remove("path")),
            Mutate(subject, m => m["extra"] = Parse("true")),
            Mutate(asset, m => m["sha256"] = Parse("\"zz\"")),
            Mutate(asset, m => m.Remove("data")),
            Mutate(asset, m => m["encoding"] = Parse("\"hex\"")),
            Mutate(asset, m => m["path"] = Parse("\"assets/x.png\"")),
            Mutate(asset, m => m["missing"] = Parse("true")),
        };
        foreach (var json in bad)
        {
            await Assert.That(Valid("jsonl-record.schema.json", Parse(json))).IsFalse();
        }

        var fileAsset = Parse("{\"type\":\"asset\",\"sha256\":\"" + new string('a', 64) + "\",\"mime\":\"image/png\",\"filename\":\"a.png\",\"bytes\":1,\"path\":\"../assets/a.png\"}");
        await Assert.That(Valid("jsonl-record.schema.json", fileAsset)).IsFalse();

        var manifest = Jsonl.Manifest(Jsonl.Out(db));
        string MutateManifest(Action<Dictionary<string, JsonElement>> change) => Mutate(manifest, change);
        var badManifests = new[]
        {
            MutateManifest(m => m["format"] = Parse("\"dossier-jsonl/2\"")),
            MutateManifest(m => m.Remove("bundle_hash")),
            MutateManifest(m => m["files"] = Parse("[\"../etc/passwd\"]")),
            MutateManifest(m => m["files"] = Parse("[\"dossier-1.jsonl\"]")),
            MutateManifest(m => m["file_stats"] = Parse("{\"x.jsonl\":{\"bytes\":1,\"lines\":1,\"sha256\":\"" + new string('a', 64) + "\"}}")),
            MutateManifest(m => m["counts"] = Parse("{\"subjects\":1,\"facts\":1}")),
            MutateManifest(m => m["extra"] = Parse("1")),
        };
        foreach (var json in badManifests)
        {
            await Assert.That(Valid("jsonl-manifest.schema.json", Parse(json))).IsFalse();
        }
    }

    private static string[] Names(JsonElement element) => element.EnumerateObject().Select(p => p.Name).OrderBy(n => n, StringComparer.Ordinal).ToArray();

    private static string[] Required(JsonElement element) =>
        element.GetProperty("required").EnumerateArray().Select(n => n.GetString()!).OrderBy(n => n, StringComparer.Ordinal).ToArray();

    [Test]
    public async Task Schemas_ParseAndTrackTheBaseContracts()
    {
        var record = Doc("jsonl-record.schema.json");
        var defs = record.GetProperty("$defs");
        await Assert.That(Names(defs)).IsEquivalentTo(new[] { "AssetEmbedded", "AssetFile", "AssetMissing", "AssetRecord", "FactRecord", "Sha256", "SubjectRecord" });
        await Assert.That(record.GetProperty("oneOf").GetArrayLength()).IsEqualTo(3);

        var subject = Doc("subject.schema.json");
        var subjectDef = defs.GetProperty("SubjectRecord");
        await Assert.That(Names(subjectDef.GetProperty("properties")))
            .IsEquivalentTo(Names(subject.GetProperty("properties")).Concat(new[] { "path", "type" }).OrderBy(n => n, StringComparer.Ordinal).ToArray());
        await Assert.That(Required(subjectDef)).IsEquivalentTo(Required(subject).Concat(new[] { "path", "type" }).OrderBy(n => n, StringComparer.Ordinal).ToArray());

        var fact = Doc("fact.schema.json");
        var factDef = defs.GetProperty("FactRecord");
        await Assert.That(Names(factDef.GetProperty("properties")))
            .IsEquivalentTo(Names(fact.GetProperty("properties")).Concat(new[] { "bundle_key", "subject_name", "type" }).OrderBy(n => n, StringComparer.Ordinal).ToArray());
        await Assert.That(Required(factDef)).IsEquivalentTo(Required(fact).Concat(new[] { "bundle_key", "subject_name", "type" }).OrderBy(n => n, StringComparer.Ordinal).ToArray());

        // Every inherited property must point at the base contract's property of the same name.
        foreach (var (def, baseFile, baseSchema) in new[] { (subjectDef, "subject.schema.json", subject), (factDef, "fact.schema.json", fact) })
        {
            foreach (var property in baseSchema.GetProperty("properties").EnumerateObject())
            {
                var reference = def.GetProperty("properties").GetProperty(property.Name).GetProperty("$ref").GetString();
                await Assert.That(reference).IsEqualTo($"{baseFile}#/properties/{property.Name}");
            }
        }

        foreach (var name in new[] { "AssetEmbedded", "AssetFile", "AssetMissing" })
        {
            await Assert.That(defs.GetProperty(name).GetProperty("additionalProperties").ValueKind).IsEqualTo(JsonValueKind.False);
        }

        await Assert.That(Required(defs.GetProperty("AssetEmbedded"))).IsEquivalentTo(new[] { "bytes", "data", "encoding", "filename", "mime", "sha256", "type" });
        await Assert.That(Required(defs.GetProperty("AssetFile"))).IsEquivalentTo(new[] { "bytes", "filename", "mime", "path", "sha256", "type" });
        await Assert.That(Required(defs.GetProperty("AssetMissing"))).IsEquivalentTo(new[] { "bytes", "filename", "mime", "missing", "sha256", "type" });

        var manifest = Doc("jsonl-manifest.schema.json");
        await Assert.That(Required(manifest)).IsEquivalentTo(new[] { "assets", "bundle_hash", "counts", "file_stats", "files", "format", "options" });
        await Assert.That(manifest.GetProperty("properties").GetProperty("format").GetProperty("const").GetString()).IsEqualTo("dossier-jsonl/1");
        await Assert.That(manifest.GetProperty("additionalProperties").ValueKind).IsEqualTo(JsonValueKind.False);
    }
}
