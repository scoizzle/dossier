# Fact 38f28795

Store id: 6bcbdd65-5604-417d-adeb-22a5b061ab3b

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
- posted_at: `2026-11-09T22:39:43.2029690+00:00`

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
  "id": "6bcbdd65-5604-417d-adeb-22a5b061ab3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2029690+00:00"
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
  "subject_id": "be1aaff1-ee00-4424-adf9-91334ef356f6",
  "subject_name": "django/db/models/fields/files::FieldFile.size",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def size(self)"
}
```
