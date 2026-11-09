# Fact e31ac201

Store id: a0ccb565-1aef-49fc-a83b-00a12a6388df

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
- posted_at: `2026-11-09T22:39:51.4485540+00:00`

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
  "id": "a0ccb565-1aef-49fc-a83b-00a12a6388df",
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
    "posted_at": "2026-11-09T22:39:51.4485540+00:00"
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
  "subject_id": "33af3e9b-e775-46e0-8a3b-8f4859e1d9cb",
  "subject_name": "django/db/models/sql/query::Query.clear_limits",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_limits(self)"
}
```
