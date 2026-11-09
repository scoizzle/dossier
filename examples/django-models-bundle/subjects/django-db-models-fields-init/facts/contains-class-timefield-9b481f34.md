# Fact 9b481f34

Store id: 478fbed0-9864-4701-83b3-88b77e167c9c

## Text

```text
contains class TimeField
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
  - target: [django/db/models/fields/__init__::TimeField](../../django-db-models-fields-init-timefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2601,"symbol":"TimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "478fbed0-9864-4701-83b3-88b77e167c9c",
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
        "line": 2601,
        "symbol": "TimeField"
      },
      "rel": "contains",
      "target": "0afe7f12-5426-460b-a77e-44ac16badc7a"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TimeField"
}
```
