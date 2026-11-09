# Fact 9c1ddf04

Store id: 5b5aa319-3ae1-4133-bd51-201c5b6cf99b

## Text

```text
def _remove_items( self, source_field_name, target_field_name, *objs, using=None, raw=False )
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
- posted_at: `2026-11-09T23:44:52.0260540+00:00`

## Data

```json
{
  "end_line": 1712,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1661,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_items"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1661,"selector":"L1661-L1712","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._remove_items"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_items](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1712,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1661,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_items"
  },
  "id": "5b5aa319-3ae1-4133-bd51-201c5b6cf99b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0260540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1661,
        "selector": "L1661-L1712",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_items"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "33ed6628-b23a-4608-a158-e383b36d555d",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_items",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_items( self, source_field_name, target_field_name, *objs, using=None, raw=False )"
}
```
