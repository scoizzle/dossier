# Fact df4d005e

Store id: 97d2b6e0-5bf1-4536-8b7f-81813e73a21d

## Text

```text
def clear_select_clause(self)
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
- posted_at: `2026-11-09T23:44:58.9562960+00:00`

## Data

```json
{
  "end_line": 2239,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2232,
  "symbol": "Query.clear_select_clause"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2232,"selector":"L2232-L2239","symbol":"Query.clear_select_clause"}`

## Items

```json
[
  {
    "text": "Remove all fields from SELECT clause.",
    "locator": {
      "line": 2233
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_select_clause](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2239,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2232,
    "symbol": "Query.clear_select_clause"
  },
  "id": "97d2b6e0-5bf1-4536-8b7f-81813e73a21d",
  "items": [
    {
      "locator": {
        "line": 2233
      },
      "text": "Remove all fields from SELECT clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9562960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2232,
        "selector": "L2232-L2239",
        "symbol": "Query.clear_select_clause"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "02b6b80e-3c34-4d42-8aa1-ac2d67ab6aca",
  "subject_name": "django/db/models/sql/query::Query.clear_select_clause",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_select_clause(self)"
}
```
