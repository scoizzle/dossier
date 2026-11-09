# Fact f5e29f11

Store id: b50748a4-8c94-4bbf-99df-f861ae46e2d2

## Text

```text
def get_object(self, instance)
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
- posted_at: `2026-11-09T22:39:44.7177100+00:00`

## Data

```json
{
  "end_line": 232,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 229,
  "symbol": "ForwardManyToOneDescriptor.get_object"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":229,"selector":"L229-L232","symbol":"ForwardManyToOneDescriptor.get_object"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_object](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 232,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 229,
    "symbol": "ForwardManyToOneDescriptor.get_object"
  },
  "id": "b50748a4-8c94-4bbf-99df-f861ae46e2d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7177100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 229,
        "selector": "L229-L232",
        "symbol": "ForwardManyToOneDescriptor.get_object"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "9156fef2-b85d-4b73-9ed4-5a5acdb30a86",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_object",
  "tags": [
    "entity:method"
  ],
  "text": "def get_object(self, instance)"
}
```
