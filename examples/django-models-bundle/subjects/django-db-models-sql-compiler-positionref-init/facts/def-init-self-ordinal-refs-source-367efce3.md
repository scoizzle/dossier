# Fact 367efce3

Store id: 758a2f2f-b7c7-4c12-b5ad-a217e07b8d3c

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
- posted_at: `2026-11-09T22:39:50.5425490+00:00`

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
  "id": "758a2f2f-b7c7-4c12-b5ad-a217e07b8d3c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5425490+00:00"
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
  "subject_id": "bd631091-0aa5-4c4d-8f3a-08b4e3e0cbfd",
  "subject_name": "django/db/models/sql/compiler::PositionRef.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, ordinal, refs, source)"
}
```
