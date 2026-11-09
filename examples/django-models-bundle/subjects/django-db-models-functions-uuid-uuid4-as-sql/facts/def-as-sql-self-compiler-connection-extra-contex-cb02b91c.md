# Fact cb02b91c

Store id: ddcb87be-3c4f-4265-8095-0077e74824a8

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
- posted_at: `2026-11-09T22:39:47.3646990+00:00`

## Data

```json
{
  "end_line": 14,
  "entity_kind": "method",
  "parent": "UUID4",
  "start_line": 11,
  "symbol": "UUID4.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":11,"selector":"L11-L14","symbol":"UUID4.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID4.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 14,
    "entity_kind": "method",
    "parent": "UUID4",
    "start_line": 11,
    "symbol": "UUID4.as_sql"
  },
  "id": "ddcb87be-3c4f-4265-8095-0077e74824a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3646990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 11,
        "selector": "L11-L14",
        "symbol": "UUID4.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "70ffd550-f07b-492f-adba-4fe7cedcae5f",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
