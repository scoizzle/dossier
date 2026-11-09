# Fact b0e61ccd

Store id: a79c9530-bc90-4f90-abb4-e78ecf3ed3af

## Text

```text
class ChoicesType(EnumType)
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
- posted_at: `2026-11-09T22:39:41.2816180+00:00`

## Data

```json
{
  "end_line": 51,
  "entity_kind": "class",
  "parent": "enums",
  "start_line": 10,
  "symbol": "ChoicesType"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"selector":"L10-L51","symbol":"ChoicesType"}`

## Items

```json
[
  {
    "text": "A metaclass for creating a enum choices.",
    "locator": {
      "line": 11
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 51,
    "entity_kind": "class",
    "parent": "enums",
    "start_line": 10,
    "symbol": "ChoicesType"
  },
  "id": "a79c9530-bc90-4f90-abb4-e78ecf3ed3af",
  "items": [
    {
      "locator": {
        "line": 11
      },
      "text": "A metaclass for creating a enum choices."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.2816180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 10,
        "selector": "L10-L51",
        "symbol": "ChoicesType"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "d5af66d6-095d-4202-a8a6-4d250774a046",
  "subject_name": "django/db/models/enums::ChoicesType",
  "tags": [
    "entity:class"
  ],
  "text": "class ChoicesType(EnumType)"
}
```
