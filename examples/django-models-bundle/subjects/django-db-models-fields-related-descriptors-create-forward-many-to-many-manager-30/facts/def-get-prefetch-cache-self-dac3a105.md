# Fact dac3a105

Store id: c4f109bd-6158-405c-95a3-6e07eb7dd8b1

## Text

```text
def get_prefetch_cache(self)
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
- posted_at: `2026-11-09T22:39:44.8643020+00:00`

## Data

```json
{
  "end_line": 1183,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1175,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1175,"selector":"L1175-L1183","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1183,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1175,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache"
  },
  "id": "c4f109bd-6158-405c-95a3-6e07eb7dd8b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8643020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1175,
        "selector": "L1175-L1183",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "353790a5-7b73-41e9-b69e-eb15ca0b2dec",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_cache(self)"
}
```
