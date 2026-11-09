# Fact 17e35f1f

Store id: bbfec66a-fc5d-4e31-a005-03f4dbf8ab4b

## Text

```text
def __init__(self, expression, output_field)
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
- posted_at: `2026-11-09T22:39:45.8972890+00:00`

## Data

```json
{
  "end_line": 14,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 13,
  "symbol": "Cast.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L14","symbol":"Cast.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 14,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 13,
    "symbol": "Cast.__init__"
  },
  "id": "bbfec66a-fc5d-4e31-a005-03f4dbf8ab4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.8972890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L14",
        "symbol": "Cast.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "74fdf657-eb64-442b-947e-b4b7ac132ca1",
  "subject_name": "django/db/models/functions/comparison::Cast.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field)"
}
```
