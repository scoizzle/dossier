# Fact a09c189b

Store id: fe8a43d8-994e-4086-9f17-115bb0b653c5

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
- posted_at: `2026-11-09T23:44:50.4900580+00:00`

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
  "id": "fe8a43d8-994e-4086-9f17-115bb0b653c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4900580+00:00"
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
  "subject_id": "bff36fcd-8adc-420b-88c9-869fbefbf4c5",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
