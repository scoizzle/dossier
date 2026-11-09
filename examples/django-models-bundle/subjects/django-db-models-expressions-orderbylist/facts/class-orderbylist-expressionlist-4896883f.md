# Fact 4896883f

Store id: 28264c99-a4d4-4260-92a3-15a7664dd9a4

## Text

```text
class OrderByList(ExpressionList)
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
- posted_at: `2026-11-09T23:31:55.9303660+00:00`

## Data

```json
{
  "end_line": 1544,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1516,
  "symbol": "OrderByList"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1516,"selector":"L1516-L1544","symbol":"OrderByList"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderByList](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1544,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1516,
    "symbol": "OrderByList"
  },
  "id": "28264c99-a4d4-4260-92a3-15a7664dd9a4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9303660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1516,
        "selector": "L1516-L1544",
        "symbol": "OrderByList"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1fde638d-26e7-454e-b5ae-c84caff2ac98",
  "subject_name": "django/db/models/expressions::OrderByList",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderByList(ExpressionList)"
}
```
