# Fact e598722f

Store id: 0ca75388-50f5-4726-8e72-c592a2c2a7e2

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
- posted_at: `2026-11-09T23:44:49.5568750+00:00`

## Data

```json
{
  "end_line": 1387,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1382,
  "symbol": "Col.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1382,"selector":"L1382-L1387","symbol":"Col.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1387,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1382,
    "symbol": "Col.get_db_converters"
  },
  "id": "0ca75388-50f5-4726-8e72-c592a2c2a7e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5568750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1382,
        "selector": "L1382-L1387",
        "symbol": "Col.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "aafbbfb9-eec4-44c3-9587-487b766cbd46",
  "subject_name": "django/db/models/expressions::Col.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
