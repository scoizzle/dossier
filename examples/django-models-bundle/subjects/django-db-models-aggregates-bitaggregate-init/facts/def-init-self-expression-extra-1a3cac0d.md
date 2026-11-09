# Fact 1a3cac0d

Store id: ad735231-d951-47da-bfe0-c2b922d392f5

## Text

```text
def __init__(self, expression, **extra)
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
- posted_at: `2026-11-09T23:44:48.3989050+00:00`

## Data

```json
{
  "end_line": 254,
  "entity_kind": "method",
  "parent": "BitAggregate",
  "start_line": 250,
  "symbol": "BitAggregate.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":250,"selector":"L250-L254","symbol":"BitAggregate.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAggregate.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 254,
    "entity_kind": "method",
    "parent": "BitAggregate",
    "start_line": 250,
    "symbol": "BitAggregate.__init__"
  },
  "id": "ad735231-d951-47da-bfe0-c2b922d392f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3989050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 250,
        "selector": "L250-L254",
        "symbol": "BitAggregate.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "f066613a-20bc-46f4-902c-f474c49994d0",
  "subject_name": "django/db/models/aggregates::BitAggregate.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, **extra)"
}
```
