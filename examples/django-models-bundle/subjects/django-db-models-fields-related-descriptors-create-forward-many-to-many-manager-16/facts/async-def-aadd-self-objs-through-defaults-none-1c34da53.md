# Fact 1c34da53

Store id: 278f33b3-3437-4e8b-8af8-1b6fa22dd0d0

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
- posted_at: `2026-11-09T22:39:44.8860270+00:00`

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
  "id": "278f33b3-3437-4e8b-8af8-1b6fa22dd0d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8860270+00:00"
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
  "subject_id": "d12608af-d030-444c-a884-a7abe29fd44e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aadd",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aadd(self, *objs, through_defaults=None)"
}
```
