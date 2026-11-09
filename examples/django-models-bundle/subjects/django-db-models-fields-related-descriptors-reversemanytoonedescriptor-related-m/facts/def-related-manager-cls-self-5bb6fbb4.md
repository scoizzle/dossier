# Fact 5bb6fbb4

Store id: 8669a15f-3882-4afa-8516-34dbe26b4e13

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
- posted_at: `2026-11-09T22:39:44.7752310+00:00`

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
  "id": "8669a15f-3882-4afa-8516-34dbe26b4e13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7752310+00:00"
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
  "subject_id": "0f467101-9cd1-406c-9a4a-e9639bfdd4e6",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.related_manager_cls",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_manager_cls(self)"
}
```
