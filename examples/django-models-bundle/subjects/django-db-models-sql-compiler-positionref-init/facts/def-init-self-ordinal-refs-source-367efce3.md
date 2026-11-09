# Fact 367efce3

Store id: 61a3be15-3d18-433c-95a6-78bd547e404f

## Text

```text
def __init__(self, ordinal, refs, source)
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
- posted_at: `2026-11-09T23:32:05.6430070+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "method",
  "parent": "PositionRef",
  "start_line": 34,
  "symbol": "PositionRef.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L36","symbol":"PositionRef.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::PositionRef.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "method",
    "parent": "PositionRef",
    "start_line": 34,
    "symbol": "PositionRef.__init__"
  },
  "id": "61a3be15-3d18-433c-95a6-78bd547e404f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6430070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L36",
        "symbol": "PositionRef.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "d6cf566d-7102-465e-8412-4f4c13f59e0a",
  "subject_name": "django/db/models/sql/compiler::PositionRef.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, ordinal, refs, source)"
}
```
