# Fact a531ad5f

Store id: 7b6ae92b-df99-47a1-9521-5e43875c14b2

## Text

```text
def __init__(self, lhs, rhs)
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
- posted_at: `2026-11-09T23:44:49.4580700+00:00`

## Data

```json
{
  "end_line": 870,
  "entity_kind": "method",
  "parent": "TemporalSubtraction",
  "start_line": 869,
  "symbol": "TemporalSubtraction.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":869,"selector":"L869-L870","symbol":"TemporalSubtraction.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::TemporalSubtraction.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 870,
    "entity_kind": "method",
    "parent": "TemporalSubtraction",
    "start_line": 869,
    "symbol": "TemporalSubtraction.__init__"
  },
  "id": "7b6ae92b-df99-47a1-9521-5e43875c14b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4580700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 869,
        "selector": "L869-L870",
        "symbol": "TemporalSubtraction.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "98e78019-0396-4a23-8db6-e344a6489373",
  "subject_name": "django/db/models/expressions::TemporalSubtraction.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, rhs)"
}
```
