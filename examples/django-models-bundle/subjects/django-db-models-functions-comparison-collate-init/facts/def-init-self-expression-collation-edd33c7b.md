# Fact edd33c7b

Store id: d09cdc52-bce7-4fbb-819d-c281643ba21a

## Text

```text
def __init__(self, expression, collation)
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
- posted_at: `2026-11-09T23:32:00.9878690+00:00`

## Data

```json
{
  "end_line": 116,
  "entity_kind": "method",
  "parent": "Collate",
  "start_line": 112,
  "symbol": "Collate.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":112,"selector":"L112-L116","symbol":"Collate.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Collate.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 116,
    "entity_kind": "method",
    "parent": "Collate",
    "start_line": 112,
    "symbol": "Collate.__init__"
  },
  "id": "d09cdc52-bce7-4fbb-819d-c281643ba21a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9878690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 112,
        "selector": "L112-L116",
        "symbol": "Collate.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "546ab0fc-e753-4ba8-a95e-82ecae9d8ede",
  "subject_name": "django/db/models/functions/comparison::Collate.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, collation)"
}
```
