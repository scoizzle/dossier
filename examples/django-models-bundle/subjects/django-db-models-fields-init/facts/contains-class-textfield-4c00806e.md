# Fact 4c00806e

Store id: d140cc1f-10eb-417b-91f1-6de735b0d147

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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

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
  "id": "d140cc1f-10eb-417b-91f1-6de735b0d147",
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
        "line": 2524,
        "symbol": "TextField"
      },
      "rel": "contains",
      "target": "31ac9379-3bcc-427e-a098-b78bb824dad2"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TextField"
}
```
