# Fact b288ad25

Store id: 9e4b5677-1de4-43f1-87c8-ff563a628d5b

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
- posted_at: `2026-11-09T22:39:48.0727050+00:00`

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
  "id": "9e4b5677-1de4-43f1-87c8-ff563a628d5b",
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
    "posted_at": "2026-11-09T22:39:48.0727050+00:00"
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
  "subject_id": "99f0f998-527d-49fc-a1d0-7ad2429b4f80",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldGetDbPrepValueMixin"
}
```
