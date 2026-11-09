# Fact 3d0a594b

Store id: 99f8f0e1-afd7-48b7-aa52-e5e9ef21e2c2

## Text

```text
def check_and_update_obj(obj)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.9200880+00:00`

## Data

```json
{
  "end_line": 861,
  "entity_kind": "function",
  "parent": "create_reverse_many_to_one_manager.RelatedManager.add",
  "start_line": 852,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":852,"selector":"L852-L861","symbol":"create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 861,
    "entity_kind": "function",
    "parent": "create_reverse_many_to_one_manager.RelatedManager.add",
    "start_line": 852,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj"
  },
  "id": "99f8f0e1-afd7-48b7-aa52-e5e9ef21e2c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9200880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 852,
        "selector": "L852-L861",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "3e3b654d-8d9d-4744-85b6-654272d1f46c",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj",
  "tags": [
    "entity:function"
  ],
  "text": "def check_and_update_obj(obj)"
}
```
