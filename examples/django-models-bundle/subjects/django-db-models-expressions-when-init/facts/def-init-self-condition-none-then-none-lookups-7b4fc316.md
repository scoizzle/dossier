# Fact 7b4fc316

Store id: 50608909-c333-4cbb-8fcb-c5f1d8b6383a

## Text

```text
def __init__(self, condition=None, then=None, **lookups)
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
- posted_at: `2026-11-09T23:31:55.9457740+00:00`

## Data

```json
{
  "end_line": 1659,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1641,
  "symbol": "When.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1641,"selector":"L1641-L1659","symbol":"When.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1659,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1641,
    "symbol": "When.__init__"
  },
  "id": "50608909-c333-4cbb-8fcb-c5f1d8b6383a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9457740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1641,
        "selector": "L1641-L1659",
        "symbol": "When.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "10d3cebd-2ca3-4c2e-9fdc-ec9ffe88b5f3",
  "subject_name": "django/db/models/expressions::When.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, condition=None, then=None, **lookups)"
}
```
