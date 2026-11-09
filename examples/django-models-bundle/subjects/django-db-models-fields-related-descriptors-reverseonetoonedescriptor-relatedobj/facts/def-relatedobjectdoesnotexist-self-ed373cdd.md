# Fact ed373cdd

Store id: c271163b-fcec-46c9-8690-ac6e882ba887

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
- posted_at: `2026-11-09T23:31:59.1878300+00:00`

## Data

```json
{
  "end_line": 465,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 450,
  "symbol": "ReverseOneToOneDescriptor.RelatedObjectDoesNotExist"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":450,"selector":"L450-L465","symbol":"ReverseOneToOneDescriptor.RelatedObjectDoesNotExist"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.RelatedObjectDoesNotExist](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 465,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 450,
    "symbol": "ReverseOneToOneDescriptor.RelatedObjectDoesNotExist"
  },
  "id": "c271163b-fcec-46c9-8690-ac6e882ba887",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1878300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 450,
        "selector": "L450-L465",
        "symbol": "ReverseOneToOneDescriptor.RelatedObjectDoesNotExist"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "88f7a208-cad3-4cee-ae0d-6987a8d37b18",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.RelatedObjectDoesNotExist",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def RelatedObjectDoesNotExist(self)"
}
```
