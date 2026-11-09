# Fact 7d8e0f53

Store id: 7d220e8a-c05c-4ed1-93b8-7a91dc15b19a

## Text

```text
class FirstValue(Func)
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
- posted_at: `2026-11-09T22:39:47.5550270+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 31,
  "symbol": "FirstValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"selector":"L31-L34","symbol":"FirstValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::FirstValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 31,
    "symbol": "FirstValue"
  },
  "id": "7d220e8a-c05c-4ed1-93b8-7a91dc15b19a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5550270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 31,
        "selector": "L31-L34",
        "symbol": "FirstValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "7a106a18-6079-4334-a61f-cb2478f40ebb",
  "subject_name": "django/db/models/functions/window::FirstValue",
  "tags": [
    "entity:class"
  ],
  "text": "class FirstValue(Func)"
}
```
