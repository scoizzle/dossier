# Fact ade45f3c

Store id: 31f8e3b0-3f4a-41b0-8ec0-52553795e8b6

## Text

```text
class FieldCacheMixin
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
- posted_at: `2026-11-09T23:31:58.1986180+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "class",
  "parent": "mixins",
  "start_line": 7,
  "symbol": "FieldCacheMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":7,"selector":"L7-L34","symbol":"FieldCacheMixin"}`

## Items

```json
[
  {
    "text": "An API for working with the model's fields value cache.",
    "locator": {
      "line": 8
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "class",
    "parent": "mixins",
    "start_line": 7,
    "symbol": "FieldCacheMixin"
  },
  "id": "31f8e3b0-3f4a-41b0-8ec0-52553795e8b6",
  "items": [
    {
      "locator": {
        "line": 8
      },
      "text": "An API for working with the model's fields value cache."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.1986180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 7,
        "selector": "L7-L34",
        "symbol": "FieldCacheMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "c84f4da3-6a8a-4fbc-9235-59bcbf50ad73",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldCacheMixin"
}
```
