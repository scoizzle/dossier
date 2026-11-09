# Fact f11bdb53

Store id: 55397252-5176-45de-82f4-06666c2d003d

## Text

```text
def has_select_fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:59.0369710+00:00`

## Data

```json
{
  "end_line": 2585,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2583,
  "symbol": "Query.has_select_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2583,"selector":"L2583-L2585","symbol":"Query.has_select_fields"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_select_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2585,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2583,
    "symbol": "Query.has_select_fields"
  },
  "id": "55397252-5176-45de-82f4-06666c2d003d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0369710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2583,
        "selector": "L2583-L2585",
        "symbol": "Query.has_select_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b34581e3-9727-4b20-80cb-173e4b436e64",
  "subject_name": "django/db/models/sql/query::Query.has_select_fields",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def has_select_fields(self)"
}
```
