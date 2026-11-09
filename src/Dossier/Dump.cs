using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Dossier;

/// <summary>dump request, per contract/ops.schema.json.</summary>
public sealed class DumpRequest
{
    public string? Source { get; set; }
    public string? Subject { get; set; }
    public string? Kind { get; set; }
    public string? Split { get; set; }
    public List<string>? Tags { get; set; }
}

/// <summary>dump response: every input chunk is created, deduped, or skipped.</summary>
public sealed class DumpResponse
{
    public List<string> Created { get; set; } = new();
    public List<string> Deduped { get; set; } = new();
    public List<SkippedChunk> Skipped { get; set; } = new();
    public List<string> Errors { get; set; } = new();
}

/// <summary>A chunk the splitter refused to post; the locator points at its line range.</summary>
public sealed class SkippedChunk
{
    public JsonElement? Locator { get; set; }
    public string Reason { get; set; } = string.Empty;
}

public sealed partial class DossierStore
{
    private const int MinChunkTextLength = 3;
    private const string DefaultFactKind = "note";
    private const string DerivedFromRel = "derived_from";
    private const string FileRefKind = "file";
    private const string ObservedBasis = "observed";

    /// <summary>UTF-8 without a BOM, failing closed on malformed bytes.</summary>
    private static readonly UTF8Encoding StrictUtf8 = new(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

    /// <summary>
    /// dump. Reads the raw source once, hashes the bytes with sha256, and writes
    /// blobs/&lt;sha256&gt; BEFORE parsing. The splitter (heading, paragraph, file, none) is
    /// deterministic over the bytes plus options, every emitted chunk becomes a fact with one
    /// derived_from file ref carrying its line range, and a chunk trimmed shorter than 3
    /// characters is reported in skipped rather than posted. Posting goes through post_facts,
    /// so a second identical dump returns every chunk as deduped.
    /// </summary>
    public DumpResponse Dump(DumpRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (string.IsNullOrWhiteSpace(request.Source))
        {
            throw new DossierRequestException("missing_source", "dump requires a non-empty source");
        }

        if (string.IsNullOrWhiteSpace(request.Subject))
        {
            throw new DossierRequestException("missing_subject", "dump requires a non-empty subject");
        }

        var response = new DumpResponse();
        var source = request.Source!;
        var split = request.Split ?? DefaultSplit(source);

        byte[] bytes;
        try
        {
            bytes = File.ReadAllBytes(source);
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or ArgumentException or NotSupportedException)
        {
            response.Errors.Add($"read_failed: {exception.Message}");
            return response;
        }

        var sha256 = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
        try
        {
            Directory.CreateDirectory(BlobRoot);
            var blobPath = Path.Combine(BlobRoot, sha256);
            if (!File.Exists(blobPath))
            {
                File.WriteAllBytes(blobPath, bytes);
            }
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException)
        {
            response.Errors.Add($"blob_failed: {exception.Message}");
            return response;
        }

        string text;
        try
        {
            text = DecodeUtf8(bytes);
        }
        catch (DecoderFallbackException exception)
        {
            // The blob is already on disk; a parse failure is reported, not thrown.
            response.Errors.Add($"parse_failed: {exception.Message}");
            return response;
        }

        List<Chunk> chunks;
        try
        {
            chunks = Split(text, split);
        }
        catch (DossierRequestException exception)
        {
            response.Errors.Add($"{exception.Code}: {exception.Message}");
            return response;
        }

        var kind = string.IsNullOrWhiteSpace(request.Kind) ? DefaultFactKind : request.Kind!;
        var tags = request.Tags ?? new List<string>();
        var facts = new List<FactInput>();
        var postedChunks = new List<Chunk>();

        foreach (var chunk in chunks)
        {
            if (chunk.Text.Trim().Length < MinChunkTextLength)
            {
                response.Skipped.Add(new SkippedChunk
                {
                    Locator = LineRangeLocator(chunk.StartLine, chunk.EndLine),
                    Reason = "too_short",
                });
                continue;
            }

            facts.Add(new FactInput
            {
                Kind = kind,
                Text = chunk.Text,
                Tags = new List<string>(tags),
                Refs = new List<RefInput>
                {
                    new()
                    {
                        Rel = DerivedFromRel,
                        Kind = FileRefKind,
                        Target = source,
                        Basis = ObservedBasis,
                        Locator = LineRangeLocator(chunk.StartLine, chunk.EndLine),
                    },
                },
            });
            postedChunks.Add(chunk);
        }

        if (facts.Count == 0)
        {
            return response;
        }

        var result = PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = request.Subject },
            Facts = facts,
        });

        var errorsByIndex = new Dictionary<int, PostError>();
        foreach (var error in result.Errors)
        {
            errorsByIndex[error.Index] = error;
        }

        var factCursor = 0;
        for (var index = 0; index < facts.Count; index++)
        {
            if (errorsByIndex.TryGetValue(index, out var error))
            {
                response.Errors.Add($"chunk:{postedChunks[index].StartLine}: {error.Code}: {error.Message}");
                continue;
            }

            var fact = result.Response.Facts[factCursor++];
            if (fact.Status == "new")
            {
                response.Created.Add(fact.Id);
            }
            else
            {
                response.Deduped.Add(fact.Id);
            }
        }

        return response;
    }

    private static string DefaultSplit(string source)
    {
        var extension = Path.GetExtension(source);
        return extension.Equals(".md", StringComparison.OrdinalIgnoreCase)
            || extension.Equals(".markdown", StringComparison.OrdinalIgnoreCase)
            ? "heading"
            : "none";
    }

    private static string DecodeUtf8(byte[] bytes)
    {
        var text = StrictUtf8.GetString(bytes);
        return text.Length > 0 && text[0] == '\uFEFF' ? text[1..] : text;
    }

    private static List<Chunk> Split(string text, string split)
    {
        var normalized = text.Replace("\r\n", "\n").Replace('\r', '\n');
        var lines = normalized.Split('\n');

        return split switch
        {
            "heading" => SplitHeading(lines),
            "paragraph" => SplitParagraph(lines),
            "file" => new List<Chunk> { new(normalized, 1, LastContentLine(lines)) },
            "none" => new List<Chunk> { new(normalized, 1, LastContentLine(lines)) },
            _ => throw new DossierRequestException(
                "invalid_split",
                $"split must be heading, paragraph, file, or none, got \"{split}\""),
        };
    }

    /// <summary>Heading split: a chunk starts at line 1 (preamble) or at any line starting with '#'.</summary>
    private static List<Chunk> SplitHeading(string[] lines)
    {
        var chunks = new List<Chunk>();
        var start = -1;

        for (var index = 0; index < lines.Length; index++)
        {
            var isHeading = lines[index].Length > 0 && lines[index][0] == '#';
            if (isHeading)
            {
                if (start >= 0)
                {
                    AddChunk(chunks, lines, start, index - 1);
                }

                start = index;
            }
            else if (start < 0 && !string.IsNullOrWhiteSpace(lines[index]))
            {
                start = index;
            }
        }

        if (start >= 0)
        {
            AddChunk(chunks, lines, start, lines.Length - 1);
        }

        return chunks;
    }

    /// <summary>Paragraph split: each run of non-blank lines is one chunk.</summary>
    private static List<Chunk> SplitParagraph(string[] lines)
    {
        var chunks = new List<Chunk>();
        var start = -1;

        for (var index = 0; index < lines.Length; index++)
        {
            if (string.IsNullOrWhiteSpace(lines[index]))
            {
                if (start >= 0)
                {
                    AddChunk(chunks, lines, start, index - 1);
                    start = -1;
                }
            }
            else if (start < 0)
            {
                start = index;
            }
        }

        if (start >= 0)
        {
            AddChunk(chunks, lines, start, lines.Length - 1);
        }

        return chunks;
    }

    private static void AddChunk(List<Chunk> chunks, string[] lines, int start, int end)
    {
        while (start <= end && string.IsNullOrWhiteSpace(lines[start]))
        {
            start++;
        }

        while (end >= start && string.IsNullOrWhiteSpace(lines[end]))
        {
            end--;
        }

        if (start > end)
        {
            return;
        }

        var text = string.Join('\n', lines[start..(end + 1)]);
        chunks.Add(new Chunk(text, start + 1, end + 1));
    }

    private static int LastContentLine(string[] lines)
    {
        var end = lines.Length;
        while (end > 1 && string.IsNullOrWhiteSpace(lines[end - 1]))
        {
            end--;
        }

        return Math.Max(1, end);
    }

    /// <summary>
    /// The contract Locator has a single <c>line</c> field and no end line, so the range is
    /// carried as line=&lt;start&gt; plus selector="L&lt;start&gt;-L&lt;end&gt;": both ends are
    /// 1-based and machine-readable without widening the contract.
    /// </summary>
    private static JsonElement LineRangeLocator(int startLine, int endLine) =>
        JsonSerializer.SerializeToElement(
            new LineRangeLocatorValue { Line = startLine, Selector = $"L{startLine}-L{endLine}" },
            JsonCodec.Options);

    private sealed class LineRangeLocatorValue
    {
        public int Line { get; set; }
        public string Selector { get; set; } = string.Empty;
    }

    private sealed record Chunk(string Text, int StartLine, int EndLine);
}
