# Fact c5ad94e7

Store id: 992e5e3f-3e3c-4f46-af9c-d2680bd8416c

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
- posted_at: `2026-11-09T23:31:59.3775010+00:00`

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
  "id": "992e5e3f-3e3c-4f46-af9c-d2680bd8416c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3775010+00:00"
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
  "subject_id": "e9138aaa-2844-4c2f-bb78-5c67f35a6998",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_prefetched_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_prefetched_objects(self)"
}
```
