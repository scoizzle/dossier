# Fact 99d3020e

Store id: d3d1c3a6-f300-46f5-9e2c-d8bc18b1ba29

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
- posted_at: `2026-11-09T23:44:49.5916370+00:00`

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
  "id": "d3d1c3a6-f300-46f5-9e2c-d8bc18b1ba29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5916370+00:00"
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
  "subject_id": "43106367-f785-4255-85b1-59225959eabd",
  "subject_name": "django/db/models/expressions::OrderByList.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
