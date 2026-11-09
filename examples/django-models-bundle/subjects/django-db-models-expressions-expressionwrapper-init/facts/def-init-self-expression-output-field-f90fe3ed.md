# Fact f90fe3ed

Store id: 193ee1b5-8319-40c8-924a-0b8665783e0f

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
- posted_at: `2026-11-09T22:39:41.6686750+00:00`

## Data

```json
{
  "end_line": 1556,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1554,
  "symbol": "ExpressionWrapper.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1554,"selector":"L1554-L1556","symbol":"ExpressionWrapper.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1556,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1554,
    "symbol": "ExpressionWrapper.__init__"
  },
  "id": "193ee1b5-8319-40c8-924a-0b8665783e0f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6686750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1554,
        "selector": "L1554-L1556",
        "symbol": "ExpressionWrapper.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d4a71277-cce6-449b-9be9-8a8c7800bf47",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field)"
}
```
