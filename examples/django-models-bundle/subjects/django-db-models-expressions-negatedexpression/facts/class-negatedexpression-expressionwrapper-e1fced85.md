# Fact e1fced85

Store id: f24a7ff3-4433-4471-bb7b-af1116e0b84f

## Text

```text
class NegatedExpression(ExpressionWrapper)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6006400+00:00`

## Data

```json
{
  "end_line": 1632,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1584,
  "symbol": "NegatedExpression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1584,"selector":"L1584-L1632","symbol":"NegatedExpression"}`

## Items

```json
[
  {
    "text": "The logical negation of a conditional expression.",
    "locator": {
      "line": 1585
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1632,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1584,
    "symbol": "NegatedExpression"
  },
  "id": "f24a7ff3-4433-4471-bb7b-af1116e0b84f",
  "items": [
    {
      "locator": {
        "line": 1585
      },
      "text": "The logical negation of a conditional expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6006400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1584,
        "selector": "L1584-L1632",
        "symbol": "NegatedExpression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c4c379a7-d006-4eeb-aa42-abc48f39a2aa",
  "subject_name": "django/db/models/expressions::NegatedExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class NegatedExpression(ExpressionWrapper)"
}
```
