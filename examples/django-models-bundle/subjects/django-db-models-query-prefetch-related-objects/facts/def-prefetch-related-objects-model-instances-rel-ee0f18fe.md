# Fact ee0f18fe

Store id: d5754c02-1b02-4b52-b0af-6c71260c5997

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
- posted_at: `2026-11-09T23:44:56.3090800+00:00`

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
  "id": "d5754c02-1b02-4b52-b0af-6c71260c5997",
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
    "posted_at": "2026-11-09T23:44:56.3090800+00:00"
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
  "subject_id": "00fde7da-73d7-4a5b-9959-21f0ee5b7c7d",
  "subject_name": "django/db/models/query::prefetch_related_objects",
  "tags": [
    "entity:function"
  ],
  "text": "def prefetch_related_objects(model_instances, *related_lookups)"
}
```
