# Fact b58f30c1

Store id: 61136f37-6698-436d-948e-72a532efa76d

## Text

```text
async def aclear(self)
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
- posted_at: `2026-11-09T23:31:59.4728350+00:00`

## Data

```json
{
  "end_line": 1390,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1389,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aclear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1389,"selector":"L1389-L1390","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aclear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aclear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1390,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1389,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aclear"
  },
  "id": "61136f37-6698-436d-948e-72a532efa76d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4728350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1389,
        "selector": "L1389-L1390",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aclear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "713aaa13-6072-449d-b5b2-81d1ec77e4ca",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aclear",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aclear(self)"
}
```
