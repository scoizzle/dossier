# Fact ba07fdc3

Store id: d3cb079b-0c06-4291-a856-c56899707cd0

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
- posted_at: `2026-11-09T22:39:44.8150670+00:00`

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
  "id": "d3cb079b-0c06-4291-a856-c56899707cd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8150670+00:00"
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
  "subject_id": "e5947a5a-c082-431c-b84f-7a2c2b9814ef",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, **kwargs)"
}
```
