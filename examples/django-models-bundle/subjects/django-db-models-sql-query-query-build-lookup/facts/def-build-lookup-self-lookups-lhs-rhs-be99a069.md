# Fact be99a069

Store id: 86e5b57d-2471-4a34-9ec1-ee4e83c7627f

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
- posted_at: `2026-11-09T23:32:06.9274200+00:00`

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
  "id": "86e5b57d-2471-4a34-9ec1-ee4e83c7627f",
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
    "posted_at": "2026-11-09T23:32:06.9274200+00:00"
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
  "subject_id": "86e0e90a-66df-4e81-a4ac-7e52d32bad58",
  "subject_name": "django/db/models/sql/query::Query.build_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def build_lookup(self, lookups, lhs, rhs)"
}
```
