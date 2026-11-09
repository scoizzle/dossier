# Fact 9b481f34

Store id: 4167abcc-c585-4ed9-ba59-916454148f59

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "4167abcc-c585-4ed9-ba59-916454148f59",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "04094d40-68bc-4a5c-b9e9-f07f85999a50"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TimeField"
}
```
