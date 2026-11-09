# Fact 50c2c6f3

Store id: da4264c2-0b09-460f-81b6-c63c919de397

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
- posted_at: `2026-11-09T23:32:03.8871760+00:00`

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
  "id": "da4264c2-0b09-460f-81b6-c63c919de397",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8871760+00:00"
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
  "subject_id": "f072ea1d-3bc4-44f4-986b-3d444258e1b3",
  "subject_name": "django/db/models/options::Options",
  "tags": [
    "entity:class"
  ],
  "text": "class Options"
}
```
