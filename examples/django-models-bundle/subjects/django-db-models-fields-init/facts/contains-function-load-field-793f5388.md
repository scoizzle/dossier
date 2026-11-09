# Fact 793f5388

Store id: 9b8acdcb-2c09-44e5-9c2f-09974bc0c43a

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "9b8acdcb-2c09-44e5-9c2f-09974bc0c43a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "eae9d058-cbeb-4ce2-9b01-dd273caf8911"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _load_field"
}
```
