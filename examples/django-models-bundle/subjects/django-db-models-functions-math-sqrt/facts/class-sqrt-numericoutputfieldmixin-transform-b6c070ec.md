# Fact b6c070ec

Store id: ba7eacc6-4c3a-4049-a95e-b570b5c9e39f

## Text

```text
class Sqrt(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:32:01.7760330+00:00`

## Data

```json
{
  "end_line": 209,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 207,
  "symbol": "Sqrt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L209","symbol":"Sqrt"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Sqrt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 209,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 207,
    "symbol": "Sqrt"
  },
  "id": "ba7eacc6-4c3a-4049-a95e-b570b5c9e39f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7760330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L209",
        "symbol": "Sqrt"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "47248188-936e-4721-a29b-1e88702e39c0",
  "subject_name": "django/db/models/functions/math::Sqrt",
  "tags": [
    "entity:class"
  ],
  "text": "class Sqrt(NumericOutputFieldMixin, Transform)"
}
```
