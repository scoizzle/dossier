# Fact f4f31f33

Store id: bfb9fcc2-e0ab-48f0-b738-21e11192db14

## Text

```text
def bulk_create( self, objs, batch_size=None, ignore_conflicts=False, update_conflicts=False, update_fields=None, unique_fields=None, )
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
- posted_at: `2026-11-09T22:39:49.4150610+00:00`

## Data

```json
{
  "end_line": 936,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 833,
  "symbol": "QuerySet.bulk_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":833,"selector":"L833-L936","symbol":"QuerySet.bulk_create"}`

## Items

```json
[
  {
    "text": "Insert each of the instances into the database. Do *not* call save() on each of the instances, do not send any pre/post_save signals, and do not set the primary key attribute if it is an autoincrement field (except if features.can_return_rows_from_bulk_insert=True). Multi-table models are not supported.",
    "locator": {
      "line": 842
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.bulk_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 936,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 833,
    "symbol": "QuerySet.bulk_create"
  },
  "id": "bfb9fcc2-e0ab-48f0-b738-21e11192db14",
  "items": [
    {
      "locator": {
        "line": 842
      },
      "text": "Insert each of the instances into the database. Do *not* call save() on each of the instances, do not send any pre/post_save signals, and do not set the primary key attribute if it is an autoincrement field (except if features.can_return_rows_from_bulk_insert=True). Multi-table models are not supported."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4150610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 833,
        "selector": "L833-L936",
        "symbol": "QuerySet.bulk_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "59b28b52-ce2c-496e-9615-a15af1145bb6",
  "subject_name": "django/db/models/query::QuerySet.bulk_create",
  "tags": [
    "entity:method"
  ],
  "text": "def bulk_create( self, objs, batch_size=None, ignore_conflicts=False, update_conflicts=False, update_fields=None, unique_fields=None, )"
}
```
