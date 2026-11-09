# Fact 370808ac

Store id: 934c7858-65b3-41aa-9f4d-540dd81f0910

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
- posted_at: `2026-11-09T23:44:58.9160980+00:00`

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
  "id": "934c7858-65b3-41aa-9f4d-540dd81f0910",
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
    "posted_at": "2026-11-09T23:44:58.9160980+00:00"
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
  "subject_id": "4c468e26-9d50-4e9d-bb60-605e4266088f",
  "subject_name": "django/db/models/sql/query::Query.split_exclude",
  "tags": [
    "entity:method"
  ],
  "text": "def split_exclude(self, filter_expr, can_reuse, names_with_path)"
}
```
