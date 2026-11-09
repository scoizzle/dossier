# Fact 8d7cc38b

Store id: 4c2581d6-01b7-4ce2-abf2-b892db878fa8

## Text

```text
contains async_function aprefetch_related_objects
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:async_function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::aprefetch_related_objects](../../django-db-models-query-aprefetch-related-objects/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2802,"symbol":"aprefetch_related_objects"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "4c2581d6-01b7-4ce2-abf2-b892db878fa8",
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
        "line": 2802,
        "symbol": "aprefetch_related_objects"
      },
      "rel": "contains",
      "target": "c48a67cc-07a6-45e5-b307-f2cca3c36d97"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:async_function"
  ],
  "text": "contains async_function aprefetch_related_objects"
}
```
