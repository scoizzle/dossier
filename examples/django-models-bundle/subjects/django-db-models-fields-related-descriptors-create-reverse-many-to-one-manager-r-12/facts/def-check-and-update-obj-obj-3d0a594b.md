# Fact 3d0a594b

Store id: a0a5599f-f5d6-4d00-9434-9046c0eec0ec

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
- posted_at: `2026-11-09T23:31:59.2542950+00:00`

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
  "id": "a0a5599f-f5d6-4d00-9434-9046c0eec0ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2542950+00:00"
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
  "subject_id": "c284109c-dbf3-410b-b68e-0f32e166d93c",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add.check_and_update_obj",
  "tags": [
    "entity:function"
  ],
  "text": "def check_and_update_obj(obj)"
}
```
