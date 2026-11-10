using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Dossier.Tests;

/// <summary>Shared fixtures for the JSONL publish and import tests.</summary>
internal static class Jsonl
{
    public sealed record Shot(string Sha, byte[] Bytes);

    public static readonly UTF8Encoding Utf8 = new(false);

    public static Shot WriteBlob(TempDb db, string content)
    {
        var bytes = Utf8.GetBytes(content);
        var sha = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
        Directory.CreateDirectory(db.Store.BlobRoot);
        File.WriteAllBytes(Path.Combine(db.Store.BlobRoot, sha), bytes);
        return new Shot(sha, bytes);
    }

    /// <summary>Hierarchy, data, tags, refs of every kind, a superseded fact and one attachment.</summary>
    public static (Shot Shot, string AppId, string ScreenId) Seed(TempDb db)
    {
        var shot = WriteBlob(db, "screenshot bytes for the round trip");
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
                        new() { Rel = "defines", Kind = "slot", Target = "Home Screen#header-a", Basis = "derived" },
                        new() { Rel = "about", Kind = "subject", Target = "My App", Basis = "inferred", Confidence = 0.4 },
                        new() { Rel = "see", Kind = "url", Target = "https://example.test/spec?a=1", Basis = "observed", Locator = Fixtures.Json("{\"anchor\":\"x\",\"line\":9}") },
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

    public static string Out(TempDb db, string name = "out") => Path.Combine(db.Directory, name);

    public static PublishResult Publish(TempDb db, Action<PublishOptions>? tweak = null, string name = "out")
    {
        var options = new PublishOptions
        {
            Out = Out(db, name),
            Format = "jsonl",
            CommandLine = "dossier publish --out out --format jsonl",
            Now = () => new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero),
        };
        tweak?.Invoke(options);
        return db.Store.Publish(options);
    }

    public static List<string> DataFiles(string dir) =>
        Directory.EnumerateFiles(dir, "dossier-*.jsonl").Select(p => Path.GetFileName(p)).OrderBy(n => n, StringComparer.Ordinal).ToList();

    /// <summary>Every line of every dossier-NNNN.jsonl in order, parsed.</summary>
    public static List<JsonElement> Records(string dir)
    {
        var result = new List<JsonElement>();
        foreach (var name in DataFiles(dir))
        {
            foreach (var line in File.ReadAllText(Path.Combine(dir, name), Utf8).Split('\n').SkipLast(1))
            {
                result.Add(JsonDocument.Parse(line).RootElement.Clone());
            }
        }

        return result;
    }

    public static JsonElement Manifest(string dir) => JsonDocument.Parse(File.ReadAllText(Path.Combine(dir, "manifest.json"), Utf8)).RootElement.Clone();

    public static Dictionary<string, byte[]> ReadAll(string dir) =>
        Directory.EnumerateFiles(dir, "*", SearchOption.AllDirectories)
            .ToDictionary(p => Path.GetRelativePath(dir, p).Replace('\\', '/'), File.ReadAllBytes, StringComparer.Ordinal);

    public static DossierRequestException Fails(Action action)
    {
        try
        {
            action();
        }
        catch (DossierRequestException exception)
        {
            return exception;
        }

        throw new InvalidOperationException("expected a DossierRequestException");
    }

    public static string WriteProfile(TempDb db, string json)
    {
        var path = Path.Combine(db.Directory, "profile.json");
        File.WriteAllText(path, json);
        return path;
    }

    public static async Task<(int Exit, string Out, string Err)> Cli(string? dbPath, params string[] args)
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
}
