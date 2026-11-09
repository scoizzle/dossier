# Fact 4c00806e

Store id: 902adc63-4bc9-4246-a0eb-6bbbaa5003a4

## Text

```text
contains class TextField
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::TextField](../../django-db-models-fields-init-textfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2524,"symbol":"TextField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "902adc63-4bc9-4246-a0eb-6bbbaa5003a4",
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
        "line": 2524,
        "symbol": "TextField"
      },
      "rel": "contains",
      "target": "e26468f2-4084-4093-baf5-9c7b8bbfafbe"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TextField"
}
```
