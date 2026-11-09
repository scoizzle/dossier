# Fact ed3b23d2

Store id: 7c80c31b-ce2c-47f9-8af4-e2cab4050021

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
- posted_at: `2026-11-09T23:32:02.6868190+00:00`

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
  "id": "7c80c31b-ce2c-47f9-8af4-e2cab4050021",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.6868190+00:00"
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
  "subject_id": "46ea1e93-3a38-4e4f-9232-83bbbe933c3e",
  "subject_name": "django/db/models/functions/window::LagLeadFunction",
  "tags": [
    "entity:class"
  ],
  "text": "class LagLeadFunction(Func)"
}
```
