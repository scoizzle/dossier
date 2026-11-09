# Fact b948c82a

Store id: 177811c2-01fa-43cf-8cf8-b1929c778976

## Text

```text
async def aprefetch_related_objects(model_instances, *related_lookups)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:async_function`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.8759200+00:00`

## Data

```json
{
  "end_line": 2806,
  "entity_kind": "async_function",
  "parent": "query",
  "start_line": 2802,
  "symbol": "aprefetch_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2802,"selector":"L2802-L2806","symbol":"aprefetch_related_objects"}`

## Items

```json
[
  {
    "text": "See prefetch_related_objects().",
    "locator": {
      "line": 2803
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::aprefetch_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2806,
    "entity_kind": "async_function",
    "parent": "query",
    "start_line": 2802,
    "symbol": "aprefetch_related_objects"
  },
  "id": "177811c2-01fa-43cf-8cf8-b1929c778976",
  "items": [
    {
      "locator": {
        "line": 2803
      },
      "text": "See prefetch_related_objects()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8759200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2802,
        "selector": "L2802-L2806",
        "symbol": "aprefetch_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "12dc9d5b-cdc5-4d8f-afa7-49a0f329cb67",
  "subject_name": "django/db/models/query::aprefetch_related_objects",
  "tags": [
    "entity:async_function",
    "async"
  ],
  "text": "async def aprefetch_related_objects(model_instances, *related_lookups)"
}
```
