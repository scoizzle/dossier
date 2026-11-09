# Fact b53d0ce7

Store id: ebd2057a-d507-440b-b4ce-11f6f9bfd55f

## Text

```text
def clear(self)
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
- posted_at: `2026-11-09T23:31:59.4672670+00:00`

## Data

```json
{
  "end_line": 1385,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1382,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1382,"selector":"L1382-L1385","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1385,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1382,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
  },
  "id": "ebd2057a-d507-440b-b4ce-11f6f9bfd55f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4672670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1382,
        "selector": "L1382-L1385",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e7518741-91e2-4016-a3a6-84f95bdf0bda",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.clear",
  "tags": [
    "entity:method"
  ],
  "text": "def clear(self)"
}
```
