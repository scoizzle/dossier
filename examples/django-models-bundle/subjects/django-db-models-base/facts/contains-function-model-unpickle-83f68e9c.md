# Fact 83f68e9c

Store id: 53235027-6e46-4c57-8c92-40cd6e8aaad5

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
- posted_at: `2026-11-09T23:44:48.5582640+00:00`

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
  "id": "53235027-6e46-4c57-8c92-40cd6e8aaad5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5582640+00:00"
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
      "target": "7737a54d-b7db-4c6f-94af-e0070affabdc"
    }
  ],
  "status": "live",
  "subject_id": "adcf7c5a-348e-4481-9bc5-dcdd17eb19d6",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function model_unpickle"
}
```
