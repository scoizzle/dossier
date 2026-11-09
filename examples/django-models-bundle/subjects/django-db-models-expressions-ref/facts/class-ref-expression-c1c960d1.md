# Fact c1c960d1

Store id: 475d81c9-6627-477f-88ff-65477ca44f5d

## Text

```text
class Ref(Expression)
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
- posted_at: `2026-11-09T22:39:41.6491180+00:00`

## Data

```json
{
  "end_line": 1485,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1447,
  "symbol": "Ref"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1447,"selector":"L1447-L1485","symbol":"Ref"}`

## Items

```json
[
  {
    "text": "Reference to column alias of the query. For example, Ref('sum_cost') in qs.annotate(sum_cost=Sum('cost')) query.",
    "locator": {
      "line": 1448
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1485,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1447,
    "symbol": "Ref"
  },
  "id": "475d81c9-6627-477f-88ff-65477ca44f5d",
  "items": [
    {
      "locator": {
        "line": 1448
      },
      "text": "Reference to column alias of the query. For example, Ref('sum_cost') in qs.annotate(sum_cost=Sum('cost')) query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6491180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1447,
        "selector": "L1447-L1485",
        "symbol": "Ref"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9be5e3e9-57ac-4bbf-bf5d-b6fce6a3d119",
  "subject_name": "django/db/models/expressions::Ref",
  "tags": [
    "entity:class"
  ],
  "text": "class Ref(Expression)"
}
```
