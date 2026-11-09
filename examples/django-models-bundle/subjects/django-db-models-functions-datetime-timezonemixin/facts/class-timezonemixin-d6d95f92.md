# Fact d6d95f92

Store id: 83252b49-130f-4239-b4b0-46c5c205ab39

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
- posted_at: `2026-11-09T23:32:01.1526280+00:00`

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
  "id": "83252b49-130f-4239-b4b0-46c5c205ab39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1526280+00:00"
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
  "subject_id": "d71f3cf0-be01-4075-837a-9e2b328a487b",
  "subject_name": "django/db/models/functions/datetime::TimezoneMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class TimezoneMixin"
}
```
