# Fact f84918f5

Store id: 19757d3b-56ab-4e20-b19b-781f48dedef9

## Text

```text
def __init__(self, expression, length, fill_text=Value(" "), **extra)
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
- posted_at: `2026-11-09T22:39:47.1268860+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "LPad",
  "start_line": 201,
  "symbol": "LPad.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":201,"selector":"L201-L208","symbol":"LPad.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::LPad.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "LPad",
    "start_line": 201,
    "symbol": "LPad.__init__"
  },
  "id": "19757d3b-56ab-4e20-b19b-781f48dedef9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1268860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 201,
        "selector": "L201-L208",
        "symbol": "LPad.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "01738607-0a85-4f2d-92ef-42ac5404b66a",
  "subject_name": "django/db/models/functions/text::LPad.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, length, fill_text=Value(\" \"), **extra)"
}
```
