# Fact 51f4e056

Store id: 145faa3a-5c08-4167-955e-d194aadaeb18

## Text

```text
async def aremove(self, *objs, bulk=True)
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
- posted_at: `2026-11-09T22:39:44.8267660+00:00`

## Data

```json
{
  "end_line": 962,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 961,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aremove"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":961,"selector":"L961-L962","symbol":"create_reverse_many_to_one_manager.RelatedManager.aremove"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aremove](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 962,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 961,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aremove"
  },
  "id": "145faa3a-5c08-4167-955e-d194aadaeb18",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8267660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 961,
        "selector": "L961-L962",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aremove"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "3bb0ac3c-87c6-4aef-ace5-f57d0b99a402",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aremove",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aremove(self, *objs, bulk=True)"
}
```
