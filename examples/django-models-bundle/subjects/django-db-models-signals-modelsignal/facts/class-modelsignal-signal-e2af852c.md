# Fact e2af852c

Store id: 26b49e22-b394-4a82-8e48-0c4e99693f59

## Text

```text
class ModelSignal(Signal)
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
- posted_at: `2026-11-09T22:39:50.3196420+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "class",
  "parent": "signals",
  "start_line": 9,
  "symbol": "ModelSignal"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/signals.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":9,"selector":"L9-L39","symbol":"ModelSignal"}`

## Items

```json
[
  {
    "text": "Signal subclass that allows the sender to be lazily specified as a string of the `app_label.ModelName` form.",
    "locator": {
      "line": 10
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/signals::ModelSignal](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "class",
    "parent": "signals",
    "start_line": 9,
    "symbol": "ModelSignal"
  },
  "id": "26b49e22-b394-4a82-8e48-0c4e99693f59",
  "items": [
    {
      "locator": {
        "line": 10
      },
      "text": "Signal subclass that allows the sender to be lazily specified as a string of the `app_label.ModelName` form."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.3196420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 9,
        "selector": "L9-L39",
        "symbol": "ModelSignal"
      },
      "rel": "derived_from",
      "target": "django/db/models/signals.py"
    }
  ],
  "status": "live",
  "subject_id": "27fda132-14d3-4adb-a78a-c710992669d6",
  "subject_name": "django/db/models/signals::ModelSignal",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelSignal(Signal)"
}
```
