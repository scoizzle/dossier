# Fact fac32472

Store id: 43af7deb-226a-4159-ad73-846f25897fdc

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
- posted_at: `2026-11-09T23:44:53.7461030+00:00`

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
  "id": "43af7deb-226a-4159-ad73-846f25897fdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7461030+00:00"
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
  "subject_id": "872cf0b8-483e-43e0-83ba-bf8056721935",
  "subject_name": "django/db/models/functions/math::Radians",
  "tags": [
    "entity:class"
  ],
  "text": "class Radians(NumericOutputFieldMixin, Transform)"
}
```
