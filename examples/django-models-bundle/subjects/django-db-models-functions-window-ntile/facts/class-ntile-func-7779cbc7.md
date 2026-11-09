# Fact 7779cbc7

Store id: 1e0a80c5-2ec0-457b-b494-ab4a6b6d0f1e

## Text

```text
class Ntile(Func)
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
- posted_at: `2026-11-09T23:44:54.4989940+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 94,
  "symbol": "Ntile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":94,"selector":"L94-L102","symbol":"Ntile"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Ntile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 94,
    "symbol": "Ntile"
  },
  "id": "1e0a80c5-2ec0-457b-b494-ab4a6b6d0f1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4989940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 94,
        "selector": "L94-L102",
        "symbol": "Ntile"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "7723333e-34e3-414d-a0e6-830fb7a676e1",
  "subject_name": "django/db/models/functions/window::Ntile",
  "tags": [
    "entity:class"
  ],
  "text": "class Ntile(Func)"
}
```
