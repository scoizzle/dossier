# Fact d3b57e05

Store id: 78196d3d-40ba-4261-9b78-1fdcf454672e

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "78196d3d-40ba-4261-9b78-1fdcf454672e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3472900+00:00"
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
      "target": "00fde7da-73d7-4a5b-9959-21f0ee5b7c7d"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_related_objects"
}
```
