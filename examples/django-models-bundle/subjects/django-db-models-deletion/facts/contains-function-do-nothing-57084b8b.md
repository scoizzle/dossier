# Fact 57084b8b

Store id: 5e73c087-ac60-4e2b-b132-a2d705958c0c

## Text

```text
contains function DO_NOTHING
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
  - target: [django/db/models/deletion::DO_NOTHING](../../django-db-models-deletion-do-nothing/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"symbol":"DO_NOTHING"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5e73c087-ac60-4e2b-b132-a2d705958c0c",
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
        "line": 80,
        "symbol": "DO_NOTHING"
      },
      "rel": "contains",
      "target": "2408caa4-d8c1-4841-a6d4-10cbb7363456"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function DO_NOTHING"
}
```
