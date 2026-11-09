# Fact aa728638

Store id: b2711723-7247-418f-92c0-51969f3af224

## Text

```text
contains function RESTRICT
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
  - target: [django/db/models/deletion::RESTRICT](../../django-db-models-deletion-restrict/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"symbol":"RESTRICT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b2711723-7247-418f-92c0-51969f3af224",
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
        "line": 47,
        "symbol": "RESTRICT"
      },
      "rel": "contains",
      "target": "0131d0f0-0e99-4a30-b340-415100a6aeeb"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function RESTRICT"
}
```
