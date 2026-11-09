# Fact 0c54025b

Store id: 0e24bd9c-4989-4cce-add4-ef31ef1a1eea

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
- posted_at: `2026-11-09T22:39:44.8551030+00:00`

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
  "id": "0e24bd9c-4989-4cce-add4-ef31ef1a1eea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8551030+00:00"
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
  "subject_id": "38f119cf-5b05-4988-9521-5522f2873959",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance=None)"
}
```
