# Fact 5a02b434

Store id: 99b924d2-36f5-46b8-81ae-e6b9509cebd5

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
- posted_at: `2026-11-09T23:31:56.8897030+00:00`

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
  "id": "99b924d2-36f5-46b8-81ae-e6b9509cebd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8897030+00:00"
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
  "subject_id": "ff7c914c-4cbb-4bfb-9a3c-432f11c59cd5",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class AutoFieldMixin"
}
```
