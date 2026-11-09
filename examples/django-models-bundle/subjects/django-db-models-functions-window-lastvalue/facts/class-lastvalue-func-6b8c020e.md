# Fact 6b8c020e

Store id: e75fc248-7aca-4f31-b6ce-326d49324196

## Text

```text
class LastValue(Func)
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
- posted_at: `2026-11-09T22:39:47.5694890+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 64,
  "symbol": "LastValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L67","symbol":"LastValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::LastValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 64,
    "symbol": "LastValue"
  },
  "id": "e75fc248-7aca-4f31-b6ce-326d49324196",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5694890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L67",
        "symbol": "LastValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "db508156-0108-405c-a1c1-de8cf235225a",
  "subject_name": "django/db/models/functions/window::LastValue",
  "tags": [
    "entity:class"
  ],
  "text": "class LastValue(Func)"
}
```
