# Fact 3cceed77

Store id: c199a7f7-9cc1-4583-9c00-dcfd3747baa9

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
- posted_at: `2026-11-09T23:31:59.1936860+00:00`

## Data

```json
{
  "end_line": 513,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 475,
  "symbol": "ReverseOneToOneDescriptor.get_prefetch_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":475,"selector":"L475-L513","symbol":"ReverseOneToOneDescriptor.get_prefetch_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_prefetch_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 513,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 475,
    "symbol": "ReverseOneToOneDescriptor.get_prefetch_querysets"
  },
  "id": "c199a7f7-9cc1-4583-9c00-dcfd3747baa9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1936860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 475,
        "selector": "L475-L513",
        "symbol": "ReverseOneToOneDescriptor.get_prefetch_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "b68f3f19-c63b-48ca-a65c-e4d947be0ae3",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
