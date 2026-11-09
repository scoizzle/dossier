# Fact 72865aac

Store id: 7ce8cf4d-8329-447d-9b5a-67583f795877

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
- posted_at: `2026-11-09T23:44:58.8075620+00:00`

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
  "id": "7ce8cf4d-8329-447d-9b5a-67583f795877",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8075620+00:00"
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
  "subject_id": "98f62873-eac3-4889-9d1c-4f6a5869beef",
  "subject_name": "django/db/models/sql/query::Query.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
