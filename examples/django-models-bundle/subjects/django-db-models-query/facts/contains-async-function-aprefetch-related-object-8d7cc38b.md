# Fact 8d7cc38b

Store id: 62be21df-3ac3-40b4-8a46-448ad2fe24e1

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
- posted_at: `2026-11-09T22:39:49.9155620+00:00`

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
  "id": "62be21df-3ac3-40b4-8a46-448ad2fe24e1",
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
        "line": 2802,
        "symbol": "aprefetch_related_objects"
      },
      "rel": "contains",
      "target": "12dc9d5b-cdc5-4d8f-afa7-49a0f329cb67"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:async_function"
  ],
  "text": "contains async_function aprefetch_related_objects"
}
```
