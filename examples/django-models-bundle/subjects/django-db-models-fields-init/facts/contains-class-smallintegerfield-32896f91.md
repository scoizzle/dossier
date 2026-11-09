# Fact 32896f91

Store id: 3721170f-ff6d-417d-96f3-ac115974f782

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "3721170f-ff6d-417d-96f3-ac115974f782",
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
        "line": 2258,
        "symbol": "SmallIntegerField"
      },
      "rel": "contains",
      "target": "3dc85d1d-eb71-41a5-96e2-983154787c2e"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class SmallIntegerField"
}
```
