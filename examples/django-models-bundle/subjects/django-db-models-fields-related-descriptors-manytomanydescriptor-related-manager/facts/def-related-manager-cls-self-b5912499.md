# Fact b5912499

Store id: c14910a5-6fea-4262-ba39-8fc01839f47b

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
- posted_at: `2026-11-09T23:44:51.9550400+00:00`

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
  "id": "c14910a5-6fea-4262-ba39-8fc01839f47b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9550400+00:00"
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
  "subject_id": "20fc5857-0125-4a9c-96a5-08f4fdf85c52",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.related_manager_cls",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_manager_cls(self)"
}
```
