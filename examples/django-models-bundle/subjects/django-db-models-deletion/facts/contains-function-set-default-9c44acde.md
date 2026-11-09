# Fact 9c44acde

Store id: 47c449f1-be80-48cb-8368-b5e00a750aed

## Text

```text
contains function SET_DEFAULT
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
  - target: [django/db/models/deletion::SET_DEFAULT](../../django-db-models-deletion-set-default/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"symbol":"SET_DEFAULT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "47c449f1-be80-48cb-8368-b5e00a750aed",
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
        "line": 76,
        "symbol": "SET_DEFAULT"
      },
      "rel": "contains",
      "target": "7620f2b2-ae94-4704-9feb-6a5fb67f8a71"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_DEFAULT"
}
```
