# Fact be99a069

Store id: 302c8b09-787f-405f-a62d-d6c9f6b36803

## Text

```text
def build_lookup(self, lookups, lhs, rhs)
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
- posted_at: `2026-11-09T23:44:58.8360230+00:00`

## Data

```json
{
  "end_line": 1458,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1414,
  "symbol": "Query.build_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1414,"selector":"L1414-L1458","symbol":"Query.build_lookup"}`

## Items

```json
[
  {
    "text": "Try to extract transforms and lookup from given lhs.",
    "locator": {
      "line": 1415
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.build_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1458,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1414,
    "symbol": "Query.build_lookup"
  },
  "id": "302c8b09-787f-405f-a62d-d6c9f6b36803",
  "items": [
    {
      "locator": {
        "line": 1415
      },
      "text": "Try to extract transforms and lookup from given lhs."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8360230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1414,
        "selector": "L1414-L1458",
        "symbol": "Query.build_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "9b4a0197-fa11-4a76-b59b-392c8dddd7fa",
  "subject_name": "django/db/models/sql/query::Query.build_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def build_lookup(self, lookups, lhs, rhs)"
}
```
