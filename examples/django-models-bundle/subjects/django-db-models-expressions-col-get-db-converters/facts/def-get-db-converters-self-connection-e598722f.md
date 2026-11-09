# Fact e598722f

Store id: 39311120-760e-41e8-ba38-de397cb1dce6

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
- posted_at: `2026-11-09T22:39:41.6357230+00:00`

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
  "id": "39311120-760e-41e8-ba38-de397cb1dce6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6357230+00:00"
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
  "subject_id": "906f4fca-d21b-4011-855a-0280785f3188",
  "subject_name": "django/db/models/expressions::Col.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
