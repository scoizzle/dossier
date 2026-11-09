# Fact d6d95f92

Store id: c58e7e4f-8c15-4275-82c9-ed5693b96f7e

## Text

```text
class TimezoneMixin
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
- posted_at: `2026-11-09T23:44:53.3053270+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 22,
  "symbol": "TimezoneMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"selector":"L22-L36","symbol":"TimezoneMixin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TimezoneMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 22,
    "symbol": "TimezoneMixin"
  },
  "id": "c58e7e4f-8c15-4275-82c9-ed5693b96f7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3053270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 22,
        "selector": "L22-L36",
        "symbol": "TimezoneMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "18d9990f-ee6e-46a1-9c4f-2f780d10ff1d",
  "subject_name": "django/db/models/functions/datetime::TimezoneMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class TimezoneMixin"
}
```
