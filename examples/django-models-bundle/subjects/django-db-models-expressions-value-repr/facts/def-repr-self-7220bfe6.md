# Fact 7220bfe6

Store id: e3a882b8-d6ab-4edf-9873-3f4bb24f9d13

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
- posted_at: `2026-11-09T23:31:55.8597400+00:00`

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
  "id": "e3a882b8-d6ab-4edf-9873-3f4bb24f9d13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8597400+00:00"
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
  "subject_id": "73dc7872-3235-436d-ad8f-7445ff56f15e",
  "subject_name": "django/db/models/expressions::Value.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
