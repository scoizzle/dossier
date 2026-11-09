# Fact 0fb737a1

Store id: 71321104-f0d4-439d-9f46-b699daeaca91

## Text

```text
def can_filter(self)
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
- posted_at: `2026-11-09T23:32:07.0349780+00:00`

## Data

```json
{
  "end_line": 2230,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2223,
  "symbol": "Query.can_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2223,"selector":"L2223-L2230","symbol":"Query.can_filter"}`

## Items

```json
[
  {
    "text": "Return True if adding filters to this instance is still possible.",
    "locator": {
      "line": 2224
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.can_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2230,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2223,
    "symbol": "Query.can_filter"
  },
  "id": "71321104-f0d4-439d-9f46-b699daeaca91",
  "items": [
    {
      "locator": {
        "line": 2224
      },
      "text": "Return True if adding filters to this instance is still possible."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0349780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2223,
        "selector": "L2223-L2230",
        "symbol": "Query.can_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "38929923-4123-4a59-848d-5b2f2f135439",
  "subject_name": "django/db/models/sql/query::Query.can_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def can_filter(self)"
}
```
