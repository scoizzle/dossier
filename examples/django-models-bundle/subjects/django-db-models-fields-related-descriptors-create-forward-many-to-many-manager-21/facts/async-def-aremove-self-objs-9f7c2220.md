# Fact 9f7c2220

Store id: cfdbe66b-a3b0-49db-bb83-bda3ce5b9529

## Text

```text
async def aremove(self, *objs)
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
- posted_at: `2026-11-09T22:39:44.8959570+00:00`

## Data

```json
{
  "end_line": 1351,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1350,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aremove"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1350,"selector":"L1350-L1351","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aremove"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aremove](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1351,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1350,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aremove"
  },
  "id": "cfdbe66b-a3b0-49db-bb83-bda3ce5b9529",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8959570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1350,
        "selector": "L1350-L1351",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aremove"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "6f1f3260-f2dc-4f2c-b0ef-84ac7e0be1cc",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aremove",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aremove(self, *objs)"
}
```
