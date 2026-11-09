# Fact 9abcb745

Store id: 3e90b2db-cafb-42ef-84c4-f70f07e4c660

## Text

```text
def final_transformer(field, alias)
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
- posted_at: `2026-11-09T22:39:51.4061060+00:00`

## Data

```json
{
  "end_line": 1934,
  "entity_kind": "function",
  "parent": "Query.setup_joins",
  "start_line": 1931,
  "symbol": "Query.setup_joins.final_transformer"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1931,"selector":"L1931-L1934","symbol":"Query.setup_joins.final_transformer"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.setup_joins.final_transformer](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1934,
    "entity_kind": "function",
    "parent": "Query.setup_joins",
    "start_line": 1931,
    "symbol": "Query.setup_joins.final_transformer"
  },
  "id": "3e90b2db-cafb-42ef-84c4-f70f07e4c660",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4061060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1931,
        "selector": "L1931-L1934",
        "symbol": "Query.setup_joins.final_transformer"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "87d18b8d-e7c3-49e1-912a-e27bf9433fa1",
  "subject_name": "django/db/models/sql/query::Query.setup_joins.final_transformer",
  "tags": [
    "entity:function"
  ],
  "text": "def final_transformer(field, alias)"
}
```
