# Fact 3e0bcff3

Store id: 338e1f1e-b43a-4135-b09c-ac061a2e5a08

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
- posted_at: `2026-11-09T23:44:49.5584520+00:00`

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
  "id": "338e1f1e-b43a-4135-b09c-ac061a2e5a08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5584520+00:00"
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
  "subject_id": "0d0a9cf2-9ca7-423e-922c-14ac3203e3b3",
  "subject_name": "django/db/models/expressions::ColPairs.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, targets, sources, output_field)"
}
```
