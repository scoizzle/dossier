# Fact c40284ce

Store id: acf829be-fd71-4138-b025-71648d1f4d9c

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
- posted_at: `2026-11-09T23:32:06.7617270+00:00`

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
  "id": "acf829be-fd71-4138-b025-71648d1f4d9c",
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
    "posted_at": "2026-11-09T23:32:06.7617270+00:00"
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
  "subject_id": "14b0b599-e11a-4d99-bb58-569e0d881dd8",
  "subject_name": "django/db/models/sql/query::Query.sql_with_params",
  "tags": [
    "entity:method"
  ],
  "text": "def sql_with_params(self)"
}
```
