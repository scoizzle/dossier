# Fact 9707950d

Store id: 8ea0d407-8519-4a86-b047-c9d16241a735

## Text

```text
def __init__(self, expression)
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
- posted_at: `2026-11-09T23:44:49.6014230+00:00`

## Data

```json
{
  "end_line": 1588,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1587,
  "symbol": "NegatedExpression.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1587,"selector":"L1587-L1588","symbol":"NegatedExpression.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1588,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1587,
    "symbol": "NegatedExpression.__init__"
  },
  "id": "8ea0d407-8519-4a86-b047-c9d16241a735",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6014230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1587,
        "selector": "L1587-L1588",
        "symbol": "NegatedExpression.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "588b1793-d296-4bd4-829e-bf05f7ce3b24",
  "subject_name": "django/db/models/expressions::NegatedExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression)"
}
```
