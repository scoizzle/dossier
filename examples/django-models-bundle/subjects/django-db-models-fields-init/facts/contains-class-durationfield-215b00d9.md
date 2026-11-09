# Fact 215b00d9

Store id: 3002f25a-78d7-41e7-a5a9-be6067c63379

## Text

```text
contains class DurationField
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
  - target: [django/db/models/fields/__init__::DurationField](../../django-db-models-fields-init-durationfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1936,"symbol":"DurationField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3002f25a-78d7-41e7-a5a9-be6067c63379",
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
        "line": 1936,
        "symbol": "DurationField"
      },
      "rel": "contains",
      "target": "d6b01c6c-d1b4-4748-8499-fad34125a060"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DurationField"
}
```
