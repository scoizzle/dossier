# Fact 2e03b6ea

Store id: f4ea63a4-38b7-4e3d-88e1-374b51684dba

## Text

```text
class Empty
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
- posted_at: `2026-11-09T22:39:50.9678630+00:00`

## Data

```json
{
  "end_line": 24,
  "entity_kind": "class",
  "parent": "datastructures",
  "start_line": 23,
  "symbol": "Empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"selector":"L23-L24","symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 24,
    "entity_kind": "class",
    "parent": "datastructures",
    "start_line": 23,
    "symbol": "Empty"
  },
  "id": "f4ea63a4-38b7-4e3d-88e1-374b51684dba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.9678630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 23,
        "selector": "L23-L24",
        "symbol": "Empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "db5c277c-1eba-469e-ba50-21cc2aaf0591",
  "subject_name": "django/db/models/sql/datastructures::Empty",
  "tags": [
    "entity:class"
  ],
  "text": "class Empty"
}
```
