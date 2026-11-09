# Fact 2e66030b

Store id: 3a71879b-a83a-4392-a15f-3a52756ee8c7

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
- posted_at: `2026-11-09T23:31:59.5003040+00:00`

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
  "id": "3a71879b-a83a-4392-a15f-3a52756ee8c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.5003040+00:00"
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
  "subject_id": "2a3854a9-1359-40fa-acf6-8149cb284976",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, *, through_defaults=None, **kwargs)"
}
```
