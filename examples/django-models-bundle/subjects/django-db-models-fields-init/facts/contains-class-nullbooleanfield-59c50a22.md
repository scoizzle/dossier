# Fact 59c50a22

Store id: d81f3217-e271-4dbc-85d6-fc579c25764d

## Text

```text
contains class NullBooleanField
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
  - target: [django/db/models/fields/__init__::NullBooleanField](../../django-db-models-fields-init-nullbooleanfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2387,"symbol":"NullBooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "d81f3217-e271-4dbc-85d6-fc579c25764d",
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
        "line": 2387,
        "symbol": "NullBooleanField"
      },
      "rel": "contains",
      "target": "e2fbfb94-bc59-4f28-b3cd-5bc9de480c08"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class NullBooleanField"
}
```
