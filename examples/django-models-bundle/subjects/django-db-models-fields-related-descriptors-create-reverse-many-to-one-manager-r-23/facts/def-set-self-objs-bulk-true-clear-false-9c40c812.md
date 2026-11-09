# Fact 9c40c812

Store id: c4266562-0ebb-4ce3-8ae4-8f66ed60b6ad

## Text

```text
def set(self, objs, *, bulk=True, clear=False)
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
- posted_at: `2026-11-09T22:39:44.8355410+00:00`

## Data

```json
{
  "end_line": 1016,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 992,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.set"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":992,"selector":"L992-L1016","symbol":"create_reverse_many_to_one_manager.RelatedManager.set"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.set](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1016,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 992,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.set"
  },
  "id": "c4266562-0ebb-4ce3-8ae4-8f66ed60b6ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8355410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 992,
        "selector": "L992-L1016",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.set"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "31687b30-0a5e-4c79-9bc6-e84a6a3aee7e",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.set",
  "tags": [
    "entity:method"
  ],
  "text": "def set(self, objs, *, bulk=True, clear=False)"
}
```
