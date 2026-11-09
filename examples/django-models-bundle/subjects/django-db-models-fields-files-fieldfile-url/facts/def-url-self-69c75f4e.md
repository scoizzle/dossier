# Fact 69c75f4e

Store id: 2d2cd710-ab06-434a-9436-c9d49057bbaf

## Text

```text
def url(self)
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
- posted_at: `2026-11-09T22:39:43.2013850+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 69,
  "symbol": "FieldFile.url"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L72","symbol":"FieldFile.url"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.url](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 69,
    "symbol": "FieldFile.url"
  },
  "id": "2d2cd710-ab06-434a-9436-c9d49057bbaf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2013850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L72",
        "symbol": "FieldFile.url"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "7585ea1c-9466-49c1-96f3-3d4e4e382c6e",
  "subject_name": "django/db/models/fields/files::FieldFile.url",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def url(self)"
}
```
