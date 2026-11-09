# Fact b0e61ccd

Store id: c1540e3d-378d-4f20-9b86-6423ac61a2ae

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
- posted_at: `2026-11-09T23:31:55.4540490+00:00`

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
  "id": "c1540e3d-378d-4f20-9b86-6423ac61a2ae",
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
    "posted_at": "2026-11-09T23:31:55.4540490+00:00"
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
  "subject_id": "ed5d4360-159a-42e4-bb21-457482721b5f",
  "subject_name": "django/db/models/enums::ChoicesType",
  "tags": [
    "entity:class"
  ],
  "text": "class ChoicesType(EnumType)"
}
```
