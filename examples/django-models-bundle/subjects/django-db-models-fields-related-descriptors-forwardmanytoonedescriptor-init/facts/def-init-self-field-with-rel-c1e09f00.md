# Fact c1e09f00

Store id: 1bcae5c8-f78f-4d7c-98b4-e976222795ce

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
- posted_at: `2026-11-09T23:31:59.1299630+00:00`

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
  "id": "1bcae5c8-f78f-4d7c-98b4-e976222795ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1299630+00:00"
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
  "subject_id": "ed5c3828-b165-49fd-bd65-95e51ecf02aa",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field_with_rel)"
}
```
