# Fact 5b2bda59

Store id: a60eb400-e683-4b23-9955-e9a169e371d6

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
- posted_at: `2026-11-09T23:44:49.4321120+00:00`

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
  "id": "a60eb400-e683-4b23-9955-e9a169e371d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4321120+00:00"
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
  "subject_id": "075c5403-621a-4054-9731-8f247da75101",
  "subject_name": "django/db/models/expressions::CombinedExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class CombinedExpression(SQLiteNumericMixin, Expression)"
}
```
