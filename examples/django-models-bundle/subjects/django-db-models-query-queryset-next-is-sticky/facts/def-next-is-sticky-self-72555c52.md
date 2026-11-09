# Fact 72555c52

Store id: 8eb803e4-f6c0-4820-87f6-e845079f1523

## Text

```text
def _next_is_sticky(self)
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
- posted_at: `2026-11-09T23:32:04.6486510+00:00`

## Data

```json
{
  "end_line": 2303,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2291,
  "symbol": "QuerySet._next_is_sticky"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2291,"selector":"L2291-L2303","symbol":"QuerySet._next_is_sticky"}`

## Items

```json
[
  {
    "text": "Indicate that the next filter call and the one following that should be treated as a single filter. This is only important when it comes to determining when to reuse tables for many-to-many filters. Required so that we can filter naturally on the results of related managers.",
    "locator": {
      "line": 2292
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._next_is_sticky](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2303,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2291,
    "symbol": "QuerySet._next_is_sticky"
  },
  "id": "8eb803e4-f6c0-4820-87f6-e845079f1523",
  "items": [
    {
      "locator": {
        "line": 2292
      },
      "text": "Indicate that the next filter call and the one following that should be treated as a single filter. This is only important when it comes to determining when to reuse tables for many-to-many filters. Required so that we can filter naturally on the results of related managers."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6486510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2291,
        "selector": "L2291-L2303",
        "symbol": "QuerySet._next_is_sticky"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "49a26ed5-1993-48b8-b047-a076f368f77c",
  "subject_name": "django/db/models/query::QuerySet._next_is_sticky",
  "tags": [
    "entity:method"
  ],
  "text": "def _next_is_sticky(self)"
}
```
