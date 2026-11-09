# Fact 212d241b

Store id: 8e1c262e-0456-49ee-ba9e-a931cf4f256e

## Text

```text
def __radd__(self, other)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.7422790+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 133,
  "symbol": "Combinable.__radd__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":133,"selector":"L133-L134","symbol":"Combinable.__radd__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__radd__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 133,
    "symbol": "Combinable.__radd__"
  },
  "id": "8e1c262e-0456-49ee-ba9e-a931cf4f256e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7422790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 133,
        "selector": "L133-L134",
        "symbol": "Combinable.__radd__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fb4571f7-3588-4bba-9cf5-8b5122e59d32",
  "subject_name": "django/db/models/expressions::Combinable.__radd__",
  "tags": [
    "entity:method"
  ],
  "text": "def __radd__(self, other)"
}
```
