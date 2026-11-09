# Fact 964aedee

Store id: b4b02b66-f2e6-403b-8ff2-28ec1cc468f8

## Text

```text
def join_parent_model(self, opts, model, alias, seen)
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
- posted_at: `2026-11-09T23:44:58.7724920+00:00`

## Data

```json
{
  "end_line": 1219,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1188,
  "symbol": "Query.join_parent_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1188,"selector":"L1188-L1219","symbol":"Query.join_parent_model"}`

## Items

```json
[
  {
    "text": "Make sure the given 'model' is joined in the query. If 'model' isn't a parent of 'opts' or if it is None this method is a no-op.",
    "locator": {
      "line": 1189
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.join_parent_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1219,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1188,
    "symbol": "Query.join_parent_model"
  },
  "id": "b4b02b66-f2e6-403b-8ff2-28ec1cc468f8",
  "items": [
    {
      "locator": {
        "line": 1189
      },
      "text": "Make sure the given 'model' is joined in the query. If 'model' isn't a parent of 'opts' or if it is None this method is a no-op."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7724920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1188,
        "selector": "L1188-L1219",
        "symbol": "Query.join_parent_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ef783052-f58a-44c6-8e25-7263c792cef5",
  "subject_name": "django/db/models/sql/query::Query.join_parent_model",
  "tags": [
    "entity:method"
  ],
  "text": "def join_parent_model(self, opts, model, alias, seen)"
}
```
