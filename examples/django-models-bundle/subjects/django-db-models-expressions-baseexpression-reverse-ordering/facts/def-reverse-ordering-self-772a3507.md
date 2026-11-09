# Fact 772a3507

Store id: b421ea72-6c79-4593-9c52-d764cbde3de3

## Text

```text
def reverse_ordering(self)
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
- posted_at: `2026-11-09T22:39:41.5322250+00:00`

## Data

```json
{
  "end_line": 479,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 478,
  "symbol": "BaseExpression.reverse_ordering"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":478,"selector":"L478-L479","symbol":"BaseExpression.reverse_ordering"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.reverse_ordering](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 479,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 478,
    "symbol": "BaseExpression.reverse_ordering"
  },
  "id": "b421ea72-6c79-4593-9c52-d764cbde3de3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5322250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 478,
        "selector": "L478-L479",
        "symbol": "BaseExpression.reverse_ordering"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a36c729d-2a8e-49f6-a3cb-e090d254a5c9",
  "subject_name": "django/db/models/expressions::BaseExpression.reverse_ordering",
  "tags": [
    "entity:method"
  ],
  "text": "def reverse_ordering(self)"
}
```
