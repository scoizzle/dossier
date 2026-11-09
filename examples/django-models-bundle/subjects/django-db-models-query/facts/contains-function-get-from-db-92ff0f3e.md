# Fact 92ff0f3e

Store id: c5badf59-6a78-499b-9e19-a7f4abefc0ad

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
- posted_at: `2026-11-09T22:39:49.9155620+00:00`

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
  "id": "c5badf59-6a78-499b-9e19-a7f4abefc0ad",
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
        "line": 60,
        "symbol": "_get_from_db"
      },
      "rel": "contains",
      "target": "1aeb015d-47ed-43d7-883d-867baae16ce5"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_from_db"
}
```
