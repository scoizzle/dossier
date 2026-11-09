# Fact 202bc71d

Store id: f9cd9808-4841-4253-b2a8-68f1deabf7d0

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
- posted_at: `2026-11-09T22:39:43.9295130+00:00`

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
  "id": "f9cd9808-4841-4253-b2a8-68f1deabf7d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.9295130+00:00"
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
  "subject_id": "9e250909-81f0-4618-8f82-58c3cc6e7e75",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.cache_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cache_name(self)"
}
```
