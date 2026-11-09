# Fact 6945b3e1

Store id: 99bea6ec-0cc0-4547-b48a-68bb0c060f15

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:31:59.1682790+00:00`

## Data

```json
{
  "end_line": 376,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 370,
  "symbol": "ForwardManyToOneDescriptor.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":370,"selector":"L370-L376","symbol":"ForwardManyToOneDescriptor.__reduce__"}`

## Items

```json
[
  {
    "text": "Pickling should return the instance attached by self.field on the model, not a new copy of that descriptor. Use getattr() to retrieve the instance directly from the model.",
    "locator": {
      "line": 371
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 376,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 370,
    "symbol": "ForwardManyToOneDescriptor.__reduce__"
  },
  "id": "99bea6ec-0cc0-4547-b48a-68bb0c060f15",
  "items": [
    {
      "locator": {
        "line": 371
      },
      "text": "Pickling should return the instance attached by self.field on the model, not a new copy of that descriptor. Use getattr() to retrieve the instance directly from the model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1682790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 370,
        "selector": "L370-L376",
        "symbol": "ForwardManyToOneDescriptor.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "2ae8b41e-b665-479e-b1ec-3b4165dab622",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
