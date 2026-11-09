# Fact 5828a342

Store id: 8d77157b-9d11-42f8-a78d-d28674384daa

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
- posted_at: `2026-11-09T23:31:53.5293670+00:00`

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
  "id": "8d77157b-9d11-42f8-a78d-d28674384daa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5293670+00:00"
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
  "subject_id": "c819f7bc-dc86-47df-8036-4e61fef15276",
  "subject_name": "django/db/models/aggregates::AggregateFilter.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
