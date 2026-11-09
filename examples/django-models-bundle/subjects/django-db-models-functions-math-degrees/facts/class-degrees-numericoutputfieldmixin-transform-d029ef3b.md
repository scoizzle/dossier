# Fact d029ef3b

Store id: 21882c94-522e-4757-8e0e-10308588ccd8

## Text

```text
class Degrees(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:44:53.7208990+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 84,
  "symbol": "Degrees"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L94","symbol":"Degrees"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Degrees](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 84,
    "symbol": "Degrees"
  },
  "id": "21882c94-522e-4757-8e0e-10308588ccd8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7208990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L94",
        "symbol": "Degrees"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "067ce70d-2069-4d5d-84d3-bf30592e3b92",
  "subject_name": "django/db/models/functions/math::Degrees",
  "tags": [
    "entity:class"
  ],
  "text": "class Degrees(NumericOutputFieldMixin, Transform)"
}
```
