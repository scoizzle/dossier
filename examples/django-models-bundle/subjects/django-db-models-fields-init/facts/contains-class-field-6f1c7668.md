# Fact 6f1c7668

Store id: 312bda04-c7bb-482e-8d8e-f4ed74bbda05

## Text

```text
contains class Field
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
  - target: [django/db/models/fields/__init__::Field](../../django-db-models-fields-init-field/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":127,"symbol":"Field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "312bda04-c7bb-482e-8d8e-f4ed74bbda05",
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
        "line": 127,
        "symbol": "Field"
      },
      "rel": "contains",
      "target": "84b2106f-54fb-400b-83a8-9c69fc305d69"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Field"
}
```
