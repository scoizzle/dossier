# Fact a71bd6c8

Store id: a0e3b809-157d-411a-ba93-87e050f9b395

## Text

```text
contains class DateField
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
  - target: [django/db/models/fields/__init__::DateField](../../django-db-models-fields-init-datefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1464,"symbol":"DateField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a0e3b809-157d-411a-ba93-87e050f9b395",
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
        "line": 1464,
        "symbol": "DateField"
      },
      "rel": "contains",
      "target": "bd533b80-aa55-48b6-9eef-d90e4ae414c1"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DateField"
}
```
