# Fact ea89bb5c

Store id: b4b00aef-bafe-4b36-aa2b-86ff1816815c

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
- posted_at: `2026-11-09T22:39:44.7488300+00:00`

## Data

```json
{
  "end_line": 468,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 467,
  "symbol": "ReverseOneToOneDescriptor.is_cached"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":467,"selector":"L467-L468","symbol":"ReverseOneToOneDescriptor.is_cached"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.is_cached](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 468,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 467,
    "symbol": "ReverseOneToOneDescriptor.is_cached"
  },
  "id": "b4b00aef-bafe-4b36-aa2b-86ff1816815c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7488300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 467,
        "selector": "L467-L468",
        "symbol": "ReverseOneToOneDescriptor.is_cached"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "cc92ab60-ef53-4856-9186-b669a50d30d3",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
