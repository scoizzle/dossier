# Fact c682d2d0

Store id: f9abc328-c95d-4876-98fd-0b5f3c23c3d3

## Text

```text
def _add_items( self, source_field_name, target_field_name, *objs, through_defaults=None, using=None, raw=False, )
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
- posted_at: `2026-11-09T23:44:52.0239880+00:00`

## Data

```json
{
  "end_line": 1659,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1582,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_items"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1582,"selector":"L1582-L1659","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._add_items"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_items](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1659,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1582,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_items"
  },
  "id": "f9abc328-c95d-4876-98fd-0b5f3c23c3d3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0239880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1582,
        "selector": "L1582-L1659",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_items"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "b7dd01a1-0c7b-4c12-915a-f59e4325aa24",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_items",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_items( self, source_field_name, target_field_name, *objs, through_defaults=None, using=None, raw=False, )"
}
```
