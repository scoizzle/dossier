# Fact 1b78cc63

Store id: 9b04db07-febc-4865-b2f6-e9fb22fed185

## Text

```text
def RelatedObjectDoesNotExist(self)
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
- posted_at: `2026-11-09T23:44:51.8290160+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 148,
  "symbol": "ForwardManyToOneDescriptor.RelatedObjectDoesNotExist"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L164","symbol":"ForwardManyToOneDescriptor.RelatedObjectDoesNotExist"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.RelatedObjectDoesNotExist](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 148,
    "symbol": "ForwardManyToOneDescriptor.RelatedObjectDoesNotExist"
  },
  "id": "9b04db07-febc-4865-b2f6-e9fb22fed185",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8290160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L164",
        "symbol": "ForwardManyToOneDescriptor.RelatedObjectDoesNotExist"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ae65fbc7-ad63-4281-a9be-0043c7069ce2",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.RelatedObjectDoesNotExist",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def RelatedObjectDoesNotExist(self)"
}
```
