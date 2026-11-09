# Fact 2ba04bde

Store id: 58471078-aa10-472b-8632-7f24c783d5f1

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
- posted_at: `2026-11-09T23:31:57.3778440+00:00`

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
  "id": "58471078-aa10-472b-8632-7f24c783d5f1",
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
    "posted_at": "2026-11-09T23:31:57.3778440+00:00"
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
  "subject_id": "adb6e22a-d982-4b8b-b543-44b57129f21a",
  "subject_name": "django/db/models/fields/files::FileDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class FileDescriptor(DeferredAttribute)"
}
```
