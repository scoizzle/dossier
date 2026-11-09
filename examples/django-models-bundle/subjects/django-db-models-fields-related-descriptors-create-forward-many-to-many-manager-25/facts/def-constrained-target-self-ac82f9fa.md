# Fact ac82f9fa

Store id: 4038ae9d-f6a3-436c-b967-cd5f555107ee

## Text

```text
def constrained_target(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.8731900+00:00`

## Data

```json
{
  "end_line": 1278,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1261,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.constrained_target"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1261,"selector":"L1261-L1278","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.constrained_target"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.constrained_target](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1278,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1261,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.constrained_target"
  },
  "id": "4038ae9d-f6a3-436c-b967-cd5f555107ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8731900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1261,
        "selector": "L1261-L1278",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.constrained_target"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "c8665a75-78a8-4a2c-937b-4db5ca8cbc70",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.constrained_target",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def constrained_target(self)"
}
```
