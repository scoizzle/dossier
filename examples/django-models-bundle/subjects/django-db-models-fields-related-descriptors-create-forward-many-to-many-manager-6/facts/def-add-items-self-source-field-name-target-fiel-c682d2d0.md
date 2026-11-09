# Fact c682d2d0

Store id: cbcb2145-423b-4fce-af9b-e694eebf7ce3

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
- posted_at: `2026-11-09T22:39:44.9446240+00:00`

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
  "id": "cbcb2145-423b-4fce-af9b-e694eebf7ce3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9446240+00:00"
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
  "subject_id": "644cc123-1acf-43d2-9d9f-614c1a7ff2e7",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_items",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_items( self, source_field_name, target_field_name, *objs, through_defaults=None, using=None, raw=False, )"
}
```
