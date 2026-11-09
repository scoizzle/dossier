# Fact e3e3a618

Store id: 0d354160-6814-4cf2-8efe-1639dab2885e

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
- posted_at: `2026-11-09T23:31:59.2435550+00:00`

## Data

```json
{
  "end_line": 795,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 789,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":789,"selector":"L789-L795","symbol":"create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 795,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 789,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects"
  },
  "id": "0d354160-6814-4cf2-8efe-1639dab2885e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2435550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 789,
        "selector": "L789-L795",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "3b380c96-7ee0-4ca9-89fa-2e030bf2c17b",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._remove_prefetched_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_prefetched_objects(self)"
}
```
