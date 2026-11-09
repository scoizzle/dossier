# Fact 40e740c7

Store id: d86d1354-c508-40a3-b7e8-0a95249611bd

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
- posted_at: `2026-11-09T23:32:01.7173820+00:00`

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
  "id": "d86d1354-c508-40a3-b7e8-0a95249611bd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7173820+00:00"
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
  "subject_id": "7d7192c6-7f0a-4149-812a-6eaa8527001d",
  "subject_name": "django/db/models/functions/math::Log",
  "tags": [
    "entity:class"
  ],
  "text": "class Log(FixDecimalInputMixin, NumericOutputFieldMixin, Func)"
}
```
