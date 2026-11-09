# Fact 25a78c6a

Store id: e7fdb3c7-aa5e-4b87-a5bc-6e31434a39d8

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
- posted_at: `2026-11-09T23:31:59.1521020+00:00`

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
  "id": "e7fdb3c7-aa5e-4b87-a5bc-6e31434a39d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1521020+00:00"
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
  "subject_id": "43ff6cda-a103-4061-be8f-9ae8c388cc4c",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
