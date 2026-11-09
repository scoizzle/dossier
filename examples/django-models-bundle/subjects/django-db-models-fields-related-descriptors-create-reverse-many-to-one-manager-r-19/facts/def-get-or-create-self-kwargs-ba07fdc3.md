# Fact ba07fdc3

Store id: 8c632228-de0b-474b-8160-9d1b36ccc6d6

## Text

```text
def get_or_create(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:59.2633630+00:00`

## Data

```json
{
  "end_line": 909,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 905,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":905,"selector":"L905-L909","symbol":"create_reverse_many_to_one_manager.RelatedManager.get_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 909,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 905,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_or_create"
  },
  "id": "8c632228-de0b-474b-8160-9d1b36ccc6d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2633630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 905,
        "selector": "L905-L909",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "a0d33ad8-6349-4fc3-8342-f2886c4a8aca",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, **kwargs)"
}
```
