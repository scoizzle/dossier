# Fact f0d4c0cf

Store id: 75fa51a4-554e-457a-bbdd-657f7e2dae87

## Text

```text
def __rpow__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2570900+00:00`

## Data

```json
{
  "end_line": 149,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 148,
  "symbol": "Combinable.__rpow__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L149","symbol":"Combinable.__rpow__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rpow__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 149,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 148,
    "symbol": "Combinable.__rpow__"
  },
  "id": "75fa51a4-554e-457a-bbdd-657f7e2dae87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2570900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L149",
        "symbol": "Combinable.__rpow__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "04c7b16c-e2e6-4b90-a81d-594d1de9dc84",
  "subject_name": "django/db/models/expressions::Combinable.__rpow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rpow__(self, other)"
}
```
