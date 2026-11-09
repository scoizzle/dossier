# Fact f90fe3ed

Store id: 839a6248-2d71-440d-8d4b-2c0174b2c1f0

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
- posted_at: `2026-11-09T23:31:55.9336420+00:00`

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
  "id": "839a6248-2d71-440d-8d4b-2c0174b2c1f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9336420+00:00"
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
  "subject_id": "bfc48cce-70b0-4353-ab3d-835ebe4820ec",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field)"
}
```
