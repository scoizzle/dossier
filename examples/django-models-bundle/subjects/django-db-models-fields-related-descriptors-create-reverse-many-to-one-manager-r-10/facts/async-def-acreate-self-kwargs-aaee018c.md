# Fact aaee018c

Store id: fb9205e4-2c0d-4881-9e17-d390eb2d2113

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
- posted_at: `2026-11-09T23:31:59.2602700+00:00`

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
  "id": "fb9205e4-2c0d-4881-9e17-d390eb2d2113",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2602700+00:00"
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
  "subject_id": "7f0de9bd-2f33-4e03-a139-dee18e972e22",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, **kwargs)"
}
```
