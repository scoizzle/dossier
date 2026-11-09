# Fact d3599e01

Store id: 53ea2a22-365b-4b1b-9924-3995326d1488

## Text

```text
async def aset(self, objs, *, clear=False, through_defaults=None)
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
- posted_at: `2026-11-09T22:39:44.9161680+00:00`

## Data

```json
{
  "end_line": 1439,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1436,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1436,"selector":"L1436-L1439","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1439,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1436,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aset"
  },
  "id": "53ea2a22-365b-4b1b-9924-3995326d1488",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9161680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1436,
        "selector": "L1436-L1439",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "264fcd80-3991-46d9-86af-09fb876f3004",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aset",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aset(self, objs, *, clear=False, through_defaults=None)"
}
```
