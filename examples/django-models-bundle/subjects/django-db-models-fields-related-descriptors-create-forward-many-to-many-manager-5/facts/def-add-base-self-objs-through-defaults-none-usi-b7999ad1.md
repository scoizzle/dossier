# Fact b7999ad1

Store id: d549932b-bd49-449d-810b-32d3960a8af7

## Text

```text
def _add_base(self, *objs, through_defaults=None, using=None, raw=False)
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
- posted_at: `2026-11-09T22:39:44.8799470+00:00`

## Data

```json
{
  "end_line": 1321,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1300,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_base"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1300,"selector":"L1300-L1321","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._add_base"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1321,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1300,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_base"
  },
  "id": "d549932b-bd49-449d-810b-32d3960a8af7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8799470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1300,
        "selector": "L1300-L1321",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._add_base"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "82fdb137-c0a1-452b-a56a-1c3aa277b07f",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_base(self, *objs, through_defaults=None, using=None, raw=False)"
}
```
