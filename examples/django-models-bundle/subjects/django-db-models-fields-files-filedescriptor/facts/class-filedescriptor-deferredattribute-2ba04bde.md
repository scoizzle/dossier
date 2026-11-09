# Fact 2ba04bde

Store id: 620dc5a3-0e64-41b6-9964-0278e78818c7

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
- posted_at: `2026-11-09T23:44:50.6423400+00:00`

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
  "id": "620dc5a3-0e64-41b6-9964-0278e78818c7",
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
    "posted_at": "2026-11-09T23:44:50.6423400+00:00"
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
  "subject_id": "c3ffeaca-b24f-4315-bcd6-8fc80864aae2",
  "subject_name": "django/db/models/fields/files::FileDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class FileDescriptor(DeferredAttribute)"
}
```
