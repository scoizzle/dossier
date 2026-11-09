# Fact 1cde9969

Store id: 17bb8b2b-20c0-4870-85b7-b499eb2bf4e8

## Text

```text
class ForwardOneToOneDescriptor(ForwardManyToOneDescriptor)
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
- posted_at: `2026-11-09T23:31:59.1711680+00:00`

## Data

```json
{
  "end_line": 429,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 379,
  "symbol": "ForwardOneToOneDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":379,"selector":"L379-L429","symbol":"ForwardOneToOneDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related object on the forward side of a one-to-one relation.",
    "locator": {
      "line": 380
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 429,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 379,
    "symbol": "ForwardOneToOneDescriptor"
  },
  "id": "17bb8b2b-20c0-4870-85b7-b499eb2bf4e8",
  "items": [
    {
      "locator": {
        "line": 380
      },
      "text": "Accessor to the related object on the forward side of a one-to-one relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1711680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 379,
        "selector": "L379-L429",
        "symbol": "ForwardOneToOneDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "1f3ddd53-934b-46ec-a6ff-e9b1ead8537e",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ForwardOneToOneDescriptor(ForwardManyToOneDescriptor)"
}
```
