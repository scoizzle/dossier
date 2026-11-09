# Fact 1235d9fc

Store id: 685e3520-4adc-4ef6-998a-8fbab5575076

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
- posted_at: `2026-11-09T23:32:06.9160940+00:00`

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
  "id": "685e3520-4adc-4ef6-998a-8fbab5575076",
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
    "posted_at": "2026-11-09T23:32:06.9160940+00:00"
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
  "subject_id": "4b7257e1-87b9-4d15-990d-7d2ac37e7b8f",
  "subject_name": "django/db/models/sql/query::Query.check_query_object_type",
  "tags": [
    "entity:method"
  ],
  "text": "def check_query_object_type(self, value, opts, field)"
}
```
