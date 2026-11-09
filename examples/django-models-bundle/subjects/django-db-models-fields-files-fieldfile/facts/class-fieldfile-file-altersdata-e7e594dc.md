# Fact e7e594dc

Store id: f282ef1c-0ffe-48d9-af1c-0a929ce80f19

## Text

```text
class FieldFile(File, AltersData)
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
- posted_at: `2026-11-09T23:44:50.6042490+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 19,
  "symbol": "FieldFile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L156","symbol":"FieldFile"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 19,
    "symbol": "FieldFile"
  },
  "id": "f282ef1c-0ffe-48d9-af1c-0a929ce80f19",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6042490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L156",
        "symbol": "FieldFile"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "93e4ac6b-5bf8-40ae-b71c-f1e26a8a804d",
  "subject_name": "django/db/models/fields/files::FieldFile",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldFile(File, AltersData)"
}
```
