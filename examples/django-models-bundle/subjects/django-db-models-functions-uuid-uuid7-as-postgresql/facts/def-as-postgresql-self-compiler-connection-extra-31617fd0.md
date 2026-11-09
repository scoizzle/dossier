# Fact 31617fd0

Store id: 6767c6b6-2c1b-47e0-ba8b-9aa44817882d

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
- posted_at: `2026-11-09T23:44:54.3401160+00:00`

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
  "id": "6767c6b6-2c1b-47e0-ba8b-9aa44817882d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3401160+00:00"
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
  "subject_id": "4e2379e1-f7bd-47f2-a8cc-6f27faa180fc",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
