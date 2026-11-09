# Fact 11c376ee

Store id: f51ac5eb-c2d5-4e00-98ee-d3a1cfef53b8

## Text

```text
def replace_expressions(self, replacements)
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
- posted_at: `2026-11-09T23:44:49.3503370+00:00`

## Data

```json
{
  "end_line": 433,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 419,
  "symbol": "BaseExpression.replace_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":419,"selector":"L419-L433","symbol":"BaseExpression.replace_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.replace_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 433,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 419,
    "symbol": "BaseExpression.replace_expressions"
  },
  "id": "f51ac5eb-c2d5-4e00-98ee-d3a1cfef53b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3503370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 419,
        "selector": "L419-L433",
        "symbol": "BaseExpression.replace_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "02b00f97-5132-4b33-8f72-05e66f3fc4f5",
  "subject_name": "django/db/models/expressions::BaseExpression.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
