# Fact 4d247adc

Store id: 4e617870-fbfd-4796-91df-b9172affbd94

## Text

```text
def _check_ordering_first_last_queryset_aggregation(self, method)
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
- posted_at: `2026-11-09T23:44:56.1914210+00:00`

## Data

```json
{
  "end_line": 2384,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2371,
  "symbol": "QuerySet._check_ordering_first_last_queryset_aggregation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2371,"selector":"L2371-L2384","symbol":"QuerySet._check_ordering_first_last_queryset_aggregation"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._check_ordering_first_last_queryset_aggregation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2384,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2371,
    "symbol": "QuerySet._check_ordering_first_last_queryset_aggregation"
  },
  "id": "4e617870-fbfd-4796-91df-b9172affbd94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1914210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2371,
        "selector": "L2371-L2384",
        "symbol": "QuerySet._check_ordering_first_last_queryset_aggregation"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e1163416-5153-4f02-8ad7-4a625c5ad4b1",
  "subject_name": "django/db/models/query::QuerySet._check_ordering_first_last_queryset_aggregation",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_ordering_first_last_queryset_aggregation(self, method)"
}
```
