# Fact 722e9ed2

Store id: 1bcdd4df-ef48-4584-aa3b-d2f3322e82fb

## Text

```text
class ImageFileDescriptor(FileDescriptor)
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
- posted_at: `2026-11-09T22:39:43.2536100+00:00`

## Data

```json
{
  "end_line": 403,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 383,
  "symbol": "ImageFileDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":383,"selector":"L383-L403","symbol":"ImageFileDescriptor"}`

## Items

```json
[
  {
    "text": "Just like the FileDescriptor, but for ImageFields. The only difference is assigning the width/height to the width_field/height_field, if appropriate.",
    "locator": {
      "line": 384
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageFileDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 403,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 383,
    "symbol": "ImageFileDescriptor"
  },
  "id": "1bcdd4df-ef48-4584-aa3b-d2f3322e82fb",
  "items": [
    {
      "locator": {
        "line": 384
      },
      "text": "Just like the FileDescriptor, but for ImageFields. The only difference is assigning the width/height to the width_field/height_field, if appropriate."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2536100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 383,
        "selector": "L383-L403",
        "symbol": "ImageFileDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "c12a5f66-e753-428a-b175-06fd2789406b",
  "subject_name": "django/db/models/fields/files::ImageFileDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageFileDescriptor(FileDescriptor)"
}
```
