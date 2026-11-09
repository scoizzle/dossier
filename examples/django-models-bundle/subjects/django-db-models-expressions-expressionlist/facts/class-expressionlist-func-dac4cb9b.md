# Fact dac4cb9b

Store id: b14d985b-1615-46db-88a0-e05856d76892

## Text

```text
class ExpressionList(Func)
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
- posted_at: `2026-11-09T22:39:41.6581260+00:00`

## Data

```json
{
  "end_line": 1513,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1488,
  "symbol": "ExpressionList"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1488,"selector":"L1488-L1513","symbol":"ExpressionList"}`

## Items

```json
[
  {
    "text": "An expression containing multiple expressions. Can be used to provide a list of expressions as an argument to another expression, like a partition clause.",
    "locator": {
      "line": 1489
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1513,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1488,
    "symbol": "ExpressionList"
  },
  "id": "b14d985b-1615-46db-88a0-e05856d76892",
  "items": [
    {
      "locator": {
        "line": 1489
      },
      "text": "An expression containing multiple expressions. Can be used to provide a list of expressions as an argument to another expression, like a partition clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6581260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1488,
        "selector": "L1488-L1513",
        "symbol": "ExpressionList"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1974fc9e-a23c-4498-be4f-939239e35ec4",
  "subject_name": "django/db/models/expressions::ExpressionList",
  "tags": [
    "entity:class"
  ],
  "text": "class ExpressionList(Func)"
}
```
