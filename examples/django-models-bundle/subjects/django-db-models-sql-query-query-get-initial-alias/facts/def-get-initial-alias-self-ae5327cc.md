# Fact ae5327cc

Store id: 56ee9078-b8e5-44b5-9ffe-a4491d5e523b

## Text

```text
def get_initial_alias(self)
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
- posted_at: `2026-11-09T23:44:58.7505040+00:00`

## Data

```json
{
  "end_line": 1124,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1112,
  "symbol": "Query.get_initial_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1112,"selector":"L1112-L1124","symbol":"Query.get_initial_alias"}`

## Items

```json
[
  {
    "text": "Return the first alias for this query, after increasing its reference count.",
    "locator": {
      "line": 1113
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_initial_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1124,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1112,
    "symbol": "Query.get_initial_alias"
  },
  "id": "56ee9078-b8e5-44b5-9ffe-a4491d5e523b",
  "items": [
    {
      "locator": {
        "line": 1113
      },
      "text": "Return the first alias for this query, after increasing its reference count."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7505040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1112,
        "selector": "L1112-L1124",
        "symbol": "Query.get_initial_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7026f896-f218-488d-bfc5-f31f788f9c03",
  "subject_name": "django/db/models/sql/query::Query.get_initial_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def get_initial_alias(self)"
}
```
