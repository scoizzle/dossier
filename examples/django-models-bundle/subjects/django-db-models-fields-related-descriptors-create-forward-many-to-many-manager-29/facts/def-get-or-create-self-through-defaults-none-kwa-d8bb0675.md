# Fact d8bb0675

Store id: 9ad64643-4e01-4e51-b77f-1776409cc71d

## Text

```text
def get_or_create(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:52.0101360+00:00`

## Data

```json
{
  "end_line": 1467,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1458,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1458,"selector":"L1458-L1467","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1467,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1458,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
  },
  "id": "9ad64643-4e01-4e51-b77f-1776409cc71d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0101360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1458,
        "selector": "L1458-L1467",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "a1f4a147-cd99-4f6c-8e15-b2df6e79e584",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, *, through_defaults=None, **kwargs)"
}
```
