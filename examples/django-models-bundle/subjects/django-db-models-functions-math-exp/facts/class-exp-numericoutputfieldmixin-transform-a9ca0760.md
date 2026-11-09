# Fact a9ca0760

Store id: 2b834fe2-335a-436e-9ac2-7b76da4fe709

## Text

```text
class Exp(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6138370+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 97,
  "symbol": "Exp"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L99","symbol":"Exp"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Exp](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 97,
    "symbol": "Exp"
  },
  "id": "2b834fe2-335a-436e-9ac2-7b76da4fe709",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6138370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L99",
        "symbol": "Exp"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "6e0ed2e3-4fd3-4d4d-bee0-bfede2d53061",
  "subject_name": "django/db/models/functions/math::Exp",
  "tags": [
    "entity:class"
  ],
  "text": "class Exp(NumericOutputFieldMixin, Transform)"
}
```
