# Fact d3b57e05

Store id: f68c1f92-11cd-45cc-b865-779ee4afe0bc

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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

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
  "id": "f68c1f92-11cd-45cc-b865-779ee4afe0bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8716240+00:00"
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
      "target": "2815ba7d-055e-43a8-bca8-6a22dd5caa9a"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_related_objects"
}
```
