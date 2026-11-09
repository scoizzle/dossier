# Fact de9d60ac

Store id: 015d1629-dfa9-48c1-a9c7-1a0ba1e16f02

## Text

```text
def __init__(self, obj, subscript)
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
- posted_at: `2026-11-09T22:39:41.5741950+00:00`

## Data

```json
{
  "end_line": 1027,
  "entity_kind": "method",
  "parent": "Sliced",
  "start_line": 1004,
  "symbol": "Sliced.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1004,"selector":"L1004-L1027","symbol":"Sliced.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1027,
    "entity_kind": "method",
    "parent": "Sliced",
    "start_line": 1004,
    "symbol": "Sliced.__init__"
  },
  "id": "015d1629-dfa9-48c1-a9c7-1a0ba1e16f02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5741950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1004,
        "selector": "L1004-L1027",
        "symbol": "Sliced.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "24e7a37c-df01-4d91-9c6d-bb15e8cc7798",
  "subject_name": "django/db/models/expressions::Sliced.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, obj, subscript)"
}
```
