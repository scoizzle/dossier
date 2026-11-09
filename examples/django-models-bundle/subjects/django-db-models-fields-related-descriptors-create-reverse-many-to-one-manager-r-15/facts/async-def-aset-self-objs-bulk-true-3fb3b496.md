# Fact 3fb3b496

Store id: f3553f88-abc7-42ff-aa43-bc31f70195b3

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
- posted_at: `2026-11-09T22:39:44.8374540+00:00`

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
  "id": "f3553f88-abc7-42ff-aa43-bc31f70195b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8374540+00:00"
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
  "subject_id": "92625e82-4d22-426a-bc3b-59328d20de58",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aset",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aset(self, objs, *, bulk=True, clear=False)"
}
```
