# Fact aaee018c

Store id: 8bf2288e-88a4-4ec7-8a05-bc41db347de2

## Text

```text
async def acreate(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.8130600+00:00`

## Data

```json
{
  "end_line": 901,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 900,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.acreate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":900,"selector":"L900-L901","symbol":"create_reverse_many_to_one_manager.RelatedManager.acreate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.acreate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 901,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 900,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.acreate"
  },
  "id": "8bf2288e-88a4-4ec7-8a05-bc41db347de2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8130600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 900,
        "selector": "L900-L901",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.acreate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "38243038-86be-49c8-b2df-4116e4758e7f",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, **kwargs)"
}
```
