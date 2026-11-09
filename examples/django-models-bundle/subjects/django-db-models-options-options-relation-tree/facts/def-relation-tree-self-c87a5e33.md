# Fact c87a5e33

Store id: 087f302c-8d50-4cd2-98e6-64196f1ee283

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
- posted_at: `2026-11-09T23:32:04.0256570+00:00`

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
  "id": "087f302c-8d50-4cd2-98e6-64196f1ee283",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0256570+00:00"
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
  "subject_id": "13cb3004-aaee-4c9a-a14e-94944126ae65",
  "subject_name": "django/db/models/options::Options._relation_tree",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _relation_tree(self)"
}
```
