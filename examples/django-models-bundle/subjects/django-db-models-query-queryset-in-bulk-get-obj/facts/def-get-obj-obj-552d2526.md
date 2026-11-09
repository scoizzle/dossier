# Fact 552d2526

Store id: 70787d4f-f6ea-4048-9d96-8df3c6a79271

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
- posted_at: `2026-11-09T23:32:04.4641830+00:00`

## Data

```json
{
  "end_line": 1276,
  "entity_kind": "function",
  "parent": "QuerySet.in_bulk",
  "start_line": 1275,
  "symbol": "QuerySet.in_bulk.get_obj"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1275,"selector":"L1275-L1276","symbol":"QuerySet.in_bulk.get_obj"}`

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
    "end_line": 1276,
    "entity_kind": "function",
    "parent": "QuerySet.in_bulk",
    "start_line": 1275,
    "symbol": "QuerySet.in_bulk.get_obj"
  },
  "id": "70787d4f-f6ea-4048-9d96-8df3c6a79271",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4641830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1275,
        "selector": "L1275-L1276",
        "symbol": "QuerySet.in_bulk.get_obj"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5bd04412-1786-47f1-a0bf-739a48ed102b",
  "subject_name": "django/db/models/query::QuerySet.in_bulk.get_obj",
  "tags": [
    "entity:function"
  ],
  "text": "def get_obj(obj)"
}
```
