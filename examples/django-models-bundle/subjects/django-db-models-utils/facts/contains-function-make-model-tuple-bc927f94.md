# Fact bc927f94

Store id: 9f965ccb-c14a-4697-b6ff-a1571283f360

## Text

```text
contains function make_model_tuple
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
- posted_at: `2026-11-09T22:39:52.1602360+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/utils::make_model_tuple](../../django-db-models-utils-make-model-tuple/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":5,"symbol":"make_model_tuple"}`

## Referenced by

None.

## Subject

[django/db/models/utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "9f965ccb-c14a-4697-b6ff-a1571283f360",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:52.1602360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 5,
        "symbol": "make_model_tuple"
      },
      "rel": "contains",
      "target": "eca21d29-683c-45aa-8316-6512f45c159f"
    }
  ],
  "status": "live",
  "subject_id": "f5e83459-87b7-40dd-8dc8-0296e557a739",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function make_model_tuple"
}
```
