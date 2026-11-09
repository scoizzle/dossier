# Fact 212d241b

Store id: f98d27de-3a94-4716-8523-935268102787

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
- posted_at: `2026-11-09T23:44:49.2517670+00:00`

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
  "id": "f98d27de-3a94-4716-8523-935268102787",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2517670+00:00"
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
  "subject_id": "f9e5169a-24f4-4a88-a35e-33a5cc601a6c",
  "subject_name": "django/db/models/expressions::Combinable.__radd__",
  "tags": [
    "entity:method"
  ],
  "text": "def __radd__(self, other)"
}
```
