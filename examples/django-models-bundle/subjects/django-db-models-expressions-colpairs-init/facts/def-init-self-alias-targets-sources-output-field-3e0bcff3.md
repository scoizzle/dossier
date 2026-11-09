# Fact 3e0bcff3

Store id: 9cd69093-9320-460d-88b7-9929763a2e2b

## Text

```text
def __init__(self, alias, targets, sources, output_field)
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
- posted_at: `2026-11-09T22:39:41.6380140+00:00`

## Data

```json
{
  "end_line": 1395,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1391,
  "symbol": "ColPairs.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1391,"selector":"L1391-L1395","symbol":"ColPairs.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1395,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1391,
    "symbol": "ColPairs.__init__"
  },
  "id": "9cd69093-9320-460d-88b7-9929763a2e2b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6380140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1391,
        "selector": "L1391-L1395",
        "symbol": "ColPairs.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c6a356c9-73ec-4f80-b745-ef3f17dd090d",
  "subject_name": "django/db/models/expressions::ColPairs.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, targets, sources, output_field)"
}
```
