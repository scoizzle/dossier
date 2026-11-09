# Fact 848667b3

Store id: 90a726cb-b9f4-483a-b1d0-0c80272d572f

## Text

```text
class ManyRelatedManager(superclass, AltersData)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.9608200+00:00`

## Data

```json
{
  "end_line": 1712,
  "entity_kind": "class",
  "parent": "create_forward_many_to_many_manager",
  "start_line": 1083,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1083,"selector":"L1083-L1712","symbol":"create_forward_many_to_many_manager.ManyRelatedManager"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1712,
    "entity_kind": "class",
    "parent": "create_forward_many_to_many_manager",
    "start_line": 1083,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager"
  },
  "id": "90a726cb-b9f4-483a-b1d0-0c80272d572f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9608200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1083,
        "selector": "L1083-L1712",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "aac27914-2f63-4598-a495-000705e621db",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyRelatedManager(superclass, AltersData)"
}
```
