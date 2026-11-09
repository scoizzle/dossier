# Fact d324eb09

Store id: 1bd02d47-55b2-4b03-a9bb-5d7d84778582

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
- posted_at: `2026-11-09T23:44:51.2053020+00:00`

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
  "id": "1bd02d47-55b2-4b03-a9bb-5d7d84778582",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.2053020+00:00"
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
  "subject_id": "e0339caa-67f0-4efd-8045-b0f2452d0b2f",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.set_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def set_cached_value(self, instance, value)"
}
```
