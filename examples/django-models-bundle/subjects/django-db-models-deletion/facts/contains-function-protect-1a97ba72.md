# Fact 1a97ba72

Store id: 2b5b5aa7-1e35-4e23-8c3b-ef8aa0a218cb

## Text

```text
contains function PROTECT
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
  - target: [django/db/models/deletion::PROTECT](../../django-db-models-deletion-protect/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"symbol":"PROTECT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2b5b5aa7-1e35-4e23-8c3b-ef8aa0a218cb",
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
        "line": 34,
        "symbol": "PROTECT"
      },
      "rel": "contains",
      "target": "7fa90b15-6241-4ee4-80ef-da858a05f1ea"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function PROTECT"
}
```
