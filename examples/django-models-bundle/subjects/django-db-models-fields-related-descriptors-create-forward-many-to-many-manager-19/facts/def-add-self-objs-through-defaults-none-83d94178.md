# Fact 83d94178

Store id: 749332c5-d671-4ea6-80bc-6ff3c99a792d

## Text

```text
def add(self, *objs, through_defaults=None)
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
- posted_at: `2026-11-09T23:31:59.4280240+00:00`

## Data

```json
{
  "end_line": 1326,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1323,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.add"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1323,"selector":"L1323-L1326","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.add"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.add](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1326,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1323,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.add"
  },
  "id": "749332c5-d671-4ea6-80bc-6ff3c99a792d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4280240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1323,
        "selector": "L1323-L1326",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.add"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bd21f562-1e86-497d-b70f-81673c076dc9",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.add",
  "tags": [
    "entity:method"
  ],
  "text": "def add(self, *objs, through_defaults=None)"
}
```
