# Fact e1d714ac

Store id: bf427d44-252f-4d03-92dc-9e8eb006b693

## Text

```text
class AggregateQuery(Query)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.4135270+00:00`

## Data

```json
{
  "end_line": 177,
  "entity_kind": "class",
  "parent": "subqueries",
  "start_line": 167,
  "symbol": "AggregateQuery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":167,"selector":"L167-L177","symbol":"AggregateQuery"}`

## Items

```json
[
  {
    "text": "Take another query as a parameter to the FROM clause and only select the elements in the provided list.",
    "locator": {
      "line": 168
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::AggregateQuery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 177,
    "entity_kind": "class",
    "parent": "subqueries",
    "start_line": 167,
    "symbol": "AggregateQuery"
  },
  "id": "bf427d44-252f-4d03-92dc-9e8eb006b693",
  "items": [
    {
      "locator": {
        "line": 168
      },
      "text": "Take another query as a parameter to the FROM clause and only select the elements in the provided list."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.4135270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 167,
        "selector": "L167-L177",
        "symbol": "AggregateQuery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "4d6d5249-5aa1-4ef9-85b0-71bad5d44ab4",
  "subject_name": "django/db/models/sql/subqueries::AggregateQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateQuery(Query)"
}
```
