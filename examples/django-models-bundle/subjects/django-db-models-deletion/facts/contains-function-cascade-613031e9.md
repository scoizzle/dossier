# Fact 613031e9

Store id: a44b6e66-455f-401c-9f72-8986d98a19ee

## Text

```text
contains function CASCADE
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
  - target: [django/db/models/deletion::CASCADE](../../django-db-models-deletion-cascade/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"symbol":"CASCADE"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a44b6e66-455f-401c-9f72-8986d98a19ee",
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
        "line": 22,
        "symbol": "CASCADE"
      },
      "rel": "contains",
      "target": "19336626-b670-4418-9187-0ac3b40532d3"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function CASCADE"
}
```
