# Fact 424da90b

Store id: c6183bde-e3b2-4032-92a7-ec08c5000d3f

## Text

```text
def set(self, objs, *, clear=False, through_defaults=None)
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
- posted_at: `2026-11-09T23:31:59.4859370+00:00`

## Data

```json
{
  "end_line": 1432,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1431,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1431,"selector":"L1431-L1432","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.set"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.set](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1432,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1431,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set"
  },
  "id": "c6183bde-e3b2-4032-92a7-ec08c5000d3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4859370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1431,
        "selector": "L1431-L1432",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.set"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "735e356c-4c2f-4101-9430-89010f10b74d",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.set",
  "tags": [
    "entity:method"
  ],
  "text": "def set(self, objs, *, clear=False, through_defaults=None)"
}
```
