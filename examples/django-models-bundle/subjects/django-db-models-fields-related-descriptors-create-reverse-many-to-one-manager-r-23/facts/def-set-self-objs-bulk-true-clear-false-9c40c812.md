# Fact 9c40c812

Store id: 6d7dfbd8-d5b6-45cc-91b6-e2ded65b0439

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
- posted_at: `2026-11-09T23:44:51.9461530+00:00`

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
  "id": "6d7dfbd8-d5b6-45cc-91b6-e2ded65b0439",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9461530+00:00"
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
  "subject_id": "42e9b7e8-efd4-4134-89fb-6da8cfc6fee7",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.set",
  "tags": [
    "entity:method"
  ],
  "text": "def set(self, objs, *, bulk=True, clear=False)"
}
```
