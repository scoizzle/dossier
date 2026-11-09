# Fact d12448f8

Store id: 7fb5ee7e-6646-4df8-96a4-e315baf0829d

## Text

```text
contains class UUIDField
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
  - target: [django/db/models/fields/__init__::UUIDField](../../django-db-models-fields-init-uuidfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2819,"symbol":"UUIDField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "7fb5ee7e-6646-4df8-96a4-e315baf0829d",
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
        "line": 2819,
        "symbol": "UUIDField"
      },
      "rel": "contains",
      "target": "77a83a23-475c-4970-89ba-db99b0b4ed4d"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class UUIDField"
}
```
