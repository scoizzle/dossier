# Fact 5bb6fbb4

Store id: f750b695-d006-4ab7-a361-b2d54e6c7889

## Text

```text
def related_manager_cls(self)
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
- posted_at: `2026-11-09T23:44:51.8921870+00:00`

## Data

```json
{
  "end_line": 684,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 677,
  "symbol": "ReverseManyToOneDescriptor.related_manager_cls"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":677,"selector":"L677-L684","symbol":"ReverseManyToOneDescriptor.related_manager_cls"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.related_manager_cls](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 684,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 677,
    "symbol": "ReverseManyToOneDescriptor.related_manager_cls"
  },
  "id": "f750b695-d006-4ab7-a361-b2d54e6c7889",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8921870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 677,
        "selector": "L677-L684",
        "symbol": "ReverseManyToOneDescriptor.related_manager_cls"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "81759e3f-b1c6-4243-91a4-37f9bf49b42e",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.related_manager_cls",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_manager_cls(self)"
}
```
