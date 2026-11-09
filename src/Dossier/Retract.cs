using Microsoft.Data.Sqlite;

namespace Dossier;

public sealed partial class DossierStore
{
    /// <summary>
    /// Retracts a fact: status=retracted, text/data nulled, FTS row removed, slot cleared,
    /// and attachment blobs deleted only when no other live fact references the same sha256.
    /// id, content_hash, provenance and created_at are left intact.
    /// </summary>
    public RetractResult Retract(string id)
    {
        using var connection = OpenConnection();
        using var transaction = connection.BeginTransaction();

        long rowId;
        using (var find = Command(connection, transaction, "SELECT rowid FROM facts WHERE id = $id"))
        {
            Bind(find, "$id", id);
            var found = find.ExecuteScalar();
            if (found is null)
            {
                return new RetractResult(false, id);
            }

            rowId = (long)found;
        }

        using (var tombstone = Command(connection, transaction, "UPDATE facts SET status = 'retracted', text = NULL, data = NULL WHERE id = $id"))
        {
            Bind(tombstone, "$id", id);
            tombstone.ExecuteNonQuery();
        }

        using (var fts = Command(connection, transaction, "DELETE FROM facts_fts WHERE rowid = $rowid"))
        {
            Bind(fts, "$rowid", rowId);
            fts.ExecuteNonQuery();
        }

        using (var slot = Command(connection, transaction, "DELETE FROM slots WHERE fact_id = $id"))
        {
            Bind(slot, "$id", id);
            slot.ExecuteNonQuery();
        }

        var shas = new List<string>();
        using (var attachments = Command(connection, transaction, "SELECT DISTINCT sha256 FROM attachments WHERE fact_id = $id"))
        {
            Bind(attachments, "$id", id);
            using var reader = attachments.ExecuteReader();
            while (reader.Read())
            {
                shas.Add(reader.GetString(0));
            }
        }

        transaction.Commit();

        foreach (var sha in shas)
        {
            if (CountLiveFactsForSha(sha) == 0)
            {
                var blob = Path.Combine(BlobRoot, sha);
                if (File.Exists(blob))
                {
                    File.Delete(blob);
                }
            }
        }

        return new RetractResult(true, id);
    }

    private int CountLiveFactsForSha(string sha)
    {
        using var connection = OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT COUNT(*)
            FROM attachments a
            JOIN facts f ON f.id = a.fact_id
            WHERE a.sha256 = $sha AND f.status = 'live'
            """;
        Bind(command, "$sha", sha);
        return Convert.ToInt32(command.ExecuteScalar());
    }
}
