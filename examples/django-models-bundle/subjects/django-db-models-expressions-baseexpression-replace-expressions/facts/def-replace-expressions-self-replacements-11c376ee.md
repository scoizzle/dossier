# Fact 11c376ee

Store id: 7eae5ae7-49af-4035-93d7-d936e1e12cb7

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
- posted_at: `2026-11-09T23:31:55.7874010+00:00`

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
  "id": "7eae5ae7-49af-4035-93d7-d936e1e12cb7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7874010+00:00"
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
  "subject_id": "fee2b647-c953-4aa5-813c-5c054f6fbf53",
  "subject_name": "django/db/models/expressions::BaseExpression.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
