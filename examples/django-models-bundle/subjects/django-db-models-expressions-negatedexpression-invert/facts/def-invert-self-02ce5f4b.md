# Fact 02ce5f4b

Store id: d5160a65-68c6-4434-a2e7-c01c1d9843f4

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T23:44:49.6033550+00:00`

## Data

```json
{
  "end_line": 1591,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1590,
  "symbol": "NegatedExpression.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1590,"selector":"L1590-L1591","symbol":"NegatedExpression.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1591,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1590,
    "symbol": "NegatedExpression.__invert__"
  },
  "id": "d5160a65-68c6-4434-a2e7-c01c1d9843f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6033550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1590,
        "selector": "L1590-L1591",
        "symbol": "NegatedExpression.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f7e8a3c6-0b30-4159-a1ae-0807e5a6187f",
  "subject_name": "django/db/models/expressions::NegatedExpression.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
