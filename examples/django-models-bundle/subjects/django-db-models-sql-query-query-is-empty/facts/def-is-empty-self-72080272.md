# Fact 72080272

Store id: 987aab72-9153-4ccd-9b61-0c78129b875b

## Text

```text
def is_empty(self)
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
- posted_at: `2026-11-09T22:39:51.4389470+00:00`

## Data

```json
{
  "end_line": 2187,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2186,
  "symbol": "Query.is_empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2186,"selector":"L2186-L2187","symbol":"Query.is_empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2187,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2186,
    "symbol": "Query.is_empty"
  },
  "id": "987aab72-9153-4ccd-9b61-0c78129b875b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4389470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2186,
        "selector": "L2186-L2187",
        "symbol": "Query.is_empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5f8c0df9-04eb-4811-b433-5844c8bb5a30",
  "subject_name": "django/db/models/sql/query::Query.is_empty",
  "tags": [
    "entity:method"
  ],
  "text": "def is_empty(self)"
}
```
