using System.Text;
using System.Text.Json;

namespace Dossier;

/// <summary>
/// Deterministic JSON: object keys sorted ordinally, no whitespace, numbers kept as written.
/// Used for content hashing and for every structured column we persist.
/// </summary>
public static class CanonicalJson
{
    public static string Write(JsonElement element)
    {
        var sb = new StringBuilder();
        Append(sb, element);
        return sb.ToString();
    }

    private static void Append(StringBuilder sb, JsonElement element)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                sb.Append('{');
                var first = true;
                foreach (var property in element.EnumerateObject().OrderBy(p => p.Name, StringComparer.Ordinal))
                {
                    if (!first)
                    {
                        sb.Append(',');
                    }

                    first = false;
                    sb.Append(JsonCodec.Quote(property.Name));
                    sb.Append(':');
                    Append(sb, property.Value);
                }

                sb.Append('}');
                break;

            case JsonValueKind.Array:
                sb.Append('[');
                var index = 0;
                foreach (var item in element.EnumerateArray())
                {
                    if (index++ > 0)
                    {
                        sb.Append(',');
                    }

                    Append(sb, item);
                }

                sb.Append(']');
                break;

            case JsonValueKind.String:
                sb.Append(JsonCodec.Quote(element.GetString()));
                break;

            case JsonValueKind.Number:
                sb.Append(element.GetRawText());
                break;

            case JsonValueKind.True:
                sb.Append("true");
                break;

            case JsonValueKind.False:
                sb.Append("false");
                break;

            case JsonValueKind.Null:
                sb.Append("null");
                break;

            default:
                sb.Append("null");
                break;
        }
    }
}
