# Fact 50c2c6f3

Store id: 587643f9-be3f-4cf0-8c98-6f2378499ada

## Text

```text
class Options
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
- posted_at: `2026-11-09T22:39:48.7425160+00:00`

## Data

```json
{
  "end_line": 1052,
  "entity_kind": "class",
  "parent": "options",
  "start_line": 90,
  "symbol": "Options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L1052","symbol":"Options"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1052,
    "entity_kind": "class",
    "parent": "options",
    "start_line": 90,
    "symbol": "Options"
  },
  "id": "587643f9-be3f-4cf0-8c98-6f2378499ada",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7425160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L1052",
        "symbol": "Options"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "5a9351ae-ab02-4f5b-ab5d-c34cf8a270e9",
  "subject_name": "django/db/models/options::Options",
  "tags": [
    "entity:class"
  ],
  "text": "class Options"
}
```
