# Fact c9d7927d

Store id: 8d2cb3aa-fb64-4ff3-9b50-e5dbad2a269f

## Text

```text
contains class PositiveIntegerField
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
  - target: [django/db/models/fields/__init__::PositiveIntegerField](../../django-db-models-fields-init-positiveintegerfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2457,"symbol":"PositiveIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8d2cb3aa-fb64-4ff3-9b50-e5dbad2a269f",
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
        "line": 2457,
        "symbol": "PositiveIntegerField"
      },
      "rel": "contains",
      "target": "856112ee-3f32-49e6-8c69-82a52640312e"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PositiveIntegerField"
}
```
