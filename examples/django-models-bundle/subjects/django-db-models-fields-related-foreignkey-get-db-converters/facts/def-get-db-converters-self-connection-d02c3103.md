# Fact d02c3103

Store id: 5eb2f33f-d8a2-442d-b511-199b4a2e1af6

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
- posted_at: `2026-11-09T23:31:58.7941400+00:00`

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
  "id": "5eb2f33f-d8a2-442d-b511-199b4a2e1af6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7941400+00:00"
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
  "subject_id": "8e57a704-b4e6-45cc-a410-549491cada8e",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
