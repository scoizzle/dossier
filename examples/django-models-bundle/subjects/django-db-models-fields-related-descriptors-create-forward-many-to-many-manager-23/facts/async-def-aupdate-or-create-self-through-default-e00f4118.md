# Fact e00f4118

Store id: 2bd5de52-1a50-4c4f-8625-e02a72b45ce6

## Text

```text
async def aupdate_or_create(self, *, through_defaults=None, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.9344190+00:00`

## Data

```json
{
  "end_line": 1494,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1491,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1491,"selector":"L1491-L1494","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1494,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1491,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create"
  },
  "id": "2bd5de52-1a50-4c4f-8625-e02a72b45ce6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9344190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1491,
        "selector": "L1491-L1494",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "8635d19a-7e76-442e-be23-2a7983512682",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate_or_create(self, *, through_defaults=None, **kwargs)"
}
```
