# Fact 3ad7c4be

Store id: d8f0624f-baec-4424-a6b9-bef64a53adb0

## Text

```text
class Avg(FixDurationInputMixin, NumericOutputFieldMixin, Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0401330+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 240,
  "symbol": "Avg"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":240,"selector":"L240-L244","symbol":"Avg"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Avg](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 240,
    "symbol": "Avg"
  },
  "id": "d8f0624f-baec-4424-a6b9-bef64a53adb0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0401330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 240,
        "selector": "L240-L244",
        "symbol": "Avg"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "7b9df69e-a931-4cf5-9501-c776fbbfbf64",
  "subject_name": "django/db/models/aggregates::Avg",
  "tags": [
    "entity:class"
  ],
  "text": "class Avg(FixDurationInputMixin, NumericOutputFieldMixin, Aggregate)"
}
```
