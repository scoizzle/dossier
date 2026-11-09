# Fact 4086c75e

Store id: 855af2af-ed2b-47b5-8860-0b80df8adf19

## Text

```text
class Ln(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6194360+00:00`

## Data

```json
{
  "end_line": 109,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 107,
  "symbol": "Ln"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L109","symbol":"Ln"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Ln](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 109,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 107,
    "symbol": "Ln"
  },
  "id": "855af2af-ed2b-47b5-8860-0b80df8adf19",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6194360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L109",
        "symbol": "Ln"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "04d93e38-b387-4bf9-ae1d-bad5fd02448b",
  "subject_name": "django/db/models/functions/math::Ln",
  "tags": [
    "entity:class"
  ],
  "text": "class Ln(NumericOutputFieldMixin, Transform)"
}
```
