# Fact c1509937

Store id: 2a5ed5fd-1a47-4624-af36-fdeaef68032d

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
- posted_at: `2026-11-09T22:39:44.9097400+00:00`

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
  "id": "2a5ed5fd-1a47-4624-af36-fdeaef68032d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9097400+00:00"
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
  "subject_id": "4400c853-c94b-451f-84af-d9bddaa1dd75",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.set_base",
  "tags": [
    "entity:method"
  ],
  "text": "def set_base(self, objs, *, clear=False, through_defaults=None, raw=False)"
}
```
