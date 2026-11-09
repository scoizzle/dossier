# Fact 8b399f96

Store id: 80e7445e-4a46-454e-84a1-852764e9878d

## Text

```text
async def aget_or_create(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.9289750+00:00`

## Data

```json
{
  "end_line": 1474,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1471,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1471,"selector":"L1471-L1474","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1474,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1471,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create"
  },
  "id": "80e7445e-4a46-454e-84a1-852764e9878d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9289750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1471,
        "selector": "L1471-L1474",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "d9ad5ece-bcdd-40ea-a22b-ef2a7575217e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.aget_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aget_or_create(self, *, through_defaults=None, **kwargs)"
}
```
