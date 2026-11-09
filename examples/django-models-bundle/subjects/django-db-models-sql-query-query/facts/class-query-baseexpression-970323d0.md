# Fact 970323d0

Store id: 51c4b4c1-3c1c-4527-980a-275c83a02cf6

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
- posted_at: `2026-11-09T22:39:51.2164780+00:00`

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
  "id": "51c4b4c1-3c1c-4527-980a-275c83a02cf6",
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
    "posted_at": "2026-11-09T22:39:51.2164780+00:00"
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
  "subject_id": "865536af-be51-49fa-80ee-b755315244e0",
  "subject_name": "django/db/models/sql/query::Query",
  "tags": [
    "entity:class"
  ],
  "text": "class Query(BaseExpression)"
}
```
