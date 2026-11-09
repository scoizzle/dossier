# Fact 5565e52c

Store id: 3c4c4db6-63d6-4d79-b7fa-d7260ce8d30d

## Text

```text
def bulk_update(self, objs, fields, batch_size=None)
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
- posted_at: `2026-11-09T22:39:49.4308080+00:00`

## Data

```json
{
  "end_line": 1047,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 991,
  "symbol": "QuerySet.bulk_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":991,"selector":"L991-L1047","symbol":"QuerySet.bulk_update"}`

## Items

```json
[
  {
    "text": "Update the given fields in each of the given objects in the database.",
    "locator": {
      "line": 992
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.bulk_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1047,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 991,
    "symbol": "QuerySet.bulk_update"
  },
  "id": "3c4c4db6-63d6-4d79-b7fa-d7260ce8d30d",
  "items": [
    {
      "locator": {
        "line": 992
      },
      "text": "Update the given fields in each of the given objects in the database."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4308080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 991,
        "selector": "L991-L1047",
        "symbol": "QuerySet.bulk_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "84ac04d8-d1e5-4894-bf5b-bc1818a8a3c1",
  "subject_name": "django/db/models/query::QuerySet.bulk_update",
  "tags": [
    "entity:method"
  ],
  "text": "def bulk_update(self, objs, fields, batch_size=None)"
}
```
