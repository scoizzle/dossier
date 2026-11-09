# Fact 50c2c6f3

Store id: d9717a85-c244-4ce2-8911-56844b6bcce9

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
- posted_at: `2026-11-09T23:44:55.4546610+00:00`

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
  "id": "d9717a85-c244-4ce2-8911-56844b6bcce9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4546610+00:00"
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
  "subject_id": "7003c2e8-a8a9-4dc9-8c64-69972325edb7",
  "subject_name": "django/db/models/options::Options",
  "tags": [
    "entity:class"
  ],
  "text": "class Options"
}
```
