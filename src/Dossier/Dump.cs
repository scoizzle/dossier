using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dossier;

/// <summary>dump request, per contract/ops.schema.json.</summary>
public sealed class DumpRequest
{
    public string? Source { get; set; }
    public string? Subject { get; set; }
    public string? Kind { get; set; }
    public string? Split { get; set; }
    public bool? EntitySubjects { get; set; }
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
            chunks = Split(text, split, source, response);
        }
        catch (DossierRequestException exception)
        {
            response.Errors.Add($"{exception.Code}: {exception.Message}");
            return response;
        }

        var kind = string.IsNullOrWhiteSpace(request.Kind) ? DefaultFactKind : request.Kind!;
        var tags = request.Tags ?? new List<string>();

        if (request.EntitySubjects == true && chunks.Any(chunk => chunk.Entity is not null))
        {
            DumpEntitySubjects(request.Subject!, source, kind, tags, chunks, response);
            return response;
        }

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

            facts.Add(BuildFact(chunk, kind, tags, source));
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

        AccountPosted(result, facts.Count, index => $"chunk:{postedChunks[index].StartLine}", response);
        return response;
    }

    private static FactInput BuildFact(Chunk chunk, string kind, List<string> tags, string source)
    {
        var entity = chunk.Entity;
        var factTags = new List<string>(tags);
        JsonElement? data = null;
        List<ItemInput>? items = null;
        var locator = LineRangeLocator(chunk.StartLine, chunk.EndLine);

        if (entity is not null)
        {
            factTags.AddRange(entity.Tags);
            data = JsonCodec.Object(
                ("symbol", entity.Symbol),
                ("entity_kind", entity.Kind),
                ("parent", entity.Parent),
                ("start_line", chunk.StartLine),
                ("end_line", chunk.EndLine));
            locator = JsonCodec.Object(
                ("line", chunk.StartLine),
                ("selector", $"L{chunk.StartLine}-L{chunk.EndLine}"),
                ("symbol", entity.Symbol));
            if (entity.Docstring is not null)
            {
                items = new List<ItemInput>
                {
                    new()
                    {
                        Text = entity.Docstring,
                        Locator = JsonCodec.Object(("line", entity.DocLine)),
                    },
                };
            }
        }

        return new FactInput
        {
            Kind = kind,
            Text = chunk.Text,
            Data = data,
            Items = items,
            Tags = factTags,
            Refs = new List<RefInput>
            {
                new()
                {
                    Rel = DerivedFromRel,
                    Kind = FileRefKind,
                    Target = source,
                    Basis = ObservedBasis,
                    Locator = locator,
                },
            },
        };
    }

    /// <summary>Maps a PostFacts result onto the manifest: each fact is created, deduped, or an error.</summary>
    private static void AccountPosted(PostResult result, int factCount, Func<int, string> label, DumpResponse response)
    {
        var errorsByIndex = new Dictionary<int, PostError>();
        foreach (var error in result.Errors)
        {
            errorsByIndex[error.Index] = error;
        }

        var factCursor = 0;
        for (var index = 0; index < factCount; index++)
        {
            if (errorsByIndex.TryGetValue(index, out var error))
            {
                response.Errors.Add($"{label(index)}: {error.Code}: {error.Message}");
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
    }

    /// <summary>
    /// --entity-subjects: every entity becomes a child subject "&lt;module&gt;::&lt;qualname&gt;"
    /// (kind = entity_kind, parent = module subject id) holding its own fact; the module subject
    /// gets one "contains" fact per top-level entity pointing at the entity subject.
    /// </summary>
    private void DumpEntitySubjects(
        string moduleSubject,
        string source,
        string kind,
        List<string> tags,
        List<Chunk> chunks,
        DumpResponse response)
    {
        var module = PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Name = moduleSubject },
            Facts = new List<FactInput>(),
        });
        var moduleId = module.Response.Subject.Id;
        var contains = new List<FactInput>();
        var containsSymbols = new List<string>();

        foreach (var chunk in chunks)
        {
            var entity = chunk.Entity!;
            var fact = BuildFact(chunk, kind, tags, source);
            var result = PostFacts(new PostFactsRequest
            {
                Subject = new SubjectInput
                {
                    Name = $"{moduleSubject}::{entity.Symbol}",
                    Kind = entity.Kind,
                    Parent = moduleId,
                },
                Facts = new List<FactInput> { fact },
            });

            AccountPosted(result, 1, _ => $"entity:{entity.Symbol}", response);
            if (result.Errors.Count > 0)
            {
                continue;
            }

            if (entity.TopLevel)
            {
                contains.Add(new FactInput
                {
                    Kind = kind,
                    Text = $"contains {entity.Kind} {entity.Symbol}",
                    Tags = new List<string>(tags) { $"entity:{entity.Kind}" },
                    Refs = new List<RefInput>
                    {
                        new()
                        {
                            Rel = "contains",
                            Kind = "subject",
                            Target = result.Response.Subject.Id,
                            Basis = ObservedBasis,
                            Locator = JsonCodec.Object(
                                ("line", chunk.StartLine),
                                ("symbol", entity.Symbol)),
                        },
                    },
                });
                containsSymbols.Add(entity.Symbol);
            }
        }

        if (contains.Count == 0)
        {
            return;
        }

        var containsResult = PostFacts(new PostFactsRequest
        {
            Subject = new SubjectInput { Id = moduleId },
            Facts = contains,
        });
        AccountPosted(containsResult, contains.Count, index => $"contains:{containsSymbols[index]}", response);
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

    private static List<Chunk> Split(string text, string split, string source, DumpResponse response)
    {
        var normalized = text.Replace("\r\n", "\n").Replace('\r', '\n');
        var lines = normalized.Split('\n');

        return split switch
        {
            "heading" => SplitHeading(lines),
            "paragraph" => SplitParagraph(lines),
            "code" => SplitCode(lines, source, response),
            "file" => new List<Chunk> { new(normalized, 1, LastContentLine(lines)) },
            "none" => new List<Chunk> { new(normalized, 1, LastContentLine(lines)) },
            _ => throw new DossierRequestException(
                "invalid_split",
                $"split must be heading, paragraph, code, file, or none, got \"{split}\""),
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
        JsonCodec.Object(("line", startLine), ("selector", $"L{startLine}-L{endLine}"));

    private sealed record Chunk(string Text, int StartLine, int EndLine, CodeEntity? Entity = null);

    private sealed record CodeEntity(
        string Symbol,
        string Kind,
        string Parent,
        bool TopLevel,
        List<string> Tags,
        string? Docstring,
        int DocLine);

    private const int MaxSignatureLength = 240;

    /// <summary>One logical Python line: physical lines joined, comments removed, strings kept verbatim.</summary>
    private sealed record LogicalLine(int Start, int End, int Indent, string Text, int HeaderEnd);

    private sealed class OpenEntity
    {
        public required string Symbol { get; init; }
        public required string EntityKind { get; init; }
        public required string Parent { get; init; }
        public required bool TopLevel { get; init; }
        public required int Indent { get; init; }
        public required int StartLine { get; init; }
        public required string Signature { get; init; }
        public required List<string> Tags { get; init; }
        public string? Docstring { get; init; }
        public int DocLine { get; init; }
        public int EndLine { get; set; }
    }

    [GeneratedRegex(@"^(async\s+)?def\s+([^\W\d]\w*)")]
    private static partial Regex PythonDefPattern();

    [GeneratedRegex(@"^class\s+([^\W\d]\w*)")]
    private static partial Regex PythonClassPattern();

    [GeneratedRegex(@"^@\s*([\w.]+)")]
    private static partial Regex PythonDecoratorPattern();

    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRun();

    [GeneratedRegex(@"\n[ \t]*\n")]
    private static partial Regex BlankLineBreak();

    /// <summary>
    /// Code split (Python only): one chunk per class, function, async function and method at any
    /// nesting depth, in source order. The chunk text is the signature; everything else rides in
    /// the entity. Non-Python sources fall back to paragraph and say so in the manifest.
    /// </summary>
    private static List<Chunk> SplitCode(string[] lines, string source, DumpResponse response)
    {
        var extension = Path.GetExtension(source);
        if (!extension.Equals(".py", StringComparison.OrdinalIgnoreCase)
            && !extension.Equals(".pyi", StringComparison.OrdinalIgnoreCase))
        {
            response.Errors.Add(
                $"warning: split_fallback: split=code supports only Python (.py, .pyi); \"{extension}\" fell back to paragraph");
            return SplitParagraph(lines);
        }

        var moduleStem = Path.GetFileNameWithoutExtension(source);
        var logical = ScanPython(lines);
        var all = new List<OpenEntity>();
        var stack = new List<OpenEntity>();
        var decorators = new List<(int Line, int Indent, string Name)>();

        for (var index = 0; index < logical.Count; index++)
        {
            var line = logical[index];
            while (stack.Count > 0 && line.Indent <= stack[^1].Indent)
            {
                stack[^1].EndLine = logical[index - 1].End;
                stack.RemoveAt(stack.Count - 1);
            }

            var decorator = PythonDecoratorPattern().Match(line.Text);
            if (line.Text.StartsWith('@'))
            {
                if (decorator.Success)
                {
                    decorators.Add((line.Start, line.Indent, decorator.Groups[1].Value));
                }

                continue;
            }

            var definition = PythonDefPattern().Match(line.Text);
            var classMatch = PythonClassPattern().Match(line.Text);
            if (!definition.Success && !classMatch.Success)
            {
                decorators.Clear();
                continue;
            }

            var isClass = classMatch.Success;
            var isAsync = definition.Success && definition.Groups[1].Success;
            var name = isClass ? classMatch.Groups[1].Value : definition.Groups[2].Value;
            var attached = decorators.Where(d => d.Indent == line.Indent).ToList();
            decorators.Clear();

            var enclosing = stack.Count > 0 ? stack[^1] : null;
            var symbol = enclosing is null ? name : $"{enclosing.Symbol}.{name}";
            var entityKind = isClass ? "class" : "function";
            if (!isClass)
            {
                var inClass = enclosing is not null && enclosing.EntityKind == "class";
                if (inClass)
                {
                    entityKind = "method";
                    if (attached.Any(d => d.Name == "staticmethod"))
                    {
                        entityKind = "static_method";
                    }
                    else if (attached.Any(d => d.Name == "classmethod"))
                    {
                        entityKind = "class_method";
                    }
                }
                else if (isAsync)
                {
                    entityKind = "async_function";
                }
            }

            var signature = line.HeaderEnd >= 0 ? line.Text[..line.HeaderEnd] : line.Text;
            signature = WhitespaceRun().Replace(signature, " ").Trim();

            var tags = new List<string> { $"entity:{entityKind}" };
            tags.AddRange(attached.Select(d => $"decorator:{d.Name}"));
            if (isAsync)
            {
                tags.Add("async");
            }

            if (signature.Length > MaxSignatureLength)
            {
                var cut = signature[..(MaxSignatureLength - 1)];
                var space = cut.LastIndexOf(' ');
                if (space > 0)
                {
                    cut = cut[..space];
                }

                signature = cut.TrimEnd() + "\u2026";
                tags.Add("signature_truncated");
            }

            string? docstring = null;
            var docLine = 0;
            var bodyOnHeaderLine = line.HeaderEnd >= 0 && line.Text[(line.HeaderEnd + 1)..].Trim().Length > 0;
            if (line.HeaderEnd >= 0 && !bodyOnHeaderLine
                && index + 1 < logical.Count && logical[index + 1].Indent > line.Indent)
            {
                docstring = FirstDocstringParagraph(logical[index + 1].Text);
                docLine = logical[index + 1].Start;
            }

            var entity = new OpenEntity
            {
                Symbol = symbol,
                EntityKind = entityKind,
                Parent = enclosing?.Symbol ?? moduleStem,
                TopLevel = enclosing is null,
                Indent = line.Indent,
                StartLine = attached.Count > 0 ? attached.Min(d => d.Line) : line.Start,
                Signature = signature,
                Tags = tags,
                Docstring = docstring,
                DocLine = docLine,
                EndLine = line.End,
            };
            all.Add(entity);
            stack.Add(entity);
        }

        if (logical.Count > 0)
        {
            foreach (var open in stack)
            {
                open.EndLine = logical[^1].End;
            }
        }

        return all
            .Select(e => new Chunk(
                e.Signature,
                e.StartLine,
                e.EndLine,
                new CodeEntity(e.Symbol, e.EntityKind, e.Parent, e.TopLevel, e.Tags, e.Docstring, e.DocLine)))
            .ToList();
    }

    /// <summary>Returns the first paragraph (whitespace collapsed) when the statement is a lone string literal.</summary>
    private static string? FirstDocstringParagraph(string statement)
    {
        var text = statement.TrimStart();
        var position = 0;
        while (position < text.Length && position < 2 && "rRuU".IndexOf(text[position]) >= 0)
        {
            position++;
        }

        if (position >= text.Length || (text[position] != '"' && text[position] != '\''))
        {
            return null;
        }

        var quote = text[position];
        var triple = text.Length >= position + 3 && text[position + 1] == quote && text[position + 2] == quote;
        var delimiter = triple ? new string(quote, 3) : quote.ToString();
        var contentStart = position + delimiter.Length;
        var cursor = contentStart;
        while (cursor < text.Length)
        {
            if (text[cursor] == '\\')
            {
                cursor += 2;
                continue;
            }

            if (string.CompareOrdinal(text, cursor, delimiter, 0, delimiter.Length) == 0)
            {
                break;
            }

            cursor++;
        }

        if (cursor >= text.Length)
        {
            return null;
        }

        var rest = text[(cursor + delimiter.Length)..].Trim();
        if (rest.Length > 0 && rest != ";")
        {
            return null;
        }

        var content = text[contentStart..cursor].Trim();
        var paragraph = BlankLineBreak().Split(content)[0];
        paragraph = WhitespaceRun().Replace(paragraph, " ").Trim();
        return paragraph.Length == 0 ? null : paragraph;
    }

    /// <summary>
    /// Tokenizes Python just enough to find logical lines: triple-quoted strings, single-line
    /// strings, comments, bracket continuation and backslash continuation. Blank and
    /// comment-only lines between statements are not logical lines.
    /// </summary>
    private static List<LogicalLine> ScanPython(string[] lines)
    {
        var result = new List<LogicalLine>();
        var builder = new StringBuilder();
        var inLogical = false;
        var tripleQuote = '\0';
        var depth = 0;
        var start = 0;
        var indent = 0;
        var headerEnd = -1;

        for (var index = 0; index < lines.Length; index++)
        {
            var line = lines[index];
            if (!inLogical)
            {
                var trimmed = line.TrimStart();
                if (trimmed.Length == 0 || trimmed[0] == '#')
                {
                    continue;
                }

                inLogical = true;
                start = index + 1;
                indent = IndentOf(line);
                line = trimmed;
                builder.Clear();
                depth = 0;
                headerEnd = -1;
            }
            else
            {
                builder.Append('\n');
            }

            var continued = false;
            var cursor = 0;
            while (cursor < line.Length)
            {
                var c = line[cursor];
                if (tripleQuote != '\0')
                {
                    if (c == '\\' && cursor + 1 < line.Length)
                    {
                        builder.Append(c).Append(line[cursor + 1]);
                        cursor += 2;
                    }
                    else if (c == tripleQuote && IsTriple(line, cursor, c))
                    {
                        builder.Append(c).Append(c).Append(c);
                        tripleQuote = '\0';
                        cursor += 3;
                    }
                    else
                    {
                        builder.Append(c);
                        cursor++;
                    }

                    continue;
                }

                if (c == '#')
                {
                    break;
                }

                if (c == '"' || c == '\'')
                {
                    if (IsTriple(line, cursor, c))
                    {
                        builder.Append(c).Append(c).Append(c);
                        tripleQuote = c;
                        cursor += 3;
                        continue;
                    }

                    builder.Append(c);
                    cursor++;
                    while (cursor < line.Length)
                    {
                        var inner = line[cursor];
                        if (inner == '\\' && cursor + 1 < line.Length)
                        {
                            builder.Append(inner).Append(line[cursor + 1]);
                            cursor += 2;
                            continue;
                        }

                        builder.Append(inner);
                        cursor++;
                        if (inner == c)
                        {
                            break;
                        }
                    }

                    continue;
                }

                if (c == '(' || c == '[' || c == '{')
                {
                    depth++;
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    depth = Math.Max(0, depth - 1);
                }
                else if (c == ':' && depth == 0 && headerEnd < 0)
                {
                    headerEnd = builder.Length;
                }
                else if (c == '\\' && cursor == line.Length - 1)
                {
                    continued = true;
                    cursor++;
                    continue;
                }

                builder.Append(c);
                cursor++;
            }

            if (tripleQuote == '\0' && depth == 0 && !continued)
            {
                result.Add(new LogicalLine(start, index + 1, indent, builder.ToString(), headerEnd));
                inLogical = false;
            }
        }

        if (inLogical)
        {
            result.Add(new LogicalLine(start, LastContentLine(lines), indent, builder.ToString(), headerEnd));
        }

        return result;
    }

    private static bool IsTriple(string line, int cursor, char quote) =>
        cursor + 2 < line.Length && line[cursor + 1] == quote && line[cursor + 2] == quote;

    private static int IndentOf(string line)
    {
        var width = 0;
        foreach (var c in line)
        {
            if (c == ' ')
            {
                width++;
            }
            else if (c == '\t')
            {
                width = (width / 8 + 1) * 8;
            }
            else
            {
                break;
            }
        }

        return width;
    }
}
