# Fact e9ca56d8

Store id: 170e3231-379e-452b-bb28-7c23f86067b3

## Text

```text
def add_distinct_fields(self, *field_names)
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
- posted_at: `2026-11-09T23:32:07.0588850+00:00`

## Data

```json
{
  "end_line": 2265,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2260,
  "symbol": "Query.add_distinct_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2260,"selector":"L2260-L2265","symbol":"Query.add_distinct_fields"}`

## Items

```json
[
  {
    "text": "Add and resolve the given fields to the query's \"distinct on\" clause.",
    "locator": {
      "line": 2261
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_distinct_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2265,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2260,
    "symbol": "Query.add_distinct_fields"
  },
  "id": "170e3231-379e-452b-bb28-7c23f86067b3",
  "items": [
    {
      "locator": {
        "line": 2261
      },
      "text": "Add and resolve the given fields to the query's \"distinct on\" clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0588850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2260,
        "selector": "L2260-L2265",
        "symbol": "Query.add_distinct_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5580c57d-9075-4ebf-b59e-ffd02499dd0f",
  "subject_name": "django/db/models/sql/query::Query.add_distinct_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def add_distinct_fields(self, *field_names)"
}
```
