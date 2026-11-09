# Fact ed8267bf

Store id: 8e17f333-dab5-40f7-b943-9f13f58461fa

## Text

```text
async def aadd(self, *objs, bulk=True)
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
- posted_at: `2026-11-09T22:39:44.8091610+00:00`

## Data

```json
{
  "end_line": 887,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 886,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":886,"selector":"L886-L887","symbol":"create_reverse_many_to_one_manager.RelatedManager.aadd"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aadd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 887,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 886,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
  },
  "id": "8e17f333-dab5-40f7-b943-9f13f58461fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8091610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 886,
        "selector": "L886-L887",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "abd71a24-46c4-4364-9b4f-608f7264a7c6",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aadd",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aadd(self, *objs, bulk=True)"
}
```
