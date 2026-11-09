# Fact 970323d0

Store id: 9e14897c-2cc4-413f-b31c-d488e8692fa1

## Text

```text
class Query(BaseExpression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.5850130+00:00`

## Data

```json
{
  "end_line": 2791,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 231,
  "symbol": "Query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":231,"selector":"L231-L2791","symbol":"Query"}`

## Items

```json
[
  {
    "text": "A single SQL query.",
    "locator": {
      "line": 232
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2791,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 231,
    "symbol": "Query"
  },
  "id": "9e14897c-2cc4-413f-b31c-d488e8692fa1",
  "items": [
    {
      "locator": {
        "line": 232
      },
      "text": "A single SQL query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5850130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 231,
        "selector": "L231-L2791",
        "symbol": "Query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e6b9cfd0-7cd4-4d20-b3e7-eb363586842e",
  "subject_name": "django/db/models/sql/query::Query",
  "tags": [
    "entity:class"
  ],
  "text": "class Query(BaseExpression)"
}
```
