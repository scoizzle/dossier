# Fact e2af852c

Store id: 3ce5e751-bca1-4514-9aec-fcd498cd7b2d

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
- posted_at: `2026-11-09T23:44:56.9381520+00:00`

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
  "id": "3ce5e751-bca1-4514-9aec-fcd498cd7b2d",
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
    "posted_at": "2026-11-09T23:44:56.9381520+00:00"
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
  "subject_id": "4fba7b1c-df3e-4059-99f0-fbed132b2bc7",
  "subject_name": "django/db/models/signals::ModelSignal",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelSignal(Signal)"
}
```
