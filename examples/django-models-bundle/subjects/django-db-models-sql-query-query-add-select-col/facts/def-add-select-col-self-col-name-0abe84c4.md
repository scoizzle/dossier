# Fact 0abe84c4

Store id: 8f65c6c7-f0c2-4e9c-a4e0-c3e3e237dd0e

## Text

```text
def add_select_col(self, col, name)
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
- posted_at: `2026-11-09T23:44:58.9656310+00:00`

## Data

```json
{
  "end_line": 2254,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2251,
  "symbol": "Query.add_select_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2251,"selector":"L2251-L2254","symbol":"Query.add_select_col"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_select_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2254,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2251,
    "symbol": "Query.add_select_col"
  },
  "id": "8f65c6c7-f0c2-4e9c-a4e0-c3e3e237dd0e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9656310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2251,
        "selector": "L2251-L2254",
        "symbol": "Query.add_select_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ab9f8632-40a2-4ce8-987f-6e88e9d1163a",
  "subject_name": "django/db/models/sql/query::Query.add_select_col",
  "tags": [
    "entity:method"
  ],
  "text": "def add_select_col(self, col, name)"
}
```
