# Fact 4552f69f

Store id: 6e5f33e3-709a-49ed-a540-56f3854f9f0b

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
- posted_at: `2026-11-09T22:39:43.2582080+00:00`

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
  "id": "6e5f33e3-709a-49ed-a540-56f3854f9f0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2582080+00:00"
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
  "subject_id": "64555d58-d3a9-446e-9c85-813885747bff",
  "subject_name": "django/db/models/fields/files::ImageFieldFile",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageFieldFile(ImageFile, FieldFile)"
}
```
