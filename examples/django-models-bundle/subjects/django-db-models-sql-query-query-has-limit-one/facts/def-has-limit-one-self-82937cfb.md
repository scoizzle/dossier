# Fact 82937cfb

Store id: f9573a7e-4ad7-4677-9aeb-0aa970b5e35b

## Text

```text
def has_limit_one(self)
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
- posted_at: `2026-11-09T23:44:58.9470710+00:00`

## Data

```json
{
  "end_line": 2221,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2220,
  "symbol": "Query.has_limit_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2221","symbol":"Query.has_limit_one"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_limit_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2221,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2220,
    "symbol": "Query.has_limit_one"
  },
  "id": "f9573a7e-4ad7-4677-9aeb-0aa970b5e35b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9470710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2221",
        "symbol": "Query.has_limit_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5fce396d-5eba-4b31-92d6-53cb4b8fb004",
  "subject_name": "django/db/models/sql/query::Query.has_limit_one",
  "tags": [
    "entity:method"
  ],
  "text": "def has_limit_one(self)"
}
```
