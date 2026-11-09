# Fact 8d7cc38b

Store id: 1f53c575-d71b-4789-bc14-1a7db9fc0146

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "1f53c575-d71b-4789-bc14-1a7db9fc0146",
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
        "line": 2802,
        "symbol": "aprefetch_related_objects"
      },
      "rel": "contains",
      "target": "45085c27-5d7b-462b-ae2b-130979f46014"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:async_function"
  ],
  "text": "contains async_function aprefetch_related_objects"
}
```
