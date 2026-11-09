# Fact 6b8c020e

Store id: f8b7b539-0eed-428b-9643-69b43157ecb3

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
- posted_at: `2026-11-09T23:44:54.4758960+00:00`

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
  "id": "f8b7b539-0eed-428b-9643-69b43157ecb3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4758960+00:00"
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
  "subject_id": "f1e31042-d3ea-4e98-9be0-e32ba253f269",
  "subject_name": "django/db/models/functions/window::LastValue",
  "tags": [
    "entity:class"
  ],
  "text": "class LastValue(Func)"
}
```
