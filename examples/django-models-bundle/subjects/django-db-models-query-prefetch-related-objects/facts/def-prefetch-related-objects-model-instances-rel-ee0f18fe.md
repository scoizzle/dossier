# Fact ee0f18fe

Store id: 90ffbb3d-5458-4c33-bb13-3a8563bbff1d

## Text

```text
def prefetch_related_objects(model_instances, *related_lookups)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.8725140+00:00`

## Data

```json
{
  "end_line": 2799,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2646,
  "symbol": "prefetch_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2646,"selector":"L2646-L2799","symbol":"prefetch_related_objects"}`

## Items

```json
[
  {
    "text": "Populate prefetched object caches for an iterable of model instances based on the lookups/Prefetch instances given.",
    "locator": {
      "line": 2647
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::prefetch_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2799,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2646,
    "symbol": "prefetch_related_objects"
  },
  "id": "90ffbb3d-5458-4c33-bb13-3a8563bbff1d",
  "items": [
    {
      "locator": {
        "line": 2647
      },
      "text": "Populate prefetched object caches for an iterable of model instances based on the lookups/Prefetch instances given."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8725140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2646,
        "selector": "L2646-L2799",
        "symbol": "prefetch_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5dda99da-a906-4142-bebe-f14d7d5ee459",
  "subject_name": "django/db/models/query::prefetch_related_objects",
  "tags": [
    "entity:function"
  ],
  "text": "def prefetch_related_objects(model_instances, *related_lookups)"
}
```
