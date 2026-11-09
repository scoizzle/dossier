# Fact 9707950d

Store id: 8316393c-ad23-4cdf-8f2c-1e6c48698922

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
- posted_at: `2026-11-09T22:39:41.6806500+00:00`

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
  "id": "8316393c-ad23-4cdf-8f2c-1e6c48698922",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6806500+00:00"
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
  "subject_id": "ba710e86-c104-4416-bf4f-f82dd8d1e8ab",
  "subject_name": "django/db/models/expressions::NegatedExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression)"
}
```
