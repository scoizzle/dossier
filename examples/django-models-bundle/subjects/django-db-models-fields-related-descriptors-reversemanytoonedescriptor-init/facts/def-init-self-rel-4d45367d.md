# Fact 4d45367d

Store id: 9420cc10-c20f-4ae6-a23b-8ef0e23f08b2

## Text

```text
def __init__(self, rel)
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
- posted_at: `2026-11-09T23:44:51.8896150+00:00`

## Data

```json
{
  "end_line": 675,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 673,
  "symbol": "ReverseManyToOneDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":673,"selector":"L673-L675","symbol":"ReverseManyToOneDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 675,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 673,
    "symbol": "ReverseManyToOneDescriptor.__init__"
  },
  "id": "9420cc10-c20f-4ae6-a23b-8ef0e23f08b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8896150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 673,
        "selector": "L673-L675",
        "symbol": "ReverseManyToOneDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "294b3900-ed56-43d4-93d3-b4048377accf",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, rel)"
}
```
