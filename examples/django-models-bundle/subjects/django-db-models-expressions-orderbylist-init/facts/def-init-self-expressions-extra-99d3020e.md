# Fact 99d3020e

Store id: 4ea954b8-ff30-44ba-8e17-c5d1b75a3bf4

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T22:39:41.6654960+00:00`

## Data

```json
{
  "end_line": 1529,
  "entity_kind": "method",
  "parent": "OrderByList",
  "start_line": 1520,
  "symbol": "OrderByList.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1520,"selector":"L1520-L1529","symbol":"OrderByList.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderByList.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1529,
    "entity_kind": "method",
    "parent": "OrderByList",
    "start_line": 1520,
    "symbol": "OrderByList.__init__"
  },
  "id": "4ea954b8-ff30-44ba-8e17-c5d1b75a3bf4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6654960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1520,
        "selector": "L1520-L1529",
        "symbol": "OrderByList.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2a09923f-c97d-4eb0-9db7-cdd3d921e09e",
  "subject_name": "django/db/models/expressions::OrderByList.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
