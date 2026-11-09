# Fact 6fb1bf9f

Store id: 67a8bce9-c2b9-4eef-9fed-ba9dbfbef652

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
- posted_at: `2026-11-09T22:39:51.7720410+00:00`

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
  "id": "67a8bce9-c2b9-4eef-9fed-ba9dbfbef652",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7720410+00:00"
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
  "subject_id": "a2bfcbe1-0914-45a0-88c1-caaa893e1ea3",
  "subject_name": "django/db/models/sql/subqueries::AggregateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model, inner_query)"
}
```
