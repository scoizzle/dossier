# Fact aac12cac

Store id: 1850ea67-5ad9-40dc-8b57-e648b1f2c150

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
- posted_at: `2026-11-09T22:39:47.3861840+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 60,
  "symbol": "UUID7.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L72","symbol":"UUID7.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 60,
    "symbol": "UUID7.as_sql"
  },
  "id": "1850ea67-5ad9-40dc-8b57-e648b1f2c150",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3861840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L72",
        "symbol": "UUID7.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "1a7e74d5-3303-4b0f-9f74-6459cf85e78c",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
