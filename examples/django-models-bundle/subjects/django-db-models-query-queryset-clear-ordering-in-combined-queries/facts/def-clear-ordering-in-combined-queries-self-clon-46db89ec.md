# Fact 46db89ec

Store id: f1dd7530-fd84-400f-b2de-6070cd680567

## Text

```text
def _clear_ordering_in_combined_queries(self, cloned_query, other_qs)
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
- posted_at: `2026-11-09T23:44:56.1944990+00:00`

## Data

```json
{
  "end_line": 2392,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2386,
  "symbol": "QuerySet._clear_ordering_in_combined_queries"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2386,"selector":"L2386-L2392","symbol":"QuerySet._clear_ordering_in_combined_queries"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._clear_ordering_in_combined_queries](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2392,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2386,
    "symbol": "QuerySet._clear_ordering_in_combined_queries"
  },
  "id": "f1dd7530-fd84-400f-b2de-6070cd680567",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1944990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2386,
        "selector": "L2386-L2392",
        "symbol": "QuerySet._clear_ordering_in_combined_queries"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "96035527-fec3-413f-a97e-73880ab62de1",
  "subject_name": "django/db/models/query::QuerySet._clear_ordering_in_combined_queries",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear_ordering_in_combined_queries(self, cloned_query, other_qs)"
}
```
