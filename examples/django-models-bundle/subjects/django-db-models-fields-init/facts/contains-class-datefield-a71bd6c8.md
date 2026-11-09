# Fact a71bd6c8

Store id: 1e1046a4-d0ec-442a-8b29-10692761c812

## Text

```text
contains class DateField
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::DateField](../../django-db-models-fields-init-datefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1464,"symbol":"DateField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "1e1046a4-d0ec-442a-8b29-10692761c812",
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
        "line": 1464,
        "symbol": "DateField"
      },
      "rel": "contains",
      "target": "5c7355d6-1b0d-4e5f-99f8-4e2ffddc9f92"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DateField"
}
```
