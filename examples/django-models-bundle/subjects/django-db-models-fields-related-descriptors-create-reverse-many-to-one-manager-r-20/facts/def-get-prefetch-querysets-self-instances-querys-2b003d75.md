# Fact 2b003d75

Store id: fa10b576-b1fe-48f4-8080-a29c2334eb10

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
- posted_at: `2026-11-09T23:31:59.2486180+00:00`

## Data

```json
{
  "end_line": 845,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 814,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":814,"selector":"L814-L845","symbol":"create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 845,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 814,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets"
  },
  "id": "fa10b576-b1fe-48f4-8080-a29c2334eb10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2486180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 814,
        "selector": "L814-L845",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "7e728752-3f92-4006-b416-2269ba2720f4",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
