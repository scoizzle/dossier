# Fact 3fb3b496

Store id: 4d5891bf-c589-45ce-a927-c33505a157f1

## Text

```text
async def aset(self, objs, *, bulk=True, clear=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.9478970+00:00`

## Data

```json
{
  "end_line": 1021,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 1020,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1020,"selector":"L1020-L1021","symbol":"create_reverse_many_to_one_manager.RelatedManager.aset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1021,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 1020,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aset"
  },
  "id": "4d5891bf-c589-45ce-a927-c33505a157f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9478970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1020,
        "selector": "L1020-L1021",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e4a3e5d8-c543-4256-b22e-4545ac706719",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aset",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aset(self, objs, *, bulk=True, clear=False)"
}
```
