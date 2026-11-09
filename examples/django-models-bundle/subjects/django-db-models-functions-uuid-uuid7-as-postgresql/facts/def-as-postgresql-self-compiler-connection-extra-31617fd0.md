# Fact 31617fd0

Store id: 22f7d240-41e2-456f-a20e-9928a150c33c

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.3987830+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 74,
  "symbol": "UUID7.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L77","symbol":"UUID7.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 74,
    "symbol": "UUID7.as_postgresql"
  },
  "id": "22f7d240-41e2-456f-a20e-9928a150c33c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3987830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L77",
        "symbol": "UUID7.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "5adb11f7-95de-44a4-9fe7-9f83e263c3dd",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
