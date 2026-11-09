# Fact 2ee227a8

Store id: d31bc6fe-b687-4df7-9c34-302604ac0994

## Text

```text
def contains_subquery(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5116580+00:00`

## Data

```json
{
  "end_line": 277,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 272,
  "symbol": "BaseExpression.contains_subquery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":272,"selector":"L272-L277","symbol":"BaseExpression.contains_subquery"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.contains_subquery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 277,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 272,
    "symbol": "BaseExpression.contains_subquery"
  },
  "id": "d31bc6fe-b687-4df7-9c34-302604ac0994",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5116580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 272,
        "selector": "L272-L277",
        "symbol": "BaseExpression.contains_subquery"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "15be7068-9032-4c8d-b7a7-e13c3a494b6a",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_subquery",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_subquery(self)"
}
```
