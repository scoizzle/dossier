# Fact c40284ce

Store id: 60d0be77-e102-409a-a183-3fb1067cecdb

## Text

```text
def sql_with_params(self)
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
- posted_at: `2026-11-09T23:44:58.6076540+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 356,
  "symbol": "Query.sql_with_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":356,"selector":"L356-L361","symbol":"Query.sql_with_params"}`

## Items

```json
[
  {
    "text": "Return the query as an SQL string and the parameters that will be substituted into the query.",
    "locator": {
      "line": 357
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.sql_with_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 356,
    "symbol": "Query.sql_with_params"
  },
  "id": "60d0be77-e102-409a-a183-3fb1067cecdb",
  "items": [
    {
      "locator": {
        "line": 357
      },
      "text": "Return the query as an SQL string and the parameters that will be substituted into the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6076540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 356,
        "selector": "L356-L361",
        "symbol": "Query.sql_with_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5e453085-0b9c-4f12-a068-8345e334b8dc",
  "subject_name": "django/db/models/sql/query::Query.sql_with_params",
  "tags": [
    "entity:method"
  ],
  "text": "def sql_with_params(self)"
}
```
