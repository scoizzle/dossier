# Fact 48c7089f

Store id: 643ef300-c515-41d1-9948-e5807c4d36d2

## Text

```text
contains class PositiveSmallIntegerField
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
  - target: [django/db/models/fields/__init__::PositiveSmallIntegerField](../../django-db-models-fields-init-positivesmallintegerfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2472,"symbol":"PositiveSmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "643ef300-c515-41d1-9948-e5807c4d36d2",
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
        "line": 2472,
        "symbol": "PositiveSmallIntegerField"
      },
      "rel": "contains",
      "target": "01f27017-bce2-4c97-9897-a8567b9e9ee9"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PositiveSmallIntegerField"
}
```
