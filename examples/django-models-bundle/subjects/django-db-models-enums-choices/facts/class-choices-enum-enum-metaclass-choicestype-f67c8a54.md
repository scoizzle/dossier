# Fact f67c8a54

Store id: c100bf04-fbd1-4bf9-89d3-3d87abf34ba9

## Text

```text
class Choices(enum.Enum, metaclass=ChoicesType)
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
- posted_at: `2026-11-09T22:39:41.3042800+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "class",
  "parent": "enums",
  "start_line": 54,
  "symbol": "Choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L65","symbol":"Choices"}`

## Items

```json
[
  {
    "text": "Class for creating enumerated choices.",
    "locator": {
      "line": 55
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/enums::Choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "class",
    "parent": "enums",
    "start_line": 54,
    "symbol": "Choices"
  },
  "id": "c100bf04-fbd1-4bf9-89d3-3d87abf34ba9",
  "items": [
    {
      "locator": {
        "line": 55
      },
      "text": "Class for creating enumerated choices."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3042800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L65",
        "symbol": "Choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "5ccdedd8-e730-4775-8995-ce1f32e84b1a",
  "subject_name": "django/db/models/enums::Choices",
  "tags": [
    "entity:class"
  ],
  "text": "class Choices(enum.Enum, metaclass=ChoicesType)"
}
```
