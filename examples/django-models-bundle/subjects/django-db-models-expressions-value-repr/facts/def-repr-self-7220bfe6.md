# Fact 7220bfe6

Store id: a9dec8d1-95c3-48c5-aa22-9576a2d25f26

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
- posted_at: `2026-11-09T22:39:41.5899890+00:00`

## Data

```json
{
  "end_line": 1169,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1168,
  "symbol": "Value.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1168,"selector":"L1168-L1169","symbol":"Value.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1169,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1168,
    "symbol": "Value.__repr__"
  },
  "id": "a9dec8d1-95c3-48c5-aa22-9576a2d25f26",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5899890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1168,
        "selector": "L1168-L1169",
        "symbol": "Value.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7166c991-ba28-4bc0-b39b-9884e374e89e",
  "subject_name": "django/db/models/expressions::Value.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
