# Fact ade45f3c

Store id: 83b80c7b-b245-4545-a562-2e875ff5a490

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
- posted_at: `2026-11-09T23:44:51.1882380+00:00`

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
  "id": "83b80c7b-b245-4545-a562-2e875ff5a490",
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
    "posted_at": "2026-11-09T23:44:51.1882380+00:00"
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
  "subject_id": "7a7c61cd-8742-4134-a6dd-a05e9ece8bf5",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class FieldCacheMixin"
}
```
