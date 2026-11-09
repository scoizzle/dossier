# Fact a083bd55

Store id: 67b00509-a670-4d9b-8547-79f8445601be

## Text

```text
def try_transform(self, lhs, name, lookups=None)
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
- posted_at: `2026-11-09T23:44:58.8406550+00:00`

## Data

```json
{
  "end_line": 1485,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1460,
  "symbol": "Query.try_transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1460,"selector":"L1460-L1485","symbol":"Query.try_transform"}`

## Items

```json
[
  {
    "text": "Helper method for build_lookup(). Try to fetch and initialize a transform for name parameter from lhs.",
    "locator": {
      "line": 1461
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.try_transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1485,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1460,
    "symbol": "Query.try_transform"
  },
  "id": "67b00509-a670-4d9b-8547-79f8445601be",
  "items": [
    {
      "locator": {
        "line": 1461
      },
      "text": "Helper method for build_lookup(). Try to fetch and initialize a transform for name parameter from lhs."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8406550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1460,
        "selector": "L1460-L1485",
        "symbol": "Query.try_transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d0eb32d2-c84e-4c3f-8cd1-f95f5e45316e",
  "subject_name": "django/db/models/sql/query::Query.try_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def try_transform(self, lhs, name, lookups=None)"
}
```
