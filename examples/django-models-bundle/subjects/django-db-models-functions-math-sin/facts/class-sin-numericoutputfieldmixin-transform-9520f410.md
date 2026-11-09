# Fact 9520f410

Store id: 169854c0-c7ed-4405-b26c-fb4beb74638a

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
- posted_at: `2026-11-09T22:39:46.6819610+00:00`

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
  "id": "169854c0-c7ed-4405-b26c-fb4beb74638a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6819610+00:00"
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
  "subject_id": "82a46dee-2a80-46cf-9abd-9709e610f96a",
  "subject_name": "django/db/models/functions/math::Sin",
  "tags": [
    "entity:class"
  ],
  "text": "class Sin(NumericOutputFieldMixin, Transform)"
}
```
