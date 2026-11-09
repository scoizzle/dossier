# Fact 3d0a594b

Store id: f4a634e0-ba1e-44a7-965c-ba8d750bc63c

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
- posted_at: `2026-11-09T22:39:44.8066740+00:00`

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
  "id": "f4a634e0-ba1e-44a7-965c-ba8d750bc63c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8066740+00:00"
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
  "subject_id": "3b092a37-5472-4c8c-b347-7182ffab610a",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj",
  "tags": [
    "entity:function"
  ],
  "text": "def check_and_update_obj(obj)"
}
```
