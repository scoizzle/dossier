# Fact f8e4bb1c

Store id: 5a7f10db-608a-45a3-a4fb-1a18522ab0ca

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:44:55.8506040+00:00`

## Data

```json
{
  "end_line": 474,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 458,
  "symbol": "QuerySet.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":458,"selector":"L458-L474","symbol":"QuerySet.__iter__"}`

## Items

```json
[
  {
    "text": "The queryset iterator protocol uses three nested iterators in the default case: 1. sql.compiler.execute_sql() - Returns 100 rows at time (constants.GET_ITERATOR_CHUNK_SIZE) using cursor.fetchmany(). This part is responsible for doing some column masking, and returning the rows in chunks. 2. sql.compiler.results_iter() - Returns one row at time. At this point the rows are still just tuples. In some cases the return values are converted to Python values at this location. 3. self.iterator() - Responsible for turning the rows into model objects.",
    "locator": {
      "line": 459
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 474,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 458,
    "symbol": "QuerySet.__iter__"
  },
  "id": "5a7f10db-608a-45a3-a4fb-1a18522ab0ca",
  "items": [
    {
      "locator": {
        "line": 459
      },
      "text": "The queryset iterator protocol uses three nested iterators in the default case: 1. sql.compiler.execute_sql() - Returns 100 rows at time (constants.GET_ITERATOR_CHUNK_SIZE) using cursor.fetchmany(). This part is responsible for doing some column masking, and returning the rows in chunks. 2. sql.compiler.results_iter() - Returns one row at time. At this point the rows are still just tuples. In some cases the return values are converted to Python values at this location. 3. self.iterator() - Responsible for turning the rows into model objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8506040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 458,
        "selector": "L458-L474",
        "symbol": "QuerySet.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "847a8227-e67a-4b9e-b04c-87d8013fa9b8",
  "subject_name": "django/db/models/query::QuerySet.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
