# Fact 4ee71c45

Store id: bfee2c43-a556-46f0-9282-4a3562b8baa4

## Text

```text
def get_prefetch_querysets(self, instances, querysets=None)
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
- posted_at: `2026-11-09T23:31:59.3903530+00:00`

## Data

```json
{
  "end_line": 1259,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1201,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1201,"selector":"L1201-L1259","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1259,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1201,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets"
  },
  "id": "bfee2c43-a556-46f0-9282-4a3562b8baa4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3903530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1201,
        "selector": "L1201-L1259",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "3f26f170-6d8a-4365-8dfb-ab56abe6fc0a",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
