# Fact ed373cdd

Store id: 5994097b-4748-4421-9952-439692dc0539

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
- posted_at: `2026-11-09T22:39:44.7453510+00:00`

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
  "id": "5994097b-4748-4421-9952-439692dc0539",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7453510+00:00"
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
  "subject_id": "89ed4a30-8a21-4fd6-abce-108a00506648",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.RelatedObjectDoesNotExist",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def RelatedObjectDoesNotExist(self)"
}
```
