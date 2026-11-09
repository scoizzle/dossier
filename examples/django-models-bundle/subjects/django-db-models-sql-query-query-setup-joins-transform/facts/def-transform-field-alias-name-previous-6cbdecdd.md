# Fact 6cbdecdd

Store id: 2717e793-254d-4936-9fd7-21f5d69e4392

## Text

```text
def transform(field, alias, *, name, previous)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.9744570+00:00`

## Data

```json
{
  "end_line": 1970,
  "entity_kind": "function",
  "parent": "Query.setup_joins",
  "start_line": 1961,
  "symbol": "Query.setup_joins.transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1961,"selector":"L1961-L1970","symbol":"Query.setup_joins.transform"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.setup_joins.transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1970,
    "entity_kind": "function",
    "parent": "Query.setup_joins",
    "start_line": 1961,
    "symbol": "Query.setup_joins.transform"
  },
  "id": "2717e793-254d-4936-9fd7-21f5d69e4392",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9744570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1961,
        "selector": "L1961-L1970",
        "symbol": "Query.setup_joins.transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "783c48ce-206c-4e28-855c-b5e7ad4b1dce",
  "subject_name": "django/db/models/sql/query::Query.setup_joins.transform",
  "tags": [
    "entity:function"
  ],
  "text": "def transform(field, alias, *, name, previous)"
}
```
