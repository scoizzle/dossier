# Fact 011617a0

Store id: a47f6925-7231-4cf4-887a-687cf12f84a9

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
- posted_at: `2026-11-09T22:39:51.3439820+00:00`

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
  "id": "a47f6925-7231-4cf4-887a-687cf12f84a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3439820+00:00"
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
  "subject_id": "1b24be13-ba80-4088-a2a7-6cba81914e8e",
  "subject_name": "django/db/models/sql/query::Query.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self, wrapper=None)"
}
```
