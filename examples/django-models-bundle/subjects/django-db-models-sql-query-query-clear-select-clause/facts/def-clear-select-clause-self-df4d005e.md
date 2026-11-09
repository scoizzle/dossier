# Fact df4d005e

Store id: 49427792-a0e6-42a4-966f-c3c2af4ebff1

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
- posted_at: `2026-11-09T22:39:51.4641990+00:00`

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
  "id": "49427792-a0e6-42a4-966f-c3c2af4ebff1",
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
    "posted_at": "2026-11-09T22:39:51.4641990+00:00"
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
  "subject_id": "725812a4-df77-4b74-a41b-9c698de77d0c",
  "subject_name": "django/db/models/sql/query::Query.clear_select_clause",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_select_clause(self)"
}
```
