# Fact 8d59cd5e

Store id: 9aa94aaf-ead4-4f8e-9712-d9d6411d2d52

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T23:44:49.6055060+00:00`

## Data

```json
{
  "end_line": 1617,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1609,
  "symbol": "NegatedExpression.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1609,"selector":"L1609-L1617","symbol":"NegatedExpression.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1617,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1609,
    "symbol": "NegatedExpression.resolve_expression"
  },
  "id": "9aa94aaf-ead4-4f8e-9712-d9d6411d2d52",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6055060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1609,
        "selector": "L1609-L1617",
        "symbol": "NegatedExpression.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9b43869b-758c-4ceb-96a1-07654074bcfd",
  "subject_name": "django/db/models/expressions::NegatedExpression.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
