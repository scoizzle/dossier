# Fact 3ad7c4be

Store id: 338c6b77-387f-4640-b6c5-12d382342c48

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
- posted_at: `2026-11-09T23:44:48.3983680+00:00`

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
  "id": "338c6b77-387f-4640-b6c5-12d382342c48",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3983680+00:00"
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
  "subject_id": "2e018115-a358-4f5f-a328-3b6599a7fdf6",
  "subject_name": "django/db/models/aggregates::Avg",
  "tags": [
    "entity:class"
  ],
  "text": "class Avg(FixDurationInputMixin, NumericOutputFieldMixin, Aggregate)"
}
```
