# Fact 61cc226b

Store id: 8ed2f115-8658-4fcf-9de4-926d3381771d

## Text

```text
def _not_support_combined_queries(self, operation_name)
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
- posted_at: `2026-11-09T23:44:56.1847050+00:00`

## Data

```json
{
  "end_line": 2365,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2360,
  "symbol": "QuerySet._not_support_combined_queries"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2360,"selector":"L2360-L2365","symbol":"QuerySet._not_support_combined_queries"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._not_support_combined_queries](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2365,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2360,
    "symbol": "QuerySet._not_support_combined_queries"
  },
  "id": "8ed2f115-8658-4fcf-9de4-926d3381771d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1847050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2360,
        "selector": "L2360-L2365",
        "symbol": "QuerySet._not_support_combined_queries"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8184eef4-e81b-4aa1-993b-1c514aba3142",
  "subject_name": "django/db/models/query::QuerySet._not_support_combined_queries",
  "tags": [
    "entity:method"
  ],
  "text": "def _not_support_combined_queries(self, operation_name)"
}
```
