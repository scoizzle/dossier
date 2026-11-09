# Fact 35714548

Store id: 2acea8f1-7b36-4f6d-96e5-cade192e4064

## Text

```text
class NthValue(Func)
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
- posted_at: `2026-11-09T22:39:47.5860880+00:00`

## Data

```json
{
  "end_line": 91,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 74,
  "symbol": "NthValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L91","symbol":"NthValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::NthValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 91,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 74,
    "symbol": "NthValue"
  },
  "id": "2acea8f1-7b36-4f6d-96e5-cade192e4064",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5860880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L91",
        "symbol": "NthValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "27988954-b01a-4134-8405-4d2f77312a42",
  "subject_name": "django/db/models/functions/window::NthValue",
  "tags": [
    "entity:class"
  ],
  "text": "class NthValue(Func)"
}
```
