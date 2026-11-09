# Fact f67c8a54

Store id: f552ffa3-2d4a-478b-9b70-1f7f7dc9788d

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
- posted_at: `2026-11-09T23:31:55.5048710+00:00`

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
  "id": "f552ffa3-2d4a-478b-9b70-1f7f7dc9788d",
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
    "posted_at": "2026-11-09T23:31:55.5048710+00:00"
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
  "subject_id": "f45dcf14-e511-436e-add4-d9dfcfe57f0f",
  "subject_name": "django/db/models/enums::Choices",
  "tags": [
    "entity:class"
  ],
  "text": "class Choices(enum.Enum, metaclass=ChoicesType)"
}
```
