# Fact 8112e55d

Store id: d0ebdf09-e110-4a68-9078-f8fb8c874096

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
- posted_at: `2026-11-09T23:44:51.8665130+00:00`

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
  "id": "d0ebdf09-e110-4a68-9078-f8fb8c874096",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8665130+00:00"
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
  "subject_id": "5d296c36-48ec-4da4-926c-07a02e57ede9",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, related)"
}
```
