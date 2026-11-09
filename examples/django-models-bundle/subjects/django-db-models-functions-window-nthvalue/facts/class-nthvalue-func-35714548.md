# Fact 35714548

Store id: 32d0c6a8-6e12-41e2-a295-fcdf7288f0ff

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
- posted_at: `2026-11-09T23:44:54.4913090+00:00`

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
  "id": "32d0c6a8-6e12-41e2-a295-fcdf7288f0ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4913090+00:00"
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
  "subject_id": "a70a0f59-5c39-41d1-a823-93028083ca76",
  "subject_name": "django/db/models/functions/window::NthValue",
  "tags": [
    "entity:class"
  ],
  "text": "class NthValue(Func)"
}
```
