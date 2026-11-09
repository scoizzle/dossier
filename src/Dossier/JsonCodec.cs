using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dossier;

/// <summary>One serializer configuration: snake_case contract field names.</summary>
public static class JsonCodec
{
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };
}
