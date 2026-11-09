# Fact 40e740c7

Store id: c9150b41-09b0-475a-a2e5-70cf7f95f97b

## Text

```text
class Log(FixDecimalInputMixin, NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T22:39:46.6219720+00:00`

## Data

```json
{
  "end_line": 123,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 112,
  "symbol": "Log"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":112,"selector":"L112-L123","symbol":"Log"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Log](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 123,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 112,
    "symbol": "Log"
  },
  "id": "c9150b41-09b0-475a-a2e5-70cf7f95f97b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6219720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 112,
        "selector": "L112-L123",
        "symbol": "Log"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "69027647-a7fc-40b8-a51e-9fbaec2f6560",
  "subject_name": "django/db/models/functions/math::Log",
  "tags": [
    "entity:class"
  ],
  "text": "class Log(FixDecimalInputMixin, NumericOutputFieldMixin, Func)"
}
```
