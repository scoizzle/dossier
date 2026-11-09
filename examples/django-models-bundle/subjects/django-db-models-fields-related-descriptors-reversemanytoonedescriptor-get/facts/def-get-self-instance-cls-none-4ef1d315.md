# Fact 4ef1d315

Store id: 5b5880c9-2150-46da-8db9-f7a704dcda7f

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T23:31:59.2230020+00:00`

## Data

```json
{
  "end_line": 699,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 686,
  "symbol": "ReverseManyToOneDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":686,"selector":"L686-L699","symbol":"ReverseManyToOneDescriptor.__get__"}`

## Items

```json
[
  {
    "text": "Get the related objects through the reverse relation.",
    "locator": {
      "line": 687
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 699,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 686,
    "symbol": "ReverseManyToOneDescriptor.__get__"
  },
  "id": "5b5880c9-2150-46da-8db9-f7a704dcda7f",
  "items": [
    {
      "locator": {
        "line": 687
      },
      "text": "Get the related objects through the reverse relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2230020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 686,
        "selector": "L686-L699",
        "symbol": "ReverseManyToOneDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "810db308-743e-462d-9e70-2e131bb6461c",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
