# Fact 64b34ec5

Store id: b76d9909-1634-46ff-af76-1d6c869b0a0b

## Text

```text
def fetch_one(self, instance)
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
- posted_at: `2026-11-09T22:39:44.7217000+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 279,
  "symbol": "ForwardManyToOneDescriptor.fetch_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":279,"selector":"L279-L287","symbol":"ForwardManyToOneDescriptor.fetch_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 279,
    "symbol": "ForwardManyToOneDescriptor.fetch_one"
  },
  "id": "b76d9909-1634-46ff-af76-1d6c869b0a0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7217000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 279,
        "selector": "L279-L287",
        "symbol": "ForwardManyToOneDescriptor.fetch_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "839de4e7-6b7d-4e08-8759-ebbca78a50ab",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_one",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_one(self, instance)"
}
```
