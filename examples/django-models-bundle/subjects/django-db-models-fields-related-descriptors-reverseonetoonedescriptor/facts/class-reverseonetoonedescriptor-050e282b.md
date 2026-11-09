# Fact 050e282b

Store id: f6457f5d-d34b-48ad-bcfc-00a6d7839b05

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
- posted_at: `2026-11-09T23:44:51.8646480+00:00`

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
  "id": "f6457f5d-d34b-48ad-bcfc-00a6d7839b05",
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
    "posted_at": "2026-11-09T23:44:51.8646480+00:00"
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
  "subject_id": "8b155a1c-2777-4a82-9067-0f531423f5fc",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ReverseOneToOneDescriptor"
}
```
