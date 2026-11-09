# Fact d71331ed

Store id: 31ab9f55-2470-42a4-93a9-9292775095fe

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
- posted_at: `2026-11-09T23:44:58.8499110+00:00`

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
  "id": "31ab9f55-2470-42a4-93a9-9292775095fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8499110+00:00"
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
  "subject_id": "5a563e76-a6e5-4161-8743-bda4a99b4c1f",
  "subject_name": "django/db/models/sql/query::Query.add_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def add_filter(self, filter_lhs, filter_rhs)"
}
```
