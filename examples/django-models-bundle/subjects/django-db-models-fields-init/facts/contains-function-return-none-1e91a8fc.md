# Fact 1e91a8fc

Store id: 0ddfb227-9f96-4616-ba79-0083f8666f78

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "0ddfb227-9f96-4616-ba79-0083f8666f78",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
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
      "target": "15c7c04e-5990-409f-a6cf-810ac1ae4e1a"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function return_None"
}
```
