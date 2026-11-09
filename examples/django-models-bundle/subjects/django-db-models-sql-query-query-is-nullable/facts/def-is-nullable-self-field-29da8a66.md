# Fact 29da8a66

Store id: bd88a6a3-ca11-4479-99c0-626fb2b18080

## Text

```text
def is_nullable(self, field)
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
- posted_at: `2026-11-09T22:39:51.5560740+00:00`

## Data

```json
{
  "end_line": 2791,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2775,
  "symbol": "Query.is_nullable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2775,"selector":"L2775-L2791","symbol":"Query.is_nullable"}`

## Items

```json
[
  {
    "text": "Check if the given field should be treated as nullable.",
    "locator": {
      "line": 2776
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_nullable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2791,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2775,
    "symbol": "Query.is_nullable"
  },
  "id": "bd88a6a3-ca11-4479-99c0-626fb2b18080",
  "items": [
    {
      "locator": {
        "line": 2776
      },
      "text": "Check if the given field should be treated as nullable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5560740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2775,
        "selector": "L2775-L2791",
        "symbol": "Query.is_nullable"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "098fe1e8-092b-4999-ad60-cad5166a75fc",
  "subject_name": "django/db/models/sql/query::Query.is_nullable",
  "tags": [
    "entity:method"
  ],
  "text": "def is_nullable(self, field)"
}
```
