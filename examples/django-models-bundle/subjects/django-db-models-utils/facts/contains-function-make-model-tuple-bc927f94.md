# Fact bc927f94

Store id: 633d7f03-cea4-4140-8052-4c1383cf3c20

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
- posted_at: `2026-11-09T23:32:07.9512730+00:00`

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
  "id": "633d7f03-cea4-4140-8052-4c1383cf3c20",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9512730+00:00"
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
      "target": "487d0216-1d46-407a-9a0c-6a5d579493eb"
    }
  ],
  "status": "live",
  "subject_id": "8d25c560-4eac-44c9-a77d-da20cef77164",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function make_model_tuple"
}
```
