# Fact 6c6515e5

Store id: e85d369c-78c2-4bc6-b048-001c19cc08b8

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
- posted_at: `2026-11-09T23:32:04.6076500+00:00`

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
  "id": "e85d369c-78c2-4bc6-b048-001c19cc08b8",
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
    "posted_at": "2026-11-09T23:32:04.6076500+00:00"
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
  "subject_id": "bbca57d2-ed53-46cc-9b62-c2bcdbf87b69",
  "subject_name": "django/db/models/query::QuerySet.ordered",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def ordered(self)"
}
```
