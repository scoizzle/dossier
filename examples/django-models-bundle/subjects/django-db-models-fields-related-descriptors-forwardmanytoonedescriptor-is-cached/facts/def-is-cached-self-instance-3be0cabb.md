# Fact 3be0cabb

Store id: 7d6dfe4a-c657-4275-9eec-9f6295560347

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
- posted_at: `2026-11-09T23:31:59.1341720+00:00`

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
  "id": "7d6dfe4a-c657-4275-9eec-9f6295560347",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1341720+00:00"
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
  "subject_id": "02c60c03-c6d8-4490-90a1-30a659d683e6",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
