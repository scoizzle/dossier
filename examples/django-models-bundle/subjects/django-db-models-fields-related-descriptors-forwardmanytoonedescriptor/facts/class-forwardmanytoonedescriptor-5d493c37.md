# Fact 5d493c37

Store id: 5c3da9c1-2229-4cbc-be3a-d99282b8d495

## Text

```text
class ForwardManyToOneDescriptor
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
- posted_at: `2026-11-09T22:39:44.6915010+00:00`

## Data

```json
{
  "end_line": 376,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 132,
  "symbol": "ForwardManyToOneDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":132,"selector":"L132-L376","symbol":"ForwardManyToOneDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related object on the forward side of a many-to-one or one-to-one (via ForwardOneToOneDescriptor subclass) relation.",
    "locator": {
      "line": 133
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 376,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 132,
    "symbol": "ForwardManyToOneDescriptor"
  },
  "id": "5c3da9c1-2229-4cbc-be3a-d99282b8d495",
  "items": [
    {
      "locator": {
        "line": 133
      },
      "text": "Accessor to the related object on the forward side of a many-to-one or one-to-one (via ForwardOneToOneDescriptor subclass) relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.6915010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 132,
        "selector": "L132-L376",
        "symbol": "ForwardManyToOneDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "3c0653b4-b961-48b4-934b-d3ac1f6e9f1d",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ForwardManyToOneDescriptor"
}
```
