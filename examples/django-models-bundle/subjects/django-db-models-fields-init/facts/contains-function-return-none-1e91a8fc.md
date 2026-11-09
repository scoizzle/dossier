# Fact 1e91a8fc

Store id: d02e299f-4f19-4f02-b208-bcfff619a22e

## Text

```text
contains function return_None
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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::return_None](../../django-db-models-fields-init-return-none/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"symbol":"return_None"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "d02e299f-4f19-4f02-b208-bcfff619a22e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 123,
        "symbol": "return_None"
      },
      "rel": "contains",
      "target": "02bffb46-5e45-46ed-9998-e5c9c5410b42"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function return_None"
}
```
