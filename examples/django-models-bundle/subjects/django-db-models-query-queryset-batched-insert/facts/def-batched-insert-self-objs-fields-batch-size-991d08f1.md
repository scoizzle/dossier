# Fact 991d08f1

Store id: 7abfc2d6-3be5-43d4-89f5-fc6429b7a668

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
- posted_at: `2026-11-09T23:44:56.1352550+00:00`

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
  "id": "7abfc2d6-3be5-43d4-89f5-fc6429b7a668",
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
    "posted_at": "2026-11-09T23:44:56.1352550+00:00"
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
  "subject_id": "19f7932b-0bde-4c1b-95be-e5413e3ff95a",
  "subject_name": "django/db/models/query::QuerySet._batched_insert",
  "tags": [
    "entity:method"
  ],
  "text": "def _batched_insert( self, objs, fields, batch_size, on_conflict=None, update_fields=None, unique_fields=None, )"
}
```
