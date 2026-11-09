# Fact 2ba04bde

Store id: 35f15588-684f-4060-b29b-a612340f5b9f

## Text

```text
class FileDescriptor(DeferredAttribute)
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
- posted_at: `2026-11-09T22:39:43.2181200+00:00`

## Data

```json
{
  "end_line": 236,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 159,
  "symbol": "FileDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":159,"selector":"L159-L236","symbol":"FileDescriptor"}`

## Items

```json
[
  {
    "text": "The descriptor for the file attribute on the model instance. Return a FieldFile when accessed so you can write code like::",
    "locator": {
      "line": 160
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 236,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 159,
    "symbol": "FileDescriptor"
  },
  "id": "35f15588-684f-4060-b29b-a612340f5b9f",
  "items": [
    {
      "locator": {
        "line": 160
      },
      "text": "The descriptor for the file attribute on the model instance. Return a FieldFile when accessed so you can write code like::"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2181200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 159,
        "selector": "L159-L236",
        "symbol": "FileDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "8e88057f-89d3-449f-8872-a311864803a9",
  "subject_name": "django/db/models/fields/files::FileDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class FileDescriptor(DeferredAttribute)"
}
```
