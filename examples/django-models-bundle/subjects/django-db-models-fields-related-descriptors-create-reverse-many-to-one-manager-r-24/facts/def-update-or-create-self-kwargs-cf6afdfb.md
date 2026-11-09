# Fact cf6afdfb

Store id: c12137b8-acba-4a9f-873a-6248151ffd32

## Text

```text
def update_or_create(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.8194420+00:00`

## Data

```json
{
  "end_line": 922,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 918,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.update_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":918,"selector":"L918-L922","symbol":"create_reverse_many_to_one_manager.RelatedManager.update_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.update_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 922,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 918,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.update_or_create"
  },
  "id": "c12137b8-acba-4a9f-873a-6248151ffd32",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8194420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 918,
        "selector": "L918-L922",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.update_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "a69a1028-0e0b-483f-bbc5-ac9864ca0891",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.update_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def update_or_create(self, **kwargs)"
}
```
