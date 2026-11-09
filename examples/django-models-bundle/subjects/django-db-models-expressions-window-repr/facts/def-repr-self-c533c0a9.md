# Fact c533c0a9

Store id: cbdea5f2-894a-4b12-858f-e2a06e967012

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:31:56.0081260+00:00`

## Data

```json
{
  "end_line": 2116,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2115,
  "symbol": "Window.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2115,"selector":"L2115-L2116","symbol":"Window.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2116,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2115,
    "symbol": "Window.__repr__"
  },
  "id": "cbdea5f2-894a-4b12-858f-e2a06e967012",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0081260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2115,
        "selector": "L2115-L2116",
        "symbol": "Window.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8a0a1506-55df-44bd-a576-1b7201a0e5d7",
  "subject_name": "django/db/models/expressions::Window.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
