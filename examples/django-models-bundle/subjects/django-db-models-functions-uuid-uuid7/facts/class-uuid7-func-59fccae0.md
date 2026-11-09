# Fact 59fccae0

Store id: 7308ec95-2318-483a-b188-4e8cc0d81703

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
- posted_at: `2026-11-09T22:39:47.3763940+00:00`

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
  "id": "7308ec95-2318-483a-b188-4e8cc0d81703",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3763940+00:00"
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
  "subject_id": "bd69de79-bec4-491f-8af5-0b132898c448",
  "subject_name": "django/db/models/functions/uuid::UUID7",
  "tags": [
    "entity:class"
  ],
  "text": "class UUID7(Func)"
}
```
