# Fact b948c82a

Store id: 8e5f5856-0150-4da5-81bd-fe9b0ade80fd

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
- posted_at: `2026-11-09T23:44:56.3120790+00:00`

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
  "id": "8e5f5856-0150-4da5-81bd-fe9b0ade80fd",
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
    "posted_at": "2026-11-09T23:44:56.3120790+00:00"
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
  "subject_id": "45085c27-5d7b-462b-ae2b-130979f46014",
  "subject_name": "django/db/models/query::aprefetch_related_objects",
  "tags": [
    "entity:async_function",
    "async"
  ],
  "text": "async def aprefetch_related_objects(model_instances, *related_lookups)"
}
```
