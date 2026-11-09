# Fact c1509937

Store id: d1eda8f0-0a8c-40e5-92f4-34f1366b3c14

## Text

```text
def set_base(self, objs, *, clear=False, through_defaults=None, raw=False)
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
- posted_at: `2026-11-09T23:44:52.0005380+00:00`

## Data

```json
{
  "end_line": 1429,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1394,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set_base"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1394,"selector":"L1394-L1429","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.set_base"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.set_base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1429,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1394,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set_base"
  },
  "id": "d1eda8f0-0a8c-40e5-92f4-34f1366b3c14",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0005380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1394,
        "selector": "L1394-L1429",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set_base"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "691de182-802a-4298-ab9a-1f58efb11ccb",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.set_base",
  "tags": [
    "entity:method"
  ],
  "text": "def set_base(self, objs, *, clear=False, through_defaults=None, raw=False)"
}
```
