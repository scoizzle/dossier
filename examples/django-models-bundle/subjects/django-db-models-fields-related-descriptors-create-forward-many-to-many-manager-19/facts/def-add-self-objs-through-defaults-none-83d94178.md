# Fact 83d94178

Store id: 03129b0a-a28c-44ca-a88b-e496f026e512

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
- posted_at: `2026-11-09T22:39:44.8833890+00:00`

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
  "id": "03129b0a-a28c-44ca-a88b-e496f026e512",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8833890+00:00"
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
  "subject_id": "14198d3d-531b-4d38-bcc9-34f1af7a1f6d",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.add",
  "tags": [
    "entity:method"
  ],
  "text": "def add(self, *objs, through_defaults=None)"
}
```
