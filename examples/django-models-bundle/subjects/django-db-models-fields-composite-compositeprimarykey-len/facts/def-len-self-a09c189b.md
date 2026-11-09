# Fact a09c189b

Store id: 81e1cad7-e3b8-4338-a62e-1b44b6d435a6

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
- posted_at: `2026-11-09T23:31:57.1343430+00:00`

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
  "id": "81e1cad7-e3b8-4338-a62e-1b44b6d435a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1343430+00:00"
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
  "subject_id": "7ce8dd8b-2d86-4115-ba9a-a0370c8530a7",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
