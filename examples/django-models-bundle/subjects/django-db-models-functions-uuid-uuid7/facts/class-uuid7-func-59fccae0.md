# Fact 59fccae0

Store id: 8aead6fb-04f0-4f11-b03b-3e63487474ba

## Text

```text
class UUID7(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.3188970+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "class",
  "parent": "uuid",
  "start_line": 47,
  "symbol": "UUID7"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"selector":"L47-L94","symbol":"UUID7"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "class",
    "parent": "uuid",
    "start_line": 47,
    "symbol": "UUID7"
  },
  "id": "8aead6fb-04f0-4f11-b03b-3e63487474ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3188970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 47,
        "selector": "L47-L94",
        "symbol": "UUID7"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "b8f22c93-72fb-4387-b82c-cf8e843bddd0",
  "subject_name": "django/db/models/functions/uuid::UUID7",
  "tags": [
    "entity:class"
  ],
  "text": "class UUID7(Func)"
}
```
