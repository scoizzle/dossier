# Fact f8ba5454

Store id: 7c41c13d-8df4-4d75-834c-be5614812988

## Text

```text
async def aget_or_create(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.9308540+00:00`

## Data

```json
{
  "end_line": 914,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 913,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aget_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":913,"selector":"L913-L914","symbol":"create_reverse_many_to_one_manager.RelatedManager.aget_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aget_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 914,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 913,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aget_or_create"
  },
  "id": "7c41c13d-8df4-4d75-834c-be5614812988",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9308540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 913,
        "selector": "L913-L914",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aget_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "243d2023-bfe2-474b-ac17-ff216d44f0a1",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aget_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aget_or_create(self, **kwargs)"
}
```
