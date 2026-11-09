# Fact aac12cac

Store id: 6f258e24-d201-4313-b183-8ff6d8494a2c

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
- posted_at: `2026-11-09T23:44:54.3284360+00:00`

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
  "id": "6f258e24-d201-4313-b183-8ff6d8494a2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3284360+00:00"
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
  "subject_id": "f7a4b962-f712-4b49-af65-d4a791bd92c1",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
