# Fact 34758cf1

Store id: 73803208-508b-40d1-a3af-4489fb937ae6

## Text

```text
class Floor(Transform)
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
- posted_at: `2026-11-09T23:32:01.7113220+00:00`

## Data

```json
{
  "end_line": 104,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 102,
  "symbol": "Floor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":102,"selector":"L102-L104","symbol":"Floor"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Floor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 104,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 102,
    "symbol": "Floor"
  },
  "id": "73803208-508b-40d1-a3af-4489fb937ae6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7113220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 102,
        "selector": "L102-L104",
        "symbol": "Floor"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "40e5f6f8-1bad-426e-8896-138e0461b00e",
  "subject_name": "django/db/models/functions/math::Floor",
  "tags": [
    "entity:class"
  ],
  "text": "class Floor(Transform)"
}
```
