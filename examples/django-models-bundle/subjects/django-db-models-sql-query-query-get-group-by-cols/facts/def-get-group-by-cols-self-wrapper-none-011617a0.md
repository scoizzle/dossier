# Fact 011617a0

Store id: 246922b1-00e8-4110-b143-7777e38e9bb4

## Text

```text
def get_group_by_cols(self, wrapper=None)
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
- posted_at: `2026-11-09T23:44:58.8008960+00:00`

## Data

```json
{
  "end_line": 1305,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1297,
  "symbol": "Query.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1297,"selector":"L1297-L1305","symbol":"Query.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1305,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1297,
    "symbol": "Query.get_group_by_cols"
  },
  "id": "246922b1-00e8-4110-b143-7777e38e9bb4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8008960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1297,
        "selector": "L1297-L1305",
        "symbol": "Query.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a9f4f415-9844-4665-96e5-7b674232445f",
  "subject_name": "django/db/models/sql/query::Query.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self, wrapper=None)"
}
```
