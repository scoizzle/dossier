# Fact b288ad25

Store id: 3ecc7546-90f3-489b-b507-a2acb7b0ed44

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
- posted_at: `2026-11-09T23:32:03.2209290+00:00`

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
  "id": "3ecc7546-90f3-489b-b507-a2acb7b0ed44",
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
    "posted_at": "2026-11-09T23:32:03.2209290+00:00"
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
  "subject_id": "360259b2-315e-405c-800f-8da910cb259d",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldGetDbPrepValueMixin"
}
```
