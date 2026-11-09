# Fact bc927f94

Store id: e4704426-de12-4ea3-8add-50e2f349b666

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
- posted_at: `2026-11-09T23:45:00.0778950+00:00`

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
  "id": "e4704426-de12-4ea3-8add-50e2f349b666",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0778950+00:00"
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
      "target": "59c9b525-a328-4815-aa3a-c28a74f89192"
    }
  ],
  "status": "live",
  "subject_id": "3a2f8b91-5e76-4523-aac0-4f1c8c9f9145",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function make_model_tuple"
}
```
