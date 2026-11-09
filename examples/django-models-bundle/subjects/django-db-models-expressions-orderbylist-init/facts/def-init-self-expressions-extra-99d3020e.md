# Fact 99d3020e

Store id: 556aa426-cee6-47b9-9178-18acb79e18c4

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T23:31:55.9312230+00:00`

## Data

```json
{
  "end_line": 1529,
  "entity_kind": "method",
  "parent": "OrderByList",
  "start_line": 1520,
  "symbol": "OrderByList.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1520,"selector":"L1520-L1529","symbol":"OrderByList.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderByList.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1529,
    "entity_kind": "method",
    "parent": "OrderByList",
    "start_line": 1520,
    "symbol": "OrderByList.__init__"
  },
  "id": "556aa426-cee6-47b9-9178-18acb79e18c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9312230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1520,
        "selector": "L1520-L1529",
        "symbol": "OrderByList.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b13e569c-d9b2-40a7-a817-bc16600dcca5",
  "subject_name": "django/db/models/expressions::OrderByList.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
