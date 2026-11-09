# Fact 991d08f1

Store id: 13df1d44-a5d9-4cab-b8dc-d15a2e9fe042

## Text

```text
def _batched_insert( self, objs, fields, batch_size, on_conflict=None, update_fields=None, unique_fields=None, )
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
- posted_at: `2026-11-09T22:39:49.6972070+00:00`

## Data

```json
{
  "end_line": 2214,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2171,
  "symbol": "QuerySet._batched_insert"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2171,"selector":"L2171-L2214","symbol":"QuerySet._batched_insert"}`

## Items

```json
[
  {
    "text": "Helper method for bulk_create() to insert objs one batch at a time.",
    "locator": {
      "line": 2180
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._batched_insert](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2214,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2171,
    "symbol": "QuerySet._batched_insert"
  },
  "id": "13df1d44-a5d9-4cab-b8dc-d15a2e9fe042",
  "items": [
    {
      "locator": {
        "line": 2180
      },
      "text": "Helper method for bulk_create() to insert objs one batch at a time."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6972070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2171,
        "selector": "L2171-L2214",
        "symbol": "QuerySet._batched_insert"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "adf4132e-30cc-40d0-ab34-0a92a6d2a6e0",
  "subject_name": "django/db/models/query::QuerySet._batched_insert",
  "tags": [
    "entity:method"
  ],
  "text": "def _batched_insert( self, objs, fields, batch_size, on_conflict=None, update_fields=None, unique_fields=None, )"
}
```
