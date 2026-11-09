# Fact 8291ff9c

Store id: 76ac5cf3-58f9-4b8f-80d1-1b9fc494e891

## Text

```text
contains class BigAutoField
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
  - target: [django/db/models/fields/__init__::BigAutoField](../../django-db-models-fields-init-bigautofield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2971,"symbol":"BigAutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "76ac5cf3-58f9-4b8f-80d1-1b9fc494e891",
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
        "line": 2971,
        "symbol": "BigAutoField"
      },
      "rel": "contains",
      "target": "eb79234d-f0f8-4bd6-b563-3779cecfe640"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BigAutoField"
}
```
