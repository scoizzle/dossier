# Fact bc36af78

Store id: e484fb92-d54f-4a8b-96d8-85f8bb9d88b2

## Text

```text
def __init__(self, names_pos, path_with_names)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.9641010+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "method",
  "parent": "MultiJoin",
  "start_line": 17,
  "symbol": "MultiJoin.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":17,"selector":"L17-L20","symbol":"MultiJoin.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::MultiJoin.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "method",
    "parent": "MultiJoin",
    "start_line": 17,
    "symbol": "MultiJoin.__init__"
  },
  "id": "e484fb92-d54f-4a8b-96d8-85f8bb9d88b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.9641010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 17,
        "selector": "L17-L20",
        "symbol": "MultiJoin.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "c2361f5f-6f26-48d2-a4b9-10b00a6f1e12",
  "subject_name": "django/db/models/sql/datastructures::MultiJoin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, names_pos, path_with_names)"
}
```
