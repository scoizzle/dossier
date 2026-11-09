# Fact fea91b2b

Store id: 3634f7f8-1661-4cf2-b268-2c7656a145e5

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
- posted_at: `2026-11-09T22:39:41.5097050+00:00`

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
  "id": "3634f7f8-1661-4cf2-b268-2c7656a145e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5097050+00:00"
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
  "subject_id": "e37fcad5-1ce1-40c4-a2ba-0e09425acae6",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_over_clause",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_over_clause(self)"
}
```
