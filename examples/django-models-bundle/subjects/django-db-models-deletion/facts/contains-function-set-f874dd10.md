# Fact f874dd10

Store id: e278d89e-b4e3-4cc9-a8c1-448b3b6a138a

## Text

```text
contains function SET
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
  - target: [django/db/models/deletion::SET](../../django-db-models-deletion-set/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"symbol":"SET"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e278d89e-b4e3-4cc9-a8c1-448b3b6a138a",
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
        "line": 52,
        "symbol": "SET"
      },
      "rel": "contains",
      "target": "77558e27-5992-4943-8dc1-71ff8c9bbf9e"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET"
}
```
