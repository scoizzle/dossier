# Fact 7400b5ff

Store id: 7befeac4-8915-401c-8838-ae9e349e39a2

## Text

```text
async def acreate(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.9218970+00:00`

## Data

```json
{
  "end_line": 1454,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1451,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.acreate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1451,"selector":"L1451-L1454","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.acreate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.acreate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1454,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1451,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.acreate"
  },
  "id": "7befeac4-8915-401c-8838-ae9e349e39a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9218970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1451,
        "selector": "L1451-L1454",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.acreate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "9dce3caf-da65-4fa3-a20e-02728402b9b6",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, *, through_defaults=None, **kwargs)"
}
```
