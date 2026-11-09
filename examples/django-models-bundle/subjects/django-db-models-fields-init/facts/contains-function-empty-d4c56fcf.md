# Fact d4c56fcf

Store id: 6fbb54d6-4bde-4663-8e9b-227870e2f09a

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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

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
  "id": "6fbb54d6-4bde-4663-8e9b-227870e2f09a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
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
      "target": "49219c2c-dac2-4868-b15c-d0eb327a7784"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _empty"
}
```
