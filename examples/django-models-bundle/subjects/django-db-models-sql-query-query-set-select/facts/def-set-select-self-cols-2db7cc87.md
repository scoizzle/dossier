# Fact 2db7cc87

Store id: 3754f8ac-d3de-4272-87a4-219281f50ad7

## Text

```text
def set_select(self, cols)
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
- posted_at: `2026-11-09T23:32:07.0539990+00:00`

## Data

```json
{
  "end_line": 2258,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2256,
  "symbol": "Query.set_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2256,"selector":"L2256-L2258","symbol":"Query.set_select"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2258,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2256,
    "symbol": "Query.set_select"
  },
  "id": "3754f8ac-d3de-4272-87a4-219281f50ad7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0539990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2256,
        "selector": "L2256-L2258",
        "symbol": "Query.set_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "dc2e30de-9927-4e44-b413-c07e3676885e",
  "subject_name": "django/db/models/sql/query::Query.set_select",
  "tags": [
    "entity:method"
  ],
  "text": "def set_select(self, cols)"
}
```
