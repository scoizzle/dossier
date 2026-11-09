# Fact cdf0fdb7

Store id: 38022d20-49be-4ab4-abb3-4b3e706d566a

## Text

```text
def __init__(self, queryset, output_field=None, **extra)
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
- posted_at: `2026-11-09T22:39:41.7204100+00:00`

## Data

```json
{
  "end_line": 1833,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1827,
  "symbol": "Subquery.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1827,"selector":"L1827-L1833","symbol":"Subquery.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1833,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1827,
    "symbol": "Subquery.__init__"
  },
  "id": "38022d20-49be-4ab4-abb3-4b3e706d566a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7204100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1827,
        "selector": "L1827-L1833",
        "symbol": "Subquery.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ed830185-e411-43a0-98e1-fd17c41e1f62",
  "subject_name": "django/db/models/expressions::Subquery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset, output_field=None, **extra)"
}
```
