# Fact fea91b2b

Store id: 5e70e64f-24d6-4d17-b402-13f3b6d807cb

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
- posted_at: `2026-11-09T23:44:49.3153790+00:00`

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
  "id": "5e70e64f-24d6-4d17-b402-13f3b6d807cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3153790+00:00"
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
  "subject_id": "8a85a815-2954-47cb-99a1-8f0f4babc089",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_over_clause",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_over_clause(self)"
}
```
