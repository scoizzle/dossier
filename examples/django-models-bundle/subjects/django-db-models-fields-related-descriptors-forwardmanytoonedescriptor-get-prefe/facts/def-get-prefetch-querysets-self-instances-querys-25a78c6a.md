# Fact 25a78c6a

Store id: 6f5167aa-b361-4252-820c-7a6049bcdc94

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
- posted_at: `2026-11-09T22:39:44.7150460+00:00`

## Data

```json
{
  "end_line": 227,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 174,
  "symbol": "ForwardManyToOneDescriptor.get_prefetch_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":174,"selector":"L174-L227","symbol":"ForwardManyToOneDescriptor.get_prefetch_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_prefetch_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 227,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 174,
    "symbol": "ForwardManyToOneDescriptor.get_prefetch_querysets"
  },
  "id": "6f5167aa-b361-4252-820c-7a6049bcdc94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7150460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 174,
        "selector": "L174-L227",
        "symbol": "ForwardManyToOneDescriptor.get_prefetch_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "37eca50b-b45d-4433-a193-1ef2a8732509",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
