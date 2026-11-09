# Fact a09c189b

Store id: 7adbf0cc-6966-4d3a-b625-1b595d8eea55

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T22:39:43.0078170+00:00`

## Data

```json
{
  "end_line": 104,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 103,
  "symbol": "CompositePrimaryKey.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":103,"selector":"L103-L104","symbol":"CompositePrimaryKey.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 104,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 103,
    "symbol": "CompositePrimaryKey.__len__"
  },
  "id": "7adbf0cc-6966-4d3a-b625-1b595d8eea55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0078170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 103,
        "selector": "L103-L104",
        "symbol": "CompositePrimaryKey.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "785b8113-4fdf-479e-a67d-bf9f66bd03b2",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
