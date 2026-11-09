# Fact 5565e52c

Store id: 6291f0b2-1a90-447f-b903-0315c09f25f0

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
- posted_at: `2026-11-09T23:44:55.9199300+00:00`

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
  "id": "6291f0b2-1a90-447f-b903-0315c09f25f0",
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
    "posted_at": "2026-11-09T23:44:55.9199300+00:00"
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
  "subject_id": "ff20acd1-5c5e-46fd-8c9e-a95093948a8d",
  "subject_name": "django/db/models/query::QuerySet.bulk_update",
  "tags": [
    "entity:method"
  ],
  "text": "def bulk_update(self, objs, fields, batch_size=None)"
}
```
