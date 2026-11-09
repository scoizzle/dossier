# Fact 793f5388

Store id: a76d8f07-f33d-4422-8978-c0d897ccf613

## Text

```text
contains function _load_field
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
  - target: [django/db/models/fields/__init__::_load_field](../../django-db-models-fields-init-load-field/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"symbol":"_load_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a76d8f07-f33d-4422-8978-c0d897ccf613",
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
        "line": 97,
        "symbol": "_load_field"
      },
      "rel": "contains",
      "target": "82475cfa-25ad-46e0-a0b9-6060bce1196a"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _load_field"
}
```
