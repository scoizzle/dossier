# Fact 8112e55d

Store id: e3c1f0c7-3bfc-488c-b185-fabbd9dc4ada

## Text

```text
def __init__(self, related)
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
- posted_at: `2026-11-09T23:31:59.1846280+00:00`

## Data

```json
{
  "end_line": 448,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 445,
  "symbol": "ReverseOneToOneDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"selector":"L445-L448","symbol":"ReverseOneToOneDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 448,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 445,
    "symbol": "ReverseOneToOneDescriptor.__init__"
  },
  "id": "e3c1f0c7-3bfc-488c-b185-fabbd9dc4ada",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1846280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 445,
        "selector": "L445-L448",
        "symbol": "ReverseOneToOneDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ff06239e-bf4f-4b5d-8645-8b515ecade44",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, related)"
}
```
