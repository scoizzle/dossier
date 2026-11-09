# Fact 2b614b0d

Store id: 758cb9eb-3511-4083-a6d0-903c326754e7

## Text

```text
contains function SET_NULL
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
  - target: [django/db/models/deletion::SET_NULL](../../django-db-models-deletion-set-null/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"symbol":"SET_NULL"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "758cb9eb-3511-4083-a6d0-903c326754e7",
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
        "line": 69,
        "symbol": "SET_NULL"
      },
      "rel": "contains",
      "target": "ac7c4365-10b5-4d18-9bf2-3fece5a5bd49"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_NULL"
}
```
