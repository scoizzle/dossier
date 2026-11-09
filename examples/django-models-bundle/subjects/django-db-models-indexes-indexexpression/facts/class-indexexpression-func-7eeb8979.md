# Fact 7eeb8979

Store id: 3d5f3f62-71cc-41f2-966d-a61133caecbc

## Text

```text
class IndexExpression(Func)
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
- posted_at: `2026-11-09T23:44:54.7102620+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "class",
  "parent": "indexes",
  "start_line": 307,
  "symbol": "IndexExpression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":307,"selector":"L307-L391","symbol":"IndexExpression"}`

## Items

```json
[
  {
    "text": "Order and wrap expressions for CREATE INDEX statements.",
    "locator": {
      "line": 308
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/indexes::IndexExpression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "class",
    "parent": "indexes",
    "start_line": 307,
    "symbol": "IndexExpression"
  },
  "id": "3d5f3f62-71cc-41f2-966d-a61133caecbc",
  "items": [
    {
      "locator": {
        "line": 308
      },
      "text": "Order and wrap expressions for CREATE INDEX statements."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.7102620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 307,
        "selector": "L307-L391",
        "symbol": "IndexExpression"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "debbb8c3-c07b-4816-867a-a6d97e0b1fb5",
  "subject_name": "django/db/models/indexes::IndexExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class IndexExpression(Func)"
}
```
