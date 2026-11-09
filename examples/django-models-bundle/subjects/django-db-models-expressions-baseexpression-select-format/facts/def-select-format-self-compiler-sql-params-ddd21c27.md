# Fact ddd21c27

Store id: d0341524-134d-4f99-a5e2-a019338f51d3

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T22:39:41.5337750+00:00`

## Data

```json
{
  "end_line": 501,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 494,
  "symbol": "BaseExpression.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":494,"selector":"L494-L501","symbol":"BaseExpression.select_format"}`

## Items

```json
[
  {
    "text": "Custom format for select clauses. For example, EXISTS expressions need to be wrapped in CASE WHEN on Oracle.",
    "locator": {
      "line": 495
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 501,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 494,
    "symbol": "BaseExpression.select_format"
  },
  "id": "d0341524-134d-4f99-a5e2-a019338f51d3",
  "items": [
    {
      "locator": {
        "line": 495
      },
      "text": "Custom format for select clauses. For example, EXISTS expressions need to be wrapped in CASE WHEN on Oracle."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5337750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 494,
        "selector": "L494-L501",
        "symbol": "BaseExpression.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e262aa95-1253-40f6-89fa-6405ddfb6381",
  "subject_name": "django/db/models/expressions::BaseExpression.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
