# Fact 1a97ba72

Store id: 96ca3ae2-01b2-46e7-baa4-b24b704a86d7

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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

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
  "id": "96ca3ae2-01b2-46e7-baa4-b24b704a86d7",
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
        "line": 34,
        "symbol": "PROTECT"
      },
      "rel": "contains",
      "target": "54cfd144-7054-4a4d-8a0c-7c753803e4ed"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function PROTECT"
}
```
