# Fact 503d3221

Store id: 3a6aeda0-56a8-4567-ac7f-825285a031c2

## Text

```text
def _prepare_for_bulk_create(self, objs)
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
- posted_at: `2026-11-09T23:44:55.9049370+00:00`

## Data

```json
{
  "end_line": 777,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 763,
  "symbol": "QuerySet._prepare_for_bulk_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":763,"selector":"L763-L777","symbol":"QuerySet._prepare_for_bulk_create"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._prepare_for_bulk_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 777,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 763,
    "symbol": "QuerySet._prepare_for_bulk_create"
  },
  "id": "3a6aeda0-56a8-4567-ac7f-825285a031c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9049370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 763,
        "selector": "L763-L777",
        "symbol": "QuerySet._prepare_for_bulk_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f57c1e51-7f3b-4f19-849f-297373dc5c8c",
  "subject_name": "django/db/models/query::QuerySet._prepare_for_bulk_create",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare_for_bulk_create(self, objs)"
}
```
