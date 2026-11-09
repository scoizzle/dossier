# Fact cb02b91c

Store id: 5f74d8a4-341f-403a-9012-d0cdb281257e

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
- posted_at: `2026-11-09T23:32:02.4814890+00:00`

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
  "id": "5f74d8a4-341f-403a-9012-d0cdb281257e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.4814890+00:00"
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
  "subject_id": "e72a0a52-2d56-4a29-8ef5-30ec585bd6c7",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
