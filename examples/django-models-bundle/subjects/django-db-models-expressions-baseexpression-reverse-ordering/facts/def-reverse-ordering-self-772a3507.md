# Fact 772a3507

Store id: 1d749348-d007-4d2b-8814-0b854668be23

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
- posted_at: `2026-11-09T23:31:55.7939430+00:00`

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
  "id": "1d749348-d007-4d2b-8814-0b854668be23",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7939430+00:00"
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
  "subject_id": "7b183e73-09bf-48ae-9b39-e46263233a49",
  "subject_name": "django/db/models/expressions::BaseExpression.reverse_ordering",
  "tags": [
    "entity:method"
  ],
  "text": "def reverse_ordering(self)"
}
```
