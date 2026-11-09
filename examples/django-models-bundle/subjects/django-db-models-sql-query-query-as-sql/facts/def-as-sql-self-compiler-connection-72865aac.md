# Fact 72865aac

Store id: 0f14de49-30e1-491a-b6c2-4bd0161eef8d

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:51.3480130+00:00`

## Data

```json
{
  "end_line": 1320,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1307,
  "symbol": "Query.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1307,"selector":"L1307-L1320","symbol":"Query.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1320,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1307,
    "symbol": "Query.as_sql"
  },
  "id": "0f14de49-30e1-491a-b6c2-4bd0161eef8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3480130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1307,
        "selector": "L1307-L1320",
        "symbol": "Query.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1601208c-33a0-43c0-b4b2-3c340ef303b7",
  "subject_name": "django/db/models/sql/query::Query.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
