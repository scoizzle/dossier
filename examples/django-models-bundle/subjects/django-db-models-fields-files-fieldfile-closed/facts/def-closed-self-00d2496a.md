# Fact 00d2496a

Store id: 2d6a9a45-588f-4237-ac8b-1e4df51e8e4f

## Text

```text
def closed(self)
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
- posted_at: `2026-11-09T22:39:43.2121330+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 131,
  "symbol": "FieldFile.closed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L134","symbol":"FieldFile.closed"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.closed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 131,
    "symbol": "FieldFile.closed"
  },
  "id": "2d6a9a45-588f-4237-ac8b-1e4df51e8e4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2121330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L134",
        "symbol": "FieldFile.closed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "038ef6f0-cb67-4124-8d10-da7545099050",
  "subject_name": "django/db/models/fields/files::FieldFile.closed",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def closed(self)"
}
```
