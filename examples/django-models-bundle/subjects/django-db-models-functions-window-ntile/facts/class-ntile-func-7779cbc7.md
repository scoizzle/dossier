# Fact 7779cbc7

Store id: 9f69360f-5c65-4e16-924a-eb1f25f41924

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
- posted_at: `2026-11-09T23:32:02.7250770+00:00`

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
  "id": "9f69360f-5c65-4e16-924a-eb1f25f41924",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.7250770+00:00"
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
  "subject_id": "774184e5-0ada-48df-b112-4a0787803dac",
  "subject_name": "django/db/models/functions/window::Ntile",
  "tags": [
    "entity:class"
  ],
  "text": "class Ntile(Func)"
}
```
