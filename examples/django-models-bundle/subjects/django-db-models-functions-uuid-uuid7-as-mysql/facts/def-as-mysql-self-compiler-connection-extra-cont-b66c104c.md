# Fact b66c104c

Store id: d0b1eedb-0980-4134-8d37-2dab0049d447

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
- posted_at: `2026-11-09T23:44:54.3448120+00:00`

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
  "id": "d0b1eedb-0980-4134-8d37-2dab0049d447",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3448120+00:00"
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
  "subject_id": "ba0a5abc-3362-4814-85f7-16a41b789b67",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
