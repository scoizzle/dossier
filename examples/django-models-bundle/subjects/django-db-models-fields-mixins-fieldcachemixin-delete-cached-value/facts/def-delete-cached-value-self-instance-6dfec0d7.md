# Fact 6dfec0d7

Store id: 15d4699d-fef2-4072-938c-9cebe74d8c05

## Text

```text
def delete_cached_value(self, instance)
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
- posted_at: `2026-11-09T22:39:43.9375130+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 33,
  "symbol": "FieldCacheMixin.delete_cached_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":33,"selector":"L33-L34","symbol":"FieldCacheMixin.delete_cached_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.delete_cached_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 33,
    "symbol": "FieldCacheMixin.delete_cached_value"
  },
  "id": "15d4699d-fef2-4072-938c-9cebe74d8c05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.9375130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 33,
        "selector": "L33-L34",
        "symbol": "FieldCacheMixin.delete_cached_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "7f04d58c-e504-468d-8f57-f6a3728e3e0a",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.delete_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def delete_cached_value(self, instance)"
}
```
