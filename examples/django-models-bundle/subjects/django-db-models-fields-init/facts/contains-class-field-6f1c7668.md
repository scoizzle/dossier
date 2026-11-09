# Fact 6f1c7668

Store id: 0e44745f-e1ae-4eea-b16a-39e5a518e195

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "0e44745f-e1ae-4eea-b16a-39e5a518e195",
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
        "line": 127,
        "symbol": "Field"
      },
      "rel": "contains",
      "target": "13ea5fe5-f7c1-4766-840c-857be074ce31"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Field"
}
```
