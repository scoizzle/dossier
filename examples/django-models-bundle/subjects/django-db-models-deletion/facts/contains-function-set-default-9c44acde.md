# Fact 9c44acde

Store id: e9669b41-d503-4faa-a974-57d44d7e7e3b

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "e9669b41-d503-4faa-a974-57d44d7e7e3b",
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
        "line": 76,
        "symbol": "SET_DEFAULT"
      },
      "rel": "contains",
      "target": "ce13f4d2-ae51-4e3c-ab02-8ee813e6cc88"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_DEFAULT"
}
```
