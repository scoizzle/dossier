# Fact eb741c4d

Store id: e3323c3c-87f9-4707-85ee-b8c4b048baf8

## Text

```text
def remove(self, *objs)
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
- posted_at: `2026-11-09T22:39:44.8927590+00:00`

## Data

```json
{
  "end_line": 1346,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1343,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1343,"selector":"L1343-L1346","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.remove"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.remove](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1346,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1343,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
  },
  "id": "e3323c3c-87f9-4707-85ee-b8c4b048baf8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8927590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1343,
        "selector": "L1343-L1346",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "5465aadb-72e4-477d-9546-8d573a132a77",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.remove",
  "tags": [
    "entity:method"
  ],
  "text": "def remove(self, *objs)"
}
```
