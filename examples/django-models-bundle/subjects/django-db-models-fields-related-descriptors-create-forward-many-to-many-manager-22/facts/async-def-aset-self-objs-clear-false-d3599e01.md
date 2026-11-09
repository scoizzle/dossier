# Fact d3599e01

Store id: b5d03058-36b9-420f-9558-90b03ab428a2

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
- posted_at: `2026-11-09T23:31:59.4930110+00:00`

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
  "id": "b5d03058-36b9-420f-9558-90b03ab428a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4930110+00:00"
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
  "subject_id": "bc9c8733-8ca9-4a4b-b9ab-ba36ff2aea8c",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aset",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aset(self, objs, *, clear=False, through_defaults=None)"
}
```
