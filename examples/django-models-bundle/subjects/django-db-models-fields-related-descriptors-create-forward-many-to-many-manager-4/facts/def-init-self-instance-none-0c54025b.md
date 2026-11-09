# Fact 0c54025b

Store id: f2397a55-e65b-4a60-97ca-efdaf3a88b32

## Text

```text
def __init__(self, instance=None)
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
- posted_at: `2026-11-09T23:31:59.3538990+00:00`

## Data

```json
{
  "end_line": 1132,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1084,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1084,"selector":"L1084-L1132","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1132,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1084,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__init__"
  },
  "id": "f2397a55-e65b-4a60-97ca-efdaf3a88b32",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3538990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1084,
        "selector": "L1084-L1132",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "d1aeced3-67c5-4a5c-9448-739694f5cea9",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance=None)"
}
```
