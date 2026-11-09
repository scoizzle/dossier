# Fact 3cceed77

Store id: 012c7bdf-fe46-4584-9470-b5fed465ce56

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
- posted_at: `2026-11-09T22:39:44.7526790+00:00`

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
  "id": "012c7bdf-fe46-4584-9470-b5fed465ce56",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7526790+00:00"
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
  "subject_id": "f19a0aa0-c92d-4b41-a893-bb9e8a6b25b1",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_prefetch_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prefetch_querysets(self, instances, querysets=None)"
}
```
