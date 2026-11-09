# Fact fac32472

Store id: 56342547-b1b1-4531-b0d1-4979fdb40255

## Text

```text
class Radians(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6441260+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 146,
  "symbol": "Radians"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":146,"selector":"L146-L156","symbol":"Radians"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Radians](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 146,
    "symbol": "Radians"
  },
  "id": "56342547-b1b1-4531-b0d1-4979fdb40255",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6441260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 146,
        "selector": "L146-L156",
        "symbol": "Radians"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "d53dd09b-5422-4062-8d20-ff2c86ea52ea",
  "subject_name": "django/db/models/functions/math::Radians",
  "tags": [
    "entity:class"
  ],
  "text": "class Radians(NumericOutputFieldMixin, Transform)"
}
```
