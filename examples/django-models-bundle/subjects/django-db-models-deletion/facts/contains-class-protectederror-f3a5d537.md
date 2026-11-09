# Fact f3a5d537

Store id: 2bbf4e61-e712-4b87-9c3a-3351d9ad8640

## Text

```text
contains class ProtectedError
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
  - target: [django/db/models/deletion::ProtectedError](../../django-db-models-deletion-protectederror/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"symbol":"ProtectedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2bbf4e61-e712-4b87-9c3a-3351d9ad8640",
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
        "line": 10,
        "symbol": "ProtectedError"
      },
      "rel": "contains",
      "target": "1f5a3434-b91b-422d-b506-8e3dd843f381"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ProtectedError"
}
```
