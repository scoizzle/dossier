# Fact 1c34da53

Store id: 61f1d193-8f34-4e67-b5b9-446a8e227fcc

## Text

```text
async def aadd(self, *objs, through_defaults=None)
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
- posted_at: `2026-11-09T23:31:59.4363480+00:00`

## Data

```json
{
  "end_line": 1333,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1330,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aadd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1330,"selector":"L1330-L1333","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aadd"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aadd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1333,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1330,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aadd"
  },
  "id": "61f1d193-8f34-4e67-b5b9-446a8e227fcc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4363480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1330,
        "selector": "L1330-L1333",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aadd"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "9ed33983-cafb-44db-bef5-c7859d12b744",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aadd",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aadd(self, *objs, through_defaults=None)"
}
```
