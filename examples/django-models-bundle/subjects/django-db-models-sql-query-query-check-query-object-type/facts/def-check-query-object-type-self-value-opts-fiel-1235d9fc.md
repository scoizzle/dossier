# Fact 1235d9fc

Store id: be3f9081-0b9f-46a1-b763-60f484cb9ee7

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
- posted_at: `2026-11-09T23:44:58.8213800+00:00`

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
  "id": "be3f9081-0b9f-46a1-b763-60f484cb9ee7",
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
    "posted_at": "2026-11-09T23:44:58.8213800+00:00"
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
  "subject_id": "0ab7189a-cd08-4c07-b853-9f78e23a6a66",
  "subject_name": "django/db/models/sql/query::Query.check_query_object_type",
  "tags": [
    "entity:method"
  ],
  "text": "def check_query_object_type(self, value, opts, field)"
}
```
