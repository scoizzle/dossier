# Fact 3be0cabb

Store id: 030a8273-77c7-44b5-b7b6-1882dba362e4

## Text

```text
def is_cached(self, instance)
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
- posted_at: `2026-11-09T22:39:44.7015100+00:00`

## Data

```json
{
  "end_line": 167,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 166,
  "symbol": "ForwardManyToOneDescriptor.is_cached"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":166,"selector":"L166-L167","symbol":"ForwardManyToOneDescriptor.is_cached"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.is_cached](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 167,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 166,
    "symbol": "ForwardManyToOneDescriptor.is_cached"
  },
  "id": "030a8273-77c7-44b5-b7b6-1882dba362e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7015100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 166,
        "selector": "L166-L167",
        "symbol": "ForwardManyToOneDescriptor.is_cached"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bc9dd842-25f3-4279-af81-24f5d81beae0",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
