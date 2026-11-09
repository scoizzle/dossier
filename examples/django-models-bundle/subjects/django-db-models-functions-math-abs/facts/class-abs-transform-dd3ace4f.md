# Fact dd3ace4f

Store id: b2a8716b-860b-47fe-84d8-3eca059816e8

## Text

```text
class Abs(Transform)
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
- posted_at: `2026-11-09T22:39:46.5526210+00:00`

## Data

```json
{
  "end_line": 15,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 13,
  "symbol": "Abs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L15","symbol":"Abs"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Abs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 15,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 13,
    "symbol": "Abs"
  },
  "id": "b2a8716b-860b-47fe-84d8-3eca059816e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5526210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L15",
        "symbol": "Abs"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "5ffb700b-449f-4cf9-9df3-4052223d37b7",
  "subject_name": "django/db/models/functions/math::Abs",
  "tags": [
    "entity:class"
  ],
  "text": "class Abs(Transform)"
}
```
