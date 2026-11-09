# Fact 56ca31af

Store id: 67121d41-117e-4fb3-94d5-a87afbcf62e1

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False, )
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
- posted_at: `2026-11-09T23:44:54.7171660+00:00`

## Data

```json
{
  "end_line": 387,
  "entity_kind": "method",
  "parent": "IndexExpression",
  "start_line": 328,
  "symbol": "IndexExpression.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":328,"selector":"L328-L387","symbol":"IndexExpression.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::IndexExpression.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 387,
    "entity_kind": "method",
    "parent": "IndexExpression",
    "start_line": 328,
    "symbol": "IndexExpression.resolve_expression"
  },
  "id": "67121d41-117e-4fb3-94d5-a87afbcf62e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.7171660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 328,
        "selector": "L328-L387",
        "symbol": "IndexExpression.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "b9936f0b-aab3-46d2-a9ee-94c7b8198ee1",
  "subject_name": "django/db/models/indexes::IndexExpression.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False, )"
}
```
