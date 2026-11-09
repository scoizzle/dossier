# Fact 78e7a890

Store id: 03aad24a-6772-4023-86aa-4a195ba5c7e3

## Text

```text
def prefetch_one_level(instances, prefetcher, lookup, level)
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
- posted_at: `2026-11-09T22:39:49.8979680+00:00`

## Data

```json
{
  "end_line": 2981,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2874,
  "symbol": "prefetch_one_level"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2874,"selector":"L2874-L2981","symbol":"prefetch_one_level"}`

## Items

```json
[
  {
    "text": "Helper function for prefetch_related_objects().",
    "locator": {
      "line": 2875
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::prefetch_one_level](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2981,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2874,
    "symbol": "prefetch_one_level"
  },
  "id": "03aad24a-6772-4023-86aa-4a195ba5c7e3",
  "items": [
    {
      "locator": {
        "line": 2875
      },
      "text": "Helper function for prefetch_related_objects()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8979680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2874,
        "selector": "L2874-L2981",
        "symbol": "prefetch_one_level"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c82ffeb5-c890-4bba-8e64-a318d0a6c034",
  "subject_name": "django/db/models/query::prefetch_one_level",
  "tags": [
    "entity:function"
  ],
  "text": "def prefetch_one_level(instances, prefetcher, lookup, level)"
}
```
