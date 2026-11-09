# Fact 8f9bf8b9

Store id: 6252a602-039d-4c23-a4b3-86176eed51e1

## Text

```text
def _clear_base(self, using=None, raw=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.8993710+00:00`

## Data

```json
{
  "end_line": 1380,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1355,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._clear_base"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1355,"selector":"L1355-L1380","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._clear_base"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._clear_base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1380,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1355,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._clear_base"
  },
  "id": "6252a602-039d-4c23-a4b3-86176eed51e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8993710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1355,
        "selector": "L1355-L1380",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._clear_base"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ab7a12f2-f2d5-4bac-a9e4-7ea5e5640d8a",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._clear_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear_base(self, using=None, raw=False)"
}
```
