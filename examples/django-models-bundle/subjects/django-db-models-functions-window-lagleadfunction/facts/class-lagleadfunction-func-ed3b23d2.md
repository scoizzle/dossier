# Fact ed3b23d2

Store id: 49a13b0e-bb45-4c02-9136-ac949e604c63

## Text

```text
class LagLeadFunction(Func)
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
- posted_at: `2026-11-09T22:39:47.5584440+00:00`

## Data

```json
{
  "end_line": 57,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 37,
  "symbol": "LagLeadFunction"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"selector":"L37-L57","symbol":"LagLeadFunction"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::LagLeadFunction](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 57,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 37,
    "symbol": "LagLeadFunction"
  },
  "id": "49a13b0e-bb45-4c02-9136-ac949e604c63",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5584440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 37,
        "selector": "L37-L57",
        "symbol": "LagLeadFunction"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "d69a6333-2b1d-4451-aa7a-db2fe71492f4",
  "subject_name": "django/db/models/functions/window::LagLeadFunction",
  "tags": [
    "entity:class"
  ],
  "text": "class LagLeadFunction(Func)"
}
```
