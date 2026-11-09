# Fact 8cda8538

Store id: a34d139b-19bc-4b37-a339-90ccd9ada5f4

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T23:31:59.1649290+00:00`

## Data

```json
{
  "end_line": 368,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 294,
  "symbol": "ForwardManyToOneDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":294,"selector":"L294-L368","symbol":"ForwardManyToOneDescriptor.__set__"}`

## Items

```json
[
  {
    "text": "Set the related instance through the forward relation.",
    "locator": {
      "line": 295
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 368,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 294,
    "symbol": "ForwardManyToOneDescriptor.__set__"
  },
  "id": "a34d139b-19bc-4b37-a339-90ccd9ada5f4",
  "items": [
    {
      "locator": {
        "line": 295
      },
      "text": "Set the related instance through the forward relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1649290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 294,
        "selector": "L294-L368",
        "symbol": "ForwardManyToOneDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "40da6d76-f6c2-4b51-a656-0a213860c816",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
