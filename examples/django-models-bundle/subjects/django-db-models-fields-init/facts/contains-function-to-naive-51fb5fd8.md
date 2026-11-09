# Fact 51fb5fd8

Store id: 48bf3315-0039-4faa-ba97-fd61d59f71bc

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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

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
  "id": "48bf3315-0039-4faa-ba97-fd61d59f71bc",
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
        "line": 1381,
        "symbol": "_to_naive"
      },
      "rel": "contains",
      "target": "53cfb11c-8a1e-48a0-bc38-587fdb69963f"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _to_naive"
}
```
