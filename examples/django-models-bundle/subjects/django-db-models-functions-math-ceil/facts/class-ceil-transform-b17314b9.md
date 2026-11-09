# Fact b17314b9

Store id: c3b7194c-e10e-40e6-a4d6-bd22f809dadd

## Text

```text
class Ceil(Transform)
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
- posted_at: `2026-11-09T23:44:53.6989230+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 61,
  "symbol": "Ceil"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L66","symbol":"Ceil"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Ceil](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 61,
    "symbol": "Ceil"
  },
  "id": "c3b7194c-e10e-40e6-a4d6-bd22f809dadd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.6989230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L66",
        "symbol": "Ceil"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "416c9a23-b574-4662-a6ab-c987b9eca9eb",
  "subject_name": "django/db/models/functions/math::Ceil",
  "tags": [
    "entity:class"
  ],
  "text": "class Ceil(Transform)"
}
```
