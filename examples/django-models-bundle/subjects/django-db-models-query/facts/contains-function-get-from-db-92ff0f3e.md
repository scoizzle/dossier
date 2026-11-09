# Fact 92ff0f3e

Store id: 5a0a5dad-700e-4cf4-beaa-fb3678bb54e1

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "5a0a5dad-700e-4cf4-beaa-fb3678bb54e1",
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
        "line": 60,
        "symbol": "_get_from_db"
      },
      "rel": "contains",
      "target": "1239b777-34b5-4ad5-ad1d-8dc026a1fc0b"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_from_db"
}
```
