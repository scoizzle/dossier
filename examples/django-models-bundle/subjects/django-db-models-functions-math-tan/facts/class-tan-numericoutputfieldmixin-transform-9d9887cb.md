# Fact 9d9887cb

Store id: 97cb50b8-87a4-4a87-8ae3-158c05b85dba

## Text

```text
class Tan(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6873990+00:00`

## Data

```json
{
  "end_line": 214,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 212,
  "symbol": "Tan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L214","symbol":"Tan"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Tan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 214,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 212,
    "symbol": "Tan"
  },
  "id": "97cb50b8-87a4-4a87-8ae3-158c05b85dba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6873990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L214",
        "symbol": "Tan"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "15b669d4-897d-4b73-ab7e-711fbed7ca98",
  "subject_name": "django/db/models/functions/math::Tan",
  "tags": [
    "entity:class"
  ],
  "text": "class Tan(NumericOutputFieldMixin, Transform)"
}
```
