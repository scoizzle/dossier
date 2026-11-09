# Fact 6f1c7668

Store id: b68f7d7d-0dab-4e76-972b-5ae29aaeb804

## Text

```text
contains class Field
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
  - target: [django/db/models/fields/__init__::Field](../../django-db-models-fields-init-field/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":127,"symbol":"Field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b68f7d7d-0dab-4e76-972b-5ae29aaeb804",
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
        "line": 127,
        "symbol": "Field"
      },
      "rel": "contains",
      "target": "d72f2f2e-9b20-4988-ac41-03c7c46f79c5"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Field"
}
```
