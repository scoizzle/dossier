# Fact 82239a4f

Store id: cc16ff94-372c-409f-a8f3-ac1743d83a23

## Text

```text
class ReverseManyToOneDescriptor
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
- posted_at: `2026-11-09T23:31:59.2133250+00:00`

## Data

```json
{
  "end_line": 711,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 657,
  "symbol": "ReverseManyToOneDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":657,"selector":"L657-L711","symbol":"ReverseManyToOneDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related objects manager on the reverse side of a many-to-one relation.",
    "locator": {
      "line": 658
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 711,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 657,
    "symbol": "ReverseManyToOneDescriptor"
  },
  "id": "cc16ff94-372c-409f-a8f3-ac1743d83a23",
  "items": [
    {
      "locator": {
        "line": 658
      },
      "text": "Accessor to the related objects manager on the reverse side of a many-to-one relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2133250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 657,
        "selector": "L657-L711",
        "symbol": "ReverseManyToOneDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "96e57659-d1c9-4b02-bc03-562624f68bb2",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ReverseManyToOneDescriptor"
}
```
