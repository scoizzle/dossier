# Fact 050e282b

Store id: 9a40f07e-f4b9-4628-a935-1db50774a280

## Text

```text
class ReverseOneToOneDescriptor
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
- posted_at: `2026-11-09T22:39:44.7395000+00:00`

## Data

```json
{
  "end_line": 654,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 432,
  "symbol": "ReverseOneToOneDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":432,"selector":"L432-L654","symbol":"ReverseOneToOneDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related object on the reverse side of a one-to-one relation.",
    "locator": {
      "line": 433
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 654,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 432,
    "symbol": "ReverseOneToOneDescriptor"
  },
  "id": "9a40f07e-f4b9-4628-a935-1db50774a280",
  "items": [
    {
      "locator": {
        "line": 433
      },
      "text": "Accessor to the related object on the reverse side of a one-to-one relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7395000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 432,
        "selector": "L432-L654",
        "symbol": "ReverseOneToOneDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "dbec2e8a-24e7-4b7d-94cc-e0aad6d49395",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ReverseOneToOneDescriptor"
}
```
