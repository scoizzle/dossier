# Fact dac3a105

Store id: cbaa133a-4c28-44ae-a17c-8f238c5eec3d

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
- posted_at: `2026-11-09T23:31:59.3718940+00:00`

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
  "id": "cbaa133a-4c28-44ae-a17c-8f238c5eec3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3718940+00:00"
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
  "subject_id": "396cefa9-ac0b-476c-af7c-c5893c4eb67f",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_cache",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_cache(self)"
}
```
