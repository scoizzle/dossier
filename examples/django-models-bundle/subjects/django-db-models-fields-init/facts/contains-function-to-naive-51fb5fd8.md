# Fact 51fb5fd8

Store id: 13585f5c-4cac-40a1-aa75-243d605ba4bd

## Text

```text
contains function _to_naive
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
  - target: [django/db/models/fields/__init__::_to_naive](../../django-db-models-fields-init-to-naive/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1381,"symbol":"_to_naive"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "13585f5c-4cac-40a1-aa75-243d605ba4bd",
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
        "line": 1381,
        "symbol": "_to_naive"
      },
      "rel": "contains",
      "target": "3e234698-3e99-4861-b378-3b619cea9295"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _to_naive"
}
```
