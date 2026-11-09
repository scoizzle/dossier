# Fact 75ee31af

Store id: 6326a04e-bca2-4e6b-a714-8709ca5b9dc0

## Text

```text
class ManyToManyDescriptor(ReverseManyToOneDescriptor)
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
- posted_at: `2026-11-09T22:39:44.8394820+00:00`

## Data

```json
{
  "end_line": 1072,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 1028,
  "symbol": "ManyToManyDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1028,"selector":"L1028-L1072","symbol":"ManyToManyDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related objects manager on the forward and reverse sides of a many-to-many relation.",
    "locator": {
      "line": 1029
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1072,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 1028,
    "symbol": "ManyToManyDescriptor"
  },
  "id": "6326a04e-bca2-4e6b-a714-8709ca5b9dc0",
  "items": [
    {
      "locator": {
        "line": 1029
      },
      "text": "Accessor to the related objects manager on the forward and reverse sides of a many-to-many relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8394820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1028,
        "selector": "L1028-L1072",
        "symbol": "ManyToManyDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "5294cea7-0ab8-45b6-a81f-6dc5783ff329",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyToManyDescriptor(ReverseManyToOneDescriptor)"
}
```
