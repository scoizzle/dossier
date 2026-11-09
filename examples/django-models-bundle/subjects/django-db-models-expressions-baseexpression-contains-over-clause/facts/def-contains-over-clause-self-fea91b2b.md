# Fact fea91b2b

Store id: 0b4f80f6-7ed9-4e6c-ae22-5341803b890f

## Text

```text
def contains_over_clause(self)
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
- posted_at: `2026-11-09T23:31:55.7674420+00:00`

## Data

```json
{
  "end_line": 263,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 259,
  "symbol": "BaseExpression.contains_over_clause"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":259,"selector":"L259-L263","symbol":"BaseExpression.contains_over_clause"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.contains_over_clause](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 263,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 259,
    "symbol": "BaseExpression.contains_over_clause"
  },
  "id": "0b4f80f6-7ed9-4e6c-ae22-5341803b890f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7674420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 259,
        "selector": "L259-L263",
        "symbol": "BaseExpression.contains_over_clause"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7e99dd79-6cb0-4f77-9060-33820c31f765",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_over_clause",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_over_clause(self)"
}
```
