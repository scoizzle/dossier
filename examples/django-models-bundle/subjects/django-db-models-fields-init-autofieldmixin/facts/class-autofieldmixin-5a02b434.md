# Fact 5a02b434

Store id: 3518f89f-fe6b-4c6a-857b-15c9682a4d68

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
- posted_at: `2026-11-09T22:39:42.7226690+00:00`

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
  "id": "3518f89f-fe6b-4c6a-857b-15c9682a4d68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7226690+00:00"
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
  "subject_id": "adc9e7db-fec9-4013-8c77-58df1bb98f53",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class AutoFieldMixin"
}
```
