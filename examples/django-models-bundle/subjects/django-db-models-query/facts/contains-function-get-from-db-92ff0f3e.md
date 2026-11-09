# Fact 92ff0f3e

Store id: 163905bc-3dd8-4534-9add-cb1f73b9dc79

## Text

```text
contains function _get_from_db
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
  - target: [django/db/models/query::_get_from_db](../../django-db-models-query-get-from-db/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"symbol":"_get_from_db"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "163905bc-3dd8-4534-9add-cb1f73b9dc79",
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
        "line": 60,
        "symbol": "_get_from_db"
      },
      "rel": "contains",
      "target": "b98c0d64-be8b-4ea6-87a5-698b0196485e"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_from_db"
}
```
