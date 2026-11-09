# Fact 5f9adaf3

Store id: 834828e2-fc5a-471c-a657-ab7637580e09

## Text

```text
def count_active_tables(self)
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
- posted_at: `2026-11-09T22:39:51.3180860+00:00`

## Data

```json
{
  "end_line": 1132,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1126,
  "symbol": "Query.count_active_tables"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1126,"selector":"L1126-L1132","symbol":"Query.count_active_tables"}`

## Items

```json
[
  {
    "text": "Return the number of tables in this query with a non-zero reference count. After execution, the reference counts are zeroed, so tables added in compiler will not be seen by this method.",
    "locator": {
      "line": 1127
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.count_active_tables](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1132,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1126,
    "symbol": "Query.count_active_tables"
  },
  "id": "834828e2-fc5a-471c-a657-ab7637580e09",
  "items": [
    {
      "locator": {
        "line": 1127
      },
      "text": "Return the number of tables in this query with a non-zero reference count. After execution, the reference counts are zeroed, so tables added in compiler will not be seen by this method."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3180860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1126,
        "selector": "L1126-L1132",
        "symbol": "Query.count_active_tables"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b96b8bd9-30d1-441d-98ce-632f145ec300",
  "subject_name": "django/db/models/sql/query::Query.count_active_tables",
  "tags": [
    "entity:method"
  ],
  "text": "def count_active_tables(self)"
}
```
