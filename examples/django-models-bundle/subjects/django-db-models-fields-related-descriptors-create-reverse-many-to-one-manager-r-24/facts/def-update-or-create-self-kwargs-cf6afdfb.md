# Fact cf6afdfb

Store id: 056e4a6c-80ca-4a54-a1e0-d7085110485e

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
- posted_at: `2026-11-09T23:44:51.9327170+00:00`

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
  "id": "056e4a6c-80ca-4a54-a1e0-d7085110485e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9327170+00:00"
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
  "subject_id": "8fe7a9f4-1105-4e07-9e4d-1d7bd10110a7",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.update_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def update_or_create(self, **kwargs)"
}
```
