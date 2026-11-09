# Fact 705a8af9

Store id: 0bff68e7-38f6-4faf-8160-d7af2b560f0a

## Text

```text
def is_cached(self, instance)
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
- posted_at: `2026-11-09T22:39:43.9335740+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 27,
  "symbol": "FieldCacheMixin.is_cached"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L28","symbol":"FieldCacheMixin.is_cached"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.is_cached](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 27,
    "symbol": "FieldCacheMixin.is_cached"
  },
  "id": "0bff68e7-38f6-4faf-8160-d7af2b560f0a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.9335740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L28",
        "symbol": "FieldCacheMixin.is_cached"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "10b6efea-2696-4508-a930-e000e6c9589a",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
