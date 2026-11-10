using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Dossier;

/// <summary>
/// One serializer configuration: snake_case contract field names. Metadata comes from source
/// generation (<see cref="DossierJsonContext"/>), so every path is trim- and Native-AOT-safe.
/// </summary>
public static class JsonCodec
{
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        TypeInfoResolver = DossierJsonContext.Default,
    };

    internal static string Serialize<T>(T value) =>
        JsonSerializer.Serialize(value, (JsonTypeInfo<T>)Options.GetTypeInfo(typeof(T)));

    internal static T? Deserialize<T>(string json) =>
        JsonSerializer.Deserialize(json, (JsonTypeInfo<T>)Options.GetTypeInfo(typeof(T)));

    /// <summary>A JSON string literal with the default serializer settings (no naming policy).</summary>
    internal static string Quote(string? value) => JsonSerializer.Serialize(value, PlainJsonContext.Default.String);

    internal static string SerializeStrings(List<string> values) =>
        JsonSerializer.Serialize(values, PlainJsonContext.Default.ListString);

    internal static List<string>? DeserializeStrings(string json) =>
        JsonSerializer.Deserialize(json, PlainJsonContext.Default.ListString);

    /// <summary>
    /// A JSON object with the given fields in order; values are string, int or null. Written with the
    /// default encoder, so the text matches what the reflection serializer wrote for a dictionary.
    /// </summary>
    internal static JsonElement Object(params (string Name, object? Value)[] fields)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            writer.WriteStartObject();
            foreach (var (name, value) in fields)
            {
                switch (value)
                {
                    case null:
                        writer.WriteNull(name);
                        break;
                    case string text:
                        writer.WriteString(name, text);
                        break;
                    case int number:
                        writer.WriteNumber(name, number);
                        break;
                    default:
                        throw new NotSupportedException($"unsupported value type {value.GetType()}");
                }
            }

            writer.WriteEndObject();
        }

        using var document = JsonDocument.Parse(stream.ToArray());
        return document.RootElement.Clone();
    }
}

/// <summary>Plain (default-options) metadata: strings, string lists and the search cursor.</summary>
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(List<string>))]
[JsonSerializable(typeof(DossierStore.CursorState))]
internal sealed partial class PlainJsonContext : JsonSerializerContext
{
}

/// <summary>A tool-call failure envelope: {"error":{"code","message"}}.</summary>
internal sealed record ErrorEnvelope(ErrorBody Error)
{
    public static ErrorEnvelope Of(string code, string message) => new(new ErrorBody(code, message));
}

internal sealed record ErrorBody(string Code, string Message);

/// <summary>retract's CLI output.</summary>
internal sealed record RetractedOutput(string Id, string Status);

/// <summary>publish's CLI summary line.</summary>
internal sealed record PublishSummary(string Out, int Files, int Written, int Subjects, int Facts, List<string> Removed, string? Format = null, int? Assets = null);

/// <summary>import's CLI summary line.</summary>
internal sealed record ImportSummary(int Subjects, int Facts, int Refs, int Attachments, int Blobs, List<ImportSkip> Skipped);

/// <summary>The provenance stamp the CLI writes onto posted facts.</summary>
internal sealed record ProvenanceStamp(string Actor, string ActorType, string Channel, string PostedAt);

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower,
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(PostFactsRequest))]
[JsonSerializable(typeof(PostFactsResponse))]
[JsonSerializable(typeof(PostResult))]
[JsonSerializable(typeof(PostError))]
[JsonSerializable(typeof(DumpRequest))]
[JsonSerializable(typeof(DumpResponse))]
[JsonSerializable(typeof(CorrelateRequest))]
[JsonSerializable(typeof(CorrelateResponse))]
[JsonSerializable(typeof(SearchRequest))]
[JsonSerializable(typeof(SearchResponse))]
[JsonSerializable(typeof(BriefSearchResponse))]
[JsonSerializable(typeof(CheckRequest))]
[JsonSerializable(typeof(CheckResponse))]
[JsonSerializable(typeof(CompileRequest))]
[JsonSerializable(typeof(CompiledDossier))]
[JsonSerializable(typeof(DossierPin))]
[JsonSerializable(typeof(ShowResult))]
[JsonSerializable(typeof(List<SubjectSummary>))]
[JsonSerializable(typeof(List<FactInput>))]
[JsonSerializable(typeof(List<ItemInput>))]
[JsonSerializable(typeof(McpServer.FactIdArgs))]
[JsonSerializable(typeof(ErrorEnvelope))]
[JsonSerializable(typeof(RetractedOutput))]
[JsonSerializable(typeof(PublishSummary))]
[JsonSerializable(typeof(ImportSummary))]
[JsonSerializable(typeof(ProvenanceStamp))]
[JsonSerializable(typeof(GraphResponse))]
internal sealed partial class DossierJsonContext : JsonSerializerContext
{
}

/// <summary>Metadata for the indented JSON blocks in published fact files (own options instance).</summary>
[JsonSerializable(typeof(JsonElement))]
internal sealed partial class DataJsonContext : JsonSerializerContext
{
}
