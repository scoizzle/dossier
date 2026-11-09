# Fact 44c84912

Store id: bd342af2-fd78-4bfb-b4fa-f9cbf2d7e8f7

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
- posted_at: `2026-11-09T23:31:59.1364960+00:00`

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
  "id": "bd342af2-fd78-4bfb-b4fa-f9cbf2d7e8f7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1364960+00:00"
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
  "subject_id": "4b287be0-2704-466d-b9b8-7ac91c98831d",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self, *, instance)"
}
```
