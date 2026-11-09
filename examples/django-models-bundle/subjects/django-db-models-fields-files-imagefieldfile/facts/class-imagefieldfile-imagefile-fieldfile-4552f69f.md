# Fact 4552f69f

Store id: 48705f91-583a-4912-8079-e28a466055c6

## Text

```text
class ImageFieldFile(ImageFile, FieldFile)
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
- posted_at: `2026-11-09T23:31:57.4228370+00:00`

## Data

```json
{
  "end_line": 417,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 406,
  "symbol": "ImageFieldFile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":406,"selector":"L406-L417","symbol":"ImageFieldFile"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageFieldFile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 417,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 406,
    "symbol": "ImageFieldFile"
  },
  "id": "48705f91-583a-4912-8079-e28a466055c6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4228370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 406,
        "selector": "L406-L417",
        "symbol": "ImageFieldFile"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "8fa7fffd-b1d6-4784-a1d6-0d4e9cadf82f",
  "subject_name": "django/db/models/fields/files::ImageFieldFile",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageFieldFile(ImageFile, FieldFile)"
}
```
