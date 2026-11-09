# Fact 5d493c37

Store id: 48de916e-10c4-49e6-8885-092f2d1b9986

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
- posted_at: `2026-11-09T23:44:51.8212250+00:00`

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
  "id": "48de916e-10c4-49e6-8885-092f2d1b9986",
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
    "posted_at": "2026-11-09T23:44:51.8212250+00:00"
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
  "subject_id": "c69a0361-dfee-494c-9398-c9d3a5604f3b",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ForwardManyToOneDescriptor"
}
```
