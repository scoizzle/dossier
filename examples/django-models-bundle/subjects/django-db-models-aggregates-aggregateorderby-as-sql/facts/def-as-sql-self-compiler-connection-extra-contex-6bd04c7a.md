# Fact 6bd04c7a

Store id: 89a2bb4d-821f-4643-8dcb-90d2913c66d5

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:31:53.5311410+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "AggregateOrderBy",
  "start_line": 65,
  "symbol": "AggregateOrderBy.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":65,"selector":"L65-L72","symbol":"AggregateOrderBy.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateOrderBy.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "AggregateOrderBy",
    "start_line": 65,
    "symbol": "AggregateOrderBy.as_sql"
  },
  "id": "89a2bb4d-821f-4643-8dcb-90d2913c66d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5311410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 65,
        "selector": "L65-L72",
        "symbol": "AggregateOrderBy.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "1ce48e4b-fc55-4cc3-8fc9-da6929c6abb7",
  "subject_name": "django/db/models/aggregates::AggregateOrderBy.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
