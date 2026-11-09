# Fact 6da4cef2

Store id: e7f975b1-a752-452c-8f5f-cffbd6e73292

## Text

```text
def count(self)
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
- posted_at: `2026-11-09T23:44:51.9820720+00:00`

## Data

```json
{
  "end_line": 1298,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1290,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1290,"selector":"L1290-L1298","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.count"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1298,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1290,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.count"
  },
  "id": "e7f975b1-a752-452c-8f5f-cffbd6e73292",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9820720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1290,
        "selector": "L1290-L1298",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.count"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "60f2bba7-4d2d-4351-9457-383018538a91",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.count",
  "tags": [
    "entity:method"
  ],
  "text": "def count(self)"
}
```
