# Fact 2778c0ac

Store id: e537266e-6379-4bab-b10b-fe819463fb2c

## Text

```text
def promote_joins(self, aliases)
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
- posted_at: `2026-11-09T23:32:06.8426400+00:00`

## Data

```json
{
  "end_line": 970,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 934,
  "symbol": "Query.promote_joins"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":934,"selector":"L934-L970","symbol":"Query.promote_joins"}`

## Items

```json
[
  {
    "text": "Promote recursively the join type of given aliases and its children to an outer join. If 'unconditional' is False, only promote the join if it is nullable or the parent join is an outer join.",
    "locator": {
      "line": 935
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.promote_joins](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 970,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 934,
    "symbol": "Query.promote_joins"
  },
  "id": "e537266e-6379-4bab-b10b-fe819463fb2c",
  "items": [
    {
      "locator": {
        "line": 935
      },
      "text": "Promote recursively the join type of given aliases and its children to an outer join. If 'unconditional' is False, only promote the join if it is nullable or the parent join is an outer join."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8426400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 934,
        "selector": "L934-L970",
        "symbol": "Query.promote_joins"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "198c6657-1182-459f-8789-129d7889b41b",
  "subject_name": "django/db/models/sql/query::Query.promote_joins",
  "tags": [
    "entity:method"
  ],
  "text": "def promote_joins(self, aliases)"
}
```
