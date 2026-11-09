# Fact 014c7f76

Store id: c5cff12e-a2e6-42de-b969-bec0dd33e75c

## Text

```text
contains class DatabaseDefault
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
- posted_at: `2026-11-09T23:44:49.6980740+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/expressions::DatabaseDefault](../../django-db-models-expressions-databasedefault/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1311,"symbol":"DatabaseDefault"}`

## Referenced by

None.

## Subject

[django/db/models/expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c5cff12e-a2e6-42de-b969-bec0dd33e75c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6980740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1311,
        "symbol": "DatabaseDefault"
      },
      "rel": "contains",
      "target": "22e8e5f3-1ea6-4f27-a5e7-bee028de31ee"
    }
  ],
  "status": "live",
  "subject_id": "28327a89-66c3-4156-a323-5c05be9f6cae",
  "subject_name": "django/db/models/expressions",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DatabaseDefault"
}
```
