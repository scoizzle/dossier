# Fact 8f21013f

Store id: 409c1c7e-d518-4f28-81a3-7260bdcafa9c

## Text

```text
def _get_target_ids(self, target_field_name, objs)
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
- posted_at: `2026-11-09T23:31:59.5657330+00:00`

## Data

```json
{
  "end_line": 1528,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1498,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1498,"selector":"L1498-L1528","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids"}`

## Items

```json
[
  {
    "text": "Return the set of ids of `objs` that the target field references.",
    "locator": {
      "line": 1499
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1528,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1498,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids"
  },
  "id": "409c1c7e-d518-4f28-81a3-7260bdcafa9c",
  "items": [
    {
      "locator": {
        "line": 1499
      },
      "text": "Return the set of ids of `objs` that the target field references."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.5657330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1498,
        "selector": "L1498-L1528",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "4b76d82d-e017-442f-b27f-b94a27a1fe3e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_target_ids",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_target_ids(self, target_field_name, objs)"
}
```
