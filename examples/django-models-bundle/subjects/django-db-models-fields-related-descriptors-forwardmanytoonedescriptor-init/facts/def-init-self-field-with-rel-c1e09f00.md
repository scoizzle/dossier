# Fact c1e09f00

Store id: fb711aa5-f358-4e9b-85bb-ffef9b7f15c9

## Text

```text
def __init__(self, field_with_rel)
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
- posted_at: `2026-11-09T22:39:44.6975160+00:00`

## Data

```json
{
  "end_line": 146,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 145,
  "symbol": "ForwardManyToOneDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":145,"selector":"L145-L146","symbol":"ForwardManyToOneDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 146,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 145,
    "symbol": "ForwardManyToOneDescriptor.__init__"
  },
  "id": "fb711aa5-f358-4e9b-85bb-ffef9b7f15c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.6975160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 145,
        "selector": "L145-L146",
        "symbol": "ForwardManyToOneDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "19dca816-7067-4228-b8d0-a169aa1601d5",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field_with_rel)"
}
```
