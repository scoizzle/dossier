# Fact 9c40c812

Store id: 3555cc19-b97c-403d-a893-4b3052bbf127

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
- posted_at: `2026-11-09T23:31:59.2956270+00:00`

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
  "id": "3555cc19-b97c-403d-a893-4b3052bbf127",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2956270+00:00"
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
  "subject_id": "302511c6-d960-4f0f-8874-96752adfa132",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.set",
  "tags": [
    "entity:method"
  ],
  "text": "def set(self, objs, *, bulk=True, clear=False)"
}
```
