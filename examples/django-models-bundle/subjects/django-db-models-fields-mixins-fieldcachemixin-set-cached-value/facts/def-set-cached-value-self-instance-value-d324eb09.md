# Fact d324eb09

Store id: 028b6426-d365-47e2-b4d3-5cc187c7b1d0

## Text

```text
def set_cached_value(self, instance, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.9357370+00:00`

## Data

```json
{
  "end_line": 31,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 30,
  "symbol": "FieldCacheMixin.set_cached_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":30,"selector":"L30-L31","symbol":"FieldCacheMixin.set_cached_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.set_cached_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 31,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 30,
    "symbol": "FieldCacheMixin.set_cached_value"
  },
  "id": "028b6426-d365-47e2-b4d3-5cc187c7b1d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.9357370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 30,
        "selector": "L30-L31",
        "symbol": "FieldCacheMixin.set_cached_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "fcc1eb92-8fb6-4a23-861e-6785b649a67b",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.set_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def set_cached_value(self, instance, value)"
}
```
