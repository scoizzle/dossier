# Fact 05c7f311

Store id: 78bd6ff0-a2cd-4c7b-96f3-73bd89757db5

## Text

```text
def clear_deferred_loading(self)
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
- posted_at: `2026-11-09T23:32:07.0965730+00:00`

## Data

```json
{
  "end_line": 2498,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2496,
  "symbol": "Query.clear_deferred_loading"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2496,"selector":"L2496-L2498","symbol":"Query.clear_deferred_loading"}`

## Items

```json
[
  {
    "text": "Remove any fields from the deferred loading set.",
    "locator": {
      "line": 2497
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.clear_deferred_loading](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2498,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2496,
    "symbol": "Query.clear_deferred_loading"
  },
  "id": "78bd6ff0-a2cd-4c7b-96f3-73bd89757db5",
  "items": [
    {
      "locator": {
        "line": 2497
      },
      "text": "Remove any fields from the deferred loading set."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0965730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2496,
        "selector": "L2496-L2498",
        "symbol": "Query.clear_deferred_loading"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "694ebf12-d5c0-4406-ade4-e5f9355b73fe",
  "subject_name": "django/db/models/sql/query::Query.clear_deferred_loading",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_deferred_loading(self)"
}
```
