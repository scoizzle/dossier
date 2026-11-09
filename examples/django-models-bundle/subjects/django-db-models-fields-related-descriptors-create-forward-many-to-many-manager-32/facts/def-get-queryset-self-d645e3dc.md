# Fact d645e3dc

Store id: 81a32cbc-1d49-4734-8106-e4057f7f8509

## Text

```text
def get_queryset(self)
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
- posted_at: `2026-11-09T23:31:59.3854650+00:00`

## Data

```json
{
  "end_line": 1199,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1194,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1194,"selector":"L1194-L1199","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.get_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1199,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1194,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_queryset"
  },
  "id": "81a32cbc-1d49-4734-8106-e4057f7f8509",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3854650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1194,
        "selector": "L1194-L1199",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bc22aefd-4235-452e-9e74-950d79d7feb2",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```
