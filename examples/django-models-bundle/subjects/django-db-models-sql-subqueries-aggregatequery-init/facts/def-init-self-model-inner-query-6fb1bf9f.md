# Fact 6fb1bf9f

Store id: a53e95db-66ba-4a44-9cdf-b5df7ce8e897

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
- posted_at: `2026-11-09T23:32:07.4182070+00:00`

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
  "id": "a53e95db-66ba-4a44-9cdf-b5df7ce8e897",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.4182070+00:00"
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
  "subject_id": "b2e21aae-4e58-4a8c-8370-9ff8967060ad",
  "subject_name": "django/db/models/sql/subqueries::AggregateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model, inner_query)"
}
```
