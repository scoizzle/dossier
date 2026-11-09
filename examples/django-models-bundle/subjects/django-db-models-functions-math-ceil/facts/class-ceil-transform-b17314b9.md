# Fact b17314b9

Store id: 03f05c4e-94c0-47af-aa4d-d6dfd025ccae

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
- posted_at: `2026-11-09T22:39:46.5794090+00:00`

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
  "id": "03f05c4e-94c0-47af-aa4d-d6dfd025ccae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5794090+00:00"
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
  "subject_id": "8d295589-5078-4597-a5c2-244a511df5cc",
  "subject_name": "django/db/models/functions/math::Ceil",
  "tags": [
    "entity:class"
  ],
  "text": "class Ceil(Transform)"
}
```
