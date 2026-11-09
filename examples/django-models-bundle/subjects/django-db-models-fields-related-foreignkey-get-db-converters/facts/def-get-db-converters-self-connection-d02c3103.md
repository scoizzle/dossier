# Fact d02c3103

Store id: 1ac5c632-eccc-4912-9e51-87f3f9b4e1f9

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6105730+00:00`

## Data

```json
{
  "end_line": 1339,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1335,
  "symbol": "ForeignKey.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1335,"selector":"L1335-L1339","symbol":"ForeignKey.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1339,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1335,
    "symbol": "ForeignKey.get_db_converters"
  },
  "id": "1ac5c632-eccc-4912-9e51-87f3f9b4e1f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6105730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1335,
        "selector": "L1335-L1339",
        "symbol": "ForeignKey.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a087fbf5-e83c-4566-9d49-b12a4a9998ba",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
