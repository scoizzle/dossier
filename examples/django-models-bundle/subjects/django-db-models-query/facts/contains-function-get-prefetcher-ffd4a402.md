# Fact ffd4a402

Store id: 2607d720-c726-4cc0-9ea8-e49f18790655

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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

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
  "id": "2607d720-c726-4cc0-9ea8-e49f18790655",
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
        "line": 2809,
        "symbol": "get_prefetcher"
      },
      "rel": "contains",
      "target": "a19762e1-80cd-47e7-b70e-c16b635fcb61"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_prefetcher"
}
```
