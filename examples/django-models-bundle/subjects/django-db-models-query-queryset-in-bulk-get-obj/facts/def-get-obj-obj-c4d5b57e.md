# Fact c4d5b57e

Store id: a6695ae5-c7d4-4de4-96d6-facf9a8f8ac1

## Text

```text
def get_obj(obj)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.5050190+00:00`

## Data

```json
{
  "end_line": 1300,
  "entity_kind": "function",
  "parent": "QuerySet.in_bulk",
  "start_line": 1295,
  "symbol": "QuerySet.in_bulk.get_obj"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1295,"selector":"L1295-L1300","symbol":"QuerySet.in_bulk.get_obj"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.in_bulk.get_obj](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1300,
    "entity_kind": "function",
    "parent": "QuerySet.in_bulk",
    "start_line": 1295,
    "symbol": "QuerySet.in_bulk.get_obj"
  },
  "id": "a6695ae5-c7d4-4de4-96d6-facf9a8f8ac1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5050190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1295,
        "selector": "L1295-L1300",
        "symbol": "QuerySet.in_bulk.get_obj"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b922cbc4-505f-44b2-82ec-366f802911f1",
  "subject_name": "django/db/models/query::QuerySet.in_bulk.get_obj",
  "tags": [
    "entity:function"
  ],
  "text": "def get_obj(obj)"
}
```
