# Fact e2e95a61

Store id: 6f35d0fe-6797-4b5b-83c7-1a3442662a42

## Text

```text
def conditional(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5137600+00:00`

## Data

```json
{
  "end_line": 319,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 317,
  "symbol": "BaseExpression.conditional"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":317,"selector":"L317-L319","symbol":"BaseExpression.conditional"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.conditional](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 319,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 317,
    "symbol": "BaseExpression.conditional"
  },
  "id": "6f35d0fe-6797-4b5b-83c7-1a3442662a42",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5137600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 317,
        "selector": "L317-L319",
        "symbol": "BaseExpression.conditional"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ac2d60c5-250a-4df2-af12-e90bdcd312ce",
  "subject_name": "django/db/models/expressions::BaseExpression.conditional",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def conditional(self)"
}
```
