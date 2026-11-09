# Fact d4c56fcf

Store id: a7af1a8f-b516-4f79-bec3-676728a8f065

## Text

```text
contains function _empty
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::_empty](../../django-db-models-fields-init-empty/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"symbol":"_empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a7af1a8f-b516-4f79-bec3-676728a8f065",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 117,
        "symbol": "_empty"
      },
      "rel": "contains",
      "target": "d5c8b0a8-71b8-4c5c-8f89-49172e7a7c61"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _empty"
}
```
