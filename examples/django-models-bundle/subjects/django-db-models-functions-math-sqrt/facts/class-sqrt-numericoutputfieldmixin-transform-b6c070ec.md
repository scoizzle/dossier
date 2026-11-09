# Fact b6c070ec

Store id: 016cd64d-3b96-4681-bb8e-faad3d7ca655

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
- posted_at: `2026-11-09T23:44:53.7741020+00:00`

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
  "id": "016cd64d-3b96-4681-bb8e-faad3d7ca655",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7741020+00:00"
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
  "subject_id": "82509de4-0361-49c1-9d00-6313dbce4f20",
  "subject_name": "django/db/models/functions/math::Sqrt",
  "tags": [
    "entity:class"
  ],
  "text": "class Sqrt(NumericOutputFieldMixin, Transform)"
}
```
