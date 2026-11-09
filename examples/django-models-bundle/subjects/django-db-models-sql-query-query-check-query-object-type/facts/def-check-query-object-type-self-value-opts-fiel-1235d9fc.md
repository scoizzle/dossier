# Fact 1235d9fc

Store id: f9296f45-1aaf-46ad-9b56-e4a4e1053ca4

## Text

```text
def check_query_object_type(self, value, opts, field)
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
- posted_at: `2026-11-09T22:39:51.3567060+00:00`

## Data

```json
{
  "end_line": 1376,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1366,
  "symbol": "Query.check_query_object_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1366,"selector":"L1366-L1376","symbol":"Query.check_query_object_type"}`

## Items

```json
[
  {
    "text": "Check whether the object passed while querying is of the correct type. If not, raise a ValueError specifying the wrong object.",
    "locator": {
      "line": 1367
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.check_query_object_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1376,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1366,
    "symbol": "Query.check_query_object_type"
  },
  "id": "f9296f45-1aaf-46ad-9b56-e4a4e1053ca4",
  "items": [
    {
      "locator": {
        "line": 1367
      },
      "text": "Check whether the object passed while querying is of the correct type. If not, raise a ValueError specifying the wrong object."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3567060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1366,
        "selector": "L1366-L1376",
        "symbol": "Query.check_query_object_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5a099149-68de-446f-a023-d87c70d1aa6d",
  "subject_name": "django/db/models/sql/query::Query.check_query_object_type",
  "tags": [
    "entity:method"
  ],
  "text": "def check_query_object_type(self, value, opts, field)"
}
```
