# Fact 4d247adc

Store id: 00f0563d-8d4b-44ef-bcfa-8009442f089c

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
- posted_at: `2026-11-09T23:32:04.6829670+00:00`

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
  "id": "00f0563d-8d4b-44ef-bcfa-8009442f089c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6829670+00:00"
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
  "subject_id": "927b59e2-2e6b-4f85-bb6b-13d44e36b94e",
  "subject_name": "django/db/models/query::QuerySet._check_ordering_first_last_queryset_aggregation",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_ordering_first_last_queryset_aggregation(self, method)"
}
```
