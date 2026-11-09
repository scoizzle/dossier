# Fact d08744a7

Store id: a63253ab-d539-49df-bb61-698002781edc

## Text

```text
contains class RestrictedError
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
  - target: [django/db/models/deletion::RestrictedError](../../django-db-models-deletion-restrictederror/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"symbol":"RestrictedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a63253ab-d539-49df-bb61-698002781edc",
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
        "line": 16,
        "symbol": "RestrictedError"
      },
      "rel": "contains",
      "target": "9931a8ca-6395-4fc1-98cb-8b809b6611da"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RestrictedError"
}
```
