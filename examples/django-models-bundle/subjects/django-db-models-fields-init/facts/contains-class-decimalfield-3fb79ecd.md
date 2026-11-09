# Fact 3fb79ecd

Store id: 4ae3c4ae-2bc2-4010-b6bb-33fff4b97b7e

## Text

```text
contains class DecimalField
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
  - target: [django/db/models/fields/__init__::DecimalField](../../django-db-models-fields-init-decimalfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1740,"symbol":"DecimalField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "4ae3c4ae-2bc2-4010-b6bb-33fff4b97b7e",
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
        "line": 1740,
        "symbol": "DecimalField"
      },
      "rel": "contains",
      "target": "25ff08c8-f0d2-423c-b20d-a1f93aa7e99b"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DecimalField"
}
```
