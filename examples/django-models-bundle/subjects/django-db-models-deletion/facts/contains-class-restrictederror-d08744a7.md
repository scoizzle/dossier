# Fact d08744a7

Store id: 2cf5c8c6-953a-4f1a-8ee7-37259c48cca4

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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

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
  "id": "2cf5c8c6-953a-4f1a-8ee7-37259c48cca4",
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
        "line": 16,
        "symbol": "RestrictedError"
      },
      "rel": "contains",
      "target": "e2db58ad-d5ae-4476-aae7-5cc35a6c7e0c"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RestrictedError"
}
```
