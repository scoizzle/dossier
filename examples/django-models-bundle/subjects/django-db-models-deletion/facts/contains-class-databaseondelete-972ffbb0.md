# Fact 972ffbb0

Store id: 2a22a4e0-8a3d-42f5-b15a-584b066b3423

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "2a22a4e0-8a3d-42f5-b15a-584b066b3423",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1285340+00:00"
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
      "target": "4b1d0377-ae61-4a39-87e7-9897bb1faa63"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DatabaseOnDelete"
}
```
