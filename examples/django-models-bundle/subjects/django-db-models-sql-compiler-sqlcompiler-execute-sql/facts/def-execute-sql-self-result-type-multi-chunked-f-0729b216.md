# Fact 0729b216

Store id: 4b7edeb0-d773-4903-867a-9c87e63aeb6a

## Text

```text
def execute_sql( self, result_type=MULTI, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE )
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
- posted_at: `2026-11-09T22:39:50.6823740+00:00`

## Data

```json
{
  "end_line": 1685,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1613,
  "symbol": "SQLCompiler.execute_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1613,"selector":"L1613-L1685","symbol":"SQLCompiler.execute_sql"}`

## Items

```json
[
  {
    "text": "Run the query against the database and return the result(s). The return value depends on the value of result_type.",
    "locator": {
      "line": 1616
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.execute_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1685,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1613,
    "symbol": "SQLCompiler.execute_sql"
  },
  "id": "4b7edeb0-d773-4903-867a-9c87e63aeb6a",
  "items": [
    {
      "locator": {
        "line": 1616
      },
      "text": "Run the query against the database and return the result(s). The return value depends on the value of result_type."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6823740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1613,
        "selector": "L1613-L1685",
        "symbol": "SQLCompiler.execute_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "bffa32b0-01e8-4796-ba5c-3d050cc59fe4",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.execute_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_sql( self, result_type=MULTI, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE )"
}
```
