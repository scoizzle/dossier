# Fact f4e2f301

Store id: 09e7d9fc-9702-4cad-911a-72af9781e625

## Text

```text
def _remove_base(self, *objs, using=None, raw=False)
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
- posted_at: `2026-11-09T23:31:59.4410100+00:00`

## Data

```json
{
  "end_line": 1341,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1337,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_base"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1337,"selector":"L1337-L1341","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._remove_base"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1341,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1337,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_base"
  },
  "id": "09e7d9fc-9702-4cad-911a-72af9781e625",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4410100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1337,
        "selector": "L1337-L1341",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._remove_base"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "43725886-8ab2-427a-8db6-c48c53fa10c2",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._remove_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _remove_base(self, *objs, using=None, raw=False)"
}
```
