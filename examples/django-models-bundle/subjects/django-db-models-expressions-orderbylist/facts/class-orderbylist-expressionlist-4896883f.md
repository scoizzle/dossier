# Fact 4896883f

Store id: e21fa802-b5a9-450e-9578-e23d4dba8464

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
- posted_at: `2026-11-09T22:39:41.6644480+00:00`

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
  "id": "e21fa802-b5a9-450e-9578-e23d4dba8464",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6644480+00:00"
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
  "subject_id": "012e44ee-39d2-43eb-b49b-6aaa4e92fd89",
  "subject_name": "django/db/models/expressions::OrderByList",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderByList(ExpressionList)"
}
```
