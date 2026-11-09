# Fact 38f28795

Store id: 34c1c983-2a36-408b-acf1-15ff59eadf93

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
- posted_at: `2026-11-09T23:44:50.6277410+00:00`

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
  "id": "34c1c983-2a36-408b-acf1-15ff59eadf93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6277410+00:00"
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
  "subject_id": "adb6e376-7e14-4d2b-81e1-4184dad16e2a",
  "subject_name": "django/db/models/fields/files::FieldFile.size",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def size(self)"
}
```
