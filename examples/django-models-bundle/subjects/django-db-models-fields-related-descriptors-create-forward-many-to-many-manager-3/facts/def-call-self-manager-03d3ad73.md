# Fact 03d3ad73

Store id: d8e11c9a-783c-4c0e-98dc-97d48733151b

## Text

```text
def __call__(self, *, manager)
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
- posted_at: `2026-11-09T22:39:44.8574180+00:00`

## Data

```json
{
  "end_line": 1139,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1134,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1134,"selector":"L1134-L1139","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.__call__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1139,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1134,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
  },
  "id": "d8e11c9a-783c-4c0e-98dc-97d48733151b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8574180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1134,
        "selector": "L1134-L1139",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "f1c6867a-c2a3-4690-b6fe-d9856ccb1ee8",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *, manager)"
}
```
