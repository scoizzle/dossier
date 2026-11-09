# Fact 972ffbb0

Store id: 685bd617-abfe-4e37-8ff4-716c61e46925

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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

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
  "id": "685bd617-abfe-4e37-8ff4-716c61e46925",
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
        "line": 84,
        "symbol": "DatabaseOnDelete"
      },
      "rel": "contains",
      "target": "beb0446a-c2e5-4a43-a708-1cc69624c171"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DatabaseOnDelete"
}
```
