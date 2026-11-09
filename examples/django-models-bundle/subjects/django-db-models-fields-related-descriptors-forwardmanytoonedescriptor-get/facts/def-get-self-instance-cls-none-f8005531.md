# Fact f8005531

Store id: e4b81b5f-cd3c-419e-8c14-6e802b2d7ed2

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
- posted_at: `2026-11-09T23:44:51.8495450+00:00`

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
  "id": "e4b81b5f-cd3c-419e-8c14-6e802b2d7ed2",
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
    "posted_at": "2026-11-09T23:44:51.8495450+00:00"
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
  "subject_id": "7e38f2a7-840d-4d75-bcde-bceba31ac24a",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
