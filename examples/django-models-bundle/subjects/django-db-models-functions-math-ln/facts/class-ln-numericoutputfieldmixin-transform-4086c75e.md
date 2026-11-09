# Fact 4086c75e

Store id: 829d67fe-4802-4ed0-8ebf-602cccebdff6

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
- posted_at: `2026-11-09T23:32:01.7138110+00:00`

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
  "id": "829d67fe-4802-4ed0-8ebf-602cccebdff6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7138110+00:00"
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
  "subject_id": "f77e8244-80f2-40bb-b445-0032159a24bc",
  "subject_name": "django/db/models/functions/math::Ln",
  "tags": [
    "entity:class"
  ],
  "text": "class Ln(NumericOutputFieldMixin, Transform)"
}
```
