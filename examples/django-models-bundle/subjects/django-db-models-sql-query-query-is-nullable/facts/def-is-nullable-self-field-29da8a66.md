# Fact 29da8a66

Store id: a7d99777-ab39-4d07-ad8b-da1569b52d74

## Text

```text
def is_nullable(self, field)
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
- posted_at: `2026-11-09T23:32:07.1511410+00:00`

## Data

```json
{
  "end_line": 2791,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2775,
  "symbol": "Query.is_nullable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2775,"selector":"L2775-L2791","symbol":"Query.is_nullable"}`

## Items

```json
[
  {
    "text": "Check if the given field should be treated as nullable.",
    "locator": {
      "line": 2776
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_nullable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2791,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2775,
    "symbol": "Query.is_nullable"
  },
  "id": "a7d99777-ab39-4d07-ad8b-da1569b52d74",
  "items": [
    {
      "locator": {
        "line": 2776
      },
      "text": "Check if the given field should be treated as nullable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1511410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2775,
        "selector": "L2775-L2791",
        "symbol": "Query.is_nullable"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8d7b90e2-69db-4fa3-b500-c683f7f0560c",
  "subject_name": "django/db/models/sql/query::Query.is_nullable",
  "tags": [
    "entity:method"
  ],
  "text": "def is_nullable(self, field)"
}
```
