# Fact b288ad25

Store id: c156cdc3-63b4-4810-bea7-1649728c5bcb

## Text

```text
class FieldGetDbPrepValueMixin
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
- posted_at: `2026-11-09T23:44:54.9304400+00:00`

## Data

```json
{
  "end_line": 282,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 254,
  "symbol": "FieldGetDbPrepValueMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":254,"selector":"L254-L282","symbol":"FieldGetDbPrepValueMixin"}`

## Items

```json
[
  {
    "text": "Some lookups require Field.get_db_prep_value() to be called on their inputs.",
    "locator": {
      "line": 255
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 282,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 254,
    "symbol": "FieldGetDbPrepValueMixin"
  },
  "id": "c156cdc3-63b4-4810-bea7-1649728c5bcb",
  "items": [
    {
      "locator": {
        "line": 255
      },
      "text": "Some lookups require Field.get_db_prep_value() to be called on their inputs."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9304400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 254,
        "selector": "L254-L282",
        "symbol": "FieldGetDbPrepValueMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "431328d0-1276-4e33-9dbb-d021654c75d8",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldGetDbPrepValueMixin"
}
```
