# Fact a531ad5f

Store id: 62fc39fe-0770-46f1-bf17-ead440b19aa4

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
- posted_at: `2026-11-09T22:39:41.5548350+00:00`

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
  "id": "62fc39fe-0770-46f1-bf17-ead440b19aa4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5548350+00:00"
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
  "subject_id": "eb048890-01cc-400a-902e-bf289dccc53d",
  "subject_name": "django/db/models/expressions::TemporalSubtraction.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, rhs)"
}
```
