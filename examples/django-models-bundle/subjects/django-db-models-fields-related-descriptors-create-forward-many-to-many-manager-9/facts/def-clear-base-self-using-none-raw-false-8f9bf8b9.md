# Fact 8f9bf8b9

Store id: cc8874ba-a3f0-48ac-8323-4118125d6bde

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
- posted_at: `2026-11-09T23:44:51.9950950+00:00`

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
  "id": "cc8874ba-a3f0-48ac-8323-4118125d6bde",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9950950+00:00"
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
  "subject_id": "d9fac40e-6e66-42a9-bc73-0da845717681",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._clear_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear_base(self, using=None, raw=False)"
}
```
