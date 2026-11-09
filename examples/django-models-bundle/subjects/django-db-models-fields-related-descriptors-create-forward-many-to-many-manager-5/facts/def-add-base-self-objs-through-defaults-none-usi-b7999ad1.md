# Fact b7999ad1

Store id: 8b48613a-e5ce-44db-871c-7718851c165c

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
- posted_at: `2026-11-09T23:31:59.4233030+00:00`

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
  "id": "8b48613a-e5ce-44db-871c-7718851c165c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4233030+00:00"
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
  "subject_id": "e0c40098-6b12-475d-ac8e-00879df90e5d",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._add_base",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_base(self, *objs, through_defaults=None, using=None, raw=False)"
}
```
