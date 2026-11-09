# Fact b66c104c

Store id: c1b4cb2a-e9b5-4b70-a075-16e99d1d0d94

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
- posted_at: `2026-11-09T22:39:47.4051860+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 87,
  "symbol": "UUID7.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":87,"selector":"L87-L94","symbol":"UUID7.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 87,
    "symbol": "UUID7.as_mysql"
  },
  "id": "c1b4cb2a-e9b5-4b70-a075-16e99d1d0d94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.4051860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 87,
        "selector": "L87-L94",
        "symbol": "UUID7.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "a556455a-14c8-4bc6-959e-c09141ae0325",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
