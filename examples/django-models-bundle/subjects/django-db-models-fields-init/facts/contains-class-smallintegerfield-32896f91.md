# Fact 32896f91

Store id: 7ec63be6-3c99-471d-8ef6-7828fc6a5589

## Text

```text
contains class SmallIntegerField
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
  - target: [django/db/models/fields/__init__::SmallIntegerField](../../django-db-models-fields-init-smallintegerfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2258,"symbol":"SmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "7ec63be6-3c99-471d-8ef6-7828fc6a5589",
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
        "line": 2258,
        "symbol": "SmallIntegerField"
      },
      "rel": "contains",
      "target": "60eb3a75-f1ad-49b3-a4b4-3c854be8cf94"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class SmallIntegerField"
}
```
