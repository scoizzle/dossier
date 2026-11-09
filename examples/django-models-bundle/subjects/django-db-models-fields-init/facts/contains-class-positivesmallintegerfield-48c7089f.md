# Fact 48c7089f

Store id: ca87ca48-703f-4662-8952-e844e3b4ff36

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "ca87ca48-703f-4662-8952-e844e3b4ff36",
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
        "line": 2472,
        "symbol": "PositiveSmallIntegerField"
      },
      "rel": "contains",
      "target": "b78b7844-16cd-412d-ac34-f2c00d57c404"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PositiveSmallIntegerField"
}
```
