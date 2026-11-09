# Fact 51f4e056

Store id: 139e6fb5-c558-449a-a56c-f03c486f8923

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
- posted_at: `2026-11-09T23:44:51.9385610+00:00`

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
  "id": "139e6fb5-c558-449a-a56c-f03c486f8923",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9385610+00:00"
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
  "subject_id": "7c028ca5-778d-47c6-a292-6e655a525d0a",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aremove",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aremove(self, *objs, bulk=True)"
}
```
