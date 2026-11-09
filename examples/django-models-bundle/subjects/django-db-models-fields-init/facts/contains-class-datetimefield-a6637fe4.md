# Fact a6637fe4

Store id: e66b5512-2c30-4868-924f-2874fe530817

## Text

```text
contains class DateTimeField
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
  - target: [django/db/models/fields/__init__::DateTimeField](../../django-db-models-fields-init-datetimefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1599,"symbol":"DateTimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e66b5512-2c30-4868-924f-2874fe530817",
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
        "line": 1599,
        "symbol": "DateTimeField"
      },
      "rel": "contains",
      "target": "0c32e5bf-56f3-4292-adf1-eb39d21468fb"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DateTimeField"
}
```
