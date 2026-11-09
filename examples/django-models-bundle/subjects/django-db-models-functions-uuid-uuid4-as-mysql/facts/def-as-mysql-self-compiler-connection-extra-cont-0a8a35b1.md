# Fact 0a8a35b1

Store id: e67cc338-c9e7-453e-b9d2-e9410315bb14

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.3707870+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "method",
  "parent": "UUID4",
  "start_line": 23,
  "symbol": "UUID4.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"selector":"L23-L28","symbol":"UUID4.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID4.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "method",
    "parent": "UUID4",
    "start_line": 23,
    "symbol": "UUID4.as_mysql"
  },
  "id": "e67cc338-c9e7-453e-b9d2-e9410315bb14",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3707870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 23,
        "selector": "L23-L28",
        "symbol": "UUID4.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "63fe5232-bd67-411e-b09b-028926987d70",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
