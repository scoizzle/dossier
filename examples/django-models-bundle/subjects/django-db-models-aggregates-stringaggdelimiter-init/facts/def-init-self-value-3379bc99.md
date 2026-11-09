# Fact 3379bc99

Store id: d875581e-1f9e-4f1a-a2e7-38cf7c2c2c70

## Text

```text
def __init__(self, value)
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
- posted_at: `2026-11-09T22:39:40.0466250+00:00`

## Data

```json
{
  "end_line": 358,
  "entity_kind": "method",
  "parent": "StringAggDelimiter",
  "start_line": 356,
  "symbol": "StringAggDelimiter.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":356,"selector":"L356-L358","symbol":"StringAggDelimiter.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAggDelimiter.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 358,
    "entity_kind": "method",
    "parent": "StringAggDelimiter",
    "start_line": 356,
    "symbol": "StringAggDelimiter.__init__"
  },
  "id": "d875581e-1f9e-4f1a-a2e7-38cf7c2c2c70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0466250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 356,
        "selector": "L356-L358",
        "symbol": "StringAggDelimiter.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "3f22cd1b-ff40-4546-9f40-6f2ec0585cb2",
  "subject_name": "django/db/models/aggregates::StringAggDelimiter.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, value)"
}
```
