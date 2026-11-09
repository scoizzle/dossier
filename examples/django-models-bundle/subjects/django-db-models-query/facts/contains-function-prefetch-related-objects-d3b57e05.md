# Fact d3b57e05

Store id: 05703e45-64db-4597-b085-e493f03ef8a0

## Text

```text
contains function prefetch_related_objects
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
  - target: [django/db/models/query::prefetch_related_objects](../../django-db-models-query-prefetch-related-objects/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2646,"symbol":"prefetch_related_objects"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "05703e45-64db-4597-b085-e493f03ef8a0",
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
        "line": 2646,
        "symbol": "prefetch_related_objects"
      },
      "rel": "contains",
      "target": "5dda99da-a906-4142-bebe-f14d7d5ee459"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_related_objects"
}
```
