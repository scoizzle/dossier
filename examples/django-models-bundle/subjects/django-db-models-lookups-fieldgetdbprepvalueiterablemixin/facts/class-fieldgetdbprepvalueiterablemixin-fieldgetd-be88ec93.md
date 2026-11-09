# Fact be88ec93

Store id: 344246ab-2e2b-45f5-9a00-9adece53b83d

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
- posted_at: `2026-11-09T23:44:54.9351510+00:00`

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
  "id": "344246ab-2e2b-45f5-9a00-9adece53b83d",
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
    "posted_at": "2026-11-09T23:44:54.9351510+00:00"
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
  "subject_id": "161e7479-2398-4302-b687-b75d15643ab8",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueIterableMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldGetDbPrepValueIterableMixin(FieldGetDbPrepValueMixin)"
}
```
