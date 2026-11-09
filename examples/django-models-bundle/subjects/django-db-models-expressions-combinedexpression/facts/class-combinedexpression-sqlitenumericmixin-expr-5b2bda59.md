# Fact 5b2bda59

Store id: 664a2b16-80d7-4679-8d02-f11f0907d8fd

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
- posted_at: `2026-11-09T23:31:55.8089370+00:00`

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
  "id": "664a2b16-80d7-4679-8d02-f11f0907d8fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8089370+00:00"
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
  "subject_id": "475b9494-1f66-4297-9815-e3b77e26fc91",
  "subject_name": "django/db/models/expressions::CombinedExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class CombinedExpression(SQLiteNumericMixin, Expression)"
}
```
