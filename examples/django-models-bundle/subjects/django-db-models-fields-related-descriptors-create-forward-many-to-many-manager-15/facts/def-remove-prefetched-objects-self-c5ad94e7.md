# Fact c5ad94e7

Store id: 3bbe69e8-e1ac-46d2-8dd8-6e3c30a9c41b

## Text

```text
def _remove_prefetched_objects(self)
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
- posted_at: `2026-11-09T22:39:44.8665710+00:00`

## Data

```json
{
  "end_line": 1192,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1185,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1185,"selector":"L1185-L1192","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1192,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1185,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects"
  },
  "id": "3bbe69e8-e1ac-46d2-8dd8-6e3c30a9c41b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8665710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1185,
        "selector": "L1185-L1192",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e5519a02-27b6-4741-9306-b043f78b2814",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_prefetched_objects(self)"
}
```
