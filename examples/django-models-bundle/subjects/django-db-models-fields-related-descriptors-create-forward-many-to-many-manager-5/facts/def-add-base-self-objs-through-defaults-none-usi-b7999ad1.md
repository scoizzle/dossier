# Fact b7999ad1

Store id: d8928076-182b-4916-ae26-fafbaab86140

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
- posted_at: `2026-11-09T23:44:51.9839790+00:00`

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
  "id": "d8928076-182b-4916-ae26-fafbaab86140",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9839790+00:00"
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
  "subject_id": "b4cb4a75-0b18-4a7e-b6a2-8fd694df63b0",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_base(self, *objs, through_defaults=None, using=None, raw=False)"
}
```
