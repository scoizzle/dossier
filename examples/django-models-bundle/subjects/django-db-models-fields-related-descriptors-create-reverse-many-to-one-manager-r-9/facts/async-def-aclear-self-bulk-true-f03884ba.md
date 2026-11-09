# Fact f03884ba

Store id: 4cca32bb-4ab3-41a0-a35d-46e16449c7c0

## Text

```text
async def aclear(self, *, bulk=True)
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
- posted_at: `2026-11-09T23:31:59.2901150+00:00`

## Data

```json
{
  "end_line": 973,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 972,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aclear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":972,"selector":"L972-L973","symbol":"create_reverse_many_to_one_manager.RelatedManager.aclear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aclear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 973,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 972,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aclear"
  },
  "id": "4cca32bb-4ab3-41a0-a35d-46e16449c7c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2901150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 972,
        "selector": "L972-L973",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aclear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "6588cf6f-bacd-4318-8229-5bccb3276d19",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aclear",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aclear(self, *, bulk=True)"
}
```
