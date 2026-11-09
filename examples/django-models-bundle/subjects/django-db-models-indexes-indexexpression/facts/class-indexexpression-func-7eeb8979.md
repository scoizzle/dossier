# Fact 7eeb8979

Store id: f2363153-81ff-4a32-86cd-faa57a500994

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
- posted_at: `2026-11-09T22:39:47.8122560+00:00`

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
  "id": "f2363153-81ff-4a32-86cd-faa57a500994",
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
    "posted_at": "2026-11-09T22:39:47.8122560+00:00"
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
  "subject_id": "359f5a6a-c25f-4e68-8942-70bb4f1647e0",
  "subject_name": "django/db/models/indexes::IndexExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class IndexExpression(Func)"
}
```
