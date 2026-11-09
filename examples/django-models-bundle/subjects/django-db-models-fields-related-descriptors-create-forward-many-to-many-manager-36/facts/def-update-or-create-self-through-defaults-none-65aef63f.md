# Fact 65aef63f

Store id: 3b26d91c-b4a4-486e-9e42-e2e3256b6b2f

## Text

```text
def update_or_create(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.9318600+00:00`

## Data

```json
{
  "end_line": 1487,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1478,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.update_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1478,"selector":"L1478-L1487","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.update_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.update_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1487,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1478,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.update_or_create"
  },
  "id": "3b26d91c-b4a4-486e-9e42-e2e3256b6b2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9318600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1478,
        "selector": "L1478-L1487",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.update_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "9018640e-f845-469d-8c4c-5dff0a4e14aa",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.update_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def update_or_create(self, *, through_defaults=None, **kwargs)"
}
```
