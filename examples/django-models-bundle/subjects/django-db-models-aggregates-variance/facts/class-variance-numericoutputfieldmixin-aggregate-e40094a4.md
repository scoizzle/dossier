# Fact e40094a4

Store id: 22003b1d-5fd6-4c47-b949-5252db35fbbd

## Text

```text
class Variance(NumericOutputFieldMixin, Aggregate)
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
- posted_at: `2026-11-09T23:44:48.4066120+00:00`

## Data

```json
{
  "end_line": 468,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 459,
  "symbol": "Variance"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":459,"selector":"L459-L468","symbol":"Variance"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Variance](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 468,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 459,
    "symbol": "Variance"
  },
  "id": "22003b1d-5fd6-4c47-b949-5252db35fbbd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4066120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 459,
        "selector": "L459-L468",
        "symbol": "Variance"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "8ed729f4-8e86-46fe-8ae6-d849ffc68bf5",
  "subject_name": "django/db/models/aggregates::Variance",
  "tags": [
    "entity:class"
  ],
  "text": "class Variance(NumericOutputFieldMixin, Aggregate)"
}
```
