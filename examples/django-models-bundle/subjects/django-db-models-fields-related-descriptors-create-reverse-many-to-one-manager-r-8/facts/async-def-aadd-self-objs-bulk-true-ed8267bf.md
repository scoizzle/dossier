# Fact ed8267bf

Store id: 6af3a7fd-6e05-417c-8e6a-59c11eb93b52

## Text

```text
async def aadd(self, *objs, bulk=True)
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
- posted_at: `2026-11-09T23:31:59.2565620+00:00`

## Data

```json
{
  "end_line": 887,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 886,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":886,"selector":"L886-L887","symbol":"create_reverse_many_to_one_manager.RelatedManager.aadd"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aadd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 887,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 886,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
  },
  "id": "6af3a7fd-6e05-417c-8e6a-59c11eb93b52",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2565620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 886,
        "selector": "L886-L887",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aadd"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "33ad331a-1915-4ee2-8205-2011d5235938",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aadd",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aadd(self, *objs, bulk=True)"
}
```
