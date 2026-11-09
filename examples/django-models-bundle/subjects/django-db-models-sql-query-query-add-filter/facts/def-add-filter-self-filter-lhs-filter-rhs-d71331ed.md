# Fact d71331ed

Store id: 50c41e1b-01d5-4d8c-a8f1-9fe139597469

## Text

```text
def add_filter(self, filter_lhs, filter_rhs)
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
- posted_at: `2026-11-09T23:32:06.9377510+00:00`

## Data

```json
{
  "end_line": 1660,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1659,
  "symbol": "Query.add_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1659,"selector":"L1659-L1660","symbol":"Query.add_filter"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1660,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1659,
    "symbol": "Query.add_filter"
  },
  "id": "50c41e1b-01d5-4d8c-a8f1-9fe139597469",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9377510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1659,
        "selector": "L1659-L1660",
        "symbol": "Query.add_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "234a5cdf-f2b0-4c6a-b644-0222aceedede",
  "subject_name": "django/db/models/sql/query::Query.add_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def add_filter(self, filter_lhs, filter_rhs)"
}
```
