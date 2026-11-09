# Fact e1d714ac

Store id: e10383ea-cdba-400e-8513-58cb7fd8e92d

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
- posted_at: `2026-11-09T23:44:59.4431660+00:00`

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
  "id": "e10383ea-cdba-400e-8513-58cb7fd8e92d",
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
    "posted_at": "2026-11-09T23:44:59.4431660+00:00"
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
  "subject_id": "447a0ff2-75f7-45bb-829b-2daa53fc1b96",
  "subject_name": "django/db/models/sql/subqueries::AggregateQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateQuery(Query)"
}
```
