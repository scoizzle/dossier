# Fact 78e41354

Store id: 83ddb587-3135-4d6c-97c5-a8d4a4fc3fe7

## Text

```text
contains function prefetch_one_level
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
- posted_at: `2026-11-09T22:39:49.9155620+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::prefetch_one_level](../../django-db-models-query-prefetch-one-level/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2874,"symbol":"prefetch_one_level"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "83ddb587-3135-4d6c-97c5-a8d4a4fc3fe7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9155620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2874,
        "symbol": "prefetch_one_level"
      },
      "rel": "contains",
      "target": "c82ffeb5-c890-4bba-8e64-a318d0a6c034"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_one_level"
}
```
