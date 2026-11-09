# Fact 27a56e98

Store id: cd8d0f1d-d53d-4774-9629-352849b33ff2

## Text

```text
def build_filter( self, filter_expr, branch_negated=False, current_negated=False, can_reuse=None, allow_joins=True, split_subq=True, check_filterable=True, summarize=False, update_join_types=True, )
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
- posted_at: `2026-11-09T23:44:58.8446840+00:00`

## Data

```json
{
  "end_line": 1657,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1487,
  "symbol": "Query.build_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1487,"selector":"L1487-L1657","symbol":"Query.build_filter"}`

## Items

```json
[
  {
    "text": "Build a WhereNode for a single filter clause but don't add it to this Query. Query.add_q() will then add this filter to the where Node.",
    "locator": {
      "line": 1499
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.build_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1657,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1487,
    "symbol": "Query.build_filter"
  },
  "id": "cd8d0f1d-d53d-4774-9629-352849b33ff2",
  "items": [
    {
      "locator": {
        "line": 1499
      },
      "text": "Build a WhereNode for a single filter clause but don't add it to this Query. Query.add_q() will then add this filter to the where Node."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8446840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1487,
        "selector": "L1487-L1657",
        "symbol": "Query.build_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1185b259-dd2e-4c00-a805-93af2dfab105",
  "subject_name": "django/db/models/sql/query::Query.build_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def build_filter( self, filter_expr, branch_negated=False, current_negated=False, can_reuse=None, allow_joins=True, split_subq=True, check_filterable=True, summarize=False, update_join_types=True, )"
}
```
