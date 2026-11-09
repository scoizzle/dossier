# Fact 766a9a3e

Store id: 12bfaf9e-bf9f-4c90-947c-def8b542f09b

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:41.5490250+00:00`

## Data

```json
{
  "end_line": 776,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 764,
  "symbol": "CombinedExpression.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":764,"selector":"L764-L776","symbol":"CombinedExpression.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 776,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 764,
    "symbol": "CombinedExpression.as_sql"
  },
  "id": "12bfaf9e-bf9f-4c90-947c-def8b542f09b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5490250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 764,
        "selector": "L764-L776",
        "symbol": "CombinedExpression.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "38e2ca95-ec10-4501-a7e4-00bf145e0945",
  "subject_name": "django/db/models/expressions::CombinedExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
