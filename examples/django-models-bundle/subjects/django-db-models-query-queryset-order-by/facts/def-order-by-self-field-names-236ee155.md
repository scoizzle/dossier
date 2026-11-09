# Fact 236ee155

Store id: e78e5009-1e45-4bdd-8882-33805b43ad29

## Text

```text
def order_by(self, *field_names)
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
- posted_at: `2026-11-09T23:32:04.5838960+00:00`

## Data

```json
{
  "end_line": 1941,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1934,
  "symbol": "QuerySet.order_by"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1934,"selector":"L1934-L1941","symbol":"QuerySet.order_by"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance with the ordering changed.",
    "locator": {
      "line": 1935
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.order_by](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1941,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1934,
    "symbol": "QuerySet.order_by"
  },
  "id": "e78e5009-1e45-4bdd-8882-33805b43ad29",
  "items": [
    {
      "locator": {
        "line": 1935
      },
      "text": "Return a new QuerySet instance with the ordering changed."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5838960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1934,
        "selector": "L1934-L1941",
        "symbol": "QuerySet.order_by"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4c1db588-f18e-4716-8688-499f3a9e645f",
  "subject_name": "django/db/models/query::QuerySet.order_by",
  "tags": [
    "entity:method"
  ],
  "text": "def order_by(self, *field_names)"
}
```
