# Fact 2045d48b

Store id: 31062cb1-4f9d-4857-a248-db190c79fe62

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
- posted_at: `2026-11-09T22:39:42.3297780+00:00`

## Data

```json
{
  "end_line": 962,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 959,
  "symbol": "Field.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":959,"selector":"L959-L962","symbol":"Field.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 962,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 959,
    "symbol": "Field.get_db_converters"
  },
  "id": "31062cb1-4f9d-4857-a248-db190c79fe62",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3297780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 959,
        "selector": "L959-L962",
        "symbol": "Field.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bbb9fb5f-89d3-4b23-9aad-eb4f6cff1008",
  "subject_name": "django/db/models/fields/__init__::Field.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
