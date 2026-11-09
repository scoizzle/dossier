# Fact ffd4a402

Store id: ae4f81d9-326c-4e60-af84-d5e98e0db04b

## Text

```text
contains function get_prefetcher
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
  - target: [django/db/models/query::get_prefetcher](../../django-db-models-query-get-prefetcher/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2809,"symbol":"get_prefetcher"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "ae4f81d9-326c-4e60-af84-d5e98e0db04b",
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
        "line": 2809,
        "symbol": "get_prefetcher"
      },
      "rel": "contains",
      "target": "b176ce71-15f0-41e4-a604-79c75b5397af"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_prefetcher"
}
```
