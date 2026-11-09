# Fact c1c960d1

Store id: 18e85f28-2983-43ee-923e-b1192b5aae9a

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
- posted_at: `2026-11-09T23:31:55.9098180+00:00`

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
  "id": "18e85f28-2983-43ee-923e-b1192b5aae9a",
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
    "posted_at": "2026-11-09T23:31:55.9098180+00:00"
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
  "subject_id": "bd5c4c3c-4c58-4b69-a61c-23ff424bbaae",
  "subject_name": "django/db/models/expressions::Ref",
  "tags": [
    "entity:class"
  ],
  "text": "class Ref(Expression)"
}
```
