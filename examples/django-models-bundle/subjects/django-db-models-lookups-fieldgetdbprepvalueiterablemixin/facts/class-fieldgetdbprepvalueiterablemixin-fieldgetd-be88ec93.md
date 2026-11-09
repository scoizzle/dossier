# Fact be88ec93

Store id: bb9b6362-3847-45ff-8527-2580ebe93308

## Text

```text
class FieldGetDbPrepValueIterableMixin(FieldGetDbPrepValueMixin)
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
- posted_at: `2026-11-09T22:39:48.0788060+00:00`

## Data

```json
{
  "end_line": 357,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 285,
  "symbol": "FieldGetDbPrepValueIterableMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":285,"selector":"L285-L357","symbol":"FieldGetDbPrepValueIterableMixin"}`

## Items

```json
[
  {
    "text": "Some lookups require Field.get_db_prep_value() to be called on each value in an iterable.",
    "locator": {
      "line": 286
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueIterableMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 357,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 285,
    "symbol": "FieldGetDbPrepValueIterableMixin"
  },
  "id": "bb9b6362-3847-45ff-8527-2580ebe93308",
  "items": [
    {
      "locator": {
        "line": 286
      },
      "text": "Some lookups require Field.get_db_prep_value() to be called on each value in an iterable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0788060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 285,
        "selector": "L285-L357",
        "symbol": "FieldGetDbPrepValueIterableMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3f93c8a1-0899-45c4-838b-1cb36d1fe39b",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueIterableMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldGetDbPrepValueIterableMixin(FieldGetDbPrepValueMixin)"
}
```
