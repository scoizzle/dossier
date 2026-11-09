# Fact 4ef1d315

Store id: 83ca6e1f-ce79-45b1-9f74-27d696f82c77

## Text

```text
def __get__(self, instance, cls=None)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.7776550+00:00`

## Data

```json
{
  "end_line": 699,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 686,
  "symbol": "ReverseManyToOneDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":686,"selector":"L686-L699","symbol":"ReverseManyToOneDescriptor.__get__"}`

## Items

```json
[
  {
    "text": "Get the related objects through the reverse relation.",
    "locator": {
      "line": 687
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 699,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 686,
    "symbol": "ReverseManyToOneDescriptor.__get__"
  },
  "id": "83ca6e1f-ce79-45b1-9f74-27d696f82c77",
  "items": [
    {
      "locator": {
        "line": 687
      },
      "text": "Get the related objects through the reverse relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7776550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 686,
        "selector": "L686-L699",
        "symbol": "ReverseManyToOneDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "26128cb8-d64a-4c2c-8ea2-13978d236b3a",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
