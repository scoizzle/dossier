# Fact f874dd10

Store id: 8d3b82a5-9e56-4163-b186-2fa3083542d8

## Text

```text
contains function SET
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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::SET](../../django-db-models-deletion-set/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"symbol":"SET"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8d3b82a5-9e56-4163-b186-2fa3083542d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0946700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 52,
        "symbol": "SET"
      },
      "rel": "contains",
      "target": "27e1f571-8295-4537-90c0-3f20a3e31adb"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET"
}
```
