# Fact c1e09f00

Store id: 7ba3e41d-0e81-4fc1-b0f7-8368becb8345

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
- posted_at: `2026-11-09T23:44:51.8266610+00:00`

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
  "id": "7ba3e41d-0e81-4fc1-b0f7-8368becb8345",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8266610+00:00"
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
  "subject_id": "4300bd0b-5ba7-4704-86aa-a56b6cb62b37",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field_with_rel)"
}
```
