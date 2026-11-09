# Fact 3f21cc28

Store id: 05316e45-de92-487d-b4a5-e4ecca391eef

## Text

```text
def exists(self)
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
- posted_at: `2026-11-09T23:44:51.9795640+00:00`

## Data

```json
{
  "end_line": 1288,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1280,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.exists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1280,"selector":"L1280-L1288","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.exists"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.exists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1288,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1280,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.exists"
  },
  "id": "05316e45-de92-487d-b4a5-e4ecca391eef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9795640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1280,
        "selector": "L1280-L1288",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.exists"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "71559332-5de4-4493-aa34-614a0b9c9cc3",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.exists",
  "tags": [
    "entity:method"
  ],
  "text": "def exists(self)"
}
```
