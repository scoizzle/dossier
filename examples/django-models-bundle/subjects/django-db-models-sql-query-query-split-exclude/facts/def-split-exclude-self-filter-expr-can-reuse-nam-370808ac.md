# Fact 370808ac

Store id: bf2ebf62-b0af-4e01-8017-e9227d9f17c1

## Text

```text
def split_exclude(self, filter_expr, can_reuse, names_with_path)
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
- posted_at: `2026-11-09T22:39:51.4310470+00:00`

## Data

```json
{
  "end_line": 2179,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2112,
  "symbol": "Query.split_exclude"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2112,"selector":"L2112-L2179","symbol":"Query.split_exclude"}`

## Items

```json
[
  {
    "text": "When doing an exclude against any kind of N-to-many relation, we need to use a subquery. This method constructs the nested query, given the original exclude filter (filter_expr) and the portion up to the first N-to-many relation field.",
    "locator": {
      "line": 2113
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.split_exclude](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2179,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2112,
    "symbol": "Query.split_exclude"
  },
  "id": "bf2ebf62-b0af-4e01-8017-e9227d9f17c1",
  "items": [
    {
      "locator": {
        "line": 2113
      },
      "text": "When doing an exclude against any kind of N-to-many relation, we need to use a subquery. This method constructs the nested query, given the original exclude filter (filter_expr) and the portion up to the first N-to-many relation field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4310470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2112,
        "selector": "L2112-L2179",
        "symbol": "Query.split_exclude"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3d638591-6b09-4855-b48f-bd4f8ccbcb6d",
  "subject_name": "django/db/models/sql/query::Query.split_exclude",
  "tags": [
    "entity:method"
  ],
  "text": "def split_exclude(self, filter_expr, can_reuse, names_with_path)"
}
```
