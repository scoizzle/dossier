# Fact 9d26419a

Store id: 79d5e077-d4f8-4110-8094-7e13261858b0

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
- posted_at: `2026-11-09T23:31:53.5371490+00:00`

## Data

```json
{
  "end_line": 269,
  "entity_kind": "method",
  "parent": "BitAggregate",
  "start_line": 256,
  "symbol": "BitAggregate.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":256,"selector":"L256-L269","symbol":"BitAggregate.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAggregate.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 269,
    "entity_kind": "method",
    "parent": "BitAggregate",
    "start_line": 256,
    "symbol": "BitAggregate.as_sql"
  },
  "id": "79d5e077-d4f8-4110-8094-7e13261858b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5371490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 256,
        "selector": "L256-L269",
        "symbol": "BitAggregate.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "990f431d-bd54-4588-a7f0-b1221e112757",
  "subject_name": "django/db/models/aggregates::BitAggregate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
