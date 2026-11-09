# Fact 7400b5ff

Store id: dbd9fa46-fc5a-439a-8c6f-6ff36ffb3dc4

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
- posted_at: `2026-11-09T23:44:52.0083370+00:00`

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
  "id": "dbd9fa46-fc5a-439a-8c6f-6ff36ffb3dc4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0083370+00:00"
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
  "subject_id": "bcad2383-6651-4eca-bdbb-b0512539ad06",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, *, through_defaults=None, **kwargs)"
}
```
