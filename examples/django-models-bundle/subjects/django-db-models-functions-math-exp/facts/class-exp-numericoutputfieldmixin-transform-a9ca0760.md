# Fact a9ca0760

Store id: 67ef0a81-29e2-405b-9fe7-6a9e55bd09d8

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
- posted_at: `2026-11-09T23:44:53.7254580+00:00`

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
  "id": "67ef0a81-29e2-405b-9fe7-6a9e55bd09d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7254580+00:00"
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
  "subject_id": "4408d07c-815e-43b1-a300-195708ef12c1",
  "subject_name": "django/db/models/functions/math::Exp",
  "tags": [
    "entity:class"
  ],
  "text": "class Exp(NumericOutputFieldMixin, Transform)"
}
```
