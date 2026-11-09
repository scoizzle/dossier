# Fact b5912499

Store id: effabdb8-a8a5-4d1f-a3b6-387f94a4798b

## Text

```text
def related_manager_cls(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.8456930+00:00`

## Data

```json
{
  "end_line": 1065,
  "entity_kind": "method",
  "parent": "ManyToManyDescriptor",
  "start_line": 1057,
  "symbol": "ManyToManyDescriptor.related_manager_cls"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1057,"selector":"L1057-L1065","symbol":"ManyToManyDescriptor.related_manager_cls"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor.related_manager_cls](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1065,
    "entity_kind": "method",
    "parent": "ManyToManyDescriptor",
    "start_line": 1057,
    "symbol": "ManyToManyDescriptor.related_manager_cls"
  },
  "id": "effabdb8-a8a5-4d1f-a3b6-387f94a4798b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8456930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1057,
        "selector": "L1057-L1065",
        "symbol": "ManyToManyDescriptor.related_manager_cls"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "dd164e55-7dd1-431c-8141-6f0017c4e258",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.related_manager_cls",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_manager_cls(self)"
}
```
