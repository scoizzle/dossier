# Fact 83f68e9c

Store id: 1110b7bd-071e-4621-a8f9-ea093dfb5550

## Text

```text
contains function model_unpickle
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3699300+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/base::model_unpickle](../../django-db-models-base-model-unpickle/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2566,"symbol":"model_unpickle"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "1110b7bd-071e-4621-a8f9-ea093dfb5550",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3699300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2566,
        "symbol": "model_unpickle"
      },
      "rel": "contains",
      "target": "9b88c94c-985a-45fb-b506-9915fdad46e6"
    }
  ],
  "status": "live",
  "subject_id": "70b750e6-0b0a-43ce-80a5-3403f95c66e3",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function model_unpickle"
}
```
