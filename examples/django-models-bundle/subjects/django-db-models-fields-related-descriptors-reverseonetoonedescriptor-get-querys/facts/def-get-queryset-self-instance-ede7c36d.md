# Fact ede7c36d

Store id: b2c1bc26-44a2-40e7-8c01-17bdfdf8db40

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
- posted_at: `2026-11-09T22:39:44.7508200+00:00`

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
  "id": "b2c1bc26-44a2-40e7-8c01-17bdfdf8db40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7508200+00:00"
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
  "subject_id": "2b43a054-b254-4245-8da0-07b81e993673",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self, *, instance)"
}
```
