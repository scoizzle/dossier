# Fact 011617a0

Store id: de5aa21e-b675-469b-b9ca-71c5194683de

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
- posted_at: `2026-11-09T23:32:06.9016300+00:00`

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
  "id": "de5aa21e-b675-469b-b9ca-71c5194683de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9016300+00:00"
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
  "subject_id": "9e753534-d8f1-4cba-881a-0a01099fc3a3",
  "subject_name": "django/db/models/sql/query::Query.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self, wrapper=None)"
}
```
