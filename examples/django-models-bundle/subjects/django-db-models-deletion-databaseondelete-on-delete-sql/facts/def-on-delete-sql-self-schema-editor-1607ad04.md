# Fact 1607ad04

Store id: 65999726-f6e8-4c83-bc66-2c62c8ff2ef2

## Text

```text
def on_delete_sql(self, schema_editor)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0894070+00:00`

## Data

```json
{
  "end_line": 93,
  "entity_kind": "method",
  "parent": "DatabaseOnDelete",
  "start_line": 92,
  "symbol": "DatabaseOnDelete.on_delete_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":92,"selector":"L92-L93","symbol":"DatabaseOnDelete.on_delete_sql"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DatabaseOnDelete.on_delete_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 93,
    "entity_kind": "method",
    "parent": "DatabaseOnDelete",
    "start_line": 92,
    "symbol": "DatabaseOnDelete.on_delete_sql"
  },
  "id": "65999726-f6e8-4c83-bc66-2c62c8ff2ef2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0894070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 92,
        "selector": "L92-L93",
        "symbol": "DatabaseOnDelete.on_delete_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "a445600c-efb6-4521-b9d4-7edace1774a1",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete.on_delete_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def on_delete_sql(self, schema_editor)"
}
```
