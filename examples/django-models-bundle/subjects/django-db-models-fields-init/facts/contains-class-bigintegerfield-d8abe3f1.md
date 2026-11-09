# Fact d8abe3f1

Store id: 5d6f551c-cf90-4d56-952c-4d9356dcd704

## Text

```text
contains class BigIntegerField
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
  - target: [django/db/models/fields/__init__::BigIntegerField](../../django-db-models-fields-init-bigintegerfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2241,"symbol":"BigIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5d6f551c-cf90-4d56-952c-4d9356dcd704",
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
        "line": 2241,
        "symbol": "BigIntegerField"
      },
      "rel": "contains",
      "target": "3117325a-0c44-4df3-850c-0b995f22ae9d"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BigIntegerField"
}
```
