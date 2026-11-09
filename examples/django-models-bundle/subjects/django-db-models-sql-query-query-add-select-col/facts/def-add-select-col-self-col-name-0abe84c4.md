# Fact 0abe84c4

Store id: f4f87e15-20f1-48a7-81c8-d72f94cd9f3c

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
- posted_at: `2026-11-09T22:39:51.4719180+00:00`

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
  "id": "f4f87e15-20f1-48a7-81c8-d72f94cd9f3c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4719180+00:00"
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
  "subject_id": "70e89bac-3087-4758-bffc-efad72105bb5",
  "subject_name": "django/db/models/sql/query::Query.add_select_col",
  "tags": [
    "entity:method"
  ],
  "text": "def add_select_col(self, col, name)"
}
```
