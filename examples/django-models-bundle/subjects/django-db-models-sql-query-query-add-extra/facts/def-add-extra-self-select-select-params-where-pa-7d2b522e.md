# Fact 7d2b522e

Store id: ebd7e07b-94ee-4234-80a1-4cefbbcb55e6

## Text

```text
def add_extra(self, select, select_params, where, params, tables, order_by)
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
- posted_at: `2026-11-09T22:39:51.5084950+00:00`

## Data

```json
{
  "end_line": 2494,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2463,
  "symbol": "Query.add_extra"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2463,"selector":"L2463-L2494","symbol":"Query.add_extra"}`

## Items

```json
[
  {
    "text": "Add data to the various extra_* attributes for user-created additions to the query.",
    "locator": {
      "line": 2464
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_extra](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2494,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2463,
    "symbol": "Query.add_extra"
  },
  "id": "ebd7e07b-94ee-4234-80a1-4cefbbcb55e6",
  "items": [
    {
      "locator": {
        "line": 2464
      },
      "text": "Add data to the various extra_* attributes for user-created additions to the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5084950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2463,
        "selector": "L2463-L2494",
        "symbol": "Query.add_extra"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "84b36381-f58d-448e-8e02-f541ee06784a",
  "subject_name": "django/db/models/sql/query::Query.add_extra",
  "tags": [
    "entity:method"
  ],
  "text": "def add_extra(self, select, select_params, where, params, tables, order_by)"
}
```
