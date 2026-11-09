# Fact e00f4118

Store id: d61e1840-ebe2-43e9-b865-dee83099b63c

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
- posted_at: `2026-11-09T23:31:59.5559550+00:00`

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
  "id": "d61e1840-ebe2-43e9-b865-dee83099b63c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.5559550+00:00"
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
  "subject_id": "5bdbc7c9-f92e-417a-aed2-96e252f8b40e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aupdate_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate_or_create(self, *, through_defaults=None, **kwargs)"
}
```
