# Fact 44c84912

Store id: 57ec556f-b593-48b9-a938-8b9f7be11a94

## Text

```text
def get_queryset(self, *, instance)
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
- posted_at: `2026-11-09T22:39:44.7035510+00:00`

## Data

```json
{
  "end_line": 172,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 169,
  "symbol": "ForwardManyToOneDescriptor.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":169,"selector":"L169-L172","symbol":"ForwardManyToOneDescriptor.get_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 172,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 169,
    "symbol": "ForwardManyToOneDescriptor.get_queryset"
  },
  "id": "57ec556f-b593-48b9-a938-8b9f7be11a94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7035510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 169,
        "selector": "L169-L172",
        "symbol": "ForwardManyToOneDescriptor.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "6587a611-3e7b-492a-adba-ec5242592676",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self, *, instance)"
}
```
