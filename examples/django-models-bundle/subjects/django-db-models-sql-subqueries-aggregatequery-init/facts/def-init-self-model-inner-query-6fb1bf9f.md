# Fact 6fb1bf9f

Store id: 86555975-84ac-4390-991a-29790cb0abf5

## Text

```text
def __init__(self, model, inner_query)
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
- posted_at: `2026-11-09T23:44:59.4484000+00:00`

## Data

```json
{
  "end_line": 177,
  "entity_kind": "method",
  "parent": "AggregateQuery",
  "start_line": 175,
  "symbol": "AggregateQuery.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":175,"selector":"L175-L177","symbol":"AggregateQuery.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::AggregateQuery.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 177,
    "entity_kind": "method",
    "parent": "AggregateQuery",
    "start_line": 175,
    "symbol": "AggregateQuery.__init__"
  },
  "id": "86555975-84ac-4390-991a-29790cb0abf5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.4484000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 175,
        "selector": "L175-L177",
        "symbol": "AggregateQuery.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "c031dd18-a06d-42ff-861b-ecd99b14f53a",
  "subject_name": "django/db/models/sql/subqueries::AggregateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model, inner_query)"
}
```
