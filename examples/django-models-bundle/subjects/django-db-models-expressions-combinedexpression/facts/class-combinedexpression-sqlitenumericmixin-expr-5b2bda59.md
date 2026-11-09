# Fact 5b2bda59

Store id: e1d0ec1d-7b06-4f21-8ce9-29b9858bc0e0

## Text

```text
class CombinedExpression(SQLiteNumericMixin, Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5433790+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 728,
  "symbol": "CombinedExpression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":728,"selector":"L728-L812","symbol":"CombinedExpression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 728,
    "symbol": "CombinedExpression"
  },
  "id": "e1d0ec1d-7b06-4f21-8ce9-29b9858bc0e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5433790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 728,
        "selector": "L728-L812",
        "symbol": "CombinedExpression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a5a944ce-8602-443c-95e1-1363c78884de",
  "subject_name": "django/db/models/expressions::CombinedExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class CombinedExpression(SQLiteNumericMixin, Expression)"
}
```
