using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace Dossier;

public sealed partial class DossierStore
{
    /// <summary>
    /// show: one fact with its refs, its attachments, and the inbound facts that reference it
    /// (the same reverse lookup as search ref_target direction=in). Returns null for an unknown id.
    /// </summary>
    public ShowResult? Show(string id)
    {
        FactRecord fact;
        List<RefRecord> refs;
        List<AttachmentRecord> attachments;

        using (var connection = OpenConnection())
        {
            using (var command = Command(
                connection,
                null,
                """
                SELECT id, subject_id, kind, key, text, data, items, tags, confidence, status, provenance, content_hash, created_at
                FROM facts WHERE id = $id
                """))
            {
                Bind(command, "$id", id);
                using var reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }

                fact = new FactRecord
                {
                    Id = reader.GetString(0),
                    SubjectId = reader.GetString(1),
                    Kind = reader.GetString(2),
                    Key = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Text = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Data = ParseJson(reader.IsDBNull(5) ? null : reader.GetString(5)),
                    Items = ParseJson(reader.IsDBNull(6) ? null : reader.GetString(6)),
                    Tags = ParseAliases(reader.GetString(7)),
                    Confidence = reader.GetDouble(8),
                    Status = reader.GetString(9),
                    Provenance = ParseJson(reader.GetString(10)),
                    ContentHash = reader.GetString(11),
                    CreatedAt = reader.GetString(12),
                };
            }

            refs = ReadRefs(connection, id);
            attachments = ReadAttachments(connection, id);
        }

        var inbound = Search(new SearchRequest { RefTarget = id, Direction = "in", Limit = MaxLimit }).Hits;

        return new ShowResult
        {
            Fact = fact,
            Refs = refs,
            Attachments = attachments,
            Inbound = inbound,
        };
    }

    private static List<RefRecord> ReadRefs(SqliteConnection connection, string id)
    {
        var refs = new List<RefRecord>();
        using var command = Command(
            connection,
            null,
            """
            SELECT rel, kind, target, locator, basis, confidence, seq, rev, snapshot, snapshot_hash, etag, verified_at, valid
            FROM refs WHERE fact_id = $id ORDER BY seq
            """);
        Bind(command, "$id", id);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            refs.Add(new RefRecord
            {
                Rel = reader.GetString(0),
                Kind = reader.GetString(1),
                Target = reader.GetString(2),
                Locator = ParseJson(reader.IsDBNull(3) ? null : reader.GetString(3)),
                Basis = reader.GetString(4),
                Confidence = reader.IsDBNull(5) ? null : reader.GetDouble(5),
                Seq = (int)reader.GetInt64(6),
                Rev = reader.IsDBNull(7) ? null : reader.GetString(7),
                Snapshot = reader.IsDBNull(8) ? null : reader.GetString(8),
                SnapshotHash = reader.IsDBNull(9) ? null : reader.GetString(9),
                Etag = reader.IsDBNull(10) ? null : reader.GetString(10),
                VerifiedAt = reader.IsDBNull(11) ? null : reader.GetString(11),
                Valid = reader.IsDBNull(12) ? null : reader.GetInt64(12) != 0,
            });
        }

        return refs;
    }

    private static List<AttachmentRecord> ReadAttachments(SqliteConnection connection, string id)
    {
        var attachments = new List<AttachmentRecord>();
        using var command = Command(
            connection,
            null,
            "SELECT sha256, filename, mime, bytes, perceptual FROM attachments WHERE fact_id = $id ORDER BY sha256");
        Bind(command, "$id", id);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            attachments.Add(new AttachmentRecord
            {
                Sha256 = reader.GetString(0),
                Filename = reader.GetString(1),
                Mime = reader.GetString(2),
                Bytes = reader.GetInt64(3),
                Perceptual = ParseJson(reader.IsDBNull(4) ? null : reader.GetString(4)),
            });
        }

        return attachments;
    }

    private static JsonElement? ParseJson(string? json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return null;
        }

        try
        {
            using var document = JsonDocument.Parse(json);
            return document.RootElement.Clone();
        }
        catch (JsonException)
        {
            return null;
        }
    }
}
