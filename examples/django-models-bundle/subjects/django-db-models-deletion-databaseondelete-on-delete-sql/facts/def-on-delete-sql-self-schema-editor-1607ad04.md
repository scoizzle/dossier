# Fact 1607ad04

Store id: 9ee45e63-3d1e-4a97-a3ad-192068853eaf

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
- posted_at: `2026-11-09T23:44:48.9050260+00:00`

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
  "id": "9ee45e63-3d1e-4a97-a3ad-192068853eaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9050260+00:00"
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
  "subject_id": "e27994a3-564b-4af2-9c35-83b32e469494",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete.on_delete_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def on_delete_sql(self, schema_editor)"
}
```
