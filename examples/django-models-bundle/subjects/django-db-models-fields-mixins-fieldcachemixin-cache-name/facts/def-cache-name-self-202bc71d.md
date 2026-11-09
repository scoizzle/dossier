# Fact 202bc71d

Store id: e1601418-4a93-4556-b68a-e74f6423da04

## Text

```text
def cache_name(self)
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
- posted_at: `2026-11-09T23:44:51.1996130+00:00`

## Data

```json
{
  "end_line": 17,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 15,
  "symbol": "FieldCacheMixin.cache_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":15,"selector":"L15-L17","symbol":"FieldCacheMixin.cache_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.cache_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 17,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 15,
    "symbol": "FieldCacheMixin.cache_name"
  },
  "id": "e1601418-4a93-4556-b68a-e74f6423da04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.1996130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 15,
        "selector": "L15-L17",
        "symbol": "FieldCacheMixin.cache_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "86de189d-2360-4fcc-91e1-8eeb149cd237",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.cache_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cache_name(self)"
}
```
