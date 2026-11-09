# Fact 78e41354

Store id: 484dd0cb-b46a-4fb8-918b-79fa0be5a3eb

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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

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
  "id": "484dd0cb-b46a-4fb8-918b-79fa0be5a3eb",
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
        "line": 2874,
        "symbol": "prefetch_one_level"
      },
      "rel": "contains",
      "target": "137dd2a0-b608-4611-8eec-2ff4e49adfd5"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_one_level"
}
```
