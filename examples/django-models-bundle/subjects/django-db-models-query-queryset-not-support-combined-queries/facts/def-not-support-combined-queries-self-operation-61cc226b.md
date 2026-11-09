# Fact 61cc226b

Store id: 577fcf4e-442d-4f36-b6bc-eb293a0f8013

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
- posted_at: `2026-11-09T23:32:04.6762570+00:00`

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
  "id": "577fcf4e-442d-4f36-b6bc-eb293a0f8013",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6762570+00:00"
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
  "subject_id": "989a49cb-2419-48fc-8913-b9331d5e0dec",
  "subject_name": "django/db/models/query::QuerySet._not_support_combined_queries",
  "tags": [
    "entity:method"
  ],
  "text": "def _not_support_combined_queries(self, operation_name)"
}
```
