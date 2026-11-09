# Fact 014c7f76

Store id: 54a8f309-0f87-4d05-8071-3d53f7afb561

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
- posted_at: `2026-11-09T22:39:41.7964630+00:00`

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
  "id": "54a8f309-0f87-4d05-8071-3d53f7afb561",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7964630+00:00"
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
      "target": "4c98563d-865b-405b-9387-73523e1ee65e"
    }
  ],
  "status": "live",
  "subject_id": "c73c9fb4-2e38-469b-adb6-39bb26aff37e",
  "subject_name": "django/db/models/expressions",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DatabaseDefault"
}
```
