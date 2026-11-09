# Fact 44c84912

Store id: 6d5dd836-6f94-40f0-84eb-864c0b8b1c92

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
- posted_at: `2026-11-09T23:44:51.8333260+00:00`

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
  "id": "6d5dd836-6f94-40f0-84eb-864c0b8b1c92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8333260+00:00"
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
  "subject_id": "98d4bca6-b624-4369-8820-4ac5279d0d3c",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self, *, instance)"
}
```
