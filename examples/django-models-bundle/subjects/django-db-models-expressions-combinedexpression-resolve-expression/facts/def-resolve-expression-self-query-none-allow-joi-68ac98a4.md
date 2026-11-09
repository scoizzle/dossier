# Fact 68ac98a4

Store id: af57cce1-ace9-453a-9ad6-445f6a4b5882

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
- posted_at: `2026-11-09T22:39:41.5497980+00:00`

## Data

```json
{
  "end_line": 808,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 778,
  "symbol": "CombinedExpression.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":778,"selector":"L778-L808","symbol":"CombinedExpression.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 808,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 778,
    "symbol": "CombinedExpression.resolve_expression"
  },
  "id": "af57cce1-ace9-453a-9ad6-445f6a4b5882",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5497980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 778,
        "selector": "L778-L808",
        "symbol": "CombinedExpression.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7965e397-2339-477f-a757-f368084f222d",
  "subject_name": "django/db/models/expressions::CombinedExpression.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
