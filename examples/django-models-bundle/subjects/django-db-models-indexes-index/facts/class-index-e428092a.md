# Fact e428092a

Store id: cca204a9-a592-4dbf-9991-804d99ffe381

## Text

```text
class Index
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
- posted_at: `2026-11-09T23:32:02.8862640+00:00`

## Data

```json
{
  "end_line": 304,
  "entity_kind": "class",
  "parent": "indexes",
  "start_line": 14,
  "symbol": "Index"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":14,"selector":"L14-L304","symbol":"Index"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 304,
    "entity_kind": "class",
    "parent": "indexes",
    "start_line": 14,
    "symbol": "Index"
  },
  "id": "cca204a9-a592-4dbf-9991-804d99ffe381",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.8862640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 14,
        "selector": "L14-L304",
        "symbol": "Index"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "0dc7cfe8-099e-4230-bb9e-5c4397cc8c39",
  "subject_name": "django/db/models/indexes::Index",
  "tags": [
    "entity:class"
  ],
  "text": "class Index"
}
```
