# Fact 72080272

Store id: 90793beb-21dc-4787-9069-bb676771c3a1

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
- posted_at: `2026-11-09T23:32:07.0104080+00:00`

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
  "id": "90793beb-21dc-4787-9069-bb676771c3a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0104080+00:00"
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
  "subject_id": "7a089cae-48ad-4243-871d-23baf4ea271e",
  "subject_name": "django/db/models/sql/query::Query.is_empty",
  "tags": [
    "entity:method"
  ],
  "text": "def is_empty(self)"
}
```
