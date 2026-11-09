# Fact a6feb90e

Store id: b5aa7fab-e997-4b95-9a23-76d036f280a5

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:49.9914650+00:00`

## Data

```json
{
  "end_line": 704,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 605,
  "symbol": "Field.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":605,"selector":"L605-L704","symbol":"Field.deconstruct"}`

## Items

```json
[
  {
    "text": "Return enough information to recreate the field as a 4-tuple:",
    "locator": {
      "line": 606
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 704,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 605,
    "symbol": "Field.deconstruct"
  },
  "id": "b5aa7fab-e997-4b95-9a23-76d036f280a5",
  "items": [
    {
      "locator": {
        "line": 606
      },
      "text": "Return enough information to recreate the field as a 4-tuple:"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9914650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 605,
        "selector": "L605-L704",
        "symbol": "Field.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fbca7035-374f-4fcb-89cf-877f840830b2",
  "subject_name": "django/db/models/fields/__init__::Field.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
