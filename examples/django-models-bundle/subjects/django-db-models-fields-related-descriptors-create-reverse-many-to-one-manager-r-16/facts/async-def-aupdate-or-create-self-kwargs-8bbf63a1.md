# Fact 8bbf63a1

Store id: f35e534f-505a-434a-af86-9ee97093c251

## Text

```text
async def aupdate_or_create(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:59.2724030+00:00`

## Data

```json
{
  "end_line": 927,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 926,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":926,"selector":"L926-L927","symbol":"create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 927,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 926,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create"
  },
  "id": "f35e534f-505a-434a-af86-9ee97093c251",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2724030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 926,
        "selector": "L926-L927",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "c68ece7e-9ff7-447b-9024-9fc9f1ad4a18",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.aupdate_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate_or_create(self, **kwargs)"
}
```
