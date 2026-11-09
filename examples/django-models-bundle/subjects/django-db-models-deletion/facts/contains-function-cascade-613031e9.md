# Fact 613031e9

Store id: c8f28275-3ddd-40a0-ae02-064893fc564a

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "c8f28275-3ddd-40a0-ae02-064893fc564a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1285340+00:00"
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
      "target": "a863d2c8-c887-4375-b59c-472b35da8864"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function CASCADE"
}
```
