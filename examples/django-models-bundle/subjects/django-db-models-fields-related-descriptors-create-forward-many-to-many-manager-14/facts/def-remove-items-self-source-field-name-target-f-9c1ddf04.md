# Fact 9c1ddf04

Store id: 3aaca926-4cd3-4e66-9292-298e72dce090

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
- posted_at: `2026-11-09T23:31:59.5906080+00:00`

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
  "id": "3aaca926-4cd3-4e66-9292-298e72dce090",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.5906080+00:00"
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
  "subject_id": "129abc7a-b745-4d54-af0e-e11be52c6c6b",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_items",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_items( self, source_field_name, target_field_name, *objs, using=None, raw=False )"
}
```
