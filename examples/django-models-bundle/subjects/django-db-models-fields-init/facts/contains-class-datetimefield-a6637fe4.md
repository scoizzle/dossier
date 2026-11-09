# Fact a6637fe4

Store id: 865e4c88-4bf8-466c-96de-0aa8c12e541c

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "865e4c88-4bf8-466c-96de-0aa8c12e541c",
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
        "line": 1599,
        "symbol": "DateTimeField"
      },
      "rel": "contains",
      "target": "0b83c67b-fb43-4d4f-a47a-691fcfa1a107"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DateTimeField"
}
```
