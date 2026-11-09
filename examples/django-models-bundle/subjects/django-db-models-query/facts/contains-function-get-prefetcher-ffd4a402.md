# Fact ffd4a402

Store id: b5e8ba41-b73c-4cfc-b882-244b9c956655

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "b5e8ba41-b73c-4cfc-b882-244b9c956655",
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
        "line": 2809,
        "symbol": "get_prefetcher"
      },
      "rel": "contains",
      "target": "2c836d2c-fb9e-499d-83e8-6ad825277d8f"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_prefetcher"
}
```
