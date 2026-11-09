# Fact e2af852c

Store id: f35132d6-6587-49f1-ab8f-b1a1ee50acba

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
- posted_at: `2026-11-09T23:32:05.3600280+00:00`

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
  "id": "f35132d6-6587-49f1-ab8f-b1a1ee50acba",
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
    "posted_at": "2026-11-09T23:32:05.3600280+00:00"
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
  "subject_id": "098fa414-9903-4fee-9dff-d89f5f7dc39f",
  "subject_name": "django/db/models/signals::ModelSignal",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelSignal(Signal)"
}
```
