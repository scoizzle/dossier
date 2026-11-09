# Fact ed3b23d2

Store id: e4f9d886-306b-4c70-9907-4aa7304c2686

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
- posted_at: `2026-11-09T23:44:54.4660400+00:00`

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
  "id": "e4f9d886-306b-4c70-9907-4aa7304c2686",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4660400+00:00"
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
  "subject_id": "16167ea6-3f59-4722-8e67-9bf622dd83df",
  "subject_name": "django/db/models/functions/window::LagLeadFunction",
  "tags": [
    "entity:class"
  ],
  "text": "class LagLeadFunction(Func)"
}
```
