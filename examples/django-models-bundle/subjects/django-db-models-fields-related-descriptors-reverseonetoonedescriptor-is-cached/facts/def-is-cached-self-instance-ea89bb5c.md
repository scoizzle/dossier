# Fact ea89bb5c

Store id: 2982bc73-35ed-4c59-9dd0-05481877a493

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
- posted_at: `2026-11-09T23:31:59.1898650+00:00`

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
  "id": "2982bc73-35ed-4c59-9dd0-05481877a493",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1898650+00:00"
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
  "subject_id": "0b229226-5d91-4d88-9aa5-3b4ffb6ad594",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
