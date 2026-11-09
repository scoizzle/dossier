# Fact a6feb90e

Store id: df7849bd-bc3f-44df-94e6-2b5ba569607c

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
- posted_at: `2026-11-09T23:31:56.4505930+00:00`

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
  "id": "df7849bd-bc3f-44df-94e6-2b5ba569607c",
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
    "posted_at": "2026-11-09T23:31:56.4505930+00:00"
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
  "subject_id": "cd738a47-1d98-49d0-8b01-bd2d0e580f26",
  "subject_name": "django/db/models/fields/__init__::Field.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
