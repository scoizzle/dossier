# Fact c87a5e33

Store id: 43ced835-5880-4683-be23-ace4ca9f9b84

## Text

```text
def _relation_tree(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.9341260+00:00`

## Data

```json
{
  "end_line": 850,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 848,
  "symbol": "Options._relation_tree"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":848,"selector":"L848-L850","symbol":"Options._relation_tree"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._relation_tree](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 850,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 848,
    "symbol": "Options._relation_tree"
  },
  "id": "43ced835-5880-4683-be23-ace4ca9f9b84",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9341260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 848,
        "selector": "L848-L850",
        "symbol": "Options._relation_tree"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "d88839f6-a12c-45f6-99b5-5bdf37c59188",
  "subject_name": "django/db/models/options::Options._relation_tree",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _relation_tree(self)"
}
```
