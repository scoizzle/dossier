# Fact b9236290

Store id: 9bf8d0b8-eeda-4e48-922e-36a2388a2b1e

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
- posted_at: `2026-11-09T23:44:54.2925460+00:00`

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
  "id": "9bf8d0b8-eeda-4e48-922e-36a2388a2b1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.2925460+00:00"
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
  "subject_id": "bbbcf9e1-66b8-4ce2-8526-0b0ff3f937aa",
  "subject_name": "django/db/models/functions/uuid::UUID4",
  "tags": [
    "entity:class"
  ],
  "text": "class UUID4(Func)"
}
```
