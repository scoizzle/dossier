# Fact ace4ef6f

Store id: c13ec238-4853-45c7-b306-0071d35252a4

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
- posted_at: `2026-11-09T23:31:53.5308590+00:00`

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
  "id": "c13ec238-4853-45c7-b306-0071d35252a4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5308590+00:00"
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
  "subject_id": "c3352df0-9c89-44ed-89a2-edd9960a8e20",
  "subject_name": "django/db/models/aggregates::AggregateOrderBy",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateOrderBy(OrderByList)"
}
```
