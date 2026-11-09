# Fact c2dc2ced

Store id: 1d357c0a-1470-44d0-a32f-fa2aae43bb58

## Text

```text
contains class FileField
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.4465340+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/files::FileField](../../django-db-models-fields-files-filefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":239,"symbol":"FileField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "1d357c0a-1470-44d0-a32f-fa2aae43bb58",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4465340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 239,
        "symbol": "FileField"
      },
      "rel": "contains",
      "target": "9ecf65a9-7e92-4dce-a564-be18c5568171"
    }
  ],
  "status": "live",
  "subject_id": "8d4f06a2-9dbc-43c2-9d3e-963deb8a9e36",
  "subject_name": "django/db/models/fields/files",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FileField"
}
```
