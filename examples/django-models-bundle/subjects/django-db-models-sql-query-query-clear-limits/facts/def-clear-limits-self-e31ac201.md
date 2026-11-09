# Fact e31ac201

Store id: ab491329-39e2-4f21-9ef4-5db8606f83c2

## Text

```text
def clear_limits(self)
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
- posted_at: `2026-11-09T23:44:58.9350350+00:00`

## Data

```json
{
  "end_line": 2214,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2212,
  "symbol": "Query.clear_limits"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2212,"selector":"L2212-L2214","symbol":"Query.clear_limits"}`

## Items

```json
[
  {
    "text": "Clear any existing limits.",
    "locator": {
      "line": 2213
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_limits](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2214,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2212,
    "symbol": "Query.clear_limits"
  },
  "id": "ab491329-39e2-4f21-9ef4-5db8606f83c2",
  "items": [
    {
      "locator": {
        "line": 2213
      },
      "text": "Clear any existing limits."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9350350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2212,
        "selector": "L2212-L2214",
        "symbol": "Query.clear_limits"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "232ad0a3-cbc6-4dc3-9205-05e46f2c5f27",
  "subject_name": "django/db/models/sql/query::Query.clear_limits",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_limits(self)"
}
```
