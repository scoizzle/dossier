# Fact e8bf82ca

Store id: cac26546-f486-48e6-aac7-126c34538f5a

## Text

```text
def fetch_many(self, instances)
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
- posted_at: `2026-11-09T22:39:44.7242940+00:00`

## Data

```json
{
  "end_line": 292,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 289,
  "symbol": "ForwardManyToOneDescriptor.fetch_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"selector":"L289-L292","symbol":"ForwardManyToOneDescriptor.fetch_many"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 292,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 289,
    "symbol": "ForwardManyToOneDescriptor.fetch_many"
  },
  "id": "cac26546-f486-48e6-aac7-126c34538f5a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7242940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 289,
        "selector": "L289-L292",
        "symbol": "ForwardManyToOneDescriptor.fetch_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ce8490c8-7281-44a4-9b39-3d11c49a11fd",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_many",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_many(self, instances)"
}
```
