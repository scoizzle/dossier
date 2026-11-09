# Fact 8d4dfdf7

Store id: 20eafc91-cfcc-4e64-bc55-3a0bd6f44235

## Text

```text
def managers(self)
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
- posted_at: `2026-11-09T23:32:03.9576500+00:00`

## Data

```json
{
  "end_line": 471,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 453,
  "symbol": "Options.managers"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":453,"selector":"L453-L471","symbol":"Options.managers"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.managers](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 471,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 453,
    "symbol": "Options.managers"
  },
  "id": "20eafc91-cfcc-4e64-bc55-3a0bd6f44235",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9576500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 453,
        "selector": "L453-L471",
        "symbol": "Options.managers"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "b31e290f-1e09-4c94-a00d-306401029483",
  "subject_name": "django/db/models/options::Options.managers",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def managers(self)"
}
```
