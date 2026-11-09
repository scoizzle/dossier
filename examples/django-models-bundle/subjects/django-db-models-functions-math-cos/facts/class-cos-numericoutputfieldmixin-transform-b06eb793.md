# Fact b06eb793

Store id: a8879590-6ace-415f-a87f-94802689c2a2

## Text

```text
class Cos(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.5883330+00:00`

## Data

```json
{
  "end_line": 71,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 69,
  "symbol": "Cos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L71","symbol":"Cos"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Cos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 71,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 69,
    "symbol": "Cos"
  },
  "id": "a8879590-6ace-415f-a87f-94802689c2a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5883330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L71",
        "symbol": "Cos"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "553667e1-95e2-460a-b70e-10e0f2255e57",
  "subject_name": "django/db/models/functions/math::Cos",
  "tags": [
    "entity:class"
  ],
  "text": "class Cos(NumericOutputFieldMixin, Transform)"
}
```
