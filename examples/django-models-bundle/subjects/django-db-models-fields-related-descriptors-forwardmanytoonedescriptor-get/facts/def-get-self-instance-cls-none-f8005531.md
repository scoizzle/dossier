# Fact f8005531

Store id: 4610ea5f-e711-4533-aa42-fd1ab2308d24

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
- posted_at: `2026-11-09T22:39:44.7196030+00:00`

## Data

```json
{
  "end_line": 277,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 234,
  "symbol": "ForwardManyToOneDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":234,"selector":"L234-L277","symbol":"ForwardManyToOneDescriptor.__get__"}`

## Items

```json
[
  {
    "text": "Get the related instance through the forward relation.",
    "locator": {
      "line": 235
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 277,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 234,
    "symbol": "ForwardManyToOneDescriptor.__get__"
  },
  "id": "4610ea5f-e711-4533-aa42-fd1ab2308d24",
  "items": [
    {
      "locator": {
        "line": 235
      },
      "text": "Get the related instance through the forward relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7196030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 234,
        "selector": "L234-L277",
        "symbol": "ForwardManyToOneDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bcfc5c9e-d777-4fcb-8095-3d29b2c12aa7",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
