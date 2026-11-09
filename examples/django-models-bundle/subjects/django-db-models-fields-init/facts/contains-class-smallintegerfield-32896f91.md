# Fact 32896f91

Store id: 068c8442-66b6-4b6f-865a-d3a261bd93a4

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "068c8442-66b6-4b6f-865a-d3a261bd93a4",
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
        "line": 2258,
        "symbol": "SmallIntegerField"
      },
      "rel": "contains",
      "target": "4eeaf767-4c49-453f-9c4a-f2bd2be3d622"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class SmallIntegerField"
}
```
