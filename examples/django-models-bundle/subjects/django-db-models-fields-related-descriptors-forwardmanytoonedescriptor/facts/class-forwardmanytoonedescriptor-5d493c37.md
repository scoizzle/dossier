# Fact 5d493c37

Store id: b7139a92-7120-4b18-b658-177cc71596f2

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
- posted_at: `2026-11-09T23:31:59.1257530+00:00`

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
  "id": "b7139a92-7120-4b18-b658-177cc71596f2",
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
    "posted_at": "2026-11-09T23:31:59.1257530+00:00"
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
  "subject_id": "c04c1eaa-0ae4-4a6f-8028-0ecb3c29d98b",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ForwardManyToOneDescriptor"
}
```
