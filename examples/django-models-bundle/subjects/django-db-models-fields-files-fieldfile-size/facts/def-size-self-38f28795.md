# Fact 38f28795

Store id: dd329d05-682a-4209-ba3f-275b7a906a71

## Text

```text
def size(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.3607010+00:00`

## Data

```json
{
  "end_line": 79,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 74,
  "symbol": "FieldFile.size"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L79","symbol":"FieldFile.size"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.size](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 79,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 74,
    "symbol": "FieldFile.size"
  },
  "id": "dd329d05-682a-4209-ba3f-275b7a906a71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3607010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L79",
        "symbol": "FieldFile.size"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "84099744-5673-4278-a261-d5fd00f751cc",
  "subject_name": "django/db/models/fields/files::FieldFile.size",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def size(self)"
}
```
