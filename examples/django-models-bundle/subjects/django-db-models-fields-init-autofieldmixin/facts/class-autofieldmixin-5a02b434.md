# Fact 5a02b434

Store id: 116a0a94-3f65-4d97-aecf-8509d7c3d877

## Text

```text
class AutoFieldMixin
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
- posted_at: `2026-11-09T23:44:50.3110290+00:00`

## Data

```json
{
  "end_line": 2928,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2874,
  "symbol": "AutoFieldMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2874,"selector":"L2874-L2928","symbol":"AutoFieldMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2928,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2874,
    "symbol": "AutoFieldMixin"
  },
  "id": "116a0a94-3f65-4d97-aecf-8509d7c3d877",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3110290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2874,
        "selector": "L2874-L2928",
        "symbol": "AutoFieldMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "afdd551c-d600-416e-a3e2-f272878aa552",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class AutoFieldMixin"
}
```
