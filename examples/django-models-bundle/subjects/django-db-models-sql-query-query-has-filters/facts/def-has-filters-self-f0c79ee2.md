# Fact f0c79ee2

Store id: b8f6d1d2-758a-48d5-8c75-047b5e90d768

## Text

```text
def has_filters(self)
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
- posted_at: `2026-11-09T22:39:51.2622510+00:00`

## Data

```json
{
  "end_line": 659,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 658,
  "symbol": "Query.has_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":658,"selector":"L658-L659","symbol":"Query.has_filters"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 659,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 658,
    "symbol": "Query.has_filters"
  },
  "id": "b8f6d1d2-758a-48d5-8c75-047b5e90d768",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2622510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 658,
        "selector": "L658-L659",
        "symbol": "Query.has_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fc9982b2-fc6c-4268-8dbb-3455d895bf90",
  "subject_name": "django/db/models/sql/query::Query.has_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def has_filters(self)"
}
```
