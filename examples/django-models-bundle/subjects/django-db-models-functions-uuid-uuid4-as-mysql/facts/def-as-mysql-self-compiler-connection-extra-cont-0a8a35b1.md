# Fact 0a8a35b1

Store id: b912e3d4-dbfd-4ab6-aba7-939062368fa6

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
- posted_at: `2026-11-09T23:32:02.4881200+00:00`

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
  "id": "b912e3d4-dbfd-4ab6-aba7-939062368fa6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.4881200+00:00"
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
  "subject_id": "026257f7-2824-46af-aa3a-581f4f324792",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
