# Fact 2b614b0d

Store id: db0c217f-2ee6-4299-b465-b8ba05ec746b

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "db0c217f-2ee6-4299-b465-b8ba05ec746b",
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
        "line": 69,
        "symbol": "SET_NULL"
      },
      "rel": "contains",
      "target": "b9d74dea-5af7-488f-a989-62154420a23a"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_NULL"
}
```
