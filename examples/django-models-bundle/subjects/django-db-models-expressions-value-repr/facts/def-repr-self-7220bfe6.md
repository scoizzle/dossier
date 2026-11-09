# Fact 7220bfe6

Store id: 21121e26-0469-40d5-92a2-05eaf4aea075

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
- posted_at: `2026-11-09T23:44:49.5233240+00:00`

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
  "id": "21121e26-0469-40d5-92a2-05eaf4aea075",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5233240+00:00"
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
  "subject_id": "35abd12e-f7ee-439a-ab08-f2ea4e914e2a",
  "subject_name": "django/db/models/expressions::Value.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
