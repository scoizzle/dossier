# Fact ed8267bf

Store id: d7b8e234-015d-4d1c-8819-ef8ecfb3de54

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
- posted_at: `2026-11-09T23:44:51.9223820+00:00`

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
  "id": "d7b8e234-015d-4d1c-8819-ef8ecfb3de54",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9223820+00:00"
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
  "subject_id": "f86fb44e-c648-463e-9569-f51d9ee705ca",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aadd",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aadd(self, *objs, bulk=True)"
}
```
