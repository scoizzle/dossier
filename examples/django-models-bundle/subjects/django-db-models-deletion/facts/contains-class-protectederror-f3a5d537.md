# Fact f3a5d537

Store id: f430aaa9-04d8-412b-a306-04e6785a1c9c

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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

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
  "id": "f430aaa9-04d8-412b-a306-04e6785a1c9c",
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
        "line": 10,
        "symbol": "ProtectedError"
      },
      "rel": "contains",
      "target": "c925367e-c776-4a97-b3a7-9eafa45060e1"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ProtectedError"
}
```
