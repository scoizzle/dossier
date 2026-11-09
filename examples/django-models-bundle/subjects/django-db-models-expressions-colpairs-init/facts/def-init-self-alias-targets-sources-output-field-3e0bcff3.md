# Fact 3e0bcff3

Store id: 13173161-e667-4516-a158-ab56f15d4302

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
- posted_at: `2026-11-09T23:31:55.8988700+00:00`

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
  "id": "13173161-e667-4516-a158-ab56f15d4302",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8988700+00:00"
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
  "subject_id": "cc74db25-2cd4-4571-b2ed-2a14384c2d6f",
  "subject_name": "django/db/models/expressions::ColPairs.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, targets, sources, output_field)"
}
```
