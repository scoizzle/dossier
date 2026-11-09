# Fact 2e66030b

Store id: 69163c1d-f8ad-4231-a55a-9cd89dd09ead

## Text

```text
def create(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:52.0064830+00:00`

## Data

```json
{
  "end_line": 1447,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1443,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1443,"selector":"L1443-L1447","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1447,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1443,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.create"
  },
  "id": "69163c1d-f8ad-4231-a55a-9cd89dd09ead",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0064830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1443,
        "selector": "L1443-L1447",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "4af587df-bd64-420b-8bfd-7a79fa802a32",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, *, through_defaults=None, **kwargs)"
}
```
