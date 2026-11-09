# Fact 6c6515e5

Store id: 7ba0b82c-e981-4a7d-baec-10ede46e3dff

## Text

```text
def ordered(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.6833970+00:00`

## Data

```json
{
  "end_line": 2054,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2035,
  "symbol": "QuerySet.ordered"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2035,"selector":"L2035-L2054","symbol":"QuerySet.ordered"}`

## Items

```json
[
  {
    "text": "Return True if the QuerySet is ordered -- i.e. has an order_by() clause or a default ordering on the model (or is empty).",
    "locator": {
      "line": 2037
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.ordered](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2054,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2035,
    "symbol": "QuerySet.ordered"
  },
  "id": "7ba0b82c-e981-4a7d-baec-10ede46e3dff",
  "items": [
    {
      "locator": {
        "line": 2037
      },
      "text": "Return True if the QuerySet is ordered -- i.e. has an order_by() clause or a default ordering on the model (or is empty)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6833970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2035,
        "selector": "L2035-L2054",
        "symbol": "QuerySet.ordered"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "002624fa-d20d-40a6-aa12-cc6a5c66ed71",
  "subject_name": "django/db/models/query::QuerySet.ordered",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def ordered(self)"
}
```
