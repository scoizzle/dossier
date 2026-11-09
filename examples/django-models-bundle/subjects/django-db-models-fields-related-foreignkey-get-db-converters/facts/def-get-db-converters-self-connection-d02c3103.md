# Fact d02c3103

Store id: c1a1f949-b96a-480b-9d62-2955cd42b18c

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
- posted_at: `2026-11-09T22:39:44.4204850+00:00`

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
  "id": "c1a1f949-b96a-480b-9d62-2955cd42b18c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4204850+00:00"
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
  "subject_id": "a085c825-06ac-4822-bb9a-00b32ddca84f",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
