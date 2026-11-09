# Fact 596d1567

Store id: b33f8bf1-e58b-4431-a234-840f70eb41e3

## Text

```text
class Pi(NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T22:39:46.6332320+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 131,
  "symbol": "Pi"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L138","symbol":"Pi"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Pi](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 131,
    "symbol": "Pi"
  },
  "id": "b33f8bf1-e58b-4431-a234-840f70eb41e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6332320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L138",
        "symbol": "Pi"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "9e81c826-3c37-44e1-b01c-c63875a2579b",
  "subject_name": "django/db/models/functions/math::Pi",
  "tags": [
    "entity:class"
  ],
  "text": "class Pi(NumericOutputFieldMixin, Func)"
}
```
