# Fact b9236290

Store id: 9f0e72a7-c82b-4190-a54d-b43b04e54392

## Text

```text
class UUID4(Func)
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
- posted_at: `2026-11-09T23:32:02.4672240+00:00`

## Data

```json
{
  "end_line": 44,
  "entity_kind": "class",
  "parent": "uuid",
  "start_line": 6,
  "symbol": "UUID4"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":6,"selector":"L6-L44","symbol":"UUID4"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID4](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 44,
    "entity_kind": "class",
    "parent": "uuid",
    "start_line": 6,
    "symbol": "UUID4"
  },
  "id": "9f0e72a7-c82b-4190-a54d-b43b04e54392",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.4672240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 6,
        "selector": "L6-L44",
        "symbol": "UUID4"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "15ab0e04-a1de-4c66-9774-35bd753b35cf",
  "subject_name": "django/db/models/functions/uuid::UUID4",
  "tags": [
    "entity:class"
  ],
  "text": "class UUID4(Func)"
}
```
