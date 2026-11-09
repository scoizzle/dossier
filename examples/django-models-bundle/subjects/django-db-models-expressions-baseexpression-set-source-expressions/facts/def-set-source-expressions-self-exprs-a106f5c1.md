# Fact a106f5c1

Store id: 5ba89721-673c-4f20-bab7-0ff5fb9cb2c8

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.2900380+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 212,
  "symbol": "BaseExpression.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L213","symbol":"BaseExpression.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 212,
    "symbol": "BaseExpression.set_source_expressions"
  },
  "id": "5ba89721-673c-4f20-bab7-0ff5fb9cb2c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2900380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L213",
        "symbol": "BaseExpression.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "167a3f35-2581-459d-bccd-1b9aeb2e2dfa",
  "subject_name": "django/db/models/expressions::BaseExpression.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
