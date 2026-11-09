# Fact 9707950d

Store id: 129c4b10-30fe-4b93-ac93-884420aa3c40

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
- posted_at: `2026-11-09T23:31:55.9403780+00:00`

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
  "id": "129c4b10-30fe-4b93-ac93-884420aa3c40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9403780+00:00"
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
  "subject_id": "0731fdb6-41bb-4c0a-8e41-16b4075bf42d",
  "subject_name": "django/db/models/expressions::NegatedExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression)"
}
```
