# Fact 972ffbb0

Store id: 0787a4a0-c3ed-41a8-9f6e-0c28789e1c81

## Text

```text
contains class DatabaseOnDelete
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
- posted_at: `2026-11-09T23:44:48.9179750+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::DatabaseOnDelete](../../django-db-models-deletion-databaseondelete/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"symbol":"DatabaseOnDelete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0787a4a0-c3ed-41a8-9f6e-0c28789e1c81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9179750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 84,
        "symbol": "DatabaseOnDelete"
      },
      "rel": "contains",
      "target": "3008d02b-ccf9-4c32-9a51-5e3f8659d0a0"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DatabaseOnDelete"
}
```
