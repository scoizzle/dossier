# Fact ede7c36d

Store id: 81c1ae53-7667-44c9-9fe1-07df9ee89f91

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
- posted_at: `2026-11-09T23:44:51.8726770+00:00`

## Data

```json
{
  "end_line": 473,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 470,
  "symbol": "ReverseOneToOneDescriptor.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":470,"selector":"L470-L473","symbol":"ReverseOneToOneDescriptor.get_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 473,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 470,
    "symbol": "ReverseOneToOneDescriptor.get_queryset"
  },
  "id": "81c1ae53-7667-44c9-9fe1-07df9ee89f91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8726770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 470,
        "selector": "L470-L473",
        "symbol": "ReverseOneToOneDescriptor.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "4e0971e3-a88b-4b48-a5f5-915a697fe57d",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self, *, instance)"
}
```
