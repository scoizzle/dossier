# Fact 766a9a3e

Store id: 0681e515-ffe2-4b58-b972-a27779565db5

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
- posted_at: `2026-11-09T23:44:49.4491670+00:00`

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
  "id": "0681e515-ffe2-4b58-b972-a27779565db5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4491670+00:00"
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
  "subject_id": "eb182c60-5df0-43e0-878e-a4261f854509",
  "subject_name": "django/db/models/expressions::CombinedExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
