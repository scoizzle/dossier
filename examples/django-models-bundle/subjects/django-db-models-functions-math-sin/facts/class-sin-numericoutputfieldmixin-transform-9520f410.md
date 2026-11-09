# Fact 9520f410

Store id: 7e0ba678-df24-4b10-935a-4656a2c1ce4b

## Text

```text
class Sin(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:32:01.7727680+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 202,
  "symbol": "Sin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":202,"selector":"L202-L204","symbol":"Sin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Sin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 202,
    "symbol": "Sin"
  },
  "id": "7e0ba678-df24-4b10-935a-4656a2c1ce4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7727680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 202,
        "selector": "L202-L204",
        "symbol": "Sin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "cd667c30-404d-4691-a67f-284e4c3a5b6d",
  "subject_name": "django/db/models/functions/math::Sin",
  "tags": [
    "entity:class"
  ],
  "text": "class Sin(NumericOutputFieldMixin, Transform)"
}
```
