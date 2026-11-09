# Fact 766b1cc1

Store id: 3ab18215-105a-4bb0-b614-1269754d718e

## Text

```text
def clear_where(self)
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
- posted_at: `2026-11-09T22:39:51.3854920+00:00`

## Data

```json
{
  "end_line": 1689,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1688,
  "symbol": "Query.clear_where"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1688,"selector":"L1688-L1689","symbol":"Query.clear_where"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_where](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1689,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1688,
    "symbol": "Query.clear_where"
  },
  "id": "3ab18215-105a-4bb0-b614-1269754d718e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3854920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1688,
        "selector": "L1688-L1689",
        "symbol": "Query.clear_where"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "67aca735-ae24-4953-809f-7fa95cc7efa4",
  "subject_name": "django/db/models/sql/query::Query.clear_where",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_where(self)"
}
```
