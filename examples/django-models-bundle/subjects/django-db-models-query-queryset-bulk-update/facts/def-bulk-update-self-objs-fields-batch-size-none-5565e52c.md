# Fact 5565e52c

Store id: 871c606c-3cb5-42d1-a3ee-0946d711fef0

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
- posted_at: `2026-11-09T23:32:04.4118280+00:00`

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
  "id": "871c606c-3cb5-42d1-a3ee-0946d711fef0",
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
    "posted_at": "2026-11-09T23:32:04.4118280+00:00"
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
  "subject_id": "b14d98f6-2b38-4457-bfbf-33a88e8e01ff",
  "subject_name": "django/db/models/query::QuerySet.bulk_update",
  "tags": [
    "entity:method"
  ],
  "text": "def bulk_update(self, objs, fields, batch_size=None)"
}
```
