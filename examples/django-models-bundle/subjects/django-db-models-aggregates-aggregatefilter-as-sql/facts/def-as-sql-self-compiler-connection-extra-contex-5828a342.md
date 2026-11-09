# Fact 5828a342

Store id: 49d9e03e-159d-4b00-a4b6-e1a4cada7ac7

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
- posted_at: `2026-11-09T23:44:48.3926270+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "method",
  "parent": "AggregateFilter",
  "start_line": 44,
  "symbol": "AggregateFilter.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":44,"selector":"L44-L52","symbol":"AggregateFilter.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateFilter.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "method",
    "parent": "AggregateFilter",
    "start_line": 44,
    "symbol": "AggregateFilter.as_sql"
  },
  "id": "49d9e03e-159d-4b00-a4b6-e1a4cada7ac7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3926270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 44,
        "selector": "L44-L52",
        "symbol": "AggregateFilter.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "4b241dc6-1f73-47cd-b087-a9680e653064",
  "subject_name": "django/db/models/aggregates::AggregateFilter.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
