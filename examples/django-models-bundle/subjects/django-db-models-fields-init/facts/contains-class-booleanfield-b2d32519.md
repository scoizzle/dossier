# Fact b2d32519

Store id: 1da13487-a524-4c2e-a49b-79f010a538c0

## Text

```text
contains class BooleanField
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
  - target: [django/db/models/fields/__init__::BooleanField](../../django-db-models-fields-init-booleanfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1200,"symbol":"BooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "1da13487-a524-4c2e-a49b-79f010a538c0",
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
        "line": 1200,
        "symbol": "BooleanField"
      },
      "rel": "contains",
      "target": "1c691d9d-153d-4fc8-83c6-ad8b6ecd08b7"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BooleanField"
}
```
