# Fact ace4ef6f

Store id: 962fc6ac-0d03-4d7f-9f5b-c50dead4a904

## Text

```text
class AggregateOrderBy(OrderByList)
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
- posted_at: `2026-11-09T22:39:40.0311140+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 62,
  "symbol": "AggregateOrderBy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":62,"selector":"L62-L72","symbol":"AggregateOrderBy"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateOrderBy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 62,
    "symbol": "AggregateOrderBy"
  },
  "id": "962fc6ac-0d03-4d7f-9f5b-c50dead4a904",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0311140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 62,
        "selector": "L62-L72",
        "symbol": "AggregateOrderBy"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "cbe2e7c2-b165-4474-ad57-3f4825bf7075",
  "subject_name": "django/db/models/aggregates::AggregateOrderBy",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateOrderBy(OrderByList)"
}
```
