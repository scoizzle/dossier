# Fact 9d26419a

Store id: fd92ce68-0d75-434d-9be9-29afd280ba09

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
- posted_at: `2026-11-09T23:44:48.3992240+00:00`

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
  "id": "fd92ce68-0d75-434d-9be9-29afd280ba09",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3992240+00:00"
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
  "subject_id": "655fcbb2-2c7f-43fb-b70c-5cc2887adfb8",
  "subject_name": "django/db/models/aggregates::BitAggregate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
