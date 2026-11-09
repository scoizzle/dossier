# Fact 56ca31af

Store id: ff883cb2-e91f-468d-8489-4a8b910f1982

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
- posted_at: `2026-11-09T23:32:02.9586020+00:00`

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
  "id": "ff883cb2-e91f-468d-8489-4a8b910f1982",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9586020+00:00"
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
  "subject_id": "012938f2-21a6-439a-9f48-478c9ee5c4eb",
  "subject_name": "django/db/models/indexes::IndexExpression.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False, )"
}
```
